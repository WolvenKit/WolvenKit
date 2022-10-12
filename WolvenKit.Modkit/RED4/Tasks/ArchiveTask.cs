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

        public void ArchiveTask(FileSystemInfo[] path, string pattern, string regex, bool diff, bool list)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Error("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file => ArchiveTaskInner(file, pattern, regex, diff, list));
        }

        private void ArchiveTaskInner(FileSystemInfo path, string pattern, string regex, bool diff, bool list)
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

            #endregion checks

            List<FileInfo> archiveFileInfos;
            switch (path)
            {
                case FileInfo file:
                    if (file.Extension != ".archive")
                    {
                        _loggerService.Error("Input file is not an .archive.");
                        return;
                    }
                    archiveFileInfos = new List<FileInfo> { file };

                    break;
                case DirectoryInfo directory:
                    archiveFileInfos = directory.GetFiles().Where(_ => _.Extension == ".archive").ToList();

                    if (archiveFileInfos.Count == 0)
                    {
                        _loggerService.Error("No .archive file to process in the input directory");
                        return;
                    }

                    break;
                default:
                    _loggerService.Error("Not a valid file or directory name.");
                    return;
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

                // serialize archive info
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
