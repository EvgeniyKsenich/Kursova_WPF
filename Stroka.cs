﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_WPF
{
    class Stroka
    {
        private string[] Out = new string[18];
        public string[] change(string file, int curent_pos)
        {
            for (int i = 0; i < 18; i++) Out[i] = "";
            int size_f = file.Length - 1;
            int more = 0, tmp = curent_pos;

            while (tmp > 18)
            {
                tmp -= 18;
                more++;
            }
            for(int i=0;i<18;i++)
            {
                Out[i] = file[(more*18)+i];
            }
           
            return Out;
        }
    }
}

