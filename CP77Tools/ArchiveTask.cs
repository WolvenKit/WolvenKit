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
            bool uncook, EUncookExtension uext, ulong hash, string pattern, string regex)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Please fill in an input path");
                return;
            }

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);
            DirectoryInfo basedir;

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                Console.WriteLine("Input path does not exist");
                return;
            }

            if (inputFileInfo.Exists && inputFileInfo.Extension != ".archive")
            {
                Console.WriteLine("Input file is not an .archive");
                return;
            }
            else if (inputDirInfo.GetFiles().Where(_=>_.Extension == ".archive").Count() < 1)
            {
                Console.WriteLine("No .archive file to process in the input directory");
                return;
            }

            basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;

            #endregion

            if (extract || dump || list || uncook)
            {
                var tobeprocessedarchives = inputFileInfo.Exists ? new List<FileInfo> { inputFileInfo } :
                    inputDirInfo.GetFiles().Where(_ => _.Extension == ".archive");
                foreach (var processedarchive in tobeprocessedarchives)
                {
                    // get outdirectory
                    DirectoryInfo outDir;
                    if (string.IsNullOrEmpty(outpath))
                    {
                        outDir = Directory.CreateDirectory(Path.Combine(
                                basedir.FullName,
                                processedarchive.Name.Replace(".archive", "")));
                    }
                    else
                    {
                        outDir = new DirectoryInfo(outpath);
                        if (!outDir.Exists)
                        {
                            outDir = Directory.CreateDirectory(outpath);
                        }
                        if (inputDirInfo.Exists)
                        {
                            outDir = Directory.CreateDirectory(Path.Combine(
                                outDir.FullName,
                                processedarchive.Name.Replace(".archive", "")));
                        }
                    }

                    // read archive
                    var ar = new Archive(processedarchive.FullName);

                    // run
                    if (extract || uncook)
                    {
                        if (hash != 0)
                        {
                            if (extract)
                            {
                                ar.ExtractSingle(hash, outDir);
                                Console.WriteLine($" {ar.Filepath}: Extracted one file: {hash}");
                            }

                            if (uncook)
                            {
                                ar.UncookSingle(hash, outDir, uext);
                                Console.WriteLine($" {ar.Filepath}: Uncooked one file: {hash}");
                            }
                        }
                        else
                        {
                            if (extract)
                            {
                                var r = ar.ExtractAll(outDir, pattern, regex);
                                Console.WriteLine($" {ar.Filepath}: Extracted {r.Item1.Count}/{r.Item2} files.");
                            }

                            if (uncook)
                            {
                                var r = ar.UncookAll(outDir, pattern, regex, uext);
                                Console.WriteLine($" {ar.Filepath}: Uncooked {r.Item1.Count}/{r.Item2} files.");
                            }
                        }

                    }

                    if (dump)
                    {
                        ar.DumpInfo(outDir);
                        Console.WriteLine($"Finished dumping {processedarchive.FullName}.");
                    }

                    if (list)
                    {
                        foreach (var entry in ar.Files)
                        {
                            Console.WriteLine(entry.Value.NameStr);
                        }
                    }
                }
            }
            return;
        }
    }
}