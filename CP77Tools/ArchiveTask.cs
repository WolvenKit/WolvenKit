using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77Tools.Model;
using CP77Tools.Services;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.CR2W.Types;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {
        
        public static void ArchiveTask(string path, string outpath, bool extract, bool dump, bool list, 
            bool uncook, EUncookExtension uext, ulong hash)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Input file does not exist");
                return;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                Console.WriteLine("Input file does not exist");
                return;
            }
            if (inputFileInfo.Extension != ".archive")
            {
                Console.WriteLine("Input file is not an .archive");
                return;
            }
            var indir = new FileInfo(path).Directory;
            if (indir == null)
                return;

            #endregion

            if (extract || dump || list || uncook)
            {
                // get outdirectory

                DirectoryInfo outDir;

                if (string.IsNullOrEmpty(outpath))
                {
                    outDir = Directory.CreateDirectory(Path.Combine(
                            indir.FullName,
                            inputFileInfo.Name.Replace(".archive", "")));
                }
                else
                {
                    outDir = new DirectoryInfo(outpath);

                    if (!outDir.Exists)
                    {
                        outDir = Directory.CreateDirectory(outpath);
                    }
                }

                // read archive
                var ar = new Archive(inputFileInfo.FullName);

                // run
                if (extract || uncook)
                {
                    if (hash != 0)
                    {
                        if (extract)
                        {
                            ar.ExtractSingle(hash, outDir);
                            Console.WriteLine($"{ar.Filepath}: Extracted one file: {hash}");
                        }

                        if (uncook)
                        {
                            ar.UncookSingle(hash, outDir, uext);
                            Console.WriteLine($"{ar.Filepath}: Uncooked one file: {hash}");
                        }
                    }
                    else
                    {
                        if (extract)
                        {
                            var r = ar.ExtractAll(outDir);
                            Console.WriteLine($"{ar.Filepath}: Extracted {r.Item1.Count}/{r.Item2} files.");
                        }

                        if (uncook)
                        {
                            var r = ar.UncookAll(outDir, uext);
                            Console.WriteLine($"{ar.Filepath}: Uncooked {r.Item1.Count}/{r.Item2} files.");
                        }
                    }
                    
                }

                if (dump)
                {
                    ar.DumpInfo(outDir);
                    Console.WriteLine($"Finished dumping {path}.");
                }

                if (list)
                {
                    foreach (var entry in ar.Files)
                    {
                        Console.WriteLine(entry.Value.NameStr);
                    }
                }
            }

            return;
        }
    }
}