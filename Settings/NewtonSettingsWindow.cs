using Fractals.Extensions;

using System;
using System.Windows.Forms;

namespace Fractals.Settings
{
    public partial class NewtonSettingsWindow : Form
    {
        public static event Action WhenLoading;
        public static event Action WhenClosing;

        public NewtonSettingsWindow() => InitializeComponent();

        private void OnLoad(object sender, EventArgs e)
        {
            xMultiplierInput.Text = NewtonSettings.XMultiplier.ToString();
            yMultiplierInput.Text = NewtonSettings.YMultiplier.ToString();
            WhenLoading?.Invoke();
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            NewtonSettings.XMultiplier = double.TryParse(xMultiplierInput.Text, out double xMultiplier) ? xMultiplier : 0.0001;
            NewtonSettings.YMultiplier = double.TryParse(yMultiplierInput.Text, out double yMultiplier) ? yMultiplier : 0.0001;
            WhenClosing?.Invoke();
        }
    }
}
