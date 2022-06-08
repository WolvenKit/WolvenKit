using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;

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

            Parallel.ForEach(path, file => ArchiveTaskInner(file, pattern, regex, diff, list));
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
                _archiveManager.LoadFromFolder(basedir);
                // TODO: use the manager here?
                archiveFileInfos = _archiveManager.Archives.Items.Select(_ => new FileInfo(_.ArchiveAbsolutePath)).ToList();
            }
            else
            {
                archiveFileInfos = new List<FileInfo> { inputFileInfo };
            }

            foreach (var processedarchive in archiveFileInfos)
            {
                // read archive
                var ar = _wolvenkitFileService.ReadRed4Archive(processedarchive.FullName, _hashService);

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
                    var json = JsonSerializer.Serialize(ar, new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    });

                    Console.Write(json);
                }
            }

            return;
        }

        #endregion Methods
    }
}
