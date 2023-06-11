using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.Scripting;

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

                _hookService.OnExport();
                return UncookBuffers(fs, relPath, args, rawOutDir, forceBuffers);
            }
            catch(System.Exception e)
            {
                _loggerService.Error($"Failed to export {cr2wFile?.Name}: {e.Message}");
                _loggerService.Debug(e.ToString());
                return false;
            }
        }
    }
}
