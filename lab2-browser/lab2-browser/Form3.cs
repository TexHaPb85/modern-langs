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
            int heightP = picture.Height / 2;
            int widthP = picture.Width / 2;

            Point[] points = new Point[5];

            points[0] = new Point(picture.Width-(widthP/2), 5);//x,y
            points[1] = new Point(picture.Width, heightP/2);
            points[2] = new Point(picture.Width - (widthP / 4), heightP);
            points[3] = new Point(picture.Width - (widthP - (widthP/4)), heightP);
            points[4] = new Point(picture.Width-widthP, heightP / 2);

            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.DrawPolygon(Pens.Black, points);
            graphics.FillPolygon(Brushes.Blue, points);
            picture.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
