using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

using IrrlichtLime;
using System.IO;

namespace WolvenKit.Render
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //using (var fo = new OpenFileDialog())
            //{
            //    fo.Filter = "DDS Image | *.dds";
            //    if (fo.ShowDialog() == DialogResult.OK)
            //    {
            //        WolvenKit.Cache.DdsImage img = new Cache.DdsImage(File.ReadAllBytes(fo.FileName));
            //        var i = 0;
            //    }
            //}
            Application.Run(new frmTerrain());
            //Application.Run(new FastRender.frmFastRender(null));

        }
    }
}
