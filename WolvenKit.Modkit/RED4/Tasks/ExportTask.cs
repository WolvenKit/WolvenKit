using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public int ExportTask(FileSystemInfo[] path, DirectoryInfo outDir, EUncookExtension? uncookext, ECookedFileFormat[] forcebuffers)
    {
        if (path == null || path.Length < 1)
        {
            _loggerService.Warning("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        var result = 0;
        Parallel.ForEach(path, file => result += ExportTaskInner(file, outDir, uncookext, forcebuffers));
        return result;
    }

    private int ExportTaskInner(FileSystemInfo path, DirectoryInfo outDir, EUncookExtension? uext, ECookedFileFormat[] forcebuffers)
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
        if (outDir is not null && !outDir.Exists)
        {
            _loggerService.Warning("Please fill in a valid outdirectory path.");
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

        if (uext != null)
        {
            exportArgs.Get<XbmExportArgs>().UncookExtension = uext.Value;
            exportArgs.Get<MlmaskExportArgs>().UncookExtension = uext.Value;
            exportArgs.Get<MeshExportArgs>().MaterialUncookExtension = uext.Value;
        }

        var archiveDepot = exportArgs.Get<MeshExportArgs>().ArchiveDepot;
        if (!string.IsNullOrEmpty(archiveDepot) && Directory.Exists(archiveDepot))
        {
            _archiveManager.LoadFromFolder(new DirectoryInfo(archiveDepot));
        }
        else
        {
            archiveDepot = exportArgs.Get<MorphTargetExportArgs>().ArchiveDepot;
            if (!string.IsNullOrEmpty(archiveDepot) && Directory.Exists(archiveDepot))
            {
                _archiveManager.LoadFromFolder(new DirectoryInfo(archiveDepot));
            }
            else
            {
                archiveDepot = exportArgs.Get<AnimationExportArgs>().ArchiveDepot;
                if (!string.IsNullOrEmpty(archiveDepot) && Directory.Exists(archiveDepot))
                {
                    _archiveManager.LoadFromFolder(new DirectoryInfo(archiveDepot));
                }
            }
        }

        var result = 0;
        foreach (var fileInfo in filesToExport)
        {
            if (_modTools.Export(fileInfo, exportArgs, basedir, outDir, forcebuffers))
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
