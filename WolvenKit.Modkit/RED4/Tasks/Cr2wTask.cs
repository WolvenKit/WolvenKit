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
        public async Task Cr2wTask(FileSystemInfo[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern, string regex, ETextConvertFormat format)
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

        private async Task Cr2wTaskInner(FileSystemInfo path, DirectoryInfo outputDirectory, bool deserialize, bool serialize,
            string pattern = "", string regex = "", ETextConvertFormat format = ETextConvertFormat.json)
        {
            #region checks

            if (path is null)
            {
                _loggerService.Error("Please fill in an input path.");
                return;
            }
            if (!path.Exists)
            {
                _loggerService.Error("Input path does not exist.");
                return;
            }

            List<FileInfo> fileInfos = new();
            switch (path)
            {
                case FileInfo file:
                    fileInfos.Add(file);
                    break;
                case DirectoryInfo directory:
                    fileInfos = directory.GetFiles("*", SearchOption.AllDirectories).ToList();
                    break;
                default:
                    _loggerService.Error("Not a valid file or directory name.");
                    return;
            }

            #endregion checks

            Stopwatch watch = new();
            watch.Restart();

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
