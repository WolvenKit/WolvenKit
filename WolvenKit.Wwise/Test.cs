using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Wwise
{
    class Test
    {
        [STAThread]
        public static void Main()
        {
            using (var of = new OpenFileDialog())
            {
                of.Filter = "Wwise files | *.wem;*.bnk; *.cache";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    switch (Path.GetExtension(of.FileName))
                    {
                        case ".cache":
                        {
                            var sc = new WolvenKit.Cache.SoundCache(of.FileName);
                            foreach(var f in sc.Files)
                            {
                                    Console.WriteLine("Item => " + f.Name + " | " + WolvenKit.Cache.SoundCache.GetIDFromPath(f.Name));
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
