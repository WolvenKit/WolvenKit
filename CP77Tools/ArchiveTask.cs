using System;
using System.IO;
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
                var outDir = inputFileInfo.Directory;
                if (outDir == null)
                    return 0;
                if (!outDir.Exists)
                    Directory.CreateDirectory(outDir.FullName);
                if (inputFileInfo.Extension != ".archive")
                    return 0;

                // load texture cache
                // switch chache types
                var ar = new Archive(inputFileInfo.FullName);

                if (options.extract)
                {
                    for (var i = 0; i < ar.Files.Count; i++)
                    {
                        var file = ar.Files[i];
                        var indir = new FileInfo(options.path).Directory;
                        if (indir == null)
                            continue;

                        string outpath = Path.Combine(indir.FullName, $"extractedfile_{i}.oodl");
                        await File.WriteAllBytesAsync(outpath, file);
                    }
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