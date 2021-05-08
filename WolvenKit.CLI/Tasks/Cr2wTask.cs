using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CP77.CR2W;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void Cr2wTask(string[] path, string outpath, bool chunks, string pattern, string regex)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                Cr2wTaskInner(file, outpath, chunks, pattern, regex);
            });
        }

        private void Cr2wTaskInner(string path, string outpath, bool chunks, string pattern = "", string regex = "")
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            var inFileInfo = new FileInfo(path);
            var inDirInfo = new DirectoryInfo(path);
            var isDirectory = !inFileInfo.Exists && inDirInfo.Exists;
            var isFile = inFileInfo.Exists && !inDirInfo.Exists;

            if (!isDirectory && !isFile)
            {
                _loggerService.LogString("Input file does not exist.", Logtype.Error);
                return;
            }

            #endregion checks

            Stopwatch watch = new();
            watch.Restart();

            // get all files
            var fileInfos = isDirectory
                ? inDirInfo.GetFiles("*", SearchOption.AllDirectories).ToList()
                : new List<FileInfo> { inFileInfo };

            // check search pattern then regex
            IEnumerable<FileInfo> finalmatches = fileInfos;
            if (!string.IsNullOrEmpty(pattern))
            {
                finalmatches = fileInfos.MatchesWildcard(item => item.FullName, pattern);
            }

            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FullName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            var finalMatchesList = finalmatches.ToList();
            _loggerService.LogString($"Found {finalMatchesList.Count} files to dump.", Logtype.Important);

            Thread.Sleep(1000);
            int progress = 0;
            Parallel.ForEach(finalMatchesList, fileInfo =>
            {
                var outputDirInfo = string.IsNullOrEmpty(outpath)
                    ? fileInfo.Directory
                    : new DirectoryInfo(outpath);
                if (outputDirInfo == null || !outputDirInfo.Exists)
                {
                    _loggerService.LogString("Invalid output directory.", Logtype.Error);
                    return;
                }

                if (chunks)
                {
                    var f = File.ReadAllBytes(fileInfo.FullName);
                    using var fs = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
                    var cr2w = _modTools.TryReadCr2WFile(fs);
                    if (cr2w == null)
                    {
                        return;
                    }

                    //write
                    File.WriteAllText(Path.Combine(outputDirInfo.FullName, $"{fileInfo.Name}.json"),
                        JsonConvert.SerializeObject(cr2w, Formatting.Indented, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.None,
                            TypeNameHandling = TypeNameHandling.None
                        }));
                }

                Interlocked.Increment(ref progress);
            });

            watch.Stop();
            _loggerService.LogString(
                $"Finished. Dumped {finalMatchesList.Count} files to JSON in {watch.ElapsedMilliseconds.ToString()}ms.",
                Logtype.Success);
        }

        #endregion Methods
    }
}
