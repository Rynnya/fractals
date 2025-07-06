using Fractals.Extensions;

using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Implementations.Geometric
{
    class State
    {
        public State(float x, float y, double angle)
        {
            X = x;
            Y = y;
            Angle = angle;
        }
        public float X { get; }
        public float Y { get; }
        public double Angle { get; }
    }

    public static class Bush
    {
        private const double angleAdjustment = 5 * (Math.PI / 32);

        public static Bitmap Draw(int width, int height, int amountOfIterations)
        {
            Bitmap result = new Bitmap(width, height);
            result.Clear(MainWindow.CurrentBackgroundColor);

            string fullRule = LSystem.Unwrap("F", amountOfIterations, (string baseString) => baseString.Replace("F", "F[+F]F[-F]"));

            double currentAngle = -(Math.PI / 2);
            int sideSize = Convert.ToInt32(width / Math.Pow(amountOfIterations + 1, 2.7));

            float x = width / 2;
            float y = height - sideSize;
            Stack<State> stack = new Stack<State>();

            foreach (char task in fullRule)
            {
                switch (task)
                {
                    case '[':
                        stack.Push(new State(x, y, currentAngle));
                        continue;
                    case ']':
                        State returnedState = stack.Pop();
                        x = returnedState.X;
                        y = returnedState.Y;
                        currentAngle = returnedState.Angle;
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
