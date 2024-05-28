using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;

namespace CP77Tools.Tasks;

public record ExportTaskOptions
{
    public DirectoryInfo? outpath { get; init; }
    public string? gamepath { get; set; }
    public EUncookExtension? uext { get; init; }
    public ECookedFileFormat[]? forcebuffers { get; init; }
}

public partial class ConsoleFunctions
{
    public int ExportTask(FileSystemInfo[] path, ExportTaskOptions options)
    {
        if (path.Length < 1)
        {
            _loggerService.Warning("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (options.outpath == null || !options.outpath.Exists)
        {
            _loggerService.Error("Please fill in an output path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (!string.IsNullOrEmpty(options.gamepath) && Directory.Exists(options.gamepath))
        {
            var exePath = new FileInfo(Path.Combine(options.gamepath, "bin", "x64", "Cyberpunk2077.exe"));
            _archiveManager.LoadGameArchives(exePath);
        }

        var result = 0;
        Parallel.ForEach(path, file => result += ExportTaskInner(file, options));
        return result;
    }

    private int ExportTaskInner(FileSystemInfo path, ExportTaskOptions options)
    {
        #region checks

        if (path is null)
        {
            _loggerService.Warning("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }
        if (!path.Exists)
        {
            _loggerService.Error("Input path does not exist.");
            return ERROR_BAD_ARGUMENTS;
        }

        #endregion checks

        List<FileInfo> filesToExport;
        DirectoryInfo basedir;
        switch (path)
        {
            case FileInfo file:
                basedir = file.Directory.NotNull();
                filesToExport = new List<FileInfo> { file };
                break;
            case DirectoryInfo directory:
                basedir = directory;
                filesToExport = directory.GetFiles("*", SearchOption.AllDirectories).ToList();
                break;
            default:
                _loggerService.Error("Not a valid file or directory name.");
                return 1;
        }

        // create extract arguments
        var exportArgs = new GlobalExportArgs().Register(
            _xbmExportArgs.Value,
            _meshExportArgs.Value,
            _morphTargetExportArgs.Value,
            _mlmaskExportArgs.Value,
            _wemExportArgs.Value,
            _animationExportArgs.Value
        );

        if (options.uext != null)
        {
            exportArgs.Get<XbmExportArgs>().UncookExtension = options.uext.Value;
            exportArgs.Get<MlmaskExportArgs>().UncookExtension = options.uext.Value;
            exportArgs.Get<MeshExportArgs>().MaterialUncookExtension = options.uext.Value;
        }

        var result = 0;
        foreach (var fileInfo in filesToExport)
        {
            if (_modTools.Export(fileInfo, exportArgs, basedir, options.outpath, options.forcebuffers))
            {
                _loggerService.Success($"Successfully exported {path}.");
            }
            else
            {
                _loggerService.Error($"Failed to export {path}.");
                result += 1;
            }
        }

        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }
}
