using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public int UnbundleTask(FileSystemInfo[] path, DirectoryInfo outpath,
        string hash, string pattern, string regex, bool DEBUG_decompress = false)
    {
        if (path == null || path.Length < 1)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        var result = 0;
        foreach (var file in path)
        {
            result += UnbundleTaskInner(file, outpath, hash, pattern, regex, DEBUG_decompress);
        }
        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }

    private int UnbundleTaskInner(FileSystemInfo path, DirectoryInfo outpath,
        string hash, string pattern, string regex, bool DEBUG_decompress = false)
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

        #endregion checks

        DirectoryInfo basedir;
        List<FileInfo> archiveFileInfos;
        switch (path)
        {
            case FileInfo file:
                if (file.Extension != ".archive")
                {
                    _loggerService.Error("Input file is not an .archive.");
                    return ERROR_BAD_ARGUMENTS;
                }
                archiveFileInfos = new List<FileInfo> { file };
                basedir = file.Directory.NotNull();
                break;
            case DirectoryInfo directory:
                archiveFileInfos = directory.GetFiles().Where(_ => _.Extension == ".archive").ToList();
                if (archiveFileInfos.Count == 0)
                {
                    _loggerService.Error("No .archive file to process in the input directory");
                    return ERROR_BAD_ARGUMENTS;
                }
                basedir = directory;
                break;
            default:
                _loggerService.Error("Not a valid file or directory name.");
                return ERROR_BAD_ARGUMENTS;
        }

        // get outdirectory
        DirectoryInfo outDir;
        if (outpath is null)
        {
            outDir = new DirectoryInfo(basedir.FullName);
        }
        else
        {
            outDir = outpath;
            if (!outDir.Exists)
            {
                outDir = Directory.CreateDirectory(outpath.FullName);
            }
        }

        var result = 0;
        foreach (var fileInfo in archiveFileInfos)
        {
            // read archive
            var ar = _wolvenkitFileService.ReadRed4Archive(fileInfo.FullName, _hashService);
            if (ar is null)
            {
                _loggerService.Error($"Could not parse archive {fileInfo}");
                continue;
            }

            var isHash = ulong.TryParse(hash, out var hashNumber);

            // run
            if (!isHash && File.Exists(hash))
            {
                var hashlist = File.ReadAllLines(hash)
                    .ToList().Select(_ => ulong.TryParse(_, out var res) ? res : 0);
                _loggerService.Info($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...");

                foreach (var hashNum in hashlist)
                {
                    var r = ModTools.ExtractSingle(ar, hashNum, outDir, DEBUG_decompress);
                    if (r > 0)
                    {
                        _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNum}");
                    }
                    else
                    {
                        _loggerService.Info($" {ar.ArchiveAbsolutePath}: No file found with hash {hashNum}");
                        result += 1;
                    }
                }

                ar.ReleaseFileHandle();

                _loggerService.Success($"Bulk extraction from hashlist file completed.");
            }
            else if (isHash && hashNumber != 0)
            {
                var r = ModTools.ExtractSingle(ar, hashNumber, outDir, DEBUG_decompress);
                if (r > 0)
                {
                    _loggerService.Success($" {ar.ArchiveAbsolutePath}: Extracted one file: {hashNumber}");
                }
                else
                {
                    _loggerService.Info($" {ar.ArchiveAbsolutePath}: No file found with hash {hashNumber}");
                    result += 1;
                }
            }
            else
            {
                // TODO return success 
                _modTools.ExtractAll(ar, outDir, pattern, regex, DEBUG_decompress);
            }
        }

        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }
}
