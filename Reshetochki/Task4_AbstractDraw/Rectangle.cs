using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace Task4_AbstractDraw
{
    class Rect:Figure
    {
        public int A { get; private set; }
        public int B { get; private set; }

        private Brush paintBrush;

        public override void Draw(Canvas canvas)
        {
            var rn = new Random();
            var rect = new System.Windows.Shapes.Rectangle();
            rect.Stroke = paintBrush;
            rect.Width = A;
            rect.Height = B;
            Canvas.SetLeft(rect,rn.Next(50, 700));
            Canvas.SetTop(rect, rn.Next(50, 700));
            canvas.Children.Add(rect);
        }
        public Rect()
        {
            var rn = new Random();
            A = rn.Next(10, 100);
            B = rn.Next(10, 100);
            paintBrush = new SolidColorBrush( Color.FromRgb((byte)rn.Next(1,255), (byte)rn.Next(1,255), (byte)rn.Next(1,255))); 
        }

    }
}
