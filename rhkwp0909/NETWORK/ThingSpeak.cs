using Newtonsoft.Json;
using rhkwp0909.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace rhkwp0909.NETWORK
{
    class ThingSpeak
    {
        const string url = "http://api.thingspeak.com/";
        const string APIKEY_WRITE = "9SWHR1IWB9H3SXIV";


        public bool sendDateToThingSpeak(string field1, string field2, string field3,
                string field4, string field5, string field6, string field7, string field8)
        {
            string sbQS = string.Empty;
            // http 통신 
            sbQS += url + "update?key=" + APIKEY_WRITE;
            if (field1 != null)
            {
                sbQS += "&field1=" + HttpUtility.UrlEncode(field1);
            }
            if (field2 != null)
            {
                sbQS += "&field2=" + HttpUtility.UrlEncode(field2);
            }
            if (field3 != null)
            {
                sbQS += "&field3=" + HttpUtility.UrlEncode(field3);
            }
            if (field4 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field5 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field6 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field7 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field8 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            int res = Convert.ToInt32(postToThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }
        public string postToThingSpeak(string str)
        {
            string response = string.Empty;
            byte[] buf = new byte[8192];

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(str);
            HttpWebResponse webResponse = (HttpWebResponse)myRequest.GetResponse();

            try
            {
                Stream myResponse = webResponse.GetResponseStream();
                int count = 0;
                do
                {
                    count = myResponse.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        response += Encoding.ASCII.GetString(buf, 0, count);
                    }
                } while (count > 0);
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";
        }
        public List<LineEnvData> readThingSpeak()
        {
            string url = "https://api.thingspeak.com/channels/1505622/feeds.json?api_key=YTKIMUQXLGPKMS2Y&results=1";
            WebClient webClient = new WebClient();
            var date = webClient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(date);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            List<LineEnvData> list = new List<LineEnvData>();

            // Console.WriteLine("채널 정보: " + feed.channel.name);
            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string finished = feeds[i].field1;
                string defectve = feeds[i].field2;
                string nufinished = feeds[i].field3;
                string nudefectve = feeds[i].field4;


                list.Add(new LineEnvData(time,finished,defectve, nufinished, nudefectve));
            }
            return list;
        }
    }
    class ThingSpeakTimer
    {
        Timer timer;

        public ThingSpeakTimer(Timer timer)
        {
            this.timer = timer;
        }

        ~ThingSpeakTimer()
        {
            stopTimer();
        }

        public void stopTimer()
        {
            timer.Dispose();
        }
    }
}
