using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        public async Task Cr2wTask(string[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern, string regex, ETextConvertFormat format)
        {
            if (path is null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            if (!deserialize && !serialize)
            {
                _loggerService.Error("Please specify either -s or -d.");
                return;
            }

            foreach (var s in path)
            {
                await Cr2wTaskInner(s, outpath, deserialize, serialize, pattern, regex, format);
            }

            // Parallel.ForEach(path, file =>
            // {
            //     Cr2wTaskInner(file, outpath, deserialize, serialize, pattern, regex, format);
            // });
        }

        private async Task Cr2wTaskInner(string path, DirectoryInfo outputDirectory, bool deserialize, bool serialize,
            string pattern = "", string regex = "", ETextConvertFormat format = ETextConvertFormat.json)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Error("Please fill in an input path.");
                return;
            }

            var inFileInfo = new FileInfo(path);
            var inDirInfo = new DirectoryInfo(path);
            var isDirectory = !inFileInfo.Exists && inDirInfo.Exists;
            var isFile = inFileInfo.Exists && !inDirInfo.Exists;

            if (!isDirectory && !isFile)
            {
                _loggerService.Error("Input file does not exist.");
                return;
            }

            #endregion checks

            Stopwatch watch = new();
            watch.Restart();

            // get all files
            var fileInfos = isDirectory
                ? inDirInfo.GetFiles("*", SearchOption.AllDirectories).ToList()
                : new List<FileInfo> { inFileInfo };


            IEnumerable<FileInfo> finalmatches = fileInfos;

            if (deserialize)
            {
                finalmatches = fileInfos.Where(_ => _.Extension == $".{format}");
            }

            if (serialize)
            {
                finalmatches = fileInfos.Where(_ => Enum.GetNames(typeof(ERedExtension)).Contains(_.TrimmedExtension()));
            }

            // check search pattern then regex
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
            _loggerService.Info($"Found {finalMatchesList.Count} files to process.");

            var progress = 0;

            foreach (var fileInfo in finalMatchesList)
            //Parallel.ForEach(finalMatchesList, fileInfo =>
            {
                var outputDirInfo = outputDirectory is null
                    ? fileInfo.Directory
                    : outputDirectory;
                if (outputDirInfo == null || !outputDirInfo.Exists)
                {
                    _loggerService.Error("Invalid output directory.");
                    return;
                }

                if (serialize)
                {
                    var infile = fileInfo.FullName;
                    if (await Task.Run(() => _modTools.ConvertToAndWrite(format, infile, outputDirInfo)))
                    {
                        _loggerService.Success($"Saved {infile} to {format}.");
                    }
                }

                if (deserialize)
                {
                    try
                    {
                        _modTools.ConvertFromAndWrite(fileInfo, outputDirInfo);
                        _loggerService.Success($"Converted {fileInfo.FullName} to CR2W");
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error($"Could not convert {fileInfo.FullName} Error:");
                        _loggerService.Error(e.ToString());
                        //throw;
                    }
                }

                Interlocked.Increment(ref progress);
                //});
            }

            watch.Stop();
            _loggerService.Info($"Elapsed time: {watch.ElapsedMilliseconds}ms.");
        }
    }
}
