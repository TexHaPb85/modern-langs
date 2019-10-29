using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_timer
{
    class PentaSmile
    {
        public Point[] points;
        private int scale = 3;

        private int circleX;
        private int circleY;
        private int circleWight;
        private int circleHeight;

        private int rectWight = 20;
        private int rectHeight = 20;

        private int fRectX;
        private int fRectY;
        private int sRectX;
        private int sRectY;

        public PentaSmile(Point upPoint)
        {
            points = new Point[5];
            this.points[0] = upPoint;
            this.points[1] = new Point(upPoint.X + 20 * scale, upPoint.Y + 20 * scale);
            this.points[2] = new Point(upPoint.X + 10 * scale, upPoint.Y + 40 * scale);
            this.points[3] = new Point(upPoint.X - 10 * scale, upPoint.Y + 40 * scale);
            this.points[4] = new Point(upPoint.X - 20 * scale, upPoint.Y + 20 * scale);

            circleX = points[0].X - 12 * scale; ;
            circleY = points[0].Y + 10 * scale;
            circleWight = 25 * scale;
            circleHeight = 15 * scale;

            fRectX = circleX-2*scale;
            fRectY = circleY + circleHeight;

            sRectX = circleX + circleWight-5*scale;
            sRectY = circleY + circleHeight;
        }

        public PentaSmile(Point []points)
        {
            this.points = points;
        }

        public void draw(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.DrawPolygon(Pens.Black, points);
            graphics.FillPolygon(Brushes.Blue, points);
            graphics.FillEllipse(Brushes.White, circleX, circleY, circleWight, circleHeight);
            graphics.FillRectangle(Brushes.Yellow, fRectX, fRectY, rectWight, rectHeight);
            graphics.FillRectangle(Brushes.Yellow, sRectX, sRectY, rectWight, rectHeight);


        }
    }
}
