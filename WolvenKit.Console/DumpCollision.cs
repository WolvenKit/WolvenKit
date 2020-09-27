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

        public static async Task<int> DumpCollision(DumpCollisionOptions options)
        {
            var dt = DateTime.Now;
            string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}")).ToString();
            var outDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nameof(DumpCollisionOptions), $"ExtractedFiles_{idx}");
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            var W3_DIR = System.Environment.GetEnvironmentVariable("W3_DIR", EnvironmentVariableTarget.User);
            if (!Directory.Exists(W3_DIR)) return 0;
            var bm = new CollisionManager();
            bm.LoadAll(W3_DIR);

            using (StreamWriter writer = File.CreateText(Path.Combine(outDir, $"__collisiondump_{idx}.csv")))
            {

                string head = "idx\t" +
                            "Name\t" +
                            "Bundle\t" +
                            //"Size\t" +
                            //"ZSize\t" +
                            //"Pageoffset\t" +
                            //"Nameoffset\t" +
                            "Unk1\t" +
                            "Unk2\t" +
                            "Unk3\t" +
                            "Unk4\t" +
                            "Unk5\t" +
                            "Comtype\t" +
                            "Tail\t" +
                            "HasMoreInfo";
                writer.WriteLine(head);

                var files = bm.FileList
                    .GroupBy(p => p.Name)
                    .Select(g => g.First())
                    .ToList();
                using (var pb = new ConsoleProgressBar.ProgressBar())
                using (var p1 = pb.Progress.Fork())
                {
                    int progress = 0;

                    //Parallel.For(0, files.Count, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
                    for (int i = 0; i < files.Count; i++)
                    {
                        IWitcherFile f = files[i];
                        if (f is CollisionCacheItem x)
                        {

                            var bundlename = new DirectoryInfo(x.Bundle.ArchiveAbsolutePath).Parent.Name;
                            if (bundlename == "content")
                            {
                                var par2 = new DirectoryInfo(x.Bundle.ArchiveAbsolutePath).Parent.Parent.Name;
                                bundlename = par2;
                            }

                            if (!(x.Comtype > 4 || x.Comtype == 1))
                            {
                                string filename = Path.GetFileName(x.Name);
                                string path = Path.Combine(outDir, $"{i}_{bundlename}_{filename}.bin");
                                using (var temp_ms = new MemoryStream())
                                using (var output = new FileStream(path, FileMode.Create, FileAccess.Write))
                                using (var bw = new BinaryWriter(output))
                                {
                                    x.Extract(temp_ms);
                                    temp_ms.Seek(0, SeekOrigin.Begin);

                                    x.REDheader.Write(bw);
                                    temp_ms.CopyTo(output);
                                }
                            }




                            string info =
                                $"{i}\t" +
                                $"{x.Name}\t" +
                                $"{bundlename}\t" +
                                //$"{x.Size}\t" +
                                //$"{x.ZSize}\t" +
                                //$"{x.PageOffset}\t" +
                                //$"{x.NameOffset}\t" +
                                $"{x.Unk1}\t" +
                                $"{x.Unk2}\t" +
                                $"{x.Unk3}\t" +
                                $"{BitConverter.ToString(x.unk4).Replace("-", string.Empty)}\t" +
                                $"{BitConverter.ToString(x.unk5).Replace("-", string.Empty)}\t" +
                                $"{x.Comtype}\t" +
                                $"{BitConverter.ToString(x.Tail).Replace("-", string.Empty)}\t"
                                ;

                            if (x.REDheader != null)
                            {
                                info += string.Join(".", x.REDheader.Items.Select(_ => _.Name));
                            }

                            //System.Console.WriteLine(info);
                            writer.WriteLine(info);
                        }

                        progress += 1;
                        var perc = progress / (double)files.Count;
                        p1.Report(perc, $"Loading bundle entries: {progress}/{files.Count}");
                    }
                }
            }

            System.Console.WriteLine($"Finished extracting.");
            System.Console.ReadLine();

            return 1;
        }
    }
}
