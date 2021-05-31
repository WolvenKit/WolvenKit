using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WolvenKit.CLI;
//using Newtonsoft.Json;
using WolvenKit.Common.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using Formatting = Newtonsoft.Json.Formatting;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void Cr2wTask(string[] path, string outpath, bool chunks, string pattern, string regex)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
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
            _loggerService.Info($"Found {finalMatchesList.Count} files to dump.");

            Thread.Sleep(1000);
            int progress = 0;
            Parallel.ForEach(finalMatchesList, fileInfo =>
            {
                var outputDirInfo = string.IsNullOrEmpty(outpath)
                    ? fileInfo.Directory
                    : new DirectoryInfo(outpath);
                if (outputDirInfo == null || !outputDirInfo.Exists)
                {
                    _loggerService.Error("Invalid output directory.");
                    return;
                }

                if (chunks)
                {
                    using var fs = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
                    var cr2w = _modTools.TryReadCr2WFile(fs);
                    if (cr2w == null)
                    {
                        return;
                    }

                    var ojson =
                        JsonConvert.SerializeObject(
                            cr2w,
                            Formatting.Indented,
                            new JsonSerializerSettings { ContractResolver = new CVarContractResolver() }
                        );
                    File.WriteAllText(Path.Combine(outputDirInfo.FullName, $"{fileInfo.Name}.o.json"), ojson);


                    var dto = new Red4W2rcFileDto().FromW2rc(cr2w);
                    var json =
                            JsonConvert.SerializeObject(
                                dto,
                                Formatting.Indented
                            );
                    File.WriteAllText(Path.Combine(outputDirInfo.FullName, $"{fileInfo.Name}.json"), json);

                    var doc = JsonConvert.DeserializeXmlNode(json, Red4W2rcFileDto.Magic);
                    doc.Save(Path.Combine(outputDirInfo.FullName, $"{fileInfo.Name}.xml"));


                    // dbg

                    var newdto = JsonConvert.DeserializeObject<Red4W2rcFileDto>(json);

                }

                Interlocked.Increment(ref progress);
            });

            watch.Stop();
            _loggerService.Success(
                $"Finished. Dumped {finalMatchesList.Count} files to JSON in {watch.ElapsedMilliseconds.ToString()}ms.");
        }

        #endregion Methods
    }
}
