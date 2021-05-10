using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using Dasync.Collections;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;

namespace CP77.CR2W
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
        public void ExtractAll(Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false)
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


            using var fs = new FileStream(ar.ArchiveAbsolutePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            using var mmf = MemoryMappedFile.CreateFromFile(fs, null, 0, MemoryMappedFileAccess.ReadWrite, HandleInheritability.None, false);

            //Thread.Sleep(1000);
            var progress = 0;
            _progressService.Report(0);

            Parallel.ForEach(finalMatchesList, info =>
            {
                var extracted = ExtractSingle(ar, info.NameHash64, outDir, decompressBuffers, mmf);

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

            _progressService.Report(1.0);

            //return (extractedList.ToList(), finalMatchesList.Count);
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
        public async Task ExtractAllAsync(Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false)
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

            await using var fs = new FileStream(ar.ArchiveAbsolutePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            using var mmf = MemoryMappedFile.CreateFromFile(fs, null, 0, MemoryMappedFileAccess.ReadWrite, HandleInheritability.None, false);

            //Thread.Sleep(1000);
            var progress = 0;
            _progressService.Report(0);

            var bag = new ConcurrentBag<object>();
            await finalMatchesList.ParallelForEachAsync(async info =>
            {
                var response = await ExtractSingleAsync(ar, info.NameHash64, outDir, decompressBuffers, mmf);
                bag.Add(response);
                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)finalMatchesList.Count);
            });
            var count = bag.Count;
            _loggerService.Info($"--------{count}---------");

            _progressService.Report(1.0);
        }

        /// <summary>
        /// Extracts a single file (by hash) as physical file to a directory
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        public int ExtractSingle(Archive ar, ulong hash, DirectoryInfo outDir, bool decompressBuffers = false, MemoryMappedFile mmf = null)
        {
            // get filename
            var entry = ar.Files[hash] as FileEntry;
            var name = entry.FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }

            // get outfile name
            var outfile = new FileInfo(Path.Combine(outDir.FullName, $"{name}"));
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
            ExtractSingleToStream(ar, hash, fs, mmf, decompressBuffers);

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
        public static async Task<int> ExtractSingleAsync(Archive ar, ulong hash, DirectoryInfo outDir, bool decompressBuffers = false, MemoryMappedFile mmf = null)
        {
            // get filename
            var entry = ar.Files[hash] as FileEntry;
            var name = entry.FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }

            // get outfile name
            var outfile = new FileInfo(Path.Combine(outDir.FullName, $"{name}"));
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
            await ExtractSingleToStreamAsync(ar, hash, fs, mmf, decompressBuffers);

            return 1;
        }


        /// <summary>
        /// Extracts a single file (by hash) from an archive to a Stream
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="stream"></param>
        /// <param name="decompressBuffers"></param>
        public static void ExtractSingleToStream(Archive ar, ulong hash, Stream ms, MemoryMappedFile mmf = null, bool decompressBuffers = false)
        {
            if (!ar.Files.ContainsKey(hash))
            {
                return;
            }

            // extract file to memorystream
            //using var ms = new MemoryStream();
            if (mmf != null)
            {
                ar.CopyFileToStream(ms, hash, decompressBuffers, mmf);
            }
            else
            {
                ar.CopyFileToStream(ms, hash, decompressBuffers);
            }

            //ms.Seek(0, SeekOrigin.Begin);
            //ms.CopyTo(stream);
        }

       
        /// <summary>
        /// Extracts a single file (by hash) from an archive to a Stream
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="stream"></param>
        /// <param name="decompressBuffers"></param>
        public static async Task ExtractSingleToStreamAsync(Archive ar, ulong hash, Stream ms, MemoryMappedFile mmf = null, bool decompressBuffers = false)
        {
            if (!ar.Files.ContainsKey(hash))
            {
                return;
            }

            if (mmf != null)
            {
                await ar.CopyFileToStreamAsync(ms, hash, decompressBuffers, mmf);
            }
            else
            {
                await ar.CopyFileToStreamAsync(ms, hash, decompressBuffers);
            }
        }


        #endregion Methods
    }
}
