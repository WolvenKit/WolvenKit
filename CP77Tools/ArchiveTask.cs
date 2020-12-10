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
        
        public static int ArchiveTask(string path, bool extract, bool dump)
        {
            if (extract || dump)
            {
                // initial checks
                var inputFileInfo = new FileInfo(path);
                if (!inputFileInfo.Exists)
                    return 0;

                var ar = new Archive(inputFileInfo.FullName);

                if (extract)
                {
                    // mmf
                    var outDir = Directory.CreateDirectory(inputFileInfo.Directory + "\\" +
                                                           inputFileInfo.Name.Replace(".archive", ""));
                    if (!outDir.Exists)
                        Directory.CreateDirectory(outDir.FullName);
                    if (inputFileInfo.Extension != ".archive")
                        return 0;
                    var indir = new FileInfo(path).Directory;
                    if (indir == null)
                        return 0;

                    ar.ExtractAll(outDir);
                }

                if (dump)
                {
                    ar.DumpInfo();
                }
            }

            Console.WriteLine($"Finished extracting {path}");

            return 1;
        }
    }
}