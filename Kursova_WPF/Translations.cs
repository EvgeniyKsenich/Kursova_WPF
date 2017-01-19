using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kursova_WPF
{
    class Translations
    {
        protected string Begining;
        protected bool STOPIT;
        protected int position;
        protected int prev_position;
        protected int state;
        protected string file;
        protected string prev_file;
        protected string comand;
        protected string prev_comand;
        protected int speed;
        protected string allomand;

        public void  Default()
        {
            file = "";
            prev_file = "";
            position = 1;
            prev_position = 1;
            state = 1;
            STOPIT = false;
            comand = "";
            speed = 500;
        }

        public string All_Comand
        {
            get { return allomand; }
            set { allomand = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Translations()
        {
            Default();
        }
        public void Set_File_Begining()
        {
            file = Begining;
        }

        public string Comand
        {
            get { return comand; }
        }
        public string Prev_Comand
        {
            get { return prev_comand; }
        }
        public string FILE
        {
            set { file = value; Prev_FILE = value; Begining = value; }
            get { return file; }
        }
        public string Prev_FILE
        {
            set { prev_file = value; }
            get { return prev_file; }
        }
        public int Position
        {
            get { return position; }
            set { position = value; Prev_Position = value; }
        }
        public int Prev_Position
        {
            get { return prev_position; }
            set { prev_position = value; }
        }
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public bool STOP
        {
            set { STOPIT = value; }
            get { return STOPIT; }
        }

        public string Transl()
        {
            int LR = position;
            int tmp = position;
            Regex tm1 = new Regex(@"([\dA-Za-z])q(\d*)->([\dA-Za-z])(?:(?:q(\d*))|(STOP))([RLrl])?");
            MatchCollection n_next = tm1.Matches(allomand);
            int size_col = n_next.Count;
            int count = size_col;
            for (int i = 0; i < size_col; i++)
            {
                if ((position - 1) < file.Length)
                {
                    if (n_next[i].Groups[1].Value == file[position - 1].ToString() && state.ToString() == n_next[i].Groups[2].Value)
                    {
                        prev_position = position;
                        prev_file = file;
                        file = file.Remove(position - 1, 1).Insert(position - 1, n_next[i].Groups[3].Value);
                        this.comand = n_next[i].Groups[0].Value;
                        if (n_next[i].Groups[6].Value == "R" || n_next[i].Groups[6].Value == "r") LR++;
                        if (n_next[i].Groups[6].Value == "L" || n_next[i].Groups[6].Value == "l") LR--;
                        state = int.Parse(n_next[i].Groups[4].Value);
                        count--;
                        break;
                    }
                    if (n_next[i].Groups[5].Value == "STOP" || n_next[i].Groups[5].Value == "stop" || n_next[i].Groups[5].Value == "Stop")
                    {
                        STOPIT = true;
                        this.comand = "Stop";
                        break;
                    }
                }
            }
            if (count == size_col)
            {
                STOPIT = true;
                this.comand = "Stop no command";
            }
            position = LR;
            return file;
        }
    }
}
