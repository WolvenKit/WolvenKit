using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void UncookTask(string[] path, string outpath,
            EUncookExtension uext, bool flip, ulong hash, string pattern, string regex)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                UncookTaskInner(file, outpath, uext, flip, hash, pattern, regex);
            });
        }

        private void UncookTaskInner(string path, string outpath,
            EUncookExtension uext, bool flip, ulong hash, string pattern, string regex)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                _loggerService.LogString("Input path does not exist.", Logtype.Error);
                return;
            }

            if (inputFileInfo.Exists && inputFileInfo.Extension != ".archive")
            {
                _loggerService.LogString("Input file is not an .archive.", Logtype.Error);
                return;
            }
            else if (inputDirInfo.Exists && inputDirInfo.GetFiles().All(_ => _.Extension != ".archive"))
            {
                _loggerService.LogString("No .archive file to process in the input directory", Logtype.Error);
                return;
            }

            var isDirectory = !inputFileInfo.Exists;
            var basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;

            #endregion checks

            List<FileInfo> archiveFileInfos;
            if (isDirectory)
            {
                var archiveManager = new ArchiveManager();
                archiveManager.LoadAll(basedir.FullName);
                // TODO: use the manager here?
                archiveFileInfos = archiveManager.Archives.Select(_ => new FileInfo(_.Value.ArchiveAbsolutePath)).ToList();
            }
            else
            {
                archiveFileInfos = new List<FileInfo> { inputFileInfo };
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
                var ar = Red4ParserServiceExtensions.ReadArchive(processedarchive.FullName, _hashService);

                // run
                if (hash != 0)
                {
                    _modTools.UncookSingle(ar, hash, outDir, uext, flip);
                    _loggerService.LogString($" {ar.ArchiveAbsolutePath}: Uncooked one file: {hash}", Logtype.Success);
                }
                else
                {
                    var r = _modTools.UncookAll(ar, outDir, pattern, regex, uext, flip);
                    _loggerService.LogString($" {ar.ArchiveAbsolutePath}: Uncooked {r.Item1.Count}/{r.Item2} files.",
                        Logtype.Success);
                }
            }

            return;
        }

        #endregion Methods
    }
}
