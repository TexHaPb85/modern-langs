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
    public partial class Sea : Form
    {
        private int shipX=0;
        private int shipY = 250;
        public Sea()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void RedrawShip()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Ship ship = new Ship(shipX,shipY);
            ship.DrawShip(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Sea_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shipX+=10;
            if (shipX > pictureBox1.Width)
                shipX = -100;
            RedrawShip();
        }
    }
}
