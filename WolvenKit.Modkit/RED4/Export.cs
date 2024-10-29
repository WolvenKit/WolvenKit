using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        /// <summary>
        /// Exports (Uncooks) a physical REDengine file into its raw file
        /// </summary>
        /// <param name="cr2wFile"></param>
        /// <param name="args"></param>
        /// <param name="basedir"></param>
        /// <param name="rawOutDir"></param>
        /// <param name="forceBuffers"></param>
        public bool Export(FileInfo cr2wFile, GlobalExportArgs args, DirectoryInfo basedir,
            DirectoryInfo? rawOutDir = null, ECookedFileFormat[]? forceBuffers = null)
        {
            try
            {
                if (cr2wFile is null or { Exists: false })
                {
                    return false;
                }
                if (cr2wFile.Directory is { Exists: false })
                {
                    return false;
                }

                // if no basedir is supplied use the file directory
                if (basedir is not { Exists: true })
                {
                    basedir = cr2wFile.Directory.NotNull();
                }
                if (rawOutDir is not { Exists: true })
                {
                    rawOutDir = cr2wFile.Directory.NotNull();
                }

                if (!cr2wFile.FullName.Contains(basedir.FullName))
                {
                    return false;
                }

                var ext = Path.GetExtension(cr2wFile.FullName).TrimStart('.');

                // read file
                using var fs = new FileStream(cr2wFile.FullName, FileMode.Open, FileAccess.Read);
                using var br = new BinaryReader(fs);

                args.Get<WemExportArgs>().FileName = cr2wFile.FullName;

                var relPath = cr2wFile.FullName.RelativePath(basedir);

                var ret = UncookBuffers(fs, relPath, args, rawOutDir, forceBuffers);

                if (args.Get<MorphTargetExportArgs>() is { ExportTextures: true, ExportMeshRelativePath: not null } morphtargetArgs)
                {
                    ret = ret && ExportMeshMaterial(cr2wFile, morphtargetArgs, basedir, rawOutDir, forceBuffers);
                }

                return ret;

            }
            catch(System.Exception e)
            {
                _loggerService.Error($"Failed to export {cr2wFile?.Name}: {e.Message}");
                _loggerService.Debug(e.ToString());
                return false;
            }
        }

        private static readonly string s_archiveDirWithSeparators = Path.DirectorySeparatorChar + "archive" + Path.DirectorySeparatorChar;
        private static readonly string s_rawDirWithSeparators = Path.DirectorySeparatorChar + "raw" + Path.DirectorySeparatorChar;

        private bool ExportMeshMaterial(FileInfo cr2WFile, MorphTargetExportArgs morphtargetArgs,
            DirectoryInfo basedir, DirectoryInfo rawOutDir, ECookedFileFormat[]? forceBuffers)
        {
            if (morphtargetArgs.ExportMeshRelativePath is null)
            {
                return false;
            }

            var absoluteMeshPath = Path.Join(basedir.FullName, morphtargetArgs.ExportMeshRelativePath);

            if (!Export(new FileInfo(absoluteMeshPath), new GlobalExportArgs(), basedir, rawOutDir, forceBuffers))
            {
                return false;
            }

            var jsonMaterialSourcePath = Path.Join(rawOutDir.FullName, morphtargetArgs.ExportMeshRelativePath)
                .Replace(".mesh", ".Material.json");

            var absoluteMorphtargetPath = cr2WFile.FullName;
            var jsonMaterialTargetPath = absoluteMorphtargetPath
                .Replace(s_archiveDirWithSeparators, s_rawDirWithSeparators)
                .Replace(".morphtarget", ".morphtarget.Material.json");

            if (!File.Exists(jsonMaterialSourcePath))
            {
                return false;
            }

            File.Move(jsonMaterialSourcePath, jsonMaterialTargetPath, true);

            if (!morphtargetArgs.DeleteMeshFileAfterExport || !File.Exists(absoluteMeshPath))
            {
                return true;
            }

            // Now clean up mesh files (if necessary)
            File.Delete(absoluteMeshPath);
            DeleteEmptyParentDir(absoluteMeshPath);

            return true;
        }

        private static void DeleteEmptyParentDir(string fileOrDirectoryName)
        {
            if (Path.GetDirectoryName(fileOrDirectoryName) is not string parentDir || !Directory.Exists(parentDir) ||
                Directory.GetFiles(parentDir).Length > 0)
            {
                return;
            }

            Directory.Delete(parentDir);
            DeleteEmptyParentDir(parentDir);
        }
    }
}
