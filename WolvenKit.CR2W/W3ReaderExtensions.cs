using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Types;

/// <summary>
/// Where most of the parsing and handling of atomic game files happens.
/// Three layers of hashes (FNV1a for a big part, Cyclic redundancy check CRC32, custom,...) on
/// header, data blocks, and atomic data.
/// Hashes are checked and their compliance is enforced by wcc_lite.exe, (and other? design history?)
/// </summary>
namespace WolvenKit.CR2W
{
    public static class W3ReaderExtensions
    {

        public static CVariable CopyViaBuffer(CVariable source, CVariable destination)
        {
            using (MemoryStream temporaryBuffer = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(temporaryBuffer))
                {
                    source.Write(writer);
                }

                temporaryBuffer.Position = 0;

                using (BinaryReader reader = new BinaryReader(temporaryBuffer))
                {
                    destination.Read(reader, (uint)temporaryBuffer.Length);
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

    }
}