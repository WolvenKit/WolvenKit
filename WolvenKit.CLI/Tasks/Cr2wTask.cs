using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;
using WolvenKit.CLI;
using WolvenKit.Common.Extensions;
using WolvenKit.Interfaces.Core;
using Formatting = Newtonsoft.Json.Formatting;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public enum ESerializeFormat
        {
            json,
            xml
        }

        public void Cr2wTask(string[] path, string outpath, bool deserialize, bool serialize, string pattern, string regex, ESerializeFormat format)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            foreach (var s in path)
            {
                Cr2wTaskInner(s, outpath, deserialize, serialize, pattern, regex, format);
            }

            // Parallel.ForEach(path, file =>
            // {
            //     Cr2wTaskInner(file, outpath, deserialize, serialize, pattern, regex, format);
            // });
        }

        private void Cr2wTaskInner(string path, string outputDirectory, bool deserialize, bool serialize,
            string pattern = "", string regex = "", ESerializeFormat format = ESerializeFormat.json)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
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
                finalmatches = fileInfos.Where(_ => _.Extension == $".{format.ToString()}");
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

            Thread.Sleep(1000);
            int progress = 0;

            foreach (var fileInfo in finalMatchesList)
            //Parallel.ForEach(finalMatchesList, fileInfo =>
            {
                var outputDirInfo = string.IsNullOrEmpty(outputDirectory)
                    ? fileInfo.Directory
                    : new DirectoryInfo(outputDirectory);
                if (outputDirInfo == null || !outputDirInfo.Exists)
                {
                    _loggerService.Error("Invalid output directory.");
                    return;
                }

                if (serialize)
                {
                    var infile = fileInfo.FullName;
                    using var fs = new FileStream(infile, FileMode.Open, FileAccess.Read);
                    var cr2w = _wolvenkitFileService.TryReadCr2WFile(fs);
                    if (cr2w == null)
                    {
                        return;
                    }

                    cr2w.FileName = infile;

                    string json = "";
                    var dto = new Red4W2rcFileDto(cr2w);
                    json =
                        JsonConvert.SerializeObject(
                            dto,
                            Formatting.Indented
                        );

                    if (string.IsNullOrEmpty(json))
                    {
                        _loggerService.Error($"Could not process {infile}.");
                        return;
                    }

                    var outpath = Path.Combine(outputDirInfo.FullName, $"{infile}.{format.ToString()}");

                    switch (format)
                    {
                        case ESerializeFormat.json:
                            File.WriteAllText(outpath, json);
                            break;
                        case ESerializeFormat.xml:
                            var doc = JsonConvert.DeserializeXmlNode(json, Red4W2rcFileDto.Magic);
                            doc?.Save(outpath);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(format), format, null);
                    }

                    _loggerService.Success($"Saved {infile} to {format.ToString()}.");
                }

                if (deserialize)
                {
                    try
                    {
                        var json = File.ReadAllText(fileInfo.FullName);
                        var newdto = JsonConvert.DeserializeObject<Red4W2rcFileDto>(json);
                        if (newdto != null)
                        {
                            var w2rc = newdto.ToW2rc();
                            var ext = newdto.Extension;
                            var outpath = Path.ChangeExtension(Path.Combine(outputDirInfo.FullName, fileInfo.Name),
                                ext);

                            using var fs2 = new FileStream(outpath, FileMode.Create, FileAccess.ReadWrite);
                            using var bw = new BinaryWriter(fs2);

                            w2rc.Write(bw);
                        }
                        else
                        {
                            throw new InvalidParsingException($"Could not parse {fileInfo.FullName}");
                        }

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
            _loggerService.Info($"Elapsed time: {watch.ElapsedMilliseconds.ToString()}ms.");
        }

        #endregion Methods
    }
}
