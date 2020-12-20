using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public static class W3ReaderExtensions
    {
        public static CVariable CopyViaBuffer(CVariable source, CVariable destination)
        {
            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                source.Write(bw);

                ms.Position = 0;

                using (BinaryReader reader = new BinaryReader(ms))
                {
                    destination.Read(reader, (uint)ms.Length);
                }
            }


            return destination;
        }




        public static float ReadHalfFloat(this BinaryReader stream)
        {
            ushort data = stream.ReadUInt16();
            // half (binary16) format IEEE 754-2008
            uint dataSign = (uint)data >> 15;
            uint dataExp = ((uint)data >> 10) & 0x001F;
            uint dataFrac = (uint)data & 0x03FF;

            uint floatExp = 0;
            uint floatFrac = 0;

            switch (dataExp)
            {
                case 0: // subnormal : (-1)^sign * 2^-14 * 0.frac
                    if (dataFrac != 0) // subnormals but non-zeros -> normals in float32
                    {
                        floatExp = -15 + 127;
                        while ((dataFrac & 0x200) == 0) { dataFrac <<= 1; floatExp--; }
                        floatFrac = (dataFrac & 0x1FF) << 14;
                    }
                    else { floatFrac = 0; floatExp = 0; } // ± 0 -> ± 0
                    break;
                case 31: // infinity or NaNs : frac ? NaN : (-1)^sign * infinity
                    floatExp = 255;
                    floatFrac = dataFrac != 0 ? (uint)0x200000 : 0; // signaling Nan or zero
                    break;
                default: // normal : (-1)^sign * 2^(exp-15) * 1.frac
                    floatExp = dataExp - 15 + 127;
                    floatFrac = dataFrac << 13;
                    break;
            }
            // single precision floating point (binary32) format IEEE 754-2008
            uint floatNum = dataSign << 31 | floatExp << 23 | floatFrac;
            return BitConverter.ToSingle(BitConverter.GetBytes(floatNum), 0);
        }

        public static int ReadBit6(this BinaryReader stream)
        {
            var result = 0;
            var shift = 0;
            byte b = 0;
            var i = 1;

            do
            {
                b = stream.ReadByte();
                if (b == 128)
                    return 0;
                byte s = 6;
                byte mask = 255;
                if (b > 127)
                {
                    mask = 127;
                    s = 7;
                }
                else if (b > 63)
                {
                    if (i == 1)
                    {
                        mask = 63;
                    }
                }
                result = result | ((b & mask) << shift);
                shift = shift + s;
                i = i + 1;
            } while (!(b < 64 || (i >= 3 && b < 128)));

            return result;
        }

        public static int ReadVLQInt32(this BinaryReader br)
        {
            var b1 = br.ReadByte();
            var sign = (b1 & 128) == 128;
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
            return sign ? size * -1 : size;
        }

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
                return null;
            if (b == 0x00)
                throw new NotImplementedException();//return "";
            

            var nxt = (b & (1 << 6)) != 0;
            var widechar = (b & (1 << 7)) == 0;
            int len = b & ((1 << 6) - 1); // null terminated?
            if (nxt)
            {
                len += 64 * br.ReadByte();
            }

            string readstring;
            if (widechar)
                readstring = Encoding.Unicode.GetString(br.ReadBytes(len * 2));
            else
            {
                readstring = Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(len));

            }
                
            return readstring;
        }

        /// <summary>
        /// Reads a null terminated string from a BinaryReader Stream
        /// First byte indicates length, where the first 2 bits are reserved
        /// bit1: 0 if widecharacterset is needed, 1 otherwise
        /// bit2: 1 if continuation byte is needed, 0 otherwise
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static string ReadLengthPrefixedStringNullTerminated(this BinaryReader br)
        {
            var b = br.ReadByte();
            if (b == 0x80)
                return null;
            if (b == 0x00)
                return "";

            var nxt = (b & (1 << 6)) != 0;
            var unknownFlag = (b & (1 << 7)) != 0;
            int len = b & ((1 << 6) - 1);
            if (nxt)
            {
                len += 64 * br.ReadByte();
            }

            string readstring;
            if (unknownFlag)
            {
                throw new NotImplementedException();
                readstring = Encoding.Unicode.GetString(br.ReadBytes((len * 2) - 1));
            }
            else
                readstring = Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(len - 1));

            if (br.ReadByte() != 0)
                throw new NullReferenceException();
            return readstring;
        }

        public static void ReadUntilPage(this BinaryReader br, int pagesize)
        {

        }
    }
}