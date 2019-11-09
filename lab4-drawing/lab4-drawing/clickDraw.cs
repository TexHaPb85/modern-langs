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
    public partial class clickDraw : Form
    {
        public clickDraw()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += OnPictureBoxClicked;
        }

        private void OnPictureBoxClicked(object sender, MouseEventArgs args)
        {
            var location = args.Location;
            Console.Write(args.Location.X + "-" + args.Location.Y);
            if (args.Button == MouseButtons.Right)
                RedrawRect(args.Location.X, args.Location.Y);
            else if (args.Button == MouseButtons.Left)
                RedrawEllipse(args.Location.X, args.Location.Y);
        }

        private void RedrawEllipse(int x, int y)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillEllipse(Brushes.Yellow, x, y, 100, 40);
            pictureBox1.Image = bitmap;
        }

        private void RedrawRect(int x, int y)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Green,x,y,100,40);
            Font font = new Font("Times New Roman", 10.0f);
            graphics.DrawString(x + "-" + y, font, Brushes.Black, new Point(x + 30, y + 10));
            pictureBox1.Image = bitmap;

        }
    }
}
