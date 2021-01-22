using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Catel.IoC;
using CP77.Common.Services;
using CP77.Common.Tools;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using CP77.CR2W.Extensions;
using CP77.CR2W.Types;
using CP77Tools.Model;
using RED.CRC32;
using WolvenKit.Common;
using WolvenKit.Common.Tools.DDS;

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
        public static int Export(FileInfo cr2wfile, EUncookExtension uncookext = EUncookExtension.tga)
        {
            #region checks

            if (cr2wfile == null) return -1;
            if (!cr2wfile.Exists) return -1;
            if (cr2wfile.Directory != null && !cr2wfile.Directory.Exists) return -1;
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(cr2wfile.Extension[1..])) return -1;
            var ext = Path.GetExtension(cr2wfile.FullName)[1..];
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext)) return 0;
            #endregion

            // read file
            using var fs = new FileStream(cr2wfile.FullName, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);

            var cr2w = TryReadCr2WFile(br);
            if (cr2w == null)
            {
                Logger.LogString($"Failed to read cr2w file {cr2wfile.FullName}", Logtype.Error);
                return -1;
            }
            cr2w.FileName = cr2wfile.FullName;

            // read buffers
            var buffers = new List<byte[]>();
            foreach (var b in cr2w.Buffers.Select(_ => _.Buffer))
            {
                br.BaseStream.Seek(b.offset, SeekOrigin.Begin);

                var zbuffer = br.ReadBytes((int) b.diskSize);

                // decompress buffers
                using var input = new MemoryStream(zbuffer);
                using var output = new MemoryStream();
                using var reader = new BinaryReader(input);
                using var writer = new BinaryWriter(output);
                reader.DecompressBuffer(writer, (uint)zbuffer.Length, b.memSize);
                
                buffers.Add(Catel.IO.StreamExtensions.ToByteArray(output));
                
            }

            
            if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
                return -1;

            return Uncook(cr2w, buffers, extAsEnum, uncookext);

        }
    }
}