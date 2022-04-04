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
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    ///     Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        #region Methods

        /// <summary>
        ///     Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <param name="outpath"></param>
        /// <param name="modname">Optional archivename</param>
        /// <returns></returns>
        public Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath, string modname = null)
        {
            var writer = new ArchiveWriter(_hashService);
            return writer.WriteArchive(infolder, outpath, modname);
        }

        #endregion Methods
    }
}
