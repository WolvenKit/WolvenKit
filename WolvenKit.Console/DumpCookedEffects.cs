using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Bundles;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Console
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> DumpCookedEffects(DumpCookedEffectsOptions options)
        {
            var dt = DateTime.Now;
            string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
            var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CookedEffectsDump", $"ExtractedFiles_{idx}");
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

           
            var bm = new BundleManager();

            var W3_DIR = System.Environment.GetEnvironmentVariable("W3_DIR", EnvironmentVariableTarget.User);
            if (!Directory.Exists(W3_DIR)) return 0;
            bm.LoadAll(W3_DIR);

            //Bundle pa1 = bm.Bundles.First(_ => _.Key.Contains("patch1")).Value;
            //var actualsize = pa1.Items.Select(_ => _.Value).Select(_ => _.Size).Sum(_ => _);
            //var actualzsize = pa1.Items.Select(_ => _.Value).Select(_ => _.ZSize).Sum(_ => _); ;

            //Load MemoryMapped Bundles
            var memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            foreach (var b in bm.Bundles.Values)
            {
                var e = b.ArchiveAbsolutePath.GetHashMD5();

                memorymappedbundles.Add(e, MemoryMappedFile.CreateFromFile(b.ArchiveAbsolutePath, FileMode.Open, e, 0, MemoryMappedFileAccess.Read));

            }

            using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__effectsdump_{idx}.txt")))
            {

                string head = "RedName\t" +
                            "EffectNames\t"
                            ;
                writer.WriteLine(head);
                System.Console.WriteLine(head);

                var files = bm.FileList
                    .Where(x => x.Name.EndsWith("w2ent"))
                    .GroupBy(p => p.Name)
                    .Select(g => g.First())
                    .ToList();
                using (var pb = new ConsoleProgressBar.ProgressBar())
                using (var p1 = pb.Progress.Fork())
                {
                    int progress = 0;

                    Parallel.For(0, files.Count, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
                    {
                        IWitcherFile f = (IWitcherFile)files[i];
                        if (f is BundleItem bi)
                        {
                            var buff = new byte[f.Size];
                            using (var s = new MemoryStream())
                            {
                                bi.ExtractExistingMMF(s);
                                s.Seek(0, SeekOrigin.Begin);

                                using (var ms = new MemoryStream(s.ToArray()))
                                using (var br = new BinaryReader(ms))
                                {
                                    var crw = new CR2WFile();
                                    crw.Read(br);

                                    foreach (var c in crw.Chunks)
                                    {
                                        if (c.data is CEntityTemplate)
                                        {
                                            var x = c.data as CEntityTemplate;
                                            if (x.CookedEffects != null)
                                            {
                                                string effectnames = "";
                                                //string animnames = "";
                                                foreach (CEntityTemplateCookedEffect effect in x.CookedEffects)
                                                {
                                                    effectnames += effect.Name == null ? "NULL" : effect.Name.Value + ";";
                                                    //animnames += effect.AnimName == null ? "NULL" : effect.AnimName.Value + ";";
                                                }

                                                string info = $"{f.Name}\t" +
                                                    $"{effectnames}\t"
                                                    //$"{animnames}\t"
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
