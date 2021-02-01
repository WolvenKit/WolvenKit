using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77.CR2W.Archive;
using CP77.CR2W;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {

        public static void UncookTask(string[] path, string outpath,
            EUncookExtension uext, bool flip, ulong hash, string pattern, string regex)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                UncookTaskInner(file, outpath, uext, flip, hash, pattern, regex);
            });

        }


        private static void UncookTaskInner(string path, string outpath, 
            EUncookExtension uext, bool flip, ulong hash, string pattern, string regex)
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

                // run
                if (hash != 0)
                {
                    ar.UncookSingle(hash, outDir, uext, flip);
                    logger.LogString($" {ar.ArchiveAbsolutePath}: Uncooked one file: {hash}", Logtype.Success);
                }
                else
                {
                    var r = ar.UncookAll(outDir, pattern, regex, uext, flip);
                    logger.LogString($" {ar.ArchiveAbsolutePath}: Uncooked {r.Item1.Count}/{r.Item2} files.",
                        Logtype.Success);
                }
            }

            return;
        }
    }
}