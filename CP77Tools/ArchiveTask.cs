using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;
using CP77Tools.Model;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {
        
        public static async Task<int> ArchiveTask(ArchiveOptions options)
        {
            if (options.extract || options.dump)
            {
                // initial checks
                var inputFileInfo = new FileInfo(options.path);
                if (!inputFileInfo.Exists)
                    return 0;

                var ar = new Archive(inputFileInfo.FullName);

                if (options.extract)
                {
                    // mmf
                    var outDir = Directory.CreateDirectory(inputFileInfo.Directory + "\\" +
                                                           inputFileInfo.Name.Replace(".archive", ""));
                    if (outDir == null)
                        return 0;
                    if (!outDir.Exists)
                        Directory.CreateDirectory(outDir.FullName);
                    if (inputFileInfo.Extension != ".archive")
                        return 0;
                    var indir = new FileInfo(options.path).Directory;
                    if (indir == null)
                        return 0;

                    using var pb = new ConsoleProgressBar.ProgressBar();
                    using var p1 = pb.Progress.Fork();

                    int progress = 0;

                    //for (var i = 0; i < ar.FilesCount; i++)
                    Parallel.For(0, ar.FilesCount, new ParallelOptions {MaxDegreeOfParallelism = 8}, i =>
                    {
                        var file = ar.GetFileData((int) i);

                        string extension = "bin";
                        if (options.extension != null)
                        {
                            extension = options.extension;
                        }

                        string outpath = Path.Combine(outDir.FullName,
                            $"{ar.Table.FileInfo[(int) i].NameHash64:X8}.{extension}");

                        File.WriteAllBytes(outpath, file);


                        progress += 1;
                        var perc = progress / (double)ar.FilesCount;
                        p1.Report(perc, $"Loading bundle entries: {progress}/{ar.FilesCount}");
                    });
                }

                if (options.dump)
                {
                    ar.DumpInfo();
                }
            }

            Console.WriteLine($"Finished extracting {options.path}");

            return 1;
        }
    }
}