using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;
using CP77Tools.Model;
using WolvenKit.CR2W.Types;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {
        
        public static int ArchiveTask(string path, string outpath, bool extract, bool dump)
        {
            // initial checks
            if (string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Input file does not exist");
                return 0;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                Console.WriteLine("Input file does not exist");
                return 0;
            }
            if (inputFileInfo.Extension != ".archive")
            {
                Console.WriteLine("Input file is not an .archive");
                return 0;
            }
            var indir = new FileInfo(path).Directory;
            if (indir == null)
                return 0;

            if (extract || dump)
            {
                var outDir = Directory.CreateDirectory(Path.Combine(
                        indir.FullName, 
                        inputFileInfo.Name.Replace(".archive", "")));
                if (!string.IsNullOrEmpty(outpath))
                {
                    outDir = new DirectoryInfo(outpath);
                    if (!outDir.Exists)
                    {
                        Console.WriteLine("Output directory does not exist");
                        return 0;
                    }
                }
                if (!outDir.Exists)
                    Directory.CreateDirectory(outDir.FullName);

                // read archive
                var ar = new Archive(inputFileInfo.FullName);

                if (extract)
                {
                    ar.ExtractAll(outDir);
                    Console.WriteLine($"Finished extracting {path}.");
                }

                if (dump)
                {
                    ar.DumpInfo(outDir);
                    Console.WriteLine($"Finished dumping {path}.");
                }
            }

            return 1;
        }
    }
}