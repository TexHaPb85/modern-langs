using Lab5_2;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace lab5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time=10;

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputparameter;

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            lblPercent.Text = string.Format("Processing...{0}%",e.ProgressPercentage);
            progress.Update();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                for(int i=0; i<process; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++*100/process, string.Format("Processig data {0}",i));
                        Thread.Sleep(time);
                    }

                }

            }
            catch(Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process has been completed.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
                time = Convert.ToInt32(textBox1.Text);
            else
                textBox1.Text = "10";

            if (!backgroundWorker.IsBusy)
            {
                _inputparameter.Delay = 100;
                _inputparameter.Process = 1200;
                backgroundWorker.RunWorkerAsync(_inputparameter);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

           
        }
    }
}
