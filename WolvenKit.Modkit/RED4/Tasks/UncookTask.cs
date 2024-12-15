using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks;

public record UncookTaskOptions
{
    public DirectoryInfo? outpath { get; set; }
    public DirectoryInfo? gamepath { get; set; }
    public DirectoryInfo? raw { get; set; }
    public string? pattern { get; init; }
    public string? regex { get; init; }
    public EUncookExtension? uext { get; init; }
    public ulong hash { get; init; }
    public bool unbundle { get; init; }
    public ECookedFileFormat[]? forcebuffers { get; init; }
    public bool? serialize { get; init; }
    public MeshExporterType? meshExporterType { get; init; }
    public MeshExportType? meshExportType { get; init; }
    public string? meshExportMaterialRepo { get; init; }
    public bool? meshExportLodFilter { get; init; }
    public bool? meshExportExperimentalMergedExport { get; init; }
    public List<uint>? opusHashes { get; set; }
    public bool? opusExportAll { get; set; }
}

public partial class ConsoleFunctions
{
    public int UncookTask(FileSystemInfo[] paths, UncookTaskOptions options)
    {
        if (paths.Length < 1 && options.gamepath == null)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (options.outpath == null)
        {
            _loggerService.Error("Please fill in an output path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (options.meshExportType != null && string.IsNullOrEmpty(options.meshExportMaterialRepo))
        {
            _loggerService.Error("When using --mesh-export-type, the --outpath or the --mesh-export-material-repo must be specified.");
            return ERROR_INVALID_COMMAND_LINE;
        }

        if (options.gamepath is { Exists: true })
        {
            var exePath = new FileInfo(Path.Combine(options.gamepath.ToString(), "bin", "x64", "Cyberpunk2077.exe"));
            _archiveManager.LoadGameArchives(exePath);
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
                    _archiveManager.LoadModArchive(file.FullName, false);
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

        result += UncookTaskInner(options);

        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }

    private int UncookTaskInner(UncookTaskOptions options)
    {
        // get outdirectory
        var outDir = options.outpath!;
        if (!outDir.Exists)
        {
            outDir = Directory.CreateDirectory(outDir.FullName);
        }

        var rawOutDirInfo = options.raw ?? outDir;
        if (!rawOutDirInfo.Exists)
        {
            rawOutDirInfo = Directory.CreateDirectory(rawOutDirInfo.FullName);
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

        if (options.meshExporterType != null)
        {
            if (options.meshExporterType == MeshExporterType.REDmod)
            {
                _loggerService.Error("When using --mesh-exporter-type REDMod isn't supported");
                return ERROR_BAD_ARGUMENTS;
            }

            exportArgs.Get<MeshExportArgs>().MeshExporter = options.meshExporterType.Value;
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

        exportArgs.Get<OpusExportArgs>().UseMod = true;
        exportArgs.Get<OpusExportArgs>().SelectedForExport = options.opusHashes ?? [];
        exportArgs.Get<OpusExportArgs>().ExportAll = options.opusExportAll ?? false;

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
