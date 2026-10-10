using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Core.Compression;
using WolvenKit.Core.CRC;

namespace WolvenKit.Modkit.RED4
{
    public static class ModToolExtensions
    {
        /// <summary>
        /// Kraken-compresses a buffer and writes it to a stream.
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="inbuffer"></param>
        /// <returns></returns>
        public static (uint, uint) CompressAndWrite(this BinaryWriter bw, byte[] inbuffer)
        {
            var size = (uint)inbuffer.Length;
            if (size < 256)
            {
                var crc = Crc32Algorithm.Compute(inbuffer);
                bw.Write(inbuffer);

                return (size, crc);
            }
            else
            {
                var r = Oodle.Compress(inbuffer, out var outBuffer, true);

                var crc = Crc32Algorithm.Compute(outBuffer);
                bw.Write(outBuffer);

                return ((uint)r, crc);
            }
        }
    }
}
