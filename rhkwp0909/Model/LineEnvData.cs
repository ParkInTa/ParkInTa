using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhkwp0909.Model
{
    class LineEnvData
    {
        string time;
        string finished;
        string defectve;
        string nufinished;
        string nudefectve;

        public LineEnvData(string finished, string defectve)
        {
            this.finished = finished;
            this.defectve = defectve;
        }

        public LineEnvData(string time, string finished, string defectve)
        {
            this.time = time;
            this.finished = finished;
            this.defectve = defectve;
        }

        public LineEnvData(string time, string finished, string defectve, string nufinished, string nudefectve)
        {
            this.time = time;
            this.finished = finished;
            this.defectve = defectve;
            this.nufinished = nufinished;
            this.nudefectve = nudefectve;
        }

        public string Time { get => time; set => time = value; }
        public string Finished { get => finished; set => finished = value; }
        public string Defectve { get => defectve; set => defectve = value; }
        public string Nufinished { get => nufinished; set => nufinished = value; }
        public string Nudefectve { get => nudefectve; set => nudefectve = value; }
    }
}
