using Fractals.Extensions;

using System;
using System.Drawing;

namespace Fractals.Implementations.Geometric
{
    public static class KochCurve
    {
        private const double angleAdjustment = Math.PI / 2;

        public static Bitmap Draw(int width, int height, int amountOfIterations)
        {
            Bitmap result = new Bitmap(width, height);
            result.Clear(MainWindow.CurrentBackgroundColor);

            string fullRule = LSystem.Unwrap("F", amountOfIterations, (string baseString) => baseString.Replace("F", "F+F-F-F+F"));

            double currentAngle = 0;
            int sideSize = Convert.ToInt32(width / Math.Pow(amountOfIterations + 1, 3.1));

            float x = sideSize;
            float y = height - sideSize;

            foreach (char task in fullRule)
            {
                switch (task)
                {
                    case 'F':
                        float newX = Convert.ToSingle(Math.Cos(currentAngle) * sideSize);
                        float newY = Convert.ToSingle(Math.Sin(currentAngle) * sideSize);
                        result.DrawLine(MainWindow.CurrentPen, x, y, x + newX, y + newY);
                        x += newX;
                        y += newY;
                        continue;
                    case '+':
                        currentAngle -= angleAdjustment;
                        continue;
                    case '-':
                        currentAngle += angleAdjustment;
                        continue;
                }
            }

            return result;
        }
    }
}
