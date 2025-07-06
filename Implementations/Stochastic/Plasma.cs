using Fractals.Extensions;

using System;
using System.Drawing;

namespace Fractals.Implementations.Stochastic
{
    public class Plasma
    {
        private readonly double[][] map;

        private double minHeight;
        private double maxHeight;

        private readonly int width;
        private readonly int height;
        private readonly int size;

        public Plasma(int w, int h)
        {
            width = w;
            height = h;
            size = PowerOf2(Math.Max(width, height)) + 1;

            map = new double[size][];
            for (int i = 0; i < size; i++)
                map[i] = new double[size];
        }

        private static int PowerOf2(int size)
        {
            int result = 2;
            while (true)
            {
                if (result >= size)
                    return result;

                result <<= 1;
            }
        }

        private double Randomize(int diameter, double baseValue)
        {
            double result = baseValue + (MainWindow.RNG.NextDouble() - 0.5) * diameter;
            minHeight = Math.Min(result, minHeight);
            maxHeight = Math.Max(result, maxHeight);
            return result;
        }

        private void Square(int x, int y, int d /* diameter */)
        {
            double sum = 0;
            int counter = 0;

            if (x - d >= 0)
            {
                if (y - d >= 0)
                {
                    sum += map[x - d][y - d];
                    counter++;
                }
                if (size > y + d)
                {
                    sum += map[x - d][y + d];
                    counter++;
                }
            }
            if (size > x + d)
            {
                if (y - d >= 0)
                {
                    sum += map[x + d][y - d];
                    counter++;
                }
                if (size > y + d)
                {
                    sum += map[x + d][y + d];
                    counter++;
                }
            }

            map[x][y] = Randomize(d, sum / counter);
        }

        private void Diamond(int x, int y, int d /* diameter */)
        {
            double sum = 0;
            int counter = 0;

            if (x - d >= 0)
            {
                sum += map[x - d][y];
                counter++;
            }
            if (size > x + d)
            {
                sum += map[x + d][y];
                counter++;
            }
            if (y - d >= 0)
            {
                sum += map[x][y - d];
                counter++;
            }
            if (size > y + d)
            {
                sum += map[x][y + d];
                counter++;
            }

            map[x][y] = Randomize(d, sum / counter);
        }

        private void DiamondSquare()
        {
            int diameter = size;
            map[0][0] = Randomize(diameter, 0);
            map[0][diameter - 1] = Randomize(diameter, 0);
            map[diameter - 1][0] = Randomize(diameter, 0);
            map[diameter - 1][diameter - 1] = Randomize(diameter, 0);
            diameter >>= 1;

            while (diameter >= 1)
            {
                for (int x = diameter; x < size; x += 2 * diameter)
                    for (int y = diameter; y < size; y += 2 * diameter)
                        Square(x, y, diameter);

                for (int x = diameter; x < size; x += 2 * diameter)
                    for (int y = 0; y < size; y += 2 * diameter)
                        Diamond(x, y, diameter);

                for (int x = 0; x < size; x += 2 * diameter)
                    for (int y = diameter; y < size; y += 2 * diameter)
                        Diamond(x, y, diameter);

                diameter >>= 1;
            }
        }

        public Bitmap Draw()
        {
            DiamondSquare();
            double heightRange = maxHeight - minHeight;

            Bitmap result = new Bitmap(width, height);
            result.Clear(Color.White);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int gradient = Math.Abs(Convert.ToInt32((map[x][y] - minHeight) / heightRange * 255));
                    result.SetPixel(x, y, Color.FromArgb(gradient, gradient, gradient));
                }
            }

            return result;
        }
    }
}
