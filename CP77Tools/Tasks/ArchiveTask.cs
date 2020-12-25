using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using WolvenKit.Common.Tools.DDS;
using CP77Tools;
using Catel.IoC;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {
        private static readonly ILoggerService logger = ServiceLocator.Default.ResolveType<ILoggerService>();

        public static void ArchiveTask(string[] path, string outpath, bool extract, bool dump, bool list,
            bool uncook, EUncookExtension uext, ulong hash, string pattern, string regex)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                ArchiveTaskInner(file, outpath, extract, dump, list,
                    uncook, uext, hash, pattern, regex);
            });

        }


        private static void ArchiveTaskInner(string path, string outpath, bool extract, bool dump, bool list, 
            bool uncook, EUncookExtension uext, ulong hash, string pattern, string regex)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);
            

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                logger.LogString("Input path does not exist", Logtype.Error);
                return;
            }

            if (inputFileInfo.Exists && inputFileInfo.Extension != ".archive")
            {
                logger.LogString("Input file is not an .archive", Logtype.Error);
                return;
            }
            else if (inputDirInfo.Exists && inputDirInfo.GetFiles().All(_ => _.Extension != ".archive"))
            {
                logger.LogString("No .archive file to process in the input directory", Logtype.Error);
                return;
            }

            var isDirectory = !inputFileInfo.Exists;
            var basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;

            #endregion

            if (extract || dump || list || uncook)
            {
                var archiveFileInfos = new List<FileInfo>();
                if (isDirectory)
                {
                    //var archiveManager = new ArchiveManager(basedir);
                    // TODO: use the manager here?
                }
                else
                {
                    archiveFileInfos = new List<FileInfo> {inputFileInfo};
                }

              
                foreach (var processedarchive in archiveFileInfos)
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
                                logger.LogString($" {ar.Filepath}: Extracted one file: {hash}", Logtype.Success);
                            }

                            if (uncook)
                            {
                                ar.UncookSingle(hash, outDir, uext);
                                logger.LogString($" {ar.Filepath}: Uncooked one file: {hash}", Logtype.Success);
                            }
                        }
                        else
                        {
                            if (extract)
                            {
                                var r = ar.ExtractAll(outDir, pattern, regex);
                                logger.LogString($"{ar.Filepath}: Extracted {r.Item1.Count}/{r.Item2} files.", Logtype.Success);
                            }

                            if (uncook)
                            {
                                var r = ar.UncookAll(outDir, pattern, regex, uext);
                                logger.LogString($" {ar.Filepath}: Uncooked {r.Item1.Count}/{r.Item2} files.", Logtype.Success);
                            }
                        }

                    }

                    if (dump)
                    {
                        File.WriteAllText(Path.Combine(outDir.Parent.FullName, $"{ar.Name}.json"),
                            JsonConvert.SerializeObject(ar, Formatting.Indented, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.None,
                                TypeNameHandling = TypeNameHandling.None
                            }));

                        logger.LogString($"Finished dumping {processedarchive.FullName}.", Logtype.Success);
                    }

                    if (list)
                    {
                        foreach (var entry in ar.Files)
                        {
                            logger.LogString(entry.Value.FileName, Logtype.Normal);
                        }
                    }


                }
            }
            return;
        }
    }
}