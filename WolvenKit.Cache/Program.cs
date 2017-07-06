using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WolvenKit.Cache
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using (var of = new OpenFileDialog())
            {
                of.Filter = "Witcher 3 Soundcache files | *.cache";
                if(of.ShowDialog() == DialogResult.OK)
                {
                    if(Cache.GetCacheTypeOfFile(of.FileName) == Cache.Cachetype.Sound)
                    {
                        Console.Title = "Reading: " + of.FileName + "!";
                        var sc = new SoundCache(of.FileName);
                        foreach (var item in sc.Files)
                        {
                            item.Extract(Path.GetDirectoryName(of.FileName) + "\\Sounds\\" + item.Name);
                        }
                        SoundCache.Write(Directory.GetFiles(Path.GetDirectoryName(of.FileName) + "\\Sounds\\").ToList(), Path.GetDirectoryName(of.FileName) + "\\Sounds\\soundpc_clone.cache");
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
