using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;

namespace CP77Tools.Tasks
{
    public record UncookTaskOptions
    {
        public DirectoryInfo outpath { get; init; }
        public string rawOutDir { get; init; }
        public EUncookExtension? uext { get; init; }
        public bool? flip { get; init; }
        public ulong hash { get; init; }
        public string pattern { get; init; }
        public string regex { get; init; }
        public bool unbundle { get; init; }
        public ECookedFileFormat[] forcebuffers { get; init; }
        public bool? serialize { get; init; }
        public MeshExportType? meshExportType { get; init; }
        public string meshExportMaterialRepo { get; init; }
    }

    public partial class ConsoleFunctions
    {
        public void UncookTask(string[] path, UncookTaskOptions options)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            foreach (var file in path)
            {
                UncookTaskInner(file, options);
            }
        }

        private void UncookTaskInner(string path, UncookTaskOptions options)
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

            if (options.meshExportType != null && string.IsNullOrEmpty(options.meshExportMaterialRepo) && options.outpath is null)
            {
                _loggerService.Warning("When using --mesh-export-type, the --outpath or the --mesh-export-material-repo must be specified.");
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
            if (options.flip != null)
            {
                exportArgs.Get<XbmExportArgs>().Flip = options.flip.Value;
            }
            if (options.uext != null)
            {
                exportArgs.Get<XbmExportArgs>().UncookExtension = options.uext.Value;
                exportArgs.Get<MlmaskExportArgs>().UncookExtension = options.uext.Value;
            }
            if (options.meshExportType != null)
            {
                exportArgs.Get<MeshExportArgs>().meshExportType = options.meshExportType.Value;
                exportArgs.Get<MeshExportArgs>().MaterialRepo = string.IsNullOrEmpty(options.meshExportMaterialRepo) ? options.outpath.FullName : options.meshExportMaterialRepo;
                exportArgs.Get<MeshExportArgs>().ArchiveDepot = basedir.FullName;
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

                DirectoryInfo rawOutDirInfo = null;
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

                // read archive
                var ar = _wolvenkitFileService.ReadRed4Archive(fileInfo.FullName, _hashService);

                // run
                if (options.hash != 0)
                {
                    _modTools.UncookSingle(ar, options.hash, outDir, exportArgs, rawOutDirInfo, options.forcebuffers, options.serialize ?? false);
                    _loggerService.Success($" {ar.ArchiveAbsolutePath}: Uncooked one file: {options.hash}");
                }
                else
                {
                    _modTools.UncookAll(ar, outDir, exportArgs, options.unbundle, options.pattern, options.regex, rawOutDirInfo, options.forcebuffers, options.serialize ?? false);
                }
            }

            return;
        }
    }
}
