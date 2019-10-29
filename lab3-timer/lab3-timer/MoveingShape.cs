using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_timer
{
    public partial class MoveingShape : Form
    {
        private int xCoord = 20;
        private int yCoord = 0;
        public MoveingShape()
        {
            InitializeComponent();
            //redrawShape();
            timer1.Enabled = true;
        }

        private void redrawShape()
        {
            if(xCoord>picture.Width || yCoord > picture.Height)
            {
                xCoord = 20;
                yCoord = 0;
            }
            PentaSmile ps = new PentaSmile(new Point(xCoord, yCoord));
            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            ps.draw(bitmap);
            picture.Image = bitmap;
            xCoord++;
            yCoord++;
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            redrawShape();
        }
    }
}
