using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task4_AbstractDraw
{
    class Circle : Figure
    {
        private int _radius;
        private readonly Brush _borderBrush;

        public Circle()
        {
            var rn = new Random();
            _radius = rn.Next(1, 200);
            _borderBrush = new SolidColorBrush(Color.FromRgb((byte)rn.Next(1, 255), (byte)rn.Next(1, 255), (byte)rn.Next(1, 255)));
        }

        public override void Draw(Canvas canvas)
        {
            var rn = new Random();
            var circle = new Ellipse
            {
                Stroke = _borderBrush,
                Width = rn.Next(40, 200),
                Height = rn.Next(40, 200)
            };
            Canvas.SetTop(circle, rn.Next(100, 700));
            Canvas.SetLeft(circle, rn.Next(100, 700));
            canvas.Children.Add(circle);
        }
    }
}
