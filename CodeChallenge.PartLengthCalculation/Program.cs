using CodeChallenge.PartLengthCalculation.UI;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CodeChallenge.PartLengthCalculation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            Application.Run(new Main());
        }
    }
}