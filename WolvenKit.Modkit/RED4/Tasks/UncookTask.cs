using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void UncookTask(string[] path, string outpath, string rawOutDir,
            EUncookExtension? uext, bool? flip, ulong hash, string pattern, string regex, bool unbundle,
            ECookedFileFormat[] forcebuffers, bool? serialize)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            foreach (var file in path)
            {
                UncookTaskInner(file, outpath, rawOutDir, uext, flip, hash, pattern, regex, unbundle, forcebuffers, serialize);
            }
        }

        private void UncookTaskInner(string path, string outpath, string rawOutDir,
            EUncookExtension? uext, bool? flip, ulong hash, string pattern, string regex, bool unbundle,
            ECookedFileFormat[] forcebuffers, bool? serialize)
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

            List<FileInfo> archiveFileInfos;
            if (isDirectory)
            {
                _archiveManager.LoadFromFolder(basedir);
                archiveFileInfos = _archiveManager.Archives.Items.Select(_ => new FileInfo(_.ArchiveAbsolutePath)).ToList();
            }
            else
            {
                archiveFileInfos = new List<FileInfo> { inputFileInfo };
            }

            foreach (var fileInfo in archiveFileInfos)
            {
                // get outdirectory
                DirectoryInfo outDir;
                if (string.IsNullOrEmpty(outpath))
                {
                    outDir = new DirectoryInfo(basedir.FullName);
                }
                else
                {
                    outDir = new DirectoryInfo(outpath);
                    if (!outDir.Exists)
                    {
                        outDir = new DirectoryInfo(outpath);
                    }
                }

                DirectoryInfo rawOutDirInfo = null;
                if (string.IsNullOrEmpty(rawOutDir))
                {
                    rawOutDirInfo = outDir;
                }
                else
                {
                    rawOutDirInfo = new DirectoryInfo(rawOutDir);
                    if (!rawOutDirInfo.Exists)
                    {
                        rawOutDirInfo = new DirectoryInfo(rawOutDir);
                    }
                }

                // read archive
                var ar = _wolvenkitFileService.ReadRed4Archive(fileInfo.FullName, _hashService);

                // run
                if (hash != 0)
                {
                    _modTools.UncookSingle(ar, hash, outDir, exportArgs, rawOutDirInfo, forcebuffers, serialize ?? false);
                    _loggerService.Success($" {ar.ArchiveAbsolutePath}: Uncooked one file: {hash}");
                }
                else
                {
                    _modTools.UncookAll(ar, outDir, exportArgs, unbundle, pattern, regex, rawOutDirInfo, forcebuffers, serialize ?? false);
                }
            }

            return;
        }

        #endregion Methods
    }
}
