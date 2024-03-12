using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.Common.Extensions;
using WolvenKit.RED4.Archive;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        #region Methods

        /// <summary>
        /// Extracts all files from an archive to a specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        public void ExtractAll(ICyberGameArchive ar, DirectoryInfo outDir, string? pattern = null, string? regex = null, bool decompressBuffers = false)
        {
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // check search pattern then regex
            var finalmatches = ar.Files.Values.Cast<FileEntry>();


            var totalInArchiveCount = ar.Files?.Count ?? 0;
            if (!string.IsNullOrEmpty(pattern))
            {
                if (ar.Files?.Values is not null)
                {
                    finalmatches = ar.Files.Values.Cast<FileEntry>().MatchesWildcard(item => item.FileName, pattern);
                }
            }

            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FileName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            var finalMatchesList = finalmatches.ToList();
            _loggerService.Info($"{ar.ArchiveAbsolutePath}: Found {finalMatchesList.Count}/{totalInArchiveCount} entries to extract.");
            if (finalMatchesList.Count == 0)
            {
                return;
            }

            var progress = 0;

            // check hashes before parallel unbundling
            for (var i = 0; i < finalMatchesList.Count; i++)
            {
                var item = finalMatchesList[i];
                _hashService.Contains(item.Key);
            }

            var archive = ar as Archive;

            Parallel.ForEach(finalMatchesList, info =>
            {
                var extracted = ExtractSingle(ar, info.NameHash64, outDir, decompressBuffers);

                if (extracted != 0)
                {
                    extractedList.Add(info.FileName);
                }
                else
                {
                    failedList.Add(info.FileName);
                }

                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)finalMatchesList.Count);
            });

            archive?.ReleaseFileHandle();

            _progressService.Completed();

            //logging
            var msg = $"{ar.ArchiveAbsolutePath}: Unbundled {extractedList.Count}/{finalMatchesList.Count} entries.";
            if (extractedList.Count == finalMatchesList.Count)
            {
                _loggerService.Success(msg);
            }
            else
            {
                _loggerService.Info(msg);
            }
        }

        /// <summary>
        /// Extracts all files from an archive to a specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        public async Task ExtractAllAsync(ICyberGameArchive ar, DirectoryInfo outDir, string? pattern = null, string? regex = null, bool decompressBuffers = false)
        {
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // check search pattern then regex
            var finalmatches = ar.Files.Values.Cast<FileEntry>();
            if (!string.IsNullOrEmpty(pattern))
            {
                finalmatches = ar.Files.Values.Cast<FileEntry>().MatchesWildcard(item => item.FileName, pattern);
            }

            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FileName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            var finalMatchesList = finalmatches.ToList();
            _loggerService.Info($"Found {finalMatchesList.Count} bundle entries to extract.");

            //Thread.Sleep(1000);
            var progress = 0;

            var bag = new ConcurrentBag<object>();
            foreach (var info in finalMatchesList)
            {
                var response = await ExtractSingleAsync(ar, info.NameHash64, outDir, decompressBuffers);
                bag.Add(response);
                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)finalMatchesList.Count);
            };

            var archive = ar as Archive;
            archive?.ReleaseFileHandle();

            _progressService.Completed();
            var count = bag.Count;
            _loggerService.Info($"--------{count}---------");
        }

        /// <summary>
        /// Extracts a single file (by hash) as physical file to a directory
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        public static int ExtractSingle(ICyberGameArchive ar, ulong hash, DirectoryInfo outDir, bool decompressBuffers = false)
        {
            if (!ar.Files.TryGetValue(hash, out var tmp) || tmp is not FileEntry gameFile)
            {
                return 0;
            }

            // get filename
            var name = gameFile.FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }

            Directory.CreateDirectory(outDir.FullName);
            // get outfile name
            var outfile = new FileInfo(Path.Combine(outDir.FullName, $"{name.Replace('\\', Path.DirectorySeparatorChar)}"));
            if (outfile.Directory == null)
            {
                return -1;
            }

            // create outfile
            if (!Directory.Exists(outfile.Directory.FullName))
            {
                Directory.CreateDirectory(outfile.Directory.FullName);
            }

            using var fs = new FileStream(outfile.FullName, FileMode.Create, FileAccess.Write);
            gameFile.Extract(fs, decompressBuffers);

            return 1;
        }

        /// <summary>
        /// Extracts a single file (by hash) as physical file to a directory
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        public static async Task<int> ExtractSingleAsync(ICyberGameArchive ar, ulong hash, DirectoryInfo outDir, bool decompressBuffers = false)
        {
            if (!ar.Files.TryGetValue(hash, out var tmp) || tmp is not FileEntry gameFile)
            {
                return 0;
            }

            // get filename
            var name = gameFile.FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }

            // get outfile name
            var outfile = new FileInfo(Path.Combine(outDir.FullName, $"{name.Replace('\\', Path.DirectorySeparatorChar)}"));
            if (outfile.Directory == null)
            {
                return -1;
            }

            // create outfile
            if (!Directory.Exists(outfile.Directory.FullName))
            {
                Directory.CreateDirectory(outfile.Directory.FullName);
            }

            await using var fs = new FileStream(outfile.FullName, FileMode.Create, FileAccess.Write);
            await gameFile.ExtractAsync(fs, decompressBuffers);

            return 1;
        }


        /// <summary>
        /// Extracts a single file (by hash) from an archive to a Stream
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="stream"></param>
        /// <param name="decompressBuffers"></param>
        public static void ExtractSingleToStream(ICyberGameArchive ar, ulong hash, Stream ms)
        {
            if (!ar.Files.TryGetValue(hash, out var tmp) || tmp is not FileEntry gameFile)
            {
                return;
            }

            gameFile.Extract(ms);
        }


        /// <summary>
        /// Extracts a single file (by hash) from an archive to a Stream
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="stream"></param>
        /// <param name="decompressBuffers"></param>
        public static async Task ExtractSingleToStreamAsync(Archive ar, ulong hash, Stream ms)
        {
            if (!ar.Files.TryGetValue(hash, out var tmp) || tmp is not FileEntry gameFile)
            {
                return;
            }

            await gameFile.ExtractAsync(ms);
        }


        #endregion Methods
    }
}
