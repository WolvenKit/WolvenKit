using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Crc32C;

namespace WolvenKit.Cache
{
    class Test_Collision
    {
        [STAThread]
        public static void Main()
        {
            bool WHITELIST = true;
            var whitelistExt = new[]
            {
                "w2cube",
            };
            bool EXTRACT = true;


            // Texture
            using (var of = new OpenFileDialog() { Filter = "Texture caches | texture.cache" })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var dt = DateTime.Now;
                    string idx = Crc32C.Crc32CAlgorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
                    var txc = new TextureCache(of.FileName);
                    var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TXTTest", $"ExtractedFiles_{idx}");
                    if (!Directory.Exists(outDir))
                        Directory.CreateDirectory(outDir);

                    // Dump
                    using (StreamWriter writer = File.CreateText(Path.Combine(outDir,$"__txtdump_{idx}.txt")))
                    {
                        string head = "Format\t" +
                            "BPP\t" +
                            "Width\t" +
                            "Height\t" +
                            "Size\t" +
                            "Mips\t" +
                            "Slices\t" +
                            "Cube\t" +
                            "Unk1\t" +
                            //"Hash\t" +
                            "Name";
                        writer.WriteLine(head);

                        foreach (var x in txc.Files)
                        {
                            string ext = x.Name.Split('.').Last();
                            if (!whitelistExt.Contains(ext) && WHITELIST)
                                continue;

                            string info = $"{x.Type.ToString("X4")}\t" +
                                $"{x.BaseAlignment}\t" + 
                                $"{x.BaseWidth}\t" + 
                                $"{x.BaseHeight}\t" + 
                                $"{x.Size}\t" + 
                                $"{x.Mipcount}\t" + 
                                $"{x.SliceCount}\t" + 
                                $"{x.IsCube.ToString("X2")}\t" +
                                $"{x.Unk1.ToString()}/{x.Unk1.ToString("X2")}\t" +
                                //$"{x.Hash}\t" +
                                $"{x.Name}\t"
                                ;

                            info += "<";
                            foreach (var y in x.MipMapInfo)
                            {
                                info += $"<{y.Item1},{y.Item2}>";
                            }
                            info += ">";

                            //Console.WriteLine(info);
                            writer.WriteLine(info);
                        
                            if (EXTRACT)
                            {
                                string fullpath = Path.Combine(outDir, x.Name);
                                string filename = Path.GetFileName(fullpath);
                                string newpath = Path.Combine(outDir, filename);
                                x.Extract(newpath);
                                Console.WriteLine($"Finished extracting {x.Name}");
                            }
                        }
                        Console.WriteLine($"Finished dumping texture cache. {of.FileName}");
                    }
                    Console.WriteLine($"Finished extracting.");
                    Console.ReadLine();
                }
            }


            // Collision
            /*
            using (var of = new OpenFileDialog(){Filter = "Collision caches | collision.cache"})
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var ccf = new CollisionCache(of.FileName);
                    var fd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"CCTest");
                    ccf.Files.ForEach(x=> x.Extract(Path.Combine(fd,x.Name)));
                    CollisionCache.Write(Directory.GetFiles(fd,"*",SearchOption.AllDirectories).ToList().OrderByDescending(x=> new FileInfo(x).CreationTime).ToList(),of.FileName + "_regenerated");
                    //IntenseTest(of.FileNames.ToList());
                    Console.ReadLine();
                }
            }
            */
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
                var sc = new CollisionCache(old);
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
                CollisionCache.Write(orderedfiles, workingdir + "\\" + filename + "_clone.cache");
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
