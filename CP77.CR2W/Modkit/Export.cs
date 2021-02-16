using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Catel.IoC;
using WolvenKit.Common.Services;
using CP77.CR2W.Archive;
using CP77.CR2W.Extensions;
using CP77.CR2W.Types;
using CP77Tools.Model;
using RED.CRC32;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Oodle;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        

        /// <summary>
        /// Exports (Uncooks) a REDEngine file into it's raw counterpart
        /// </summary>
        /// <param name="cr2wfile"></param>
        /// <param name="outpath"></param>
        public static bool Export(FileInfo cr2wfile, EUncookExtension uncookext = EUncookExtension.dds, bool flip = false)
        {
            #region checks

            if (cr2wfile == null) return false;
            if (!cr2wfile.Exists) return false;
            if (cr2wfile.Directory != null && !cr2wfile.Directory.Exists) return false;
            var ext = Path.GetExtension(cr2wfile.FullName)[1..];
            #endregion

            // read file
            using var fs = new FileStream(cr2wfile.FullName, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);

            var cr2w = ModTools.TryReadCr2WFile(br);
            if (cr2w == null)
            {
                Logger.LogString($"Failed to read cr2w file {cr2wfile.FullName}", Logtype.Error);
                return false;
            }
            cr2w.FileName = cr2wfile.FullName;

            return Uncook(fs, cr2wfile, ext, uncookext, flip);

        }




    }
}