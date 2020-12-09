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
                    if (!outDir.Exists)
                        Directory.CreateDirectory(outDir.FullName);
                    if (inputFileInfo.Extension != ".archive")
                        return 0;
                    var indir = new FileInfo(options.path).Directory;
                    if (indir == null)
                        return 0;

                    ar.ExtractAll(outDir);
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