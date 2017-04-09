using System;
using System.Windows.Forms;

namespace WolvenKit.Render
{
    static class Program
    {
        public static Bithack3D bithack3D;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bithack3D = new Bithack3D();
            Application.Run(bithack3D);
        }
    }
}
