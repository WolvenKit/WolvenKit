using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WolvenKit.Core.Extensions
{
    public static class BinaryReaderExtensions
    {
        //public static IEditableVariable CopyViaBuffer(IEditableVariable source, IEditableVariable destination)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    using (BinaryWriter bw = new BinaryWriter(ms))
        //    {
        //        source.Write(bw);

        //        ms.Position = 0;

        //        using (BinaryReader reader = new BinaryReader(ms))
        //        {
        //            destination.Read(reader, (uint)ms.Length);
        //        }
        //    }

        //    return destination;
        //}

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
                {
                    return 0;
                }

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
                result |= (b & mask) << shift;
                shift += s;
                i++;
            } while (!(b < 64 || (i >= 3 && b < 128)));

            return result;
        }

        public static float ReadHalfFloat(this BinaryReader stream)
        {
            var data = stream.ReadUInt16();
            // half (binary16) format IEEE 754-2008
            var dataSign = (uint)data >> 15;
            var dataExp = ((uint)data >> 10) & 0x001F;
            var dataFrac = (uint)data & 0x03FF;

            uint floatExp = 0;
            uint floatFrac = 0;

            switch (dataExp)
            {
                case 0: // subnormal : (-1)^sign * 2^-14 * 0.frac
                    if (dataFrac != 0) // subnormals but non-zeros -> normals in float32
                    {
                        floatExp = -15 + 127;
                        while ((dataFrac & 0x200) == 0)
                        { dataFrac <<= 1; floatExp--; }
                        floatFrac = (dataFrac & 0x1FF) << 14;
                    }
                    else
                    { floatFrac = 0; floatExp = 0; } // ± 0 -> ± 0
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
            var floatNum = (dataSign << 31) | (floatExp << 23) | floatFrac;
            return BitConverter.ToSingle(BitConverter.GetBytes(floatNum), 0);
        }

        /// <summary>
        /// Reads a length-prefixed string from a BinaryReader Stream.
        /// <br/>
        /// The length is stored as a VLQ encoded integer, using the sign to denote the character width
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static string ReadLengthPrefixedString(this BinaryReader br)
        {
            // Prefix length is stored as a VLQ signed integer
            var prefix = br.ReadVLQInt32();
            // The string length in characters is the absolute value of the prefix
            var length = Math.Abs(prefix);

            if (length == 0)
            {
                return string.Empty;
            }

            // The character width is determined by the sign of the prefix
            return prefix > 0
                ? Encoding.Unicode.GetString(br.ReadBytes(length * 2))
                : Encoding.UTF8.GetString(br.ReadBytes(length));
        }

        /// <summary>
        /// Continuation bit flag used for VLQ packed ints
        /// </summary>
        internal const byte s_VLQ_Continuation = 0b10000000;

        /// <summary>
        /// Bitmask of the value bits in each VLQ packed octet
        /// </summary>
        internal const byte s_VLQ_ValueMask = 0b01111111;

        /// <summary>
        /// Helper extension function to simplify flag checks
        /// </summary>
        /// <param name="b">Data byte</param>
        /// <param name="flag">Flag bits to check</param>
        /// <returns></returns>
        private static bool HasFlag(this byte b, byte flag) => (b & flag) == flag;

        /// <summary>
        /// Reads a Variable-Length Quantity of bytes and return a signed 32-bit integer
        /// </summary>
        /// <remarks>
        /// CDPR seem to use a modified version of <see href="https://en.wikipedia.org/wiki/LEB128">LEB128</see>
        /// encoding to store integer values.
        /// <br/>
        /// For signed integers, instead of using two's-compliment, they use a slightly modified encoding for the first octet:<br/>
        /// - Bit 7 is used to denote sign<br/>
        /// - Bit 6 is used as the continuation bit<br/>
        /// - Bits 0-5 store the lower 6 bits of the value<br/>
        /// The remaining octets use the standard LEB128 encoding, up to a maximum total of 5 bytes
        /// <br/>
        /// This implementation seems to mirror the
        /// <see href="https://en.wikipedia.org/wiki/Variable-length_quantity#Sign_bit">Compact Indices</see>
        /// layout used by Epic Games in their old Unreal Packages format.
        /// </remarks>
        /// <returns>A signed 32-bit integer</returns>
        /// <exception cref="InvalidDataException">Thrown if continuation bit is set on the 5th byte</exception>
        public static int ReadVLQInt32(this BinaryReader br)
        {
            var b = br.ReadByte();
            var isNegative = b.HasFlag(0b10000000);
            // Initial value from the lower 6 bits
            var value = b & 0b00111111;

            // First octet stores the continuation flag in the 6th bit
            // Is value larger than 6 bits?
            if (b.HasFlag(0b01000000))
            {
                b = br.ReadByte();
                // Mask and add the next 7 bits
                value |= (b & s_VLQ_ValueMask) << 6;

                // Is value larger than 13 bits?
                if (b.HasFlag(s_VLQ_Continuation))
                {
                    b = br.ReadByte();
                    value |= (b & s_VLQ_ValueMask) << 13;

                    // Is value larger than 20 bits?
                    if (b.HasFlag(s_VLQ_Continuation))
                    {
                        b = br.ReadByte();
                        value |= (b & s_VLQ_ValueMask) << 20;

                        // Is value larger than 27 bits?
                        if (b.HasFlag(s_VLQ_Continuation))
                        {
                            b = br.ReadByte();
                            value |= (b & s_VLQ_ValueMask) << 27;

                            // Is value larger than 34 bits? That seems bad
                            if (b.HasFlag(s_VLQ_Continuation))
                            {
                                throw new InvalidDataException($"Continuation bit set on 5th byte");
                            }
                        }
                    }
                }
            }

            return isNegative ? -value : value;
        }

        /// <summary>
        /// Reads a Variable-Length Quantity of bytes (between 1 and 5) and return an unsigned 32-bit integer.
        /// <br/>
        /// See <see cref="ReadVLQInt32"/> for more info.
        /// </summary>
        /// <returns>An unsigned 32-bit integer</returns>
        /// <exception cref="InvalidDataException">Thrown if continuation bit is set on the 5th byte</exception>
        public static uint ReadVLQUInt32(this BinaryReader br)
        {
            var b = br.ReadByte();
            // Initial value from the lower 7 bits
            var value = (uint)b & s_VLQ_ValueMask;

            // First octet stores the continuation flag in the 6th bit
            // Is value larger than 7 bits?
            if (b.HasFlag(s_VLQ_Continuation))
            {
                b = br.ReadByte();
                // Mask and add the next 7 bits
                value |= (uint)(b & s_VLQ_ValueMask) << 7;

                // Is value larger than 14 bits?
                if (b.HasFlag(s_VLQ_Continuation))
                {
                    b = br.ReadByte();
                    value |= (uint)(b & s_VLQ_ValueMask) << 14;

                    // Is value larger than 21 bits?
                    if (b.HasFlag(s_VLQ_Continuation))
                    {
                        b = br.ReadByte();
                        value |= (uint)(b & s_VLQ_ValueMask) << 21;

                        // Is value larger than 28 bits?
                        if (b.HasFlag(s_VLQ_Continuation))
                        {
                            b = br.ReadByte();
                            value |= (uint)(b & s_VLQ_ValueMask) << 28;

                            // Is value larger than 35 bits? That seems bad
                            if (b.HasFlag(s_VLQ_Continuation))
                            {
                                throw new InvalidDataException($"Continuation bit set on 5th byte");
                            }
                        }
                    }
                }
            }

            return value;
        }

        public static string ReadNullTerminatedString(this BinaryReader br, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            var bytes = new List<byte>();
            for (byte b; (b = br.ReadByte()) != 0x00;)
            {
                bytes.Add(b);
            }

            return encoding.GetString(bytes.ToArray());
        }
    }
}
