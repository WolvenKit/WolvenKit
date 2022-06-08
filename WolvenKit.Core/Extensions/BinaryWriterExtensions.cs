using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace WolvenKit.Core.Extensions
{
    public static class BineryWriterExtensions
    {
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
            for (var i = 0; i < buffer.Length; i++)
            {
                buffer[i] = paddingbyte;
            }

            bw.Write(buffer);
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

            for (var i = 0; left > 0; i++)
            {
                if (i == 0)
                {
                    bytes.Add(left & 63);
                    left >>= 6;
                }
                else
                {
                    bytes.Add(left & 255);
                    left >>= 7;
                }
            }

            for (var i = 0; i < bytes.Count; i++)
            {
                var last = i == bytes.Count - 1;
                var cleft = bytes.Count - 1 - i;

                if (!last)
                {
                    bytes[i] = cleft >= 1 && i >= 1 ? bytes[i] | 128 : bytes[i] < 64 ? bytes[i] | 64 : bytes[i] | 128;
                }

                if (bytes[i] == 128)
                {
                    throw new Exception("No clue what to do here, still need to think about it... :p");
                }

                stream.Write((byte)bytes[i]);
            }
        }

        /// <summary>
        /// Writes a UTF8 encoded string to a BinaryWriter Stream.
        /// The string is prefixed with its length in bytes, stored as a VLQ encoded integer
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The string to write.</param>
        public static void WriteLengthPrefixedString(this BinaryWriter writer, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                writer.Write((byte)0x00);
                return;
            }

            var output = Encoding.UTF8.GetBytes(value);

            // The sign bit of the prefix is used to denote the character encoding
            // Positive (0) for UTF16, negative (1) for UTF8
            // All strings seen in CP77 so far have been UTF8, so we set it negative
            writer.WriteVLQInt32(-output.Length);

            writer.Write(output);
        }

        /// <summary>
        /// Writes a signed 32-bit integer as Variable-Length Quantity of bytes
        /// <br/>
        /// See <see cref="BinaryReaderExtensions.ReadVLQInt32"/> for more info
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="value"></param>
        public static void WriteVLQInt32(this BinaryWriter bw, int value)
        {
            // Sign is stored in the 7th bit instead of two's-compliment
            // so we save the absolute of the value and the sign separately
            var isNegative = value < 0;
            var absVal = (uint)Math.Abs(value);

            // Initial value from the lower 6 bits
            var b = (byte)(absVal & 0b00111111);

            if (isNegative)
            {
                b |= 0b10000000;
            }

            absVal >>= 6;

            // Is value larger than 6 bits?
            if (absVal > 0)
            {
                // First octet stores the continuation flag in the 6th bit
                b |= 0b01000000;
            }
            bw.Write(b);

            // Any remaining octets are written the same as unsigned ints
            if (absVal > 0)
            {
                bw.WriteVLQUInt32(absVal);
            }
        }

        /// <summary>
        /// Writes an unsigned 32-bit integer as Variable-Length Quantity of bytes
        /// <br/>
        /// See <see cref="BinaryReaderExtensions.ReadVLQInt32"/> for more info
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="value"></param>
        public static void WriteVLQUInt32(this BinaryWriter bw, uint value)
        {
            do
            {
                // Get the value from the lower 7 bits
                var b = (byte)(value & 0b01111111);
                // Shift the value down to the next 7 bits
                value >>= 7;
                // Is there any data remaining?
                if (value > 0)
                {
                    // Set the contiuation bit
                    b |= 0b10000000;
                }
                bw.Write(b);
            }
            while (value > 0);
        }

        /// <summary>
        /// Write a structure to the stream.
        /// </summary>
        /// <typeparam name="T">The struct type.</typeparam>
        /// <param name="writer">The writer.</param>
        /// <param name="obj">The instance of the structure.</param>
        public static void Write<T>(this BinaryWriter writer, T obj)
            where T : struct
        {
            var size = Marshal.SizeOf(typeof(T));
            var ptr = Marshal.AllocHGlobal(size);

            try
            {
                var bytes = new byte[size];
                Marshal.StructureToPtr(obj, ptr, false);
                Marshal.Copy(ptr, bytes, 0, size);

                writer.Write(bytes);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static void WriteNullTerminatedString(this BinaryWriter bw, string text, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            bw.Write(encoding.GetBytes(text));
            bw.Write((byte)0);
        }
    }
}
