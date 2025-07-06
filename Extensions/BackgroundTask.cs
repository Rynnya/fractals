using Fractals.Implementations.Dynamic;
using Fractals.Implementations.Geometric;
using Fractals.Implementations.Stochastic;

using System;
using System.ComponentModel;
using System.Drawing;

namespace Fractals.Extensions
{
    public static class BackgroundTask
    {
        private static readonly BackgroundWorker worker = new BackgroundWorker();

        private static Bitmap WorkerJob(BackgroundTaskContainer arguments)
        {
            int amountOfIterations = arguments.GeometricAmountOfIterations;

            switch (arguments.SelectedIndex)
            {
                case 0:
                    switch (arguments.GeometricSelectedIndex)
                    {
                        case 0:
                            return KochCurve.Draw(arguments.Width, arguments.Height, amountOfIterations);
                        case 1:
                            return HilbertCurve.Draw(arguments.Width, arguments.Height, amountOfIterations);
                        case 2:
                            return SierpinskiCurve.Draw(arguments.Width, arguments.Height, amountOfIterations);
                        case 3:
                            return SierpinskiTriangle.Draw(arguments.Width, arguments.Height, amountOfIterations);
                        case 4:
                            return HarterDragon.Draw(arguments.Width, arguments.Height, amountOfIterations);
                        case 5:
                            return Bush.Draw(arguments.Width, arguments.Height, amountOfIterations);
                    }
                    break;
                case 1:
                    switch (arguments.DynamicSelectedIndex)
                    {
                        case 0:
                            return JuliaSet.Draw(arguments.Width, arguments.Height, JuliaSettings.CReal, JuliaSettings.CImagine);
                        case 1:
                            return NewtonFractal.Draw(arguments.Width, arguments.Height, NewtonSettings.XMultiplier, NewtonSettings.YMultiplier);
                    }
                    break;
                case 2:
                    if (arguments.FractalTreeSelected)
                    {
                        Bitmap result = new Bitmap(arguments.Width, arguments.Height);
                        result.Clear(Color.White);

                        FractalTree.Draw(ref result, 400, 600, 3 * Math.PI / 2, 100);
                        return result;
                    }

                    if (arguments.PlasmaSelected)
                    {
                        Plasma plasma = new Plasma(arguments.Width, arguments.Height);
                        return plasma.Draw();
                    }
                    break;
            }

            return arguments.CurrentImage;
        }

        public static void Initialize()
        {
            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                BackgroundTaskContainer arguments = e.Argument as BackgroundTaskContainer;
                e.Result = WorkerJob(arguments);
            };
        }

        public static void OnCompleted(RunWorkerCompletedEventHandler handler) => worker.RunWorkerCompleted += handler;

        public static void Run(BackgroundTaskContainer container) => worker.RunWorkerAsync(container);
    }

    public class BackgroundTaskContainer
    {
        public int SelectedIndex { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int GeometricAmountOfIterations { get; set; }
        public int GeometricSelectedIndex { get; set; }

        public int DynamicSelectedIndex { get; set; }

        public bool FractalTreeSelected { get; set; }
        public bool PlasmaSelected { get; set; }

        public Bitmap CurrentImage { get; set; }
    }
}
