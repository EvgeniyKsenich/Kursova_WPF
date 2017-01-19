using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Kursova_WPF
{
    /// <summary>
    /// Логика взаимодействия для Tabel.xaml
    /// </summary>
    public partial class Tabel : Window
    {
        public Tabel()
        {
            InitializeComponent();
            Set_Table();
        }

        private string[] konf = new string[0];
        private string[] komand = new string[0];
        private int[] num = new int[0];
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        public void Add_Table(string konf_, string komand_, int num_)
        {
            string[] _konf = new string[konf.Length+1];
            string[] _komand = new string[komand.Length+1];
            int[] _num = new int[num.Length+1];
            for (int i = 0; i < konf.Length; i++)
                _konf[i] = konf[i];
            _konf[konf.Length] = konf_;
            konf = _konf;

            for (int i = 0; i < num.Length; i++)
                _num[i] = num[i];
            _num[num.Length] = num_;
            num = _num;

            for (int i = 0; i < komand.Length; i++)
                _komand[i] = komand[i];
            _komand[komand.Length] = komand_;
            komand = _komand;
        }

        public void Set_Table()
        {
            
            Dispatcher.Invoke(() =>
            {
                listView.Items.Clear();
                for (int i = 0; i < konf.Length; i++)
                {
                    if (num.Length-1 > i)
                    {
                        if (i == 0)
                        {
                            listView.Items.Add(new Data_Control() { State = konf[i], Number = num[i], Comand = komand[i + 1] });
                        }
                        else
                        {
                            listView.Items.Add(new Data_Control() { State = konf[i], Number = (num[i]+1), Comand = komand[i + 1] });
                        }
                    }
                }
            });
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
