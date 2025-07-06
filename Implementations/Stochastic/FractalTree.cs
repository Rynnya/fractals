using Fractals.Extensions;

using System;
using System.Drawing;

namespace Fractals.Implementations.Stochastic
{
    public static class FractalTree
    {
        private static readonly Pen leafPen = new Pen(Color.Green);
        private static readonly Pen lightLeafPen = new Pen(Color.FromArgb(90, 135, 5));
        private static readonly Pen treePen = new Pen(Color.FromArgb(100, 3, 4));

        public static void Draw(ref Bitmap field, int x, int y, double angle, int length)
        {
            if (length < 8)
                return;

            int x1 = Convert.ToInt32(x + Math.Cos(angle) * length);
            int y1 = Convert.ToInt32(y + Math.Sin(angle) * length);
            length = Math.Min(length, 100);
            int it = length / 6;

            if (length < 40)
            {
                for (int i = 0; i < 3; i++)
                    field.DrawLine(MainWindow.RNG.NextDouble() > 0.5 ? leafPen : lightLeafPen, x + i, y, x1, y1);
            }
            else
            {
                int diff = length / 12;

                for (int i = 0; i < it; i++)
                    field.DrawLine(treePen, x + i - diff, y, x1, y1);
            }

            int amountOfIterations = 9 - MainWindow.RNG.Next(9);
            for (int i = 0; i < amountOfIterations; i++)
            {
                int growth = MainWindow.RNG.Next(length - it) + it;
                
                int newX = Convert.ToInt32(x + Math.Cos(angle) * growth);
                int newY = Convert.ToInt32(y + Math.Sin(angle) * growth);
                double newAngle = angle + 1.6 * (0.5 - MainWindow.RNG.NextDouble());
                int newLength = length - 5 - MainWindow.RNG.Next(30);

                Draw(ref field, newX, newY, newAngle, newLength);
            }
        }
    }
}
