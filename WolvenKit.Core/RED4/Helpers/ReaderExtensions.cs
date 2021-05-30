using System;
using System.IO;
using System.Text;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W
{
    public static class ReaderExtensions
    {
        #region Methods

        /// <summary>
        /// Reads a string from a BinaryReader Stream
        /// First byte indicates length, where the first 2 bits are reserved
        /// bit1: 0 if widecharacterset is needed, 1 otherwise
        /// bit2: 1 if continuation byte is needed, 0 otherwise
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static string ReadLengthPrefixedString(this BinaryReader br)
        {
            // ReadVLQInt32 but highest bit is widechar instead of sign
            var b1 = br.ReadByte();
            if (b1 == 0x80)
                return null;
            if (b1 == 0x00)
                return "";

            var widechar = (b1 & 128) == 0;
            var next = (b1 & 64) == 64;
            var size = b1 % 128 % 64;
            var offset = 6;
            while (next)
            {
                var b = br.ReadByte();
                size = (b % 128) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }

            string readstring;
            readstring = widechar
                ? Encoding.Unicode.GetString(br.ReadBytes(size * 2))
                : Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(size));

            return readstring;
        }

        #endregion Methods
    }
}
