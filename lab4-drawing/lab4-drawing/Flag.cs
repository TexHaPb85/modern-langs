using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_drawing
{
    class Flag
    {
        private int width;
        private int height;
        private Point upLeftPoint;

        public Flag(int width, int height) {
            this.upLeftPoint = new Point(5, 5);
            this.width = width;
            this.height = height;
        }

        public Flag(Point upPoint)
        {
            this.upLeftPoint = upPoint;
        }

        public void DrawFlag(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Blue, upLeftPoint.X, upLeftPoint.Y, width, height);
            graphics.FillRectangle(Brushes.Yellow, upLeftPoint.X, upLeftPoint.Y+height, width, height);
            Font font = new Font("Times New Roman", 30.0f);
            Point p = new Point(upLeftPoint.X + 2, upLeftPoint.Y + height * 2 + 30);
            graphics.DrawString("Ukraine", font, Brushes.Black, p);
        }
    }
}
