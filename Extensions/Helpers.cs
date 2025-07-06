using System;
using System.Drawing;

namespace Fractals.Extensions
{
    public static class LSystem
    {
        public static string Unwrap(string baseString, int amountOfIterations, Func<string, string> replacements)
        {
            while (amountOfIterations-- > 0)
                baseString = replacements(baseString);

            return baseString;
        }
    }

    public static class Extensions
    {
        public static void DrawLine(this Bitmap bitmap, Pen pen, float x1, float y1, float x2, float y2)
        {
            using (var field = Graphics.FromImage(bitmap))
                field.DrawLine(pen, x1, y1, x2, y2);
        }

        public static void Clear(this Bitmap bitmap, Color fill)
        {
            using (var field = Graphics.FromImage(bitmap))
                field.Clear(fill);
        }
    }
}
