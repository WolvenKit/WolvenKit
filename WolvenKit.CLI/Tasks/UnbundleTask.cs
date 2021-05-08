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
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
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
                _loggerService.LogString("No .archive file to process in the input directory.", Logtype.Error);
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

                var isHash = ulong.TryParse(hash, out ulong hashNumber);

                // run
                if (!isHash && File.Exists(hash))
                {
                    var hashlist = File.ReadAllLines(hash)
                        .ToList().Select(_ => ulong.TryParse(_, out ulong res) ? res : 0);
                    _loggerService.LogString($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...",
                        Logtype.Normal);
                    foreach (var hash_num in hashlist)
                    {
                        _modTools.ExtractSingle(ar, hash_num, outDir, DEBUG_decompress);
                        _loggerService.LogString($" {ar.ArchiveAbsolutePath}: Extracted one file: {hash_num}", Logtype.Success);
                    }

                    _loggerService.LogString($"Bulk extraction from hashlist file completed.", Logtype.Success);
                }
                else if (isHash && hashNumber != 0)
                {
                    _modTools.ExtractSingle(ar, hashNumber, outDir, DEBUG_decompress);
                    _loggerService.LogString($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNumber}", Logtype.Success);
                }
                else
                {
                    var r = _modTools.ExtractAll(ar, outDir, pattern, regex, DEBUG_decompress);
                    _loggerService.Success($"{ar.ArchiveAbsolutePath}: Extracted {r.Item1.Count}/{r.Item2} files.");
                }
            }

            return;
        }

        #endregion Methods
    }
}
