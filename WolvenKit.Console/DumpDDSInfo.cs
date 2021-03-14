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
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.Console
{
    public static partial class ConsoleFunctions
    {
        internal class XBMBundleInfo
        {
            //public string Name { get; set; }
            //public string Width { get; set; }
            //public string Height { get; set; }
            public string Format { get; set; }
            public string Compression { get; set; }
            public string TextureGroup { get; set; }
            public string Unk { get; set; }
            public string Unk1 { get; set; }
            public string Unk2 { get; set; }
        }

        public static async Task<int> DumpDDSInfo(DumpDDSOptions options)
        {
            var dt = DateTime.Now;
            string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
            var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DDSTest", $"ExtractedFiles_{idx}");
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // load TextureManager
            var txc = new TextureManager();
            var W3_DIR = System.Environment.GetEnvironmentVariable("W3_DIR", EnvironmentVariableTarget.User);
            if (!Directory.Exists(W3_DIR)) return 0;
            txc.LoadAll(W3_DIR);
            System.Console.WriteLine($"Loaded texture manager.");

            // load BundleManager
            var bundlexbmDict = new Dictionary<uint, XBMBundleInfo>();
            var bm = new BundleManager();
            bm.LoadAll(W3_DIR);
            System.Console.WriteLine($"Loaded bundle manager.");

            var memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            foreach (var b in bm.Bundles.Values)
            {
                var e = b.ArchiveAbsolutePath.GetHashMD5();
                memorymappedbundles.Add(e, MemoryMappedFile.CreateFromFile(b.ArchiveAbsolutePath, FileMode.Open, e, 0, MemoryMappedFileAccess.Read));
            }

            #region XBM DUMP
            const string ext = "xbm";
            using (var pb = new ConsoleProgressBar.ProgressBar())
            using (var p1 = pb.Progress.Fork())
            {
                int progress = 0;
                var files1 = bm.FileList.Where(x => x.Name.EndsWith(ext)).ToList();

                Parallel.For(0, files1.Count, new ParallelOptions {MaxDegreeOfParallelism = 8}, i =>
                {
                    var f = files1[i];
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
                                    lock (bundlexbmDict)
                                    {
                                        if (!bundlexbmDict.ContainsKey(x.TextureCacheKey.val))
                                        {
                                            bundlexbmDict.Add(x.TextureCacheKey.val, new XBMBundleInfo()
                                                {
                                                    //Name = f.Name,
                                                    //Width = x.Width == null ? "NULL" : x.Width.val.ToString(),
                                                    //Height = x.Height == null ? "NULL" : x.Height.val.ToString(),
                                                    Format = x.Format == null ? "NULL" : x.Format.WrappedEnum.ToString(),
                                                    Compression = x.Compression == null ? "NULL" : x.Compression.WrappedEnum.ToString(),
                                                    TextureGroup = x.TextureGroup == null ? "NULL" : x.TextureGroup.Value,
                                                    Unk = x.unk?.ToString() ?? "NULL",
                                                    Unk1 = x.unk1?.ToString() ?? "NULL",
                                                    Unk2 = x.unk2?.ToString() ?? "NULL",

                                                }
                                            );
                                        }
                                    }

                                }
                            }
                        }
                    }
                    //catch (Exception ex)
                    //{
                    //    throw ex;
                    //}

                    progress += 1;
                    var perc = progress / (double)files1.Count;
                    p1.Report(perc, $"Loading bundle entries: {progress}/{files1.Count}");
                });
            }
            System.Console.WriteLine($@"Loaded {bundlexbmDict.Values.Count} bundle entries.");
            #endregion

            #region DUMP TEXCACHE
            // Dump texture cache infos
            using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__ddsdump_{idx}.txt")))
            {
                string head =
                    "Format1\t" +
                    "Format2\t" +
                    "BPP\t" +
                    "Width\t" +
                    "Height\t" +
                    "Size\t" +
                    "Mips\t" +
                    "Slices\t" +
                    "Cube\t" +
                    "Unk1\t" +
                    "Hash\t" +
                    "Ext\t" +
                    "Name\t";
                head += "XBMFormat\t" +
                    "XBMCompression\t" +
                    "XBMTextureGroup\t" +
                    "XBMunk\t" +
                    "XBMunk1\t" +
                    "XBMunk2\t"
                    ;
                writer.WriteLine(head);


                using (var pb = new ConsoleProgressBar.ProgressBar())
                using (var p1 = pb.Progress.Fork())
                {
                    int progress = 0;
                    var files = txc.FileList;

                    Parallel.For(0, files.Count, new ParallelOptions {MaxDegreeOfParallelism = 8}, i =>
                    {
                        IWitcherFile f = files[i];
                        TextureCacheItem x = f as TextureCacheItem;

                        string info = $"{x.Type1}/{x.Type1:X2}\t" +
                                      $"{x.Type2}/{x.Type2:X2}\t" +
                                      $"{x.BaseAlignment}\t" +
                                      $"{x.BaseWidth}\t" +
                                      $"{x.BaseHeight}\t" +
                                      $"{x.Size}\t" +
                                      $"{x.Mipcount}\t" +
                                      $"{x.SliceCount}\t" +
                                      $"{x.IsCube:X2}\t" +
                                      $"{x.Unk1}/{x.Unk1:X2}\t" +
                                      $"{x.Hash}\t" +
                                      $"{Path.GetExtension(x.Name)}\t" +
                                      $"{x.Name}\t"
                            ;

                        if (bundlexbmDict.ContainsKey(x.Hash))
                        {
                            var bundleinfo = bundlexbmDict[x.Hash];
                            info +=
                                $"{bundleinfo.Format}\t" +
                                $"{bundleinfo.Compression}\t" +
                                $"{bundleinfo.TextureGroup}\t" +
                                $"{bundleinfo.Unk}\t" +
                                $"{bundleinfo.Unk1}\t" +
                                $"{bundleinfo.Unk2}\t"
                                ;
                        }
                        else
                        {
                            info +=
                                $"NOT FOUND\t" +
                                $"NOT FOUND\t" +
                                $"NOT FOUND\t" +
                                $"NOT FOUND\t" +
                                $"NOT FOUND\t" +
                                $"NOT FOUND\t"
                                ;
                        }

                        lock (writer)
                        {
                            writer.WriteLine(info);
                        }

                        progress += 1;
                        var perc = progress / (double)files.Count;
                        p1.Report(perc, $"Loading cache entries: {progress}/{files.Count}");
                    });
                    System.Console.WriteLine($"Finished dumping info from {files.Count} texture caches.\r\n");
                }

            }

            #endregion


            System.Console.WriteLine($"Finished.\r\n");
            System.Console.ReadLine();

            return 1;
        }
    }
}
