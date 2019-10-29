using System;
using System.Windows.Forms;

namespace lab3_timer
{
    public partial class Form1 : Form
    {
        private int sec, mns, hrs;
        private bool isGoing = false;
        public Form1()
        {
            InitializeComponent();
            MoveingShape f2 = new MoveingShape();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec < 59)
            {
                sec++;
            }
            else if (mns < 59)
            {
                sec = 0;
                mns++;
            }
            else
            {
                mns = 0;
                hrs++;
            }
            label1.Text = hrs.ToString() + ":" + mns.ToString() + ":" + sec.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isGoing)
            {
                timer1.Enabled = true;
                button1.Text = "stop";
                isGoing = true;
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "continue";
                isGoing = false;
            }
            
            DateTime today = DateTime.Now;
            label2.Text = "Date:"+today.ToString()+" day:"+today.DayOfWeek;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
