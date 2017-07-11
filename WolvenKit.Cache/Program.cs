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
            using (var of = new OpenFileDialog())
            {
                of.Filter = "Witcher 3 Soundcache files | *.cache";
                of.Multiselect = true;
                if(of.ShowDialog() == DialogResult.OK)
                {
                    IntenseTest(of.FileNames.ToList());
                }
            }
            Console.ReadLine();
        }

        public static void IntenseTest(List<string> Files2Test)
        {
            var xdoc = new XDocument(new XElement("SoundCacheTest",
                Files2Test.Select(x=> new XElement("Result",new XAttribute("FileName",Path.GetFileName(x)),
                                                   new XElement("OldFileHash",GetHash(x)),
                                                   new XElement("NewFileHash",CloneSoundCache(x))))));
            xdoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\result.xml");

        }

        public static string CloneSoundCache(string old)
        {
            if (Cache.GetCacheTypeOfFile(old) == Cache.Cachetype.Sound)
            {
                try
                {
                    Directory.GetFiles(Path.GetDirectoryName(old) + "\\sf\\SoundCache").ToList().ForEach(x => File.Delete(x));
                    Console.WriteLine("Deleted wms and bnks!");
                    File.Delete(Path.GetDirectoryName(old) + "\\Sounds\\soundpc_clone.cache");
                    Console.WriteLine("Deleted soundcache clone!");
                }
                catch { }
                Console.Title = "Reading: " + old + "!";
                Console.WriteLine("-----------------------------------");
                var sc = new SoundCache(old);
                foreach (var item in sc.Files)
                {
                    item.Extract(Path.GetDirectoryName(old) + "\\sf\\" + item.Name);
                    Console.WriteLine("Extracted: " + item.Name);
                }
                SoundCache.Write(Directory.GetFiles(Path.GetDirectoryName(old) + "\\sf\\SoundCache").ToList().OrderBy(x => new FileInfo(x).CreationTime).ToList(), Path.GetDirectoryName(old) + "\\Sounds\\soundpc_clone.cache");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Soundcache clone created!");
                Console.WriteLine();
                return GetHash(Path.GetDirectoryName(old) + "\\Sounds\\soundpc_clone.cache");
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
