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
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Console
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> DumpXbmInfo(DumpXbmsOptions options)
        {
            // create output dir
            var dt = DateTime.Now;
            string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
            var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "XBMTest", $"ExtractedFiles_{idx}");
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Load bundle manager
            var bm = new BundleManager();
            var W3_DIR = System.Environment.GetEnvironmentVariable("W3_DIR", EnvironmentVariableTarget.User);
            if (!Directory.Exists(W3_DIR)) return 0;
            bm.LoadAll(W3_DIR);

            //Load MemoryMapped Bundles
            var memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            foreach (var b in bm.Bundles.Values)
            {
                var e = b.ArchiveAbsolutePath.GetHashMD5();

                memorymappedbundles.Add(e, MemoryMappedFile.CreateFromFile(b.ArchiveAbsolutePath, FileMode.Open, e, 0, MemoryMappedFileAccess.Read));

            }

            

            using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__xbmdump_{idx}.txt")))
            {
                string head = "RedName\t" +
                              "Width\t" +
                              "Height\t" +
                              "Format\t" +
                              "Compression\t" +
                              "TextureGroup\t" +
                              "TextureCacheKey\t" +
                              "unk\t" +
                              "unk1\t" +
                              "unk2\t"+
                              "MipsCount\t"
                            ;
                writer.WriteLine(head);
                System.Console.WriteLine(head);

                string ext = "xbm";
                var files = bm.FileList.Where(x => x.Name.EndsWith(ext)).ToList();
                using (var pb = new ConsoleProgressBar.ProgressBar())
                using (var p1 = pb.Progress.Fork())
                {
                    int progress = 0;

                    Parallel.For(0, files.Count, new ParallelOptions {MaxDegreeOfParallelism = 8}, i =>
                    {
                        var f = files[i];
                        if (f is BundleItem bi)
                        {
                            var buff = new byte[f.Size];
                            using (var s = new MemoryStream())
                            {
                                bi.ExtractExistingMMF(s);

                                using (var ms = new MemoryStream(s.ToArray()))
                                using (var br = new BinaryReader(ms))
                                {
                                    var crw = new CR2WFile();
                                    crw.Read(br);

                                    foreach (var c in crw.Chunks)
                                    {
                                        if (!(c.data is CBitmapTexture x)) continue;
                                        string info = $"{f.Name}\t" +
                                                      $"{x.Width.val}\t" +
                                                      $"{x.Height.val}\t" +
                                                      $"{x.Format}\t" +
                                                      $"{x.Compression}\t" +
                                                      $"{x.TextureGroup}\t" +
                                                      $"{x.TextureCacheKey}\t" +
                                                      $"{x.unk}\t" +
                                                      $"{x.unk1}\t" +
                                                      $"{x.unk2}\t" +
                                                      $"{x.MipsCount}\t"
                                            ;

                                        //System.Console.WriteLine(info);
                                        lock (writer)
                                        {
                                            writer.WriteLine(info);
                                        }
                                    }
                                }
                            }
                        }

                        progress += 1;
                        var perc = progress / (double)files.Count;
                        p1.Report(perc, $"Loading bundle entries: {progress}/{files.Count}");
                    });
                }
            }

            System.Console.WriteLine($"Finished extracting.");
            System.Console.ReadLine();

            return 1;
        }
    }
}
