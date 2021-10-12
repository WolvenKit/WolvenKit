using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {

        #region Methods

        public void UnbundleTask(string[] path, string outpath,
            string hash, string pattern, string regex, bool DEBUG_decompress = false)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file =>
            {
                UnbundleTaskInner(file, outpath, hash, pattern, regex, DEBUG_decompress);
            });
        }

        private void UnbundleTaskInner(string path, string outpath,
            string hash, string pattern, string regex, bool DEBUG_decompress = false)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                _loggerService.Warning("Input path does not exist.");
                return;
            }

            if (inputFileInfo.Exists && inputFileInfo.Extension != ".archive")
            {
                _loggerService.Warning("Input file is not an .archive.");
                return;
            }
            else if (inputDirInfo.Exists && inputDirInfo.GetFiles().All(_ => _.Extension != ".archive"))
            {
                _loggerService.Warning("No .archive file to process in the input directory.");
                return;
            }

            var isDirectory = !inputFileInfo.Exists;
            var basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;

            #endregion checks

            List<FileInfo> archiveFileInfos;
            if (isDirectory)
            {
                var archiveManager = new ArchiveManager(_hashService);
                archiveManager.LoadFromFolder(basedir);
                // TODO: use the manager here?
                archiveFileInfos = archiveManager.Archives.Items.Select(_ => new FileInfo(_.ArchiveAbsolutePath)).ToList();
            }
            else
            {
                archiveFileInfos = new List<FileInfo> { inputFileInfo };
            }

            foreach (var fileInfo in archiveFileInfos)
            {
                // get outdirectory
                DirectoryInfo outDir;
                if (string.IsNullOrEmpty(outpath))
                {
                    outDir = new DirectoryInfo(Path.Combine(
                        basedir.FullName,
                        fileInfo.Name.Replace(".archive", "")));
                }
                else
                {
                    outDir = new DirectoryInfo(outpath);
                    if (!outDir.Exists)
                    {
                        outDir = new DirectoryInfo(outpath);
                    }

                    if (inputDirInfo.Exists)
                    {
                        outDir = new DirectoryInfo(Path.Combine(
                            outDir.FullName,
                            fileInfo.Name.Replace(".archive", "")));
                    }
                }

                // read archive
                var ar = Red4ParserServiceExtensions.ReadArchive(fileInfo.FullName, _hashService);

                var isHash = ulong.TryParse(hash, out ulong hashNumber);

                // run
                if (!isHash && File.Exists(hash))
                {
                    var hashlist = File.ReadAllLines(hash)
                        .ToList().Select(_ => ulong.TryParse(_, out var res) ? res : 0);
                    _loggerService.Info($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...");
                    foreach (var hashNum in hashlist)
                    {
                        var r = ModTools.ExtractSingle(ar, hashNum, outDir, DEBUG_decompress);
                        if (r > 0)
                        {
                            _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNum}");
                        }
                        else
                        {
                            _loggerService.Info($" {ar.ArchiveAbsolutePath}: No file found with hash {hashNum}");
                        }
                    }

                    _loggerService.Success($"Bulk extraction from hashlist file completed.");
                }
                else if (isHash && hashNumber != 0)
                {
                    var r = ModTools.ExtractSingle(ar, hashNumber, outDir, DEBUG_decompress);
                    if (r > 0)
                    {
                        _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNumber}");
                    }
                    else
                    {
                        _loggerService.Info($" {ar.ArchiveAbsolutePath}: No file found with hash {hashNumber}");
                    }
                }
                else
                {
                    _modTools.ExtractAll(ar, outDir, pattern, regex, DEBUG_decompress);
                }
            }

            return;
        }

        #endregion Methods
    }
}
