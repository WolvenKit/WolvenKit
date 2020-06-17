using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WolvenKit.Console
{
    using CR2W;
    using System.IO;
    using CR2W.Types;
    using System.Collections;
    using System.Reflection;
    using Cache;
    using Bundles;
    using Common;
    using static WolvenKit.CR2W.Types.Enums;
    using ConsoleProgressBar;
    using WolvenKit.Common.Model;

    public class WolvenKitConsole
    {

        [STAThread]
        public static async Task Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                while (true)
                {
                    string line = System.Console.ReadLine();
                    Parse(line.Split(' '));
                }

            }
            else
            {
                Parse(args);
            }
        }

        internal static async Task Parse(string[] _args)
        {
            var result = Parser.Default.ParseArguments<CacheOptions, BundleOptions, DumpXbmsOptions, DumpDDSOptions>(_args)
                        .MapResult(
                          async (CacheOptions opts) => await DumpCache(opts),
                          async (BundleOptions opts) => await RunBundle(opts),
                          async (DumpXbmsOptions opts) => await DumpXbmInfo(opts),
                          async (DumpDDSOptions opts) => await DumpDDSInfo(opts),
                          //errs => 1,
                          _ => Task.FromResult(1));
        }

        internal class XBMBundleInfo
        {
            public string Name { get; set; }
            public uint Width { get; set; }
            public uint Height { get; set; }
            public ETextureRawFormat Format { get; set; }
            public ETextureCompression Compression { get; set; }
            public string TextureGroup { get; set; }
        }


        private static async Task<int> DumpDDSInfo(DumpDDSOptions options)
        {
            var dt = DateTime.Now;
            string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
            var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DDSTest", $"ExtractedFiles_{idx}");

            using (var pb = new ProgressBar())
            {
                if (!Directory.Exists(outDir))
                    Directory.CreateDirectory(outDir);
                var txc = new TextureManager();
                //using (var p11 = pb.Progress.Fork(0.25, "Loading TextureManager"))
                {
                    txc.LoadAll("C:\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
                }
                System.Console.WriteLine($"Loaded TextureManager");

                //combined bundle dump
                // load xbm bundle infos
                var bundlexbmDict = new Dictionary<uint, XBMBundleInfo>();
                var mc = new BundleManager();
                //using (var p12 = pb.Progress.Fork(0.25, "Loading BundleManager"))
                {
                    mc.LoadAll("C:\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
                }

                System.Console.WriteLine($"Loaded BundleManager");


                //using (var p2 = pb.Progress.Fork(0.5, "Loading Bundle Info"))
                using (var p2 = pb.Progress.Fork(0.5, "Bundle Info"))
                {
                    var filesb = mc.FileList.Where(x => x.Name.EndsWith("xbm")).ToList();
                    for (int i = 0; i < filesb.Count; i++)
                    {
                        var f = filesb[i];
                        try
                        {
                            var buff = new byte[f.Size];
                            using (var s = new MemoryStream())
                            {
                                f.Extract(s);

                                using (var ms = new MemoryStream(s.ToArray()))
                                using (var br = new BinaryReader(ms))
                                {
                                    var crw = new CR2WFile();
                                    crw.Read(br);

                                    foreach (var c in crw.chunks)
                                    {
                                        if (c.data is CBitmapTexture)
                                        {
                                            var x = c.data as CBitmapTexture;

                                            if (!bundlexbmDict.ContainsKey(x.TextureCacheKey.val))
                                            {
                                                var compression = x.Compression;
                                                var format = x.Format;

                                                bundlexbmDict.Add(x.TextureCacheKey.val, new XBMBundleInfo()
                                                {
                                                    Name = f.Name,
                                                    Width = x.Width == null ? 0 : x.Width.val,
                                                    Height = x.Height == null ? 0 : x.Height.val,
                                                    Format = format,
                                                    Compression = compression,
                                                    TextureGroup = x.TextureGroup == null ? "" : x.TextureGroup.Value,

                                                }
                                                );
                                            }
                                            else
                                            {

                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        p2.Report(i / (double)filesb.Count, $"Loading bundle entries: {i}/{filesb.Count}");
                    }
                }
                System.Console.WriteLine($"Loaded {bundlexbmDict.Values.Count} Bundle Entries");

                using (var p3 = pb.Progress.Fork(0.5, "Cache Info"))
                {
                    // Dump texture cache infos
                    using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__ddsdump_{idx}.txt")))
                    {
                        string head = "Format1\t" +
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
                            "Name\t";
                        head += "XBMFormat\t" +
                            "XBMCompression\t" +
                            "XBMTExtureGroup\t"
                            ;
                        writer.WriteLine(head);

                        //string ext = "xbm";
                        //var files = txc.FileList.Where(x => x.Name.EndsWith(ext)).ToList();
                        var files = txc.FileList;
                        for (int j = 0; j < files.Count; j++)
                        {
                            IWitcherFile f = files[j];
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
                                $"{x.Name}\t"
                                ;

                            //info += "<";
                            //foreach (var y in x.MipMapInfo)
                            //{
                            //    info += $"<{y.Item1},{y.Item2}>";
                            //}
                            //info += ">";

                            if (bundlexbmDict.ContainsKey(x.Hash))
                            {
                                XBMBundleInfo bundleinfo = bundlexbmDict[x.Hash];
                                info +=
                                    //$"{bundleinfo.Width}\t" +
                                    //$"{bundleinfo.Height}\t" +
                                    $"{bundleinfo.Format}\t" +
                                    $"{bundleinfo.Compression}\t" +
                                    $"{bundleinfo.TextureGroup}\t"
                                    ;
                            }
                            else
                            {

                            }



                            //System.Console.WriteLine(info);
                            writer.WriteLine(info);
                            p3.Report(j / (double)files.Count, $"Dumping cache entries: {j}/{files.Count}");
                        }
                        System.Console.WriteLine($"Finished dumping {files.Count} texture cache infos.\r\n");
                    }
                }
            }
            System.Console.WriteLine($"Finished.\r\n");
            System.Console.ReadLine();

            return 1;
        }

        private static async Task<int> DumpXbmInfo(DumpXbmsOptions options)
        {
            var dt = DateTime.Now;
            string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
            var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "XBMTest", $"ExtractedFiles_{idx}");
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);
            var mc = new BundleManager();
            mc.LoadAll("C:\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
            string ext = "xbm";

            using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__xbmdump_{idx}.txt")))
            {

                string head = "RedName\t" +
                            "Width\t" +
                            "Height\t" +
                            "Format\t" +
                            "Compression\t" +
                            "TextureGroup\t" +
                            "TextureCacheKey\t"
                            ;
                writer.WriteLine(head);
                System.Console.WriteLine(head);


                var files = mc.FileList.Where(x => x.Name.EndsWith(ext)).ToList();
                for (int i = 0; i < files.Count; i++)
                {
                    var f = files[i];
                    try
                    {
                        var buff = new byte[f.Size];
                        using (var s = new MemoryStream())
                        {
                            f.Extract(s);

                            using (var ms = new MemoryStream(s.ToArray()))
                            using (var br = new BinaryReader(ms))
                            {
                                var crw = new CR2WFile();
                                crw.Read(br);

                                foreach (var c in crw.chunks)
                                {
                                    if (c.data is CBitmapTexture)
                                    {
                                        var x = c.data as CBitmapTexture;

                                        string info = $"{f.Name}\t" +
                                            $"{x.Width.val}\t" +
                                            $"{x.Height.val}\t" +
                                            $"{x.Format}\t" +
                                            $"{x.Compression}\t" +
                                            $"{x.TextureGroup}\t" +
                                            $"{x.TextureCacheKey}\t"
                                            ;

                                        //System.Console.WriteLine(info);
                                        writer.WriteLine(info);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    //System.Console.WriteLine($"Finished extracting {f.Name}");
                }
            }

            System.Console.WriteLine($"Finished extracting.");
            System.Console.ReadLine();

            return 1;
        }

        private static async Task<int> DumpCache(CacheOptions options)
        {
            bool WHITELIST = true;
            var whitelistExt = new[]
            {
                "w2cube",
            };
            bool EXTRACT = true;


            // Texture
            //using (var of = new OpenFileDialog() { Filter = "Texture caches | texture.cache" })
            {
                //if (of.ShowDialog() == DialogResult.OK)
                {
                    var dt = DateTime.Now;
                    string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
                    //var txc = new TextureCache(of.FileName);
                    var txc = new TextureCache(options.path);
                    var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TXTTest", $"ExtractedFiles_{idx}");
                    if (!Directory.Exists(outDir))
                        Directory.CreateDirectory(outDir);

                    // Dump
                    using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__txtdump_{idx}.txt")))
                    {
                        string head = "Format\t" +
                            "Format2\t" +
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

                            string info = $"{x.Type1:X2}\t" +
                                $"{x.Type2:X2}\t" +
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
                                x.Extract(new BundleFileExtractArgs(newpath));
                                System.Console.WriteLine($"Finished extracting {x.Name}");
                            }
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

        public static void IntenseTest(List<string> Files2Test)
        {
            var xdoc = new XDocument(new XElement("CollisionCacheTest",
                Files2Test.Select(x => new XElement("Result", new XAttribute("FileName", x),
                                                   new XElement("OldFileHash", GetHash(x)),
                                                   new XElement("NewFileHash", CloneCollisionCache(x))))));
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
                    System.Console.WriteLine("Deleted wms and bnks!");
                    Directory.GetFiles(workingdir).ToList().ForEach(x => File.Delete(x));
                    System.Console.WriteLine("Deleted soundcache clone!");
                }
                catch { }
                System.Console.Title = "Reading: " + old + "!";
                System.Console.WriteLine("-----------------------------------");
                var sc = new CollisionCache(old);
                foreach (var item in sc.Files)
                {
                    item.Extract(new BundleFileExtractArgs(clonedir + "\\" + item.Name));
                    System.Console.WriteLine("Extracted: " + item.Name);
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
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("Collision cache clone created!");
                System.Console.WriteLine();
                return GetHash(workingdir + "\\" + filename + "_clone.cache");
            }
            return "Not a Collisioncache";
        }

        public static string GetHash(string FileName)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            using (var stream = File.OpenRead(FileName))
                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "");
        }

        private static async Task<int> RunBundle(BundleOptions options)
        {
            return 0;
        }




    }
}
