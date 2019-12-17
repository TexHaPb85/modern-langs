using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab5_2
{ 
    public partial class Form2 : Form
    {
        public static double n=10;

        public Form2()
        {
            
            InitializeComponent();
            //===============================================================================================создали первый поток
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;//2 seconds
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();            

            
        }         
        //---------------------------------------------------------таймер для обновления формы
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }//------------------------------------------------------------------------------------        
        protected override void OnPaint(PaintEventArgs e)
        {
            Random rnd = new Random();  //Создание объекта для генерации чисел
            int value = rnd.Next(10, 200);//Получить случайное число (в диапазоне от 0 до 10)
            int value1 = rnd.Next(10, 200);//Получить случайное число (в диапазоне от 0 до 10)
            //e.Graphics.FillRectangle(Brushes.Blue, value, value1, 100, 30);// рисуем фигуру квадат
            //Console.WriteLine("Координата Х: " + value + "  Координата Y: " + value1 + "(Поток-1)");
            //--------------------------------------------------------------------сердце
            Pen pen = new Pen(Brushes.Blue);
            pen.Width = 5;
            e.Graphics.DrawEllipse(pen, value, value1, 40, 40);

        }//==============================================================================================закончили первый поток



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Thread((s) =>
            {
                if (textBox1.Text.Length >= 1)
                    n = Convert.ToDouble(textBox1.Text);
                else
                    this.textBox1.BeginInvoke((MethodInvoker)(() => textBox1.Text = "10"));
                double res = 0;
                for(int i = 0; i < n; i++)
                {
                    res += 1 / Math.Pow(2, i);
                }

                this.textBox2.BeginInvoke((MethodInvoker)(() => this.textBox2.Text = "sum"+res));

            })).Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }





        //=============================================================================================закончили  второй поток
    }
}
