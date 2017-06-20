using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        Timer t = null;
        Timer t2 = null;
        int starth = 0;
        int startm = 0;
        int starts = 0;
        private void StartTimer()
        {
            t = new Timer()
            {
                Interval = 100
            };
            t.Tick += new EventHandler(T_Tick);
            t.Enabled = true;
        }

        private void StartTimer2()
        {
            t2 = new Timer()
            {
                Interval = 1000
            };
            t2.Tick += new EventHandler(T2_Tick);
            t2.Enabled = true;
        }

        void T_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        void T2_Tick(object sender, EventArgs e)
        {
            Runtime();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        public void Runtime()
        {
            int SecTime = Retime(label2.Text);
            SecTime = SecTime + 1;
            label2.Text = "Program running: " + Convert.ToString(SecTime) + " Sec";
                
        }

        public int Retime(string time)
        {
            string num = "";
            for (int i = 0; i < time.Length; i++)
            {
                switch (time[i])
                {
                    case '0':
                    num = num + time[i];
                        break;
                    case '1':
                        num = num + time[i];
                        break;
                    case '2':
                        num = num + time[i];
                        break;
                    case '3':
                        num = num + time[i];
                        break;
                    case '4':
                        num = num + time[i];
                        break;
                    case '5':
                        num = num + time[i];
                        break;
                    case '6':
                        num = num + time[i];
                        break;
                    case '7':
                        num = num + time[i];
                        break;
                    case '8':
                        num = num + time[i];
                        break;
                    case '9':
                        num = num + time[i];
                        break;
                    default:
                        break;
                }
            }
            
            return Convert.ToInt32(num);
        }
        
        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StartTimer();
            StartTimer2();
            starth = Convert.ToInt16(DateTime.Now.ToString("HH"));
            startm = Convert.ToInt16(DateTime.Now.ToString("mm"));
            starts = Convert.ToInt16(DateTime.Now.ToString("ss"));
            starttime.Text = "Time started: " + DateTime.Now.ToString("HH:mm:ss");
            button1.Enabled = false;
            button1.BackColor = Color.LimeGreen;
            button1.Text = "Program Started";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CaptureButton1_Click(object sender, EventArgs e)
        {
            timer1value.Text = DateTime.Now.ToString("HH:mm:ss");
            int timer1h = Convert.ToUInt16(DateTime.Now.ToString("HH"));
            int timer1m = Convert.ToUInt16(DateTime.Now.ToString("mm"));
            int timer1s = Convert.ToUInt16(DateTime.Now.ToString("ss"));
            string timer1t = Timertf(timer1h, timer1m, timer1s);
            timert1.Text = timer1t;
        }

        public string Timertf(int timer1h, int timer1m, int timer1s)
        {
            if ((timer1s - starts) >= 0)
            {
                timer1s = timer1s - starts;
            }
            else
            {
                timer1s = timer1s + 60 - starts;
                timer1m = timer1m - 1;
            }

            int timerm = 0;
            if ((timer1m - startm) >= 0)
            {
                timer1m = timer1m - startm + timerm;
            }
            else {
                timer1m = timer1m + 60 - startm;
                timer1h = timer1h - 1;
            }

            int timerh = 0;
            if ((timer1h - starth) >= 0)
            {
                timer1h = timer1h - starth + timerh;
            }
            else timer1h = timer1h + 24 - starth;
            return ("Time: " + Convert.ToString(timer1h) + ":" + Convert.ToString(timer1m) + "." + Convert.ToString(timer1s));
        }

        private void CaptureButton2_Click(object sender, EventArgs e)
        {
            timer2value.Text = DateTime.Now.ToString("HH:mm:ss");
            int timer2h = Convert.ToUInt16(DateTime.Now.ToString("HH"));
            int timer2m = Convert.ToUInt16(DateTime.Now.ToString("mm"));
            int timer2s = Convert.ToUInt16(DateTime.Now.ToString("ss"));
            string timer2t = Timertf(timer2h, timer2m, timer2s);
            timert2.Text = timer2t;
        }

        private void CaptureButton3_Click(object sender, EventArgs e)
        {
            timer3value.Text = DateTime.Now.ToString("HH:mm:ss");
            int timer3h = Convert.ToUInt16(DateTime.Now.ToString("HH"));
            int timer3m = Convert.ToUInt16(DateTime.Now.ToString("mm"));
            int timer3s = Convert.ToUInt16(DateTime.Now.ToString("ss"));
            string timer3t = Timertf(timer3h, timer3m, timer3s);
            timert3.Text = timer3t;
        }
    }
}
