using Oracle.ManagedDataAccess.Client;
using rhkwp0909.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhkwp0909.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                Environment.Exit(0);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void custTable()
        {
            try
            {
                string sql = "create table cust_0906 (" +
                     "num number  NOT NULL," +
                     "name varchar(10) NOT NULL," +
                     "age  varchar(20) NOT NULL," +
                     "tel  varchar(50) NOT NULL," +
                     "addr  varchar(20) NOT NULL," +
                     "wnals  varchar(20) NOT NULL," +
                     "gender varchar(20) NOT NULL," +
                     "emdfhr  DATE NOT NULL," +
                     "PRIMARY KEY(num))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "create sequence seq_num " +
                    "increment by 1 start with 1000";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 오류: " + e.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                string sql = "drop table cust_0906";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "drop sequence seq_num";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블(시퀀스) 삭제 오류: "
                    + e.Message);
            }

        }
        public void custDB(LineEnvData dataa)
        {
            try
            {
                string sql = string.Format("insert into ware_0914 values (" +
                    "'{0}','{1}','{2}','{3}','{4}') ",
                    dataa.Time,dataa.Finished, dataa.Defectve,dataa.Nufinished,dataa.Nudefectve);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }

        }
        public List<LineEnvData> getLivew()
        {
            string sql = "select " +
                "time as 작업시간, " +
                "finished as 완성품, " +
                "defectve as 불량품, " +
                "nufinished as 누적완성품, " +
                "nudefectve as 누적불량품 " +
                "from ware_0914";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<LineEnvData> list = new List<LineEnvData>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    LineEnvData saVo = new LineEnvData(
                        rd["작업시간"].ToString(),
                        rd["완성품"].ToString(),
                        rd["불량품"].ToString(),
                        rd["누적완성품"].ToString(),
                        rd["누적불량품"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 111.");
            }
            rd.Close();
            return list;
            
        }
    }    
}
