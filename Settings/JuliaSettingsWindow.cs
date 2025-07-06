using Fractals.Extensions;

using System;
using System.Windows.Forms;

namespace Fractals.Settings
{
    public partial class JuliaSettingsWindow : Form
    {
        public static event Action WhenLoading;
        public static event Action WhenClosing;

        public JuliaSettingsWindow() => InitializeComponent();

        private void LoadSettings(object sender, EventArgs e)
        {
            cRealInput.Text = JuliaSettings.CReal.ToString();
            cImagineInput.Text = JuliaSettings.CImagine.ToString();
            WhenLoading?.Invoke();
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            JuliaSettings.CReal = double.TryParse(cRealInput.Text, out double cReal) ? cReal : 0.0051231;
            JuliaSettings.CImagine = double.TryParse(cImagineInput.Text, out double cImagine) ? cImagine : -0.9914112;
            WhenClosing?.Invoke();
        }
    }
}
