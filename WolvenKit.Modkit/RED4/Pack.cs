using System.IO;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    ///     Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        /// <summary>
        ///     Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <param name="outpath"></param>
        /// <param name="modname">Optional archivename</param>
        /// <returns></returns>
        public bool Pack(DirectoryInfo infolder, DirectoryInfo outpath, string? modname = null)
        {
            if (!infolder.Exists)
            {
                _loggerService.Error($"Could not pack archive from {infolder}");
                return false;
            }

            if (!outpath.Exists)
            {
                _loggerService.Error($"Could not pack archive to {outpath}");
                return false;
            }

            var outFile = Path.Combine(outpath.FullName, $"{infolder.Name}.archive");
            if (modname != null)
            {
                outFile = Path.Combine(outpath.FullName, $"{modname}.archive");
            }
            var tmpFile = Path.ChangeExtension(outFile, "tmp");

            if (!FileHelper.SafeDelete(tmpFile, _loggerService) || !FileHelper.SafeDelete(outFile, _loggerService))
            {
                return false;
            }

            bool success;
            using (var fs = File.Create(tmpFile))
            {
                ArchiveWriter writer = new(_hashService, _loggerService);
                success = writer.WriteArchive(infolder, fs);
            }

            if (!success)
            {
                _loggerService.Error("Could not pack archive");

                FileHelper.SafeDelete(tmpFile);
                return false;
            }

            var moveSuccess = FileHelper.SafeMove(tmpFile, outFile, _loggerService);
            
            FileHelper.SafeDelete(tmpFile);

            if (!moveSuccess)
            {
                return false;
            }

            _loggerService.Success($"Finished packing {outFile}.");
            return true;
        }
    }
}
