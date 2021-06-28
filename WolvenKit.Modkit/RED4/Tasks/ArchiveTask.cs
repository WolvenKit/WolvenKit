using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77.CR2W;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void ArchiveTask(string[] path, string pattern, string regex, bool diff, bool list)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file =>
            {
                ArchiveTaskInner(file, pattern, regex, diff, list);
            });
        }

        private void ArchiveTaskInner(string path, string pattern, string regex, bool diff, bool list)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                _loggerService.Warning("Input path does not exist.");
                return;
            }

            if (inputFileInfo.Exists && inputFileInfo.Extension != ".archive")
            {
                _loggerService.Warning("Input file is not an .archive.");
                return;
            }
            else if (inputDirInfo.Exists && inputDirInfo.GetFiles().All(_ => _.Extension != ".archive"))
            {
                _loggerService.Warning("No .archive file to process in the input directory");
                return;
            }

            var isDirectory = !inputFileInfo.Exists;
            var basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;

            #endregion checks

            List<FileInfo> archiveFileInfos;
            if (isDirectory)
            {
                var archiveManager = new ArchiveManager(_hashService);
                archiveManager.LoadFromFolder(basedir.FullName);
                // TODO: use the manager here?
                archiveFileInfos = archiveManager.Archives.Select(_ => new FileInfo(_.Value.ArchiveAbsolutePath)).ToList();
            }
            else
            {
                archiveFileInfos = new List<FileInfo> { inputFileInfo };
            }

            foreach (var processedarchive in archiveFileInfos)
            {
                // read archive
                var ar = Red4ParserServiceExtensions.ReadArchive(processedarchive.FullName, _hashService);

                // run

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

                // list files in archive
                if (list)
                {
                    foreach (var finalmatch in finalmatches)
                    {
                        Console.WriteLine(finalmatch.Name);
                    }
                }

                //
                if (diff)
                {
                    var json = JsonConvert.SerializeObject(ar, Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.None,
                            TypeNameHandling = TypeNameHandling.None
                        });
                    Console.Write(json);
                }
            }

            return;
        }

        #endregion Methods
    }
}
