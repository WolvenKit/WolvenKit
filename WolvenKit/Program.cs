using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using WolvenKit.App;

namespace WolvenKit
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[]  args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    switch (Path.GetExtension(args[0]))
                    {
                        case ".w3modproj":
                        {
                            MainController.Get().InitialModProject = args[0];
                            break;
                        }
                        case ".wkp":
                        {
                            MainController.Get().InitialWKP = args[0];
                            break;
                        }
                        case ".w2ent":
                        {
                            MainController.Get().InitialFilePath = args[0];
                            break;
                        }
                    }
                }
            }
            Application.Run(MockKernel.Get().Window);   
        }
    }
}