using System.IO;
using WolvenKit.Helpers;
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

            ArchiveWriter writer = new(_hashService, _loggerService);


            var ms = new MemoryStream();
            var archive = writer.WriteArchive(infolder, ms);
            if (!archive)
            {
                _loggerService.Error($"Could not pack archive");
                return false;
            }

            var outfile = Path.Combine(outpath.FullName, $"{infolder.Name}.archive");
            if (modname != null)
            {
                outfile = Path.Combine(outpath.FullName, $"{modname}.archive");
            }

            if (FileHelper.SafeWrite(ms, outfile, _loggerService))
            {
                _loggerService.Success($"Finished packing {outfile}.");
                return true;
            }

            return false;
        }
    }
}
