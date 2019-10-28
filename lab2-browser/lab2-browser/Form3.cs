using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_browser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Draw();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Draw()
        {
            Point[] points = new Point[5];
            points[0] = new Point(50, 20);//x,y
            points[1] = new Point(70, 40);
            points[2] = new Point(60, 60);
            points[3] = new Point(40, 60);
            points[4] = new Point(30, 40);

            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawPolygon(Pens.Black, points);
            picture.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
