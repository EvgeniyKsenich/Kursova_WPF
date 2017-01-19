using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kursova_WPF
{
    class validation
    {
        public validation()
        {
            MS[0] = false;
            MS[1] = false;
            MS[2] = false;
        }
        public bool[] MAS
        {
            get { return MS; }
            set { MS = value; }
        }

        protected string AngAl = "A-Za-z";
        protected string Num = "\\d";
        protected string znaki = "<>=\\+\\-\\*\\/";
        protected bool[] MS = new bool[3];
        protected static Regex tm1 = new Regex(@"([\dA-Za-z])q(\d*)->([\dA-Za-z])(?:(?:q(\d*))|(STOP))([RLrl])?");

        public bool CheakComand(string comand, bool[] all)
        {
            MatchCollection n_next = tm1.Matches(comand);
            int q1, q2;
            for (int i = 0; i < n_next.Count; i++)
            {
                if (n_next[i].Groups[4].Value == "") return false;
                q1 = int.Parse(n_next[i].Groups[2].Value);
                q2 = int.Parse(n_next[i].Groups[4].Value);
                q1--;
                q2--;
                if (all[q1] == false || all[q2] == false) return false;
            }
            return true;
        }


        public bool CheackValid(string file)
        {
            if(MS[0]==false && MS[1]==false && MS[2]==false)
            {
                return false;
            }
            string REG = "(([";
            string zap = "(([^";
            if (MS[0] == true) { REG += Num; zap += Num; }
            if (MS[1] == true) { REG += AngAl; zap += AngAl; }
            if (MS[2] == true) {REG += znaki; zap += znaki; }
            REG += "])+)";
            zap += "])+)";
            Regex tm1 = new Regex(@zap);
            Match mch = tm1.Match(file);
            if (mch.Success == true) return false;
            return true;
        }

 
    }
}
