using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
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
        /// Read a single string from the current stream, where the first bytes indicate the length.
        /// </summary>
        /// <returns>string value read</returns>
        public static void WriteStringDefaultSingle(this BinaryWriter bw, string value)
        {
            int len = value.Length;
            bool utf = RequiresUTF(value);

            // mask the value
            byte b = (byte)(len & 0x3F);
            // check for continuation
            bool cont = len >> 6 != 0;

            // set the two last bits
            // reserved utf bit 7
            if (!utf)
            {
                b |= 0x80;
            }
            else
                throw new NotImplementedException();
            // continuation bit 6
            if (cont)
            {
                b |= 0x40;
            }
            bw.Write(b);

            // continue 
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

            

            if (utf)
                bw.Write(Encoding.Unicode.GetBytes(value));
            else
                bw.Write(Encoding.ASCII.GetBytes(value));

            bool RequiresUTF(string val)
            {
                foreach (var c in val)
                {
                    if (c > 255)
                        return true;
                }
                return false;
            }
        }

    }

}