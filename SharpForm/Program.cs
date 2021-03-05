using System;
using System.Windows.Forms;
using SharpForm.Forms;

namespace SharpForm
{
    internal static class Program
    {
        [STAThread]
        private static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}