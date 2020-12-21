using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public static class W3WriterExtensions
    {

        public static void WriteBit6(this BinaryWriter stream, int c)
        {
            if (c == 0)
            {
                stream.Write((byte)128);
                return;
            }

            //var str2 = Convert.ToString(c, 2);

            var bytes = new List<int>();
            var left = c;

            for (var i = 0; (left > 0); i++)
            {
                if (i == 0)
                {
                    bytes.Add(left & 63);
                    left = left >> 6;
                }
                else
                {
                    bytes.Add(left & 255);
                    left = left >> 7;
                }
            }


            for (var i = 0; i < bytes.Count; i++)
            {
                var last = (i == bytes.Count - 1);
                var cleft = (bytes.Count - 1) - i;

                if (!last)
                {
                    if (cleft >= 1 && i >= 1)
                    {
                        bytes[i] = bytes[i] | 128;
                    }
                    else if (bytes[i] < 64)
                    {
                        bytes[i] = bytes[i] | 64;
                    }
                    else
                    {
                        bytes[i] = bytes[i] | 128;
                    }
                }

                if (bytes[i] == 128)
                {
                    throw new Exception("No clue what to do here, still need to think about it... :p");
                }

                stream.Write((byte)bytes[i]);
            }
        }

        public static void WriteVLQInt32(this BinaryWriter bw, int value)
        {
            bool negative = value < 0;
            value = Math.Abs(value);
            byte b = (byte)(value & 0x3F);
            value >>= 6;
            if (negative)
            {
                b |= 0x80;
            }
            bool cont = value != 0;
            if (cont)
            {
                b |= 0x40;
            }
            bw.Write(b);
            while (cont)
            {
                b = (byte)(value & 0x7F);
                value >>= 7;
                cont = value != 0;
                if (cont)
                {
                    b |= 0x80;
                }
                bw.Write(b);
            }

            
        }


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

            int len = value.Length;
            bool requiresWideChar = value.Any(c => c > 255);

            var div = Math.DivRem(len, 0x40, out var mod);
            len -= (div * 0x40);

            // mask the value
            byte b = (byte)(len & 0x3F); // 00xxxxxx
            // check for continuation
            //bool cont = len >> 6 != 0;
            bool cont = div != 0;

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
                bw.Write((byte)div);
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
                bw.Write(Encoding.Unicode.GetBytes(value));
            else
                bw.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(value));
        }

        /// <summary>
        /// Writes a string to a BinaryWriter Stream
        /// First byte indicates length, where the first 2 bits are reserved
        /// bit1: 0 if widecharacterset is needed, 1 otherwise
        /// bit2: 1 if continuation byte is needed, 0 otherwise
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="value"></param>
        public static void WriteLengthPrefixedStringNullTerminated(this BinaryWriter bw, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                bw.Write((byte)0x80);
                return;
            }

            int len = value.Length + 1; // null terminated
            bool requiresWideChar = value.Any(c => c > 255);

            var div = Math.DivRem(len, 0x40, out var mod);
            len -= (div * 0x40);

            // mask the value
            byte b = (byte)(len & 0x3F); // 00xxxxxx
            // check for continuation
            //bool cont = len >> 6 != 0;
            bool cont = div != 0;

            // set the two last bits
            // reserved utf bit 7
            if (requiresWideChar)
                throw new NotImplementedException();
            else
            {
                // do nothing
                //b |= 0x80;
            }

            // continuation bit 6
            if (cont)
            {
                b |= 0x40;
            }
            bw.Write(b);

            // continue 
            if (cont)
                bw.Write((byte)div);

            if (requiresWideChar)
                bw.Write(Encoding.Unicode.GetBytes(value));
            else
                bw.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(value));

            // null terminated
            bw.Write((byte)0x00);
        }

        /// <summary>
        /// Padds until next page
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="pagesize"></param>
        /// <param name="paddingbyte"></param>
        public static void PadUntilPage(this BinaryWriter bw, int pagesize = 4096, byte paddingbyte = 0xD9)
        {
            var pos = bw.BaseStream.Position;
            var mod = pos / 4096;
            var diff = ((mod + 1) * 4096) - pos;

            var buffer = new byte[diff];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = paddingbyte;
            }

            bw.Write(buffer);
        }

    }

}