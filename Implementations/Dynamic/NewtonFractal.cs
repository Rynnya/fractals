using Fractals.Extensions;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Fractals.Implementations.Dynamic
{
    public static class NewtonFractal
    {
        private const int maxIterations = 50;
        private const double tolerance = 0.000001;

        private static readonly Complex realOne = new Complex(1, 0);

        class ResultToColor
        {
            public Complex Complex { get; set; }

            public Color Color { get; set; }

        }

        // z^3 - 1
        private static readonly List<ResultToColor> roots = new List<ResultToColor>
        {
            { new ResultToColor { Complex = new Complex(1, 0), Color = Color.Red } },
            { new ResultToColor { Complex = new Complex(-0.5, Math.Sqrt(3) / 2), Color = Color.Green } },
            { new ResultToColor { Complex = new Complex(-0.5, -Math.Sqrt(3) / 2), Color = Color.Blue } }
        };

        private static Color Calculate(Complex z)
        {
            for (int n = 0; n < maxIterations; n++)
            {
                // f(z) = z^3 - 1; f'(z) = 3 * z^2
                z -= Complex.Divide(Complex.Pow(z, 3) - realOne, 3 * Complex.Multiply(z, z));

                for (int i = 0; i < roots.Count; i++)
                {
                    Complex diff = z - roots[i].Complex;

                    if (Math.Abs(diff.Real) < tolerance && Math.Abs(diff.Imaginary) > tolerance)
                        return roots[i].Color;
                }
            }

            return Color.Crimson;
        }

        public static Bitmap Draw(int width, int height, double xMultiplier, double yMultiplier)
        {
            Bitmap result = new Bitmap(width, height);
            result.Clear(Color.White);

            int middleX = width / 2;
            int middleY = height / 2;

            for (int y = -middleY; y < middleY; y++)
                for (int x = -middleX; x < middleX; x++)
                    result.SetPixel(middleX + x, middleY + y, Calculate(new Complex(x * xMultiplier, y * yMultiplier)));

            return result;
        }
    }
}
