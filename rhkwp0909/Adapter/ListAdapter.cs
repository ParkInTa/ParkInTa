using rhkwp0909.DAO;
using rhkwp0909.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhkwp0909.Adapter
{
    class ListAdapter
    {
        List<LineEnvData> lineEnvDatas = new List<LineEnvData>();
        public void addToList(LineEnvData lineEnv)
        {
            lineEnvDatas.Add(lineEnv);
            addToDB(lineEnv);
        }
        public void addToDB(LineEnvData lineEnv)
        {
            OraMgr.Instance.custDB(lineEnv);
        }
        public List<LineEnvData> getcustDB()
        {
            List<LineEnvData> list = OraMgr.Instance.getLivew();
            return list;
        }

    }
}
