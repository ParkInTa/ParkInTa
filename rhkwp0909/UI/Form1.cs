using rhkwp0909.Adapter;
using rhkwp0909.DAO;
using rhkwp0909.Model;
using rhkwp0909.NETWORK;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace rhkwp0909
{
    partial class Form1 : Form
    {
        List<ListAdapter> list;
        ListAdapter adapter = new ListAdapter();
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer sTimer, rTimer;
        Random r = new Random();
        int sum = 0;
        int nope = 0;
        public Form1()
        {
            InitializeComponent();
            sTimer = new ThingSpeakTimer(new Timer(new TimerCallback(writeHandler), null, 1000, 20000));
            rTimer = new ThingSpeakTimer(new Timer(new TimerCallback(readHandler), null, 2000, 20000));
            OraMgr.Instance.connectDB();
            initListView2();
        }

        void writeHandler(object args)
        {
            int[] rand = { 90,91, 92, 93, 94, 95, 96, 97, 98, 100 };
            string time = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:s");
            //string timer = "TO_CHAR(SYSDATE,'YYYY-MM-DD')";
            int finished = rand[r.Next(10)];
            int defectve = 100 - finished;

            sum += finished;
            nope += defectve;

            bool chk = ts.sendDateToThingSpeak(finished.ToString(), defectve.ToString(),sum.ToString(),
                nope.ToString(),null,null,null,null);
            if (chk == true)
            {
                Console.WriteLine("데이터 전송 성공!");
            }
            else
            {
                Console.WriteLine("데이터 전송 실패!");
            }
            OraMgr.Instance.custDB(new LineEnvData(
               time,finished.ToString(),defectve.ToString(),sum.ToString(),
                nope.ToString()));


        }
        
        void readHandler(object args)
        {
            List<LineEnvData> list = ts.readThingSpeak();
            for (int i = 0; i < list.Count; i++)
            {
                Invoke(new Action(delegate ()
                {
                    line2finished1.Value = Convert.ToDouble(list[i].Finished);
                    line2defectve1.Value = Convert.ToDouble(list[i].Defectve);
                    int infinished = Convert.ToInt32(list[i].Finished);
                    int indefectve = Convert.ToInt32(list[i].Defectve);
                    // 양품 누적
                    line1finished1.Text = list[i].Nufinished;
                    // 불량품 누적
                    line1defectve1.Text = list[i].Nudefectve;
                
                    listView1.Items.Add(new ListViewItem(
                        new string[]
                        {
                        list[i].Time,
                        list[i].Finished,
                        list[i].Defectve,
                        list[i].Nufinished,
                        list[i].Nudefectve

                        }));
                }));

                Console.WriteLine("시간: " + list[i].Time);
                Console.WriteLine("부품 1라인 완성품: " + list[i].Finished + " 개");
                Console.WriteLine("부품 1라인 불량품: " + list[i].Defectve + " 개");

                Console.WriteLine("누적된 완성품 :" + list[i].Nufinished + "개");
                Console.WriteLine("누적된 불량품 :" + list[i].Nudefectve + "개");
                Console.WriteLine("==================================");
            }
            


        }
        void initListView2()
        {
            List<LineEnvData> list = adapter.getcustDB();

            for (int i = 0; i < list.Count; i++)
            {
                listView1.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Time,
                        list[i].Finished,
                        list[i].Defectve,
                        list[i].Nufinished,
                        list[i].Nudefectve

                    }));
            }
        }


    }
    
}
