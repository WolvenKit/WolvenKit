using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W;
using WolvenKit.Common;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;

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

        public async Task UnbundleTaskAsync(string[] path, string outpath,
            string hash, string pattern, string regex, bool DEBUG_decompress = false)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            var tasks = path
                .Select(s => UnbundleTaskInnerAsync(s, outpath, hash, pattern, regex, DEBUG_decompress))
                .ToList();

            await Task.WhenAll(tasks);
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
                archiveManager.LoadFromFolder(basedir.FullName);
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

                var isHash = ulong.TryParse(hash, out ulong hashNumber);

                // run
                if (!isHash && File.Exists(hash))
                {
                    var hashlist = File.ReadAllLines(hash)
                        .ToList().Select(_ => ulong.TryParse(_, out var res) ? res : 0);
                    _loggerService.Info($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...");
                    foreach (var hashNum in hashlist)
                    {
                        _modTools.ExtractSingle(ar, hashNum, outDir, DEBUG_decompress);
                        _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNum}");
                    }

                    _loggerService.Success($"Bulk extraction from hashlist file completed.");
                }
                else if (isHash && hashNumber != 0)
                {
                    _modTools.ExtractSingle(ar, hashNumber, outDir, DEBUG_decompress);
                    _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNumber}");
                }
                else
                {
                    _modTools.ExtractAll(ar, outDir, pattern, regex, DEBUG_decompress);
                }
            }

            return;
        }

        private async Task UnbundleTaskInnerAsync(string path, string outpath,
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
                archiveManager.LoadFromFolder(basedir.FullName);
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

                var isHash = ulong.TryParse(hash, out ulong hashNumber);

                // run
                if (!isHash && File.Exists(hash))
                {
                    var hashlist = (await File.ReadAllLinesAsync(hash))
                        .ToList().Select(_ => ulong.TryParse(_, out ulong res) ? res : 0);
                    _loggerService.Info($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...");
                    foreach (var hash_num in hashlist)
                    {
                        await _modTools.ExtractSingleAsync(ar, hash_num, outDir, DEBUG_decompress);
                        _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hash_num}");
                    }

                    _loggerService.Success($"Bulk extraction from hashlist file completed.");
                }
                else if (isHash && hashNumber != 0)
                {
                    await _modTools.ExtractSingleAsync(ar, hashNumber, outDir, DEBUG_decompress);
                    _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNumber}");
                }
                else
                {
                    await _modTools.ExtractAllAsync(ar, outDir, pattern, regex, DEBUG_decompress);
                    //_loggerService.Success($"{ar.ArchiveAbsolutePath}: Extracted {r.Item1.Count}/{r.Item2} files.");
                    _loggerService.Success($"{ar.ArchiveAbsolutePath}: Extracted all files.");
                }
            }

            return;
        }



        #endregion Methods
    }
}
