using System;
using System.IO;
using System.Linq;
using System.Text;

namespace WolvenKit.RED3.CR2W
{
    public static class W3WriterExtensions
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
            if (string.IsNullOrEmpty(value))
            {
                bw.Write((byte)0x80);
                return;
            }

            var len = value.Length;
            var requiresWideChar = value.Any(c => c > 255);

            var div = Math.DivRem(len, 0x40, out var mod);
            len -= div * 0x40;

            // mask the value
            var b = (byte)(len & 0x3F); // 00xxxxxx
            // check for continuation
            //bool cont = len >> 6 != 0;
            var cont = div != 0;

            // set the two last bits
            // reserved utf bit 7
            if (requiresWideChar)
            {
                // do nothing
            }
            else
            {
                b |= 0x80;
            }
            // continuation bit 6
            if (cont)
            {
                b |= 0x40;
            }
            bw.Write(b);

            // continue
            if (cont)
            {
                bw.Write((byte)div);
            }
            //while (cont)
            //{
            //    b = (byte)(len & 0x7F);
            //    len >>= 7;
            //    cont = len != 0;
            //    if (cont)
            //    {
            //        b |= 0x80;
            //    }
            //    bw.Write(b);
            //}

            if (requiresWideChar)
            {
                bw.Write(Encoding.Unicode.GetBytes(value));
            }
            else
            {
                bw.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(value));
            }
        }

        #endregion Methods
    }
}
