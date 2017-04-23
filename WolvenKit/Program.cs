using System;
using System.Threading;
using System.Windows.Forms;

namespace WolvenKit
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainController.Get().Window);
        }
    }
}