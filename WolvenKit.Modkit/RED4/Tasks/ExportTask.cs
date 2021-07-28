using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W.Archive;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void ExportTask(string[] path, string outDir, EUncookExtension? uncookext, bool? flip, ECookedFileFormat[] forcebuffers)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file =>
            {
                ExportTaskInner(file, outDir, uncookext, flip, forcebuffers);
            });
        }

        private void ExportTaskInner(string path, string outDir, EUncookExtension? uext, bool? flip, ECookedFileFormat[] forcebuffers)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            if (!string.IsNullOrEmpty(outDir) && !Directory.Exists(outDir))
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
                _wemExportArgs.Value
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
                var bm = new ArchiveManager(_hashService);
                bm.LoadFromFolder(new DirectoryInfo(archiveDepot));
                exportArgs.Get<MeshExportArgs>().Archives = bm.Archives.Values.Cast<Archive>().ToList();
                exportArgs.Get<MorphTargetExportArgs>().Archives = bm.Archives.Values.Cast<Archive>().ToList();
            }

            foreach (var fileInfo in filesToExport)
            {
                if (!Enum.TryParse(inputFileInfo.Extension.TrimStart('.'), true, out ECookedFileFormat extAsEnum))
                {
                    continue;
                }

                var di = string.IsNullOrEmpty(outDir) ? null : new DirectoryInfo(outDir);
                if (_modTools.Export(fileInfo, exportArgs, basedir, di, forcebuffers))
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
