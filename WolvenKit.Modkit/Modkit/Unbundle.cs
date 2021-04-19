using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Extensions;
using WolvenKit.Common.Services;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
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
        public static (List<string>, int) ExtractAll(this Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            // check search pattern then regex
            IEnumerable<FileEntry> finalmatches = ar.Files.Values;
            if (!string.IsNullOrEmpty(pattern))
            {
                finalmatches = ar.Files.Values.MatchesWildcard(item => item.FileName, pattern);
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
            logger.LogString($"Found {finalMatchesList.Count} bundle entries to extract.", Logtype.Important);

            Thread.Sleep(1000);
            var progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                var extracted = ar.ExtractSingle(info.NameHash64, outDir, decompressBuffers);

                if (extracted != 0)
                {
                    extractedList.Add(info.FileName);
                }
                else
                {
                    failedList.Add(info.FileName);
                }

                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)finalMatchesList.Count);
            });

            return (extractedList.ToList(), finalMatchesList.Count);
        }

        /// <summary>
        /// Extracts a single file (by hash) as physical file to a directory
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        public static int ExtractSingle(this Archive ar, ulong hash, DirectoryInfo outDir, bool decompressBuffers = false)
        {
            // get filename
            var name = ar.Files[hash].FileName;
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
            Directory.CreateDirectory(outfile.Directory.FullName);
            using var fs = new FileStream(outfile.FullName, FileMode.Create, FileAccess.Write);
            ExtractSingleToStream(ar, hash, fs, decompressBuffers);

            return 1;
        }

        /// <summary>
        /// Extracts a single file (by hash) from an archive to a Stream
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="stream"></param>
        /// <param name="decompressBuffers"></param>
        public static void ExtractSingleToStream(Archive ar, ulong hash, Stream stream, bool decompressBuffers = false)
        {
            if (!ar.Files.ContainsKey(hash))
            {
                return;
            }

            // extract file to memorystream
            using var ms = new MemoryStream();
            ar.CopyFileToStream(ms, hash, decompressBuffers);

            ms.Seek(0, SeekOrigin.Begin);
            ms.CopyTo(stream);
        }

        #endregion Methods
    }
}
