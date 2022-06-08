using System;
using System.IO;
using System.Text;

namespace WolvenKit.RED3.CR2W
{
    public static class W3ReaderExtensions
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
            var b = br.ReadByte();
            if (b == 0x80)
            {
                return null;
            }

            if (b == 0x00)
            {
                throw new NotImplementedException();//return "";
            }

            var nxt = (b & (1 << 6)) != 0;
            var widechar = (b & (1 << 7)) == 0;
            var len = b & ((1 << 6) - 1); // null terminated?
            if (nxt)
            {
                len += 64 * br.ReadByte();
            }

            var readstring = widechar ? Encoding.Unicode.GetString(br.ReadBytes(len * 2)) : Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(len));

            return readstring;
        }

        #endregion Methods
    }
}
