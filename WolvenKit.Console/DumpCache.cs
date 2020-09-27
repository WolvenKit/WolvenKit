using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Console
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> DumpCache(CacheOptions options)
        {
            bool WHITELIST = true;
            var whitelistExt = new[]
            {
                //"w2cube"
                "w2l"
            };
            bool EXTRACT = true;


            // Texture
            //using (var of = new OpenFileDialog() { Filter = "Texture caches | texture.cache" })
            {
                //if (of.ShowDialog() == DialogResult.OK)
                {
                    //var txc = new TextureCache(of.FileName);
                    var txc = new TextureCache(options.path);
                    var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TXTTest", $"ExtractedFiles3");
                    if (!Directory.Exists(outDir))
                        Directory.CreateDirectory(outDir);

                    // Dump
                    /*                    using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__txtdump.txt")))
                    */
                    using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"seed_trial.txt")))
                    {
                        string head = "Format\t" +
                            "Format2\t" +
                            "BPP\t" +
                            "Width\t" +
                            "Height\t" +
                            "Size\t" +
                            "PageOffset\t" +
                            "CompressedSize\t" +
                            "UncompressedSize\t" +
                            "MipOffsetIndex\t" +
                            "NumMipOffsets\t" +
                            "TimeStamp\t" +
                            "Mips\t" +
                            "Slices\t" +
                            "Cube\t" +
                            "Unk1\t" +
                            "Hash\t" +
                            "Name\t" +
                            "Extension\t" +
                            "MipmapCount\t" +
                            "Mipmaps"
                            ;
                        writer.WriteLine(head);

                        short i = 1;
                        foreach (var x in txc.Files)
                        {
                            string ext = x.Name.Split('.').Last();
                            if (!whitelistExt.Contains(ext) && WHITELIST)
                                continue;

                            string info = $"{x.Type1:X2}\t" +
                                $"{x.Type2:X2}\t" +
                                $"{x.BaseAlignment}\t" +
                                $"{x.BaseWidth}\t" +
                                $"{x.BaseHeight}\t" +
                                $"{x.Size}\t" +
                                $"{x.PageOffset}\t" +
                                $"{x.CompressedSize}\t" +
                                $"{x.UncompressedSize}\t" +
                                $"{x.MipOffsetIndex}\t" +
                                $"{x.NumMipOffsets}\t" +
                                $"{x.TimeStamp}\t" +
                                $"{x.Mipcount}\t" +
                                $"{x.SliceCount}\t" +
                                $"{x.IsCube.ToString("X2")}\t" +
                                $"{x.Unk1.ToString()}/{x.Unk1.ToString("X2")}\t" +
                                $"{x.Hash}\t" +
                                $"{x.Name}\t"
                                ;
                            info += $"{x.Name.Split('.').Last()}\t";
                            info += $"{x.MipMapInfo.Count()}\t";
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
                                string padir = Path.GetDirectoryName(fullpath).Split('\\').Last();
                                string newpath = Path.Combine(outDir, padir + i++.ToString() + filename);
                                x.Extract(new BundleFileExtractArgs(newpath, EUncookExtension.jpg));
                                System.Console.WriteLine($"Finished extracting {x.Name}");
                            }
                            writer.WriteLine("\t\t{");
                            writer.WriteLine($"\t\t\"path\": \"" + x.Name + "\",");
                            writer.WriteLine("\t\t\"cache\": \"texture\"");
                            writer.WriteLine("\t\t},");


                        }
                        System.Console.WriteLine($"Finished dumping texture cache. {options.path}");
                    }
                    System.Console.WriteLine($"Finished extracting.");
                    System.Console.ReadLine();
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

            return 1;
        }
    }
}
