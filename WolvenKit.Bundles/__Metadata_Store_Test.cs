using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Bundles
{
    class __Metadata_Store_Test
    {
        [STAThread]
        static int Main(string[] args)
        {
            using (var of = new OpenFileDialog() {Filter = "Metadata files | *.store"})
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var f = new Metadata_Store(of.FileName);
                }
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
            return 0;
        }
    }
}
