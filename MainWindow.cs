using Fractals.Extensions;
using Fractals.Settings;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fractals
{
    public partial class MainWindow : Form
    {
        public static readonly Random RNG = new Random();

        private readonly Graphics field = null;
        private Rectangle fieldRectangle;

        private Bitmap currentImage = null;
        private Color storedColor = Color.White;

        public static Pen CurrentPen { get; private set; } = new Pen(Color.Black);
        public static Color CurrentBackgroundColor { get; private set; } = Color.White;

        public MainWindow()
        {
            InitializeComponent();

            field = outputBox.CreateGraphics();
            fieldRectangle = new Rectangle(0, 0, outputBox.Width, outputBox.Height);

            BackgroundTask.Initialize();
            BackgroundTask.OnCompleted((object sender, RunWorkerCompletedEventArgs e) =>
            {
                if (e.Error == null && !e.Cancelled)
                {
                    currentImage = e.Result as Bitmap;
                    field.DrawImage(currentImage, fieldRectangle);
                }

                ChangeDrawState(true);
            });

            void whenLoading()
            {
                drawFractal.Enabled = false;
                selectType.Enabled = false;
            }

            void whenClosing()
            {
                drawFractal.Enabled = true;
                selectType.Enabled = true;
            }

            JuliaSettingsWindow.WhenLoading += whenLoading;
            JuliaSettingsWindow.WhenClosing += whenClosing;

            NewtonSettingsWindow.WhenLoading += whenLoading;
            NewtonSettingsWindow.WhenClosing += whenClosing;
        }

        private void PreRenderEvent(object sender, EventArgs e)
        {
            geometricTypeSelect.SelectedIndex = 0;
            dynamicTypeSelect.SelectedIndex = 0;
            stochasticFractalTree.Select();
        }

        private void ClearField()
        {
            field.Clear(CurrentBackgroundColor);
        }

        private void ChangeDrawState(bool state)
        {
            drawFractal.Enabled = state;
        }

        private void Draw(object sender, EventArgs e)
        {
            ChangeDrawState(false);

            BackgroundTask.Run(new BackgroundTaskContainer
            {
                SelectedIndex = selectType.SelectedIndex,
                Width = outputBox.Width,
                Height = outputBox.Height,

                GeometricAmountOfIterations = geometricAmountOfIterationsSelect.SelectedIndex + 1,
                GeometricSelectedIndex = geometricTypeSelect.SelectedIndex,

                DynamicSelectedIndex = dynamicTypeSelect.SelectedIndex,

                FractalTreeSelected = stochasticFractalTree.Checked,
                PlasmaSelected = stochasticPlasma.Checked,

                CurrentImage = currentImage
            });
        }

        private void ChangeFractalColor(object sender, EventArgs e)
        {
            if (fractalColorDialog.ShowDialog() == DialogResult.OK)
                CurrentPen.Color = fractalColorDialog.Color;
        }

        private void ChangeFieldColor(object sender, EventArgs e)
        {
            if (fieldColorDialog.ShowDialog() == DialogResult.OK)
                CurrentBackgroundColor = fieldColorDialog.Color;
            ClearField();
        }

        private void GeometricTypeChanged(object sender, EventArgs e)
        {
            object[] items = Enumerable.Range(1, Constants.geometricMaxIterations[geometricTypeSelect.SelectedIndex]).Cast<object>().ToArray();
            geometricAmountOfIterationsSelect.Items.Clear();
            geometricAmountOfIterationsSelect.Items.AddRange(items);
            geometricAmountOfIterationsSelect.SelectedIndex = 0;
        }

        private void DynamicSettingsOpen(object sender, EventArgs e)
        {
            switch (dynamicTypeSelect.SelectedIndex)
            {
                case 0:
                    new JuliaSettingsWindow
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = new Point(Location.X + Width - 300, Location.Y + Height / 3),
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false
                    }.Show();
                    break;
                case 1:
                    new NewtonSettingsWindow
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = new Point(Location.X + Width - 300, Location.Y + Height / 3),
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false
                    }.Show();
                    break;
            }
        }

        private void FractalTypeChanged(object sender, EventArgs e)
        {
            if (selectType.SelectedIndex == 0)
            {
                fractalColor.Enabled = true;
                fieldColor.Enabled = true;
                CurrentBackgroundColor = storedColor;
                ClearField();

                return;
            }

            if (fractalColor.Enabled)
            {
                fractalColor.Enabled = false;
                fieldColor.Enabled = false;
                storedColor = CurrentBackgroundColor;
                CurrentBackgroundColor = Color.White;
                ClearField();
            }
        }
    }
}
