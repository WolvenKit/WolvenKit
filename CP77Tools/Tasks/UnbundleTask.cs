using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77.CR2W.Archive;
using Catel.IoC;
using CP77.CR2W;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {
        private static readonly ILoggerService logger = ServiceLocator.Default.ResolveType<ILoggerService>();

        public static void UnbundleTask(string[] path, string outpath,
            string hash, string pattern, string regex)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                UnbundleTaskInner(file, outpath, hash, pattern, regex);
            });

        }


        private static void UnbundleTaskInner(string path, string outpath, 
            string hash, string pattern, string regex)
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

            List<FileInfo> archiveFileInfos;
            if (isDirectory)
            {
                var archiveManager = new ArchiveManager(basedir);
                // TODO: use the manager here?
                archiveFileInfos = archiveManager.Archives.Select(_ => new FileInfo(_.Value.ArchiveAbsolutePath)).ToList();
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

                var isHash = ulong.TryParse(hash, out ulong hashNumber);

                // run
                {
                    if (!isHash && File.Exists(hash))
                    {
                        var hashlist = File.ReadAllLines(hash)
                            .ToList().Select(_ => ulong.TryParse(_, out ulong res) ? res : 0);
                        logger.LogString($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...",
                            Logtype.Normal);
                        foreach (var hash_num in hashlist)
                        {
                            ar.ExtractSingle(hash_num, outDir);
                            logger.LogString($" {ar.ArchiveAbsolutePath}: Extracted one file: {hash_num}", Logtype.Success);
                        }

                        logger.LogString($"Bulk extraction from hashlist file completed!", Logtype.Success);
                    }
                    else if (isHash && hashNumber != 0)
                    {
                        ar.ExtractSingle(hashNumber, outDir);
                        logger.LogString($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNumber}", Logtype.Success);
                    }
                    else
                    {
                        var r = ar.ExtractAll(outDir, pattern, regex);
                        logger.LogString($"{ar.ArchiveAbsolutePath}: Extracted {r.Item1.Count}/{r.Item2} files.",
                            Logtype.Success);
                    }

                }




            }

            return;
        }
    }
}