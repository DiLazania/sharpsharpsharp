using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task4_AbstractDraw
{
    internal class Triangle : Figure
    {
        private (int x, int y) _a;
        private (int x, int y) _b;
        private (int x, int y) _c;
        private readonly Brush _brush; 

        public Triangle()
        {
            var rn = new Random();
            _a = (rn.Next(50, 500), rn.Next(50, 500));
            _b = (rn.Next(50, 500), rn.Next(50, 500));
            _c = (rn.Next(50, 500), rn.Next(50, 500));
            _brush = new SolidColorBrush(Color.FromRgb((byte)rn.Next(1, 255), (byte)rn.Next(1, 255), (byte)rn.Next(1, 255)));
        }

        public override void Draw(Canvas canvas)
        {
            var triangle = new Polygon();
            var vertices = new PointCollection
            {
                new Point(_a.x, _a.y),
                new Point(_b.x, _b.y),
                new Point(_c.x, _c.y)
            };
            triangle.Points = vertices;
            triangle.Stroke = _brush;
            var rn = new Random();
            Canvas.SetTop(triangle, rn.Next(100, 200));
            Canvas.SetLeft(triangle, rn.Next(100, 200));
            canvas.Children.Add(triangle);
        }
    }
}
