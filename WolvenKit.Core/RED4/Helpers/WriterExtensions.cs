using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WolvenKit.RED4.CR2W
{
    public static class WriterExtensions
    {
        #region Methods



        /// <summary>
        /// Writes a string to a BinaryWriter Stream
        /// First byte indicates length, where the first 2 bits are reserved
        /// bit1: 0 if widecharacterset is needed, 1 otherwise
        /// bit2: 1 if continuation byte is needed, 0 otherwise
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="value"></param>
        public static void WriteLengthPrefixedString(this BinaryWriter bw, string value)
        {
            // WriteVLQInt32 but highest bit is widechar instead of sign
            if (string.IsNullOrEmpty(value))
            {
                bw.Write((byte)0x00);
                return;
            }

            int len = value.Length;
            bool requiresWideChar = value.Any(c => c > 255);

            byte b = (byte)(len & 0x3F);
            len >>= 6;
            if (!requiresWideChar)
            {
                b |= 0x80;
            }
            bool cont = len != 0;
            if (cont)
            {
                b |= 0x40;
            }
            bw.Write(b);
            while (cont)
            {
                b = (byte)(len & 0x7F);
                len >>= 7;
                cont = len != 0;
                if (cont)
                {
                    b |= 0x80;
                }
                bw.Write(b);
            }

            if (requiresWideChar)
                bw.Write(Encoding.Unicode.GetBytes(value));
            else
                bw.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(value));
        }

        #endregion Methods
    }
}
