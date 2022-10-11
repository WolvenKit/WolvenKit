using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void ExportTask(string[] path, DirectoryInfo outDir, EUncookExtension? uncookext, bool? flip, ECookedFileFormat[] forcebuffers)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file => ExportTaskInner(file, outDir, uncookext, flip, forcebuffers));
        }

        private void ExportTaskInner(string path, DirectoryInfo outDir, EUncookExtension? uext, bool? flip, ECookedFileFormat[] forcebuffers)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            if (outDir is not null && !outDir.Exists)
            {
                _loggerService.Warning("Please fill in a valid outdirectory path.");
                return;
            }

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                _loggerService.Warning("Input path does not exist.");
                return;
            }

            var isDirectory = !inputFileInfo.Exists;
            var basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;

            #endregion checks


            var filesToExport = isDirectory
                ? inputDirInfo.GetFiles("*", SearchOption.AllDirectories).ToList()
                : new List<FileInfo> { inputFileInfo };

            // create extract arguments
            var exportArgs = new GlobalExportArgs().Register(
                _xbmExportArgs.Value,
                _meshExportArgs.Value,
                _morphTargetExportArgs.Value,
                _mlmaskExportArgs.Value,
                _wemExportArgs.Value,
                _animationExportArgs.Value
            );
            if (flip != null)
            {
                exportArgs.Get<XbmExportArgs>().Flip = flip.Value;
            }
            if (uext != null)
            {
                exportArgs.Get<XbmExportArgs>().UncookExtension = uext.Value;
                exportArgs.Get<MlmaskExportArgs>().UncookExtension = uext.Value;
            }

            var archiveDepot = exportArgs.Get<MeshExportArgs>().ArchiveDepot;
            if (!string.IsNullOrEmpty(archiveDepot) && Directory.Exists(archiveDepot))
            {
                _archiveManager.LoadFromFolder(new DirectoryInfo(archiveDepot));
                exportArgs.Get<MeshExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                exportArgs.Get<MorphTargetExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                exportArgs.Get<AnimationExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
            }
            else
            {
                archiveDepot = exportArgs.Get<MorphTargetExportArgs>().ArchiveDepot;
                if (!string.IsNullOrEmpty(archiveDepot) && Directory.Exists(archiveDepot))
                {
                    _archiveManager.LoadFromFolder(new DirectoryInfo(archiveDepot));
                    exportArgs.Get<MeshExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                    exportArgs.Get<MorphTargetExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                    exportArgs.Get<AnimationExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
                else
                {
                    archiveDepot = exportArgs.Get<AnimationExportArgs>().ArchiveDepot;
                    if (!string.IsNullOrEmpty(archiveDepot) && Directory.Exists(archiveDepot))
                    {
                        _archiveManager.LoadFromFolder(new DirectoryInfo(archiveDepot));
                        exportArgs.Get<MeshExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                        exportArgs.Get<MorphTargetExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                        exportArgs.Get<AnimationExportArgs>().Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                    }
                }
            }

            foreach (var fileInfo in filesToExport)
            {
                if (_modTools.Export(fileInfo, exportArgs, basedir, outDir, forcebuffers))
                {
                    _loggerService.Success($"Successfully exported {path}.");
                }
                else
                {
                    _loggerService.Error($"Failed to export {path}.");
                }
            }

            return;
        }

        #endregion Methods
    }
}
