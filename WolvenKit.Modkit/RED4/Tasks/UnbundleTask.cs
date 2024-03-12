using System.IO;
using System.Linq;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks;

public record UnbundleTaskOptions
{
    public DirectoryInfo? outpath { get; init; }
    public string? gamepath { get; set; }
    public string? hash { get; init; }
    public string? pattern { get; init; }
    public string? regex { get; init; }
    public bool DEBUG_decompress { get; init; }
}

public partial class ConsoleFunctions
{
    public int UnbundleTask(FileSystemInfo[] paths, UnbundleTaskOptions options)
    {
        if (paths.Length < 1 && string.IsNullOrEmpty(options.gamepath))
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (options.outpath == null)
        {
            _loggerService.Error("Please fill in an output path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (!string.IsNullOrEmpty(options.gamepath) && Directory.Exists(options.gamepath))
        {
            var exePath = new FileInfo(Path.Combine(options.gamepath, "bin", "x64", "Cyberpunk2077.exe"));
            _archiveManager.LoadGameArchives(exePath, false);
        }

        var result = 0;
        foreach (var path in paths)
        {
            if (!path.Exists)
            {
                _loggerService.Error($"\"{path.FullName}\" could not be found!");
                result += ERROR_BAD_ARGUMENTS;
                continue;
            }

            switch (path)
            {
                case FileInfo file:
                    if (file.Extension != ".archive")
                    {
                        _loggerService.Error("Input file is not an .archive.");
                        return ERROR_BAD_ARGUMENTS;
                    }
                    _archiveManager.LoadModArchive(file.FullName);
                    break;
                case DirectoryInfo directory:
                    var archiveFileInfos = directory.GetFiles().Where(_ => _.Extension == ".archive").ToList();
                    if (archiveFileInfos.Count == 0)
                    {
                        _loggerService.Error("No .archive file to process in the input directory");
                        return ERROR_BAD_ARGUMENTS;
                    }
                    _archiveManager.LoadAdditionalModArchives(directory.FullName, false);
                    break;
                default:
                    _loggerService.Error($"\"{path.FullName}\" is not a valid file or directory name.");
                    break;
            }
        }

        result += UnbundleTaskInner(options);
        
        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }

    private int UnbundleTaskInner(UnbundleTaskOptions options)
    {
        // get outdirectory
        var outDir = options.outpath!;
        if (!outDir.Exists)
        {
            outDir = Directory.CreateDirectory(outDir.FullName);
        }

        var result = 0;
        foreach (var gameArchive in _archiveManager.Archives.Items)
        {
            // TODO[ModKit]
            if (gameArchive is not Archive ar)
            {
                continue;
            }

            var isHash = ulong.TryParse(options.hash, out var hashNumber);

            // run
            if (!isHash && File.Exists(options.hash))
            {
                var hashlist = File.ReadAllLines(options.hash)
                    .ToList().Select(_ => ulong.TryParse(_, out var res) ? res : 0);
                _loggerService.Info($"Extracing all files from the hashlist ({hashlist.Count()}hashes) ...");

                foreach (var hashNum in hashlist)
                {
                    var r = ModTools.ExtractSingle(ar, hashNum, outDir, options.DEBUG_decompress);
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
                var r = ModTools.ExtractSingle(ar, hashNumber, outDir, options.DEBUG_decompress);
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
                _modTools.ExtractAll(ar, outDir, options.pattern, options.regex, options.DEBUG_decompress);
            }
        }

        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }
}
