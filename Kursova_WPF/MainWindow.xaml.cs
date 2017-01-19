using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.ComponentModel;

namespace Kursova_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tr.State = 1;
            Event_Table += win2.Set_Table;
        }
        Tabel win2 = new Tabel();
        Translations tr = new Translations();
        validation vl = new validation();
        bool[] MN_cheack = new bool[14];
        bool[] AL_cheack = new bool[3];
        bool data = false;
        bool stop_start;

        public event Action Event_Table;


        private void Add_in_Table()
        {
            win2.Add_Table(tr.Prev_FILE,tr.Comand,tr.Prev_Position);
        }
        private void HeadText(string[] mas, int curent_pos)
        {
            if(curent_pos > 18)  while (curent_pos > 18) curent_pos -= 18;
            Dispatcher.Invoke(() => {
            textBlock_1.Text = mas[0];
            if(curent_pos==1)textBlock_1.Background = new SolidColorBrush(Colors.Red);
            else textBlock_1.Background = new SolidColorBrush(Colors.Blue);
            textBlock_2.Text = mas[1];
            if (curent_pos == 2) textBlock_2.Background = new SolidColorBrush(Colors.Red);
            else textBlock_2.Background = new SolidColorBrush(Colors.Blue);
            textBlock_3.Text = mas[2];
            if (curent_pos == 3) textBlock_3.Background = new SolidColorBrush(Colors.Red);
            else textBlock_3.Background = new SolidColorBrush(Colors.Blue);
            textBlock_4.Text = mas[3];
            if (curent_pos == 4) textBlock_4.Background = new SolidColorBrush(Colors.Red);
            else textBlock_4.Background = new SolidColorBrush(Colors.Blue);
            textBlock_5.Text = mas[4];
            if (curent_pos == 5) textBlock_5.Background = new SolidColorBrush(Colors.Red);
            else textBlock_5.Background = new SolidColorBrush(Colors.Blue);
            textBlock_6.Text = mas[5];
            if (curent_pos == 6) textBlock_6.Background = new SolidColorBrush(Colors.Red);
            else textBlock_6.Background = new SolidColorBrush(Colors.Blue);
            textBlock_7.Text = mas[6];
            if (curent_pos == 7) textBlock_7.Background = new SolidColorBrush(Colors.Red);
            else textBlock_7.Background = new SolidColorBrush(Colors.Blue);
            textBlock_8.Text = mas[7];
            if (curent_pos == 8) textBlock_8.Background = new SolidColorBrush(Colors.Red);
            else textBlock_8.Background = new SolidColorBrush(Colors.Blue);
            textBlock_9.Text = mas[8];
            if (curent_pos == 9) textBlock_9.Background = new SolidColorBrush(Colors.Red);
            else textBlock_9.Background = new SolidColorBrush(Colors.Blue);
            textBlock_10.Text = mas[9];
            if (curent_pos == 10) textBlock_10.Background = new SolidColorBrush(Colors.Red);
            else textBlock_10.Background = new SolidColorBrush(Colors.Blue);
            textBlock_11.Text = mas[10];
            if (curent_pos == 11) textBlock_11.Background = new SolidColorBrush(Colors.Red);
            else textBlock_11.Background = new SolidColorBrush(Colors.Blue);
            textBlock_12.Text = mas[11];
            if (curent_pos == 12) textBlock_12.Background = new SolidColorBrush(Colors.Red);
            else textBlock_12.Background = new SolidColorBrush(Colors.Blue);
            textBlock_13.Text = mas[12];
            if (curent_pos == 13) textBlock_13.Background = new SolidColorBrush(Colors.Red);
            else textBlock_13.Background = new SolidColorBrush(Colors.Blue);
            textBlock_14.Text = mas[13];
            if (curent_pos == 14) textBlock_14.Background = new SolidColorBrush(Colors.Red);
            else textBlock_14.Background = new SolidColorBrush(Colors.Blue);
            textBlock_15.Text = mas[14];
            if (curent_pos == 15) textBlock_15.Background = new SolidColorBrush(Colors.Red);
            else textBlock_15.Background = new SolidColorBrush(Colors.Blue);
            textBlock_16.Text = mas[15];
            if (curent_pos == 16) textBlock_16.Background = new SolidColorBrush(Colors.Red);
            else textBlock_16.Background = new SolidColorBrush(Colors.Blue);
            textBlock_17.Text = mas[16];
            if (curent_pos == 17) textBlock_17.Background = new SolidColorBrush(Colors.Red);
            else textBlock_17.Background = new SolidColorBrush(Colors.Blue);
            textBlock_18.Text = mas[17];
            if (curent_pos == 18) textBlock_18.Background = new SolidColorBrush(Colors.Red);
            else textBlock_18.Background = new SolidColorBrush(Colors.Blue);
            HEAD();
            });
        }
        void HEAD()
        {
            label_out_position.Content = tr.Position.ToString();
            label_out_stan.Content = tr.State.ToString();
        }
        void CheackB()
        {
            Dispatcher.Invoke(() =>
            {
                MN_cheack[0] = checkBox_q1.IsChecked.Value;
                MN_cheack[1] = checkBox_q2.IsChecked.Value;
                MN_cheack[2] = checkBox_q3.IsChecked.Value;
                MN_cheack[3] = checkBox_q4.IsChecked.Value;
                MN_cheack[4] = checkBox_q5.IsChecked.Value;
                MN_cheack[5] = checkBox_q6.IsChecked.Value;
                MN_cheack[6] = checkBox_q7.IsChecked.Value;
                MN_cheack[7] = checkBox_q8.IsChecked.Value;
                MN_cheack[8] = checkBox_q9.IsChecked.Value;
                MN_cheack[9] = checkBox_q10.IsChecked.Value;
                MN_cheack[10] = checkBox_q11.IsChecked.Value;
                MN_cheack[11] = checkBox_q12.IsChecked.Value;
                MN_cheack[12] = checkBox_q13.IsChecked.Value;
                MN_cheack[13] = checkBox_q14.IsChecked.Value;
            });
        }
        void Speed()
        {
            if (radioButton.IsChecked == true)
                tr.Speed = 500;
            if (radioButton_1.IsChecked == true)
                tr.Speed = 150;
            if (radioButton_2.IsChecked == true)
                tr.Speed = 0;
        }
        void CheackA()
        {
            Dispatcher.Invoke(() =>
            {
                AL_cheack[0] = checkBox_numbers.IsChecked.Value;
                AL_cheack[1] = checkBox_ALF.IsChecked.Value;
                AL_cheack[2] = checkBox_znaki.IsChecked.Value;
            });
        }
        bool CheackMasCheackBox()
        {
            for (int i = 0; i < 14; i++) if (MN_cheack[i] == true) return true;
            return false;
        }
        bool CheackMasCheackBoxA()
        {
            for (int i = 0; i < 3; i++) if (AL_cheack[i] == true) return true;
            return false;
        }
        void ReadData()
        {
            tr.FILE = textBox_in_data.Text;
            data = true;
        }
        void ReadState()
        {
            Regex num = new Regex(@"[1-9](:?\d+)?");
            Match st = num.Match(textBox_in_state.Text);
            tr.State = int.Parse(st.Groups[0].Value);
        }

        void One_Step()
        {
            try
            {
                Dispatcher.Invoke(() =>
                {
                    CheackB();
                    if (data)
                    {
                        Add_in_Table();
                        tr.FILE = tr.Transl();
                        Stroka st = new Stroka();
                        string[] a1 = st.change(tr.FILE, tr.Position);
                        HeadText(a1, tr.Position);
                        if (tr.FILE.Length + 1 <= tr.Position || tr.STOP || tr.Position < 1) {
                            Add_in_Table();
                            stop_start = false;
                            Event_Table();
                            win2.Show();
                            tr.Position = 1; tr.STOP = false;
                            data = true;
                            win2 = new Tabel();
                            Event_Table = null;
                            Event_Table += win2.Set_Table;
                            HeadText(a1, tr.Position);
                            tr.Default();
                            data = false;
                        }
                    }
                });
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Сталася неочікувана помилка", "Помилка");
            }

        }

        void Start()
        {
            if (data)
            {
                while (true)
                {
                    if (!stop_start) break;
                    One_Step();
                    if (tr.Position >= tr.FILE.Length+1) break;
                    Thread.Sleep(tr.Speed);
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(tr.Position>0) One_Step();
            else
            {
                string[] mas = new string[18];
                HeadText(mas,1);
            }
        }

        private void textBox_in_data_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Speed();
            if (!stop_start)
            {
                stop_start = true;
                Thread myThread = new Thread(new ThreadStart(Start));
                myThread.Start();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            stop_start = false;
        }
      
        private void Set_Data(object sender, RoutedEventArgs e)
        {
            if(sender == button_comand)
            {
                CheackB();
                if (vl.CheakComand(textBox_command.Text, MN_cheack))
                {
                    tr.All_Comand = textBox_command.Text;
                }
                else
                {
                    System.Windows.MessageBox.Show("Введений стан не передбачений множиною станів", "Помилка");
                }
            }
            if (sender == button_konf)
            {
                stop_start = false;
                CheackA();
                vl.MAS = AL_cheack;
                if (vl.CheackValid(textBox_in_data.Text))//VALIDATIONS input data
                {
                    stop_start = false;
                    ReadData();
                    tr.Position = 1;
                    Stroka st = new Stroka();
                    string[] a1 = st.change(tr.FILE, st.Position);
                    HeadText(a1, st.Position);
                }
                else
                {
                    System.Windows.MessageBox.Show("Введені данні не передбачені можливим алфавітом", "Помилка");
                }
            }
            if (sender == button_state)
            {
                CheackB();
                Regex tm1 = new Regex(@"(:?q|Q)?(\d+)");
                Match n_next = tm1.Match(textBox_in_state.Text);
                if (n_next.Success)
                {
                    if (CheackMasCheackBox())
                    {

                        if (int.Parse(n_next.Groups[2].Value) >= 1 && (int.Parse(n_next.Groups[2].Value) <= 14))
                        {
                            if (MN_cheack[int.Parse(n_next.Groups[2].Value) - 1] == true)
                                tr.State = int.Parse(n_next.Groups[2].Value);
                        }
                        else
                        {
                            if (int.Parse(n_next.Groups[2].Value) > 14)
                            {
                                for (int i = 13; i >= 0; i--)
                                    if (MN_cheack[i] == true)
                                    {
                                        tr.State = i + 1;
                                        textBox_in_state.Text = "q" + (i + 1);
                                        break;
                                    }
                            }

                        }
                        HEAD();
                    }
                    else
                    {
                        checkBox_q1.IsChecked = true;
                        textBox_in_state.Text = "q1";
                    }
                }
                else
                {
                    textBox_in_state.Text = "q1";
                }
            }
            
        }

        private void Move_Click(object sender, RoutedEventArgs e)
        {
            if (sender == button_m_l)
            {
                CheackB();
                if (CheackMasCheackBox())
                {
                    if (tr.State > 1)
                        for (int i = tr.State - 2; i != -1; i--)
                        {
                            if (MN_cheack[i] == true)
                            {
                                tr.State = i + 1;
                                textBox_in_state.Text = "q" + (i + 1);
                                break;
                            }
                        }
                }
                HEAD();
            }
            if (sender == button_m_r)
            {
                CheackB();
                if (CheackMasCheackBox())
                {
                    if (tr.State < 14)
                        for (int i = tr.State; i < 14; i++)
                        {
                            if (MN_cheack[i] == true)
                            {
                                tr.State = i + 1;
                                textBox_in_state.Text = "q" + (i + 1);
                                break;
                            }
                        }
                }
                HEAD();
            }
        }

    }
}
