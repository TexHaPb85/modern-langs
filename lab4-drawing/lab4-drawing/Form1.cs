using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_drawing
{
    public partial class FormFlag : Form
    {
        private int flagWidth = 30;
        private int flagHeight = 10;
        public FormFlag()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Redraw()
        {
            Flag urkFlag = new Flag(flagWidth,flagHeight);
            Bitmap bitmap = new Bitmap(pictureFlag.Width, pictureFlag.Height);
            urkFlag.DrawFlag(bitmap);
            pictureFlag.Image = bitmap;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureFlag_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Redraw();
            flagHeight += 3;
            flagWidth += 6;
            Console.WriteLine(flagHeight);
            if (flagWidth > 200 || flagHeight > 100)
            {
                timer1.Enabled = false;
                Console.WriteLine(flagHeight);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickDraw clickDraw = new clickDraw();
            clickDraw.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sea sea = new Sea();
            sea.ShowDialog();
        }
    }
}
