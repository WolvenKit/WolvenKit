using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks;

public record UncookTaskOptions
{
    public DirectoryInfo? outpath { get; init; }
    public string? rawOutDir { get; init; }
    public EUncookExtension? uext { get; init; }
    public ulong hash { get; init; }
    public string? pattern { get; init; }
    public string? regex { get; init; }
    public bool unbundle { get; init; }
    public ECookedFileFormat[]? forcebuffers { get; init; }
    public bool? serialize { get; init; }
    public MeshExportType? meshExportType { get; init; }
    public string? meshExportMaterialRepo { get; init; }
    public bool? meshExportLodFilter { get; init; }
    public bool? meshExportExperimentalMergedExport { get; init; }
}

public partial class ConsoleFunctions
{
    public int UncookTask(FileSystemInfo[] path, UncookTaskOptions options)
    {
        if (path == null || path.Length < 1)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        var result = 0;
        foreach (var file in path)
        {
            result += UncookTaskInner(file, options);
        }
        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }

    private int UncookTaskInner(FileSystemInfo path, UncookTaskOptions options)
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

        if (options.meshExportType != null && string.IsNullOrEmpty(options.meshExportMaterialRepo) && options.outpath is null)
        {
            _loggerService.Error("When using --mesh-export-type, the --outpath or the --mesh-export-material-repo must be specified.");
            return ERROR_INVALID_COMMAND_LINE;
        }

        #endregion checks

        DirectoryInfo basedir;
        switch (path)
        {
            case FileInfo file:
                if (file.Extension != ".archive")
                {
                    _loggerService.Error("Input file is not an .archive.");
                    return ERROR_BAD_ARGUMENTS;
                }
                _archiveManager.LoadArchive(file.FullName);
                basedir = file.Directory.NotNull();
                break;
            case DirectoryInfo directory:
                var archiveFileInfos = directory.GetFiles().Where(_ => _.Extension == ".archive").ToList();
                if (archiveFileInfos.Count == 0)
                {
                    _loggerService.Error("No .archive file to process in the input directory");
                    return ERROR_BAD_ARGUMENTS;
                }
                _archiveManager.LoadFromFolder(directory);
                basedir = directory;
                break;
            default:
                _loggerService.Error("Not a valid file or directory name.");
                return ERROR_BAD_ARGUMENTS;
        }

        // get outdirectory
        DirectoryInfo outDir;
        if (options.outpath is null)
        {
            outDir = new DirectoryInfo(basedir.FullName);
        }
        else
        {
            outDir = options.outpath;
            if (!outDir.Exists)
            {
                outDir = Directory.CreateDirectory(options.outpath.FullName);
            }
        }

        DirectoryInfo? rawOutDirInfo = null;
        if (string.IsNullOrEmpty(options.rawOutDir))
        {
            rawOutDirInfo = outDir;
        }
        else
        {
            rawOutDirInfo = new DirectoryInfo(options.rawOutDir);
            if (!rawOutDirInfo.Exists)
            {
                rawOutDirInfo = new DirectoryInfo(options.rawOutDir);
            }
        }

        var exportArgs = new GlobalExportArgs().Register(
            _xbmExportArgs.Value,
            _meshExportArgs.Value,
            _morphTargetExportArgs.Value,
            _mlmaskExportArgs.Value,
            _wemExportArgs.Value
        );

        if (options.uext != null)
        {
            exportArgs.Get<XbmExportArgs>().UncookExtension = options.uext.Value;
            exportArgs.Get<MlmaskExportArgs>().UncookExtension = options.uext.Value;
            exportArgs.Get<MeshExportArgs>().MaterialUncookExtension = options.uext.Value;
        }

        if (options.meshExportType != null)
        {
            exportArgs.Get<MeshExportArgs>().meshExportType = options.meshExportType.Value;
        }

        if (options.meshExportExperimentalMergedExport == true)
        {
            exportArgs.Get<MeshExportArgs>().ExperimentalMergedExport = true;
        }

        if (options.meshExportLodFilter == true)
        {
            exportArgs.Get<MeshExportArgs>().LodFilter = true;
        }

        exportArgs.Get<GeneralExportArgs>().MaterialRepositoryPath = string.IsNullOrEmpty(options.meshExportMaterialRepo) ? outDir.FullName : options.meshExportMaterialRepo;
        exportArgs.Get<MeshExportArgs>().MaterialRepo = string.IsNullOrEmpty(options.meshExportMaterialRepo) ? outDir.FullName : options.meshExportMaterialRepo;

        var result = 0;
        foreach (var gameArchive in _archiveManager.Archives.Items)
        {
            // TODO[ModKit]
            if (gameArchive is not ICyberGameArchive ar)
            {
                continue;
            }

            if (options.hash != 0)
            {
                if (_modTools.UncookSingle(ar, options.hash, outDir, exportArgs, rawOutDirInfo, options.forcebuffers, options.serialize ?? false))
                {
                    _loggerService.Success($" {ar.ArchiveAbsolutePath}: Uncooked file: {options.hash}");
                }
                else
                {
                    _loggerService.Warning($" {ar.ArchiveAbsolutePath}: Failed to uncook file: {options.hash}");
                    result += 1;
                }
            }
            else
            {
                // TODO return success
                _modTools.UncookAll(ar, outDir, exportArgs, options.unbundle, options.pattern, options.regex, rawOutDirInfo, options.forcebuffers, options.serialize ?? false);
            }
        }

        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }
}
