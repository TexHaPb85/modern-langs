﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_drawing
{
    class Ship
    {
        public int x;
        public int y;
        public int scale = 3;

        public Ship(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void DrawShip(Bitmap bitmap)
        {
            Point[] points = new Point[5];
            points[0] = new Point(x,y);
            points[1] = new Point(x+5*scale, y + 20 * scale);
            points[2] = new Point(x + 100 * scale, y);
            points[3] = new Point(x +10 * scale, y + 20 * scale);
            points[4] = new Point(x, y);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillPolygon(Brushes.Gray, points);
            graphics.FillRectangle(Brushes.Black, x + 10, y, 50, 20);
        }
    }
}
