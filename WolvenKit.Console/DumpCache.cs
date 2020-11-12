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
            if (options.dump || options.extract)
            {
                // initial checks
                var inputFileInfo = new FileInfo(options.path);
                if (!inputFileInfo.Exists)
                    return 0;
                var outDir = inputFileInfo.Directory;
                if (outDir == null)
                    return 0;
                if (!outDir.Exists)
                    Directory.CreateDirectory(outDir.FullName);

                // load texture cache
                var txc = new TextureCache(inputFileInfo.FullName);

                const string head = "Format\t" +
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
                                    "Mipmaps";

                // dump and extract files
                using (var writer = File.CreateText($"{inputFileInfo.FullName}.txt"))
                {
                    // write header
                    writer.WriteLine(head);

                    // write info elements
                    foreach (var x in txc.Files)
                    {
                        if (options.dump)
                        {
                            string ext = x.Name.Split('.').Last();

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
                                info += $"<{y.Size},{y.ZSize}>";
                            }

                            info += ">";

                            //Console.WriteLine(info);
                            writer.WriteLine(info);
                        }

                        if (options.extract)
                        {
                            string fullpath = Path.Combine(outDir.FullName, x.Name);
                            //string filename = Path.GetFileName(fullpath);
                            //string padir = Path.GetDirectoryName(fullpath).Split('\\').Last();
                            //string newpath = Path.Combine(outDir.FullName, padir + i++.ToString() + filename);
                            x.Extract(new BundleFileExtractArgs(fullpath, EUncookExtension.dds));
                            System.Console.WriteLine($"Finished extracting {x.Name}");
                        }
                    }

                    if (options.dump)
                        System.Console.WriteLine($"Finished dumping {options.path}.");

                    if (options.extract)
                        System.Console.WriteLine($"Finished extracting {options.path}.");
                }
            }

            if (options.create)
            {
                if (!Directory.Exists(options.path))
                    return 0;
                var txc = new TextureCache();
                txc.LoadFiles(options.path);
                txc.Write(Path.Combine(options.path, "texture.cache"));

                System.Console.WriteLine($"Finished creating {options.path}.");
            }
            
            
            return 1;
        }
    }
}
