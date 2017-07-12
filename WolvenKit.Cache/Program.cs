using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace WolvenKit.Cache
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using (var fb = new FolderBrowserDialog())
            {
                if(fb.ShowDialog() == DialogResult.OK)
                {
                    IntenseTest(Directory.GetFiles(fb.SelectedPath,"soundspc.cache",SearchOption.AllDirectories).ToList());
                    MessageBox.Show("Operation completed!");
                }
            }
           /*using (var of = new OpenFileDialog())
            {
                of.Filter = "Witcher 3 Sound cache files | *.cache";
                of.Multiselect = true;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    IntenseTest(of.FileNames.ToList());
                }
            }*/
            Console.ReadLine();
        }

        public static void IntenseTest(List<string> Files2Test)
        {
            var xdoc = new XDocument(new XElement("SoundCacheTest",
                Files2Test.Select(x=> new XElement("Result",new XAttribute("FileName",x),
                                                   new XElement("OldFileHash",GetHash(x)),
                                                   new XElement("NewFileHash",CloneSoundCache(x))))));
            xdoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\result.xml");

        }

        public static string CloneSoundCache(string old)
        {
            if (Cache.GetCacheTypeOfFile(old) == Cache.Cachetype.Sound)
            {
                var filename = Path.GetFileName(Path.GetTempFileName());
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var workingdir = desktop + "\\workingdir";
                var clonedir = desktop + "\\clonedsoundcache";
                try
                {
                    Directory.GetFiles(clonedir + "\\SoundCache").ToList().ForEach(x => File.Delete(x));
                    Console.WriteLine("Deleted wms and bnks!");
                    Directory.GetFiles(workingdir).ToList().ForEach(x => File.Delete(x));
                    Console.WriteLine("Deleted soundcache clone!");
                }
                catch { }
                Console.Title = "Reading: " + old + "!";
                Console.WriteLine("-----------------------------------");
                var sc = new SoundCache(old);
                foreach (var item in sc.Files)
                {
                    item.Extract(clonedir + "\\" + item.Name);
                    Console.WriteLine("Extracted: " + item.Name);
                }
                var orderedfiles = new List<string>();
                foreach (var oi in sc.Files)
                {
                    foreach (var ni in Directory.GetFiles(clonedir + "\\SoundCache").ToList().OrderBy(x => new FileInfo(x).CreationTime).ToList())
                    {
                        if (("SoundCache\\" + Path.GetFileName(ni)) == oi.Name)
                            orderedfiles.Add(ni);
                    }
                }
                SoundCache.Write(orderedfiles, workingdir + "\\" + filename + "_clone.cache");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Soundcache clone created!");
                Console.WriteLine();
                return GetHash(workingdir + "\\" + filename + "_clone.cache");
            }
            return "Not a soundcache";
        }
        
        public static string GetHash(string FileName)
        {
            using (var md5 = MD5.Create())
                using (var stream = File.OpenRead(FileName))
                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "");
        }
    }
}
