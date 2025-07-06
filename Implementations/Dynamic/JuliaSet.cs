using Fractals.Extensions;

using System;
using System.Drawing;

namespace Fractals.Implementations.Dynamic
{
    public static class JuliaSet
    {
        private const int maxIterations = 300;

        public static Bitmap Draw(int width, int height, double cReal, double cImagine)
        {
            Bitmap result = new Bitmap(width, height);
            result.Clear(Color.White);

            int r = MainWindow.RNG.Next(1, 9);
            int g = MainWindow.RNG.Next(1, 9);
            int b = MainWindow.RNG.Next(1, 9);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double newRe = 1.5 * (x - 0.5 * width) / (0.5 * width);
                    double newIm = (y - 0.5 * height) / (0.5 * height);

                    for (int n = 0; n < maxIterations; n++)
                    {
                        double oldRe = newRe;
                        double oldIm = newIm;

                        newRe = Math.Pow(oldRe, 2) - Math.Pow(oldIm, 2) + cReal;
                        newIm = 2 * oldRe * oldIm + cImagine;

                        if ((newRe * newRe + newIm * newIm) > 4)
                        {
                            result.SetPixel(x, y, Color.FromArgb(n * r % 255, n * g % 255, n * b % 255));
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
