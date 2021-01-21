using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using CP77.CR2W.Extensions;
using WolvenKit.Common;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        /// <summary>
        /// Expects uncompressed buffers
        /// </summary>
        /// <param name="file"></param>
        /// <param name="buffers"></param>
        /// <param name="outfile"></param>
        /// <returns></returns>
        public static int Unbundle(byte[] file, List<byte[]> buffers, FileInfo outfile)
        {
            var extractsuccess = false;
            
            // write main file
            Directory.CreateDirectory(outfile.Directory.FullName);
            using var fs = new FileStream(outfile.FullName, FileMode.Create, FileAccess.Write);
            using var bw = new BinaryWriter(fs);
            bw.Write(file);
            extractsuccess = true;

            // write buffers
            // buffers are usually(?) appended to the main file
            // TODO: dump all buffered files and check this
            for (int j = 0; j < buffers.Count; j++)
            {
                var buffer = buffers[j];
                bw.Write(buffer);
                extractsuccess = true;
            }


            return extractsuccess ? 1 : 0;
        }
        
        
        /// <summary>
        /// Extracts a single file + buffers.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <returns></returns>
        public static int ExtractSingle(this Archive.Archive ar, ulong hash, DirectoryInfo outDir)
        {
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            return ar.ExtractSingleInner(hash, outDir);
        }
        
        private static int ExtractSingleInner(this Archive.Archive ar, ulong hash, DirectoryInfo outDir)
        {
            
            var (file, buffers) = ar.GetFileData(hash, false);

            if (!ar.Files.ContainsKey(hash))
                return -1;
            string name = ar.Files[hash].FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }

            var outfile = new FileInfo(Path.Combine(outDir.FullName,
                $"{name}"));
            if (outfile.Directory == null)
                return -1;


            return Unbundle(file, buffers, outfile);
        }

        /// <summary>
        /// Extracts all Files to the specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        public static (List<string>, int) ExtractAll(this Archive.Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "")
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = ar.Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = ar.Files.Values.MatchesWildcard(item => item.FileName, pattern);
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
            int progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                
                var extracted = ar.ExtractSingleInner(info.NameHash64, outDir);

                if (extracted != 0)
                    extractedList.Add(info.FileName);
                else
                    failedList.Add(info.FileName);

                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)finalMatchesList.Count);
            });

            return (extractedList.ToList(), finalMatchesList.Count);
        }
    }
}