using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.Exceptions;
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
        public Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath, string? modname = null)
        {
            if (!infolder.Exists)
            {
                _loggerService.Error($"Could not pack archive from {infolder}");
                throw new PackException();
            }

            if (!outpath.Exists)
            {
                _loggerService.Error($"Could not pack archive to {outpath}");
                throw new PackException();
            }

            ArchiveWriter writer = new(_hashService, _loggerService);
            
            var archive = writer.WriteArchive(infolder, outpath, modname);
            if (archive == null)
            {
                _loggerService.Error($"Could not pack archive");
                throw new PackException();
            }

            return archive;
        }
    }
}
