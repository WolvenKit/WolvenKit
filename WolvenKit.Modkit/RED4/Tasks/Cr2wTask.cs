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

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public async Task<int> Cr2wTask(FileSystemInfo[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern, string regex, ETextConvertFormat format)
    {
        if (path is null || path.Length < 1)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (!deserialize && !serialize)
        {
            _loggerService.Error("Please specify either -s or -d.");
            return ERROR_INVALID_COMMAND_LINE;
        }

        var result = 0;
        foreach (var s in path)
        {
            result += await Cr2wTaskInner(s, outpath, deserialize, serialize, pattern, regex, format);
        }

        return result;
    }

    private async Task<int> Cr2wTaskInner(FileSystemInfo path, DirectoryInfo outputDirectory, bool deserialize, bool serialize,
        string pattern = "", string regex = "", ETextConvertFormat format = ETextConvertFormat.json)
    {
        #region checks

        if (path is null)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }
        if (!path.Exists)
        {
            _loggerService.Error("Input path does not exist.");
            return ERROR_BAD_ARGUMENTS;
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
                return ERROR_BAD_ARGUMENTS;
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
        {
            var outputDirInfo = outputDirectory is null
                ? fileInfo.Directory
                : outputDirectory;
            if (outputDirInfo == null || !outputDirInfo.Exists)
            {
                _loggerService.Error("Invalid output directory.");
                return 1;
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

        return 0;
    }
}
