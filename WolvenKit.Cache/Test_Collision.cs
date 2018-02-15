using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WolvenKit.Cache
{
    class Test_Collision
    {
        [STAThread]
        public static void Main()
        {
            using (var of = new OpenFileDialog(){Filter = "Collision caches | collision.cache"})
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var ccf = new CollisionCache.CollisionCache(of.FileName);
                    var fd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"CCTest");
                    ccf.Files.ForEach(x=> x.Extract(Path.Combine(fd,x.Name)));
                    CollisionCache.CollisionCache.Write(Directory.GetFiles(fd,"*",SearchOption.AllDirectories).ToList().OrderByDescending(x=> new FileInfo(x).CreationTime).ToList(),of.FileName + "_regenerated");
                    //IntenseTest(of.FileNames.ToList());
                    Console.ReadLine();
                }
            }
        }

        public static void IntenseTest(List<string> Files2Test)
        {
            var xdoc = new XDocument(new XElement("CollisionCacheTest",
                Files2Test.Select(x=> new XElement("Result",new XAttribute("FileName",x),
                                                   new XElement("OldFileHash",GetHash(x)),
                                                   new XElement("NewFileHash",CloneCollisionCache(x))))));
            xdoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\result.xml");
        }
        public static string CloneCollisionCache(string old)
        {
            if (Cache.GetCacheTypeOfFile(old) == Cache.Cachetype.Collision)
            {
                var filename = Path.GetFileName(Path.GetTempFileName());
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var workingdir = desktop + "\\workingdir";
                var clonedir = desktop + "\\clonedcachedir";
                try
                {
                    Directory.GetFiles(clonedir + "\\Collisioncache").ToList().ForEach(x => File.Delete(x));
                    Console.WriteLine("Deleted wms and bnks!");
                    Directory.GetFiles(workingdir).ToList().ForEach(x => File.Delete(x));
                    Console.WriteLine("Deleted soundcache clone!");
                }
                catch { }
                Console.Title = "Reading: " + old + "!";
                Console.WriteLine("-----------------------------------");
                var sc = new CollisionCache.CollisionCache(old);
                foreach (var item in sc.Files)
                {
                    item.Extract(clonedir + "\\" + item.Name);
                    Console.WriteLine("Extracted: " + item.Name);
                }
                var orderedfiles = new List<string>();
                foreach (var oi in sc.Files)
                {

                    foreach (var ni in Directory.GetFiles(clonedir + "\\Collisioncache").ToList().OrderBy(x => new FileInfo(x).CreationTime).ToList())
                    {
                        if (("Collisioncache\\" + Path.GetFileName(ni)) == oi.Name)
                            orderedfiles.Add(ni);
                    }
                }
                CollisionCache.CollisionCache.Write(orderedfiles, workingdir + "\\" + filename + "_clone.cache");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Collision cache clone created!");
                Console.WriteLine();
                return GetHash(workingdir + "\\" + filename + "_clone.cache");
            }
            return "Not a Collisioncache";
        }

        public static string GetHash(string FileName)
        {
            using (var md5 = MD5.Create())
                using (var stream = File.OpenRead(FileName))
                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "");
        }
    }
}
