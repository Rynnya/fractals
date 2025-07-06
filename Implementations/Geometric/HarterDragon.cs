using Fractals.Extensions;

using System;
using System.Drawing;
using System.Text;

namespace Fractals.Implementations.Geometric
{
    public static class HarterDragon
    {
        private const double angleAdjustment = Math.PI / 2;

        public static Bitmap Draw(int width, int height, int amountOfIterations)
        {
            Bitmap result = new Bitmap(width, height);
            result.Clear(MainWindow.CurrentBackgroundColor);

            string fullRule = LSystem.Unwrap("FX", amountOfIterations, (string baseString) =>
            {
                StringBuilder output = new StringBuilder();

                foreach (char task in baseString)
                {
                    switch (task)
                    {
                        case '+':
                        case '-':
                        case 'F':
                            output.Append(task);
                            continue;
                        case 'X':
                            output.Append("X+YF+");
                            continue;
                        case 'Y':
                            output.Append("-FX-Y");
                            continue;
                    }
                }

                return output.ToString();
            });

            double currentAngle = 0;
            int sideSize = Convert.ToInt32(width / Math.Pow(amountOfIterations + 1, 2));

            float x = width / 2;
            float y = height / 2;

            foreach (char task in fullRule)
            {
                switch (task)
                {
                    case 'X':
                    case 'Y':
                        continue;
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
