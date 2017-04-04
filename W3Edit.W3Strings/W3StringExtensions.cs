using System;
using System.Collections.Generic;
using System.IO;

namespace W3Edit.W3Strings
{
    public static class W3StringExtensions
    {
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

        // first byte:
        //      01111111
        //      ^^^^^^^^
        //      |||    |
        //      |||____|_ 6 bit value
        //      ||_______ flag: next byte required
        //      |________ flag: signed value

        // next bytes:
        //      11111111
        //      ^^^^^^^^
        //      ||     |
        //      ||_____|_ 7 bit value
        //      |________ flag: next byte required

        //let b = stream.read_u8();

        //// lower 6 bit
        //let mut value = (b & 0b0011_1111) as u32;

        //if b & 0b0100_0000 == 64 {
        //    let mut shift = 6;          // first byte 6 lowest bits
        //    loop {
        //        let next = stream.read_u8();

        //        value |= ((next & 0b0111_1111) as u32) << shift;
        //        shift += 7;             // each next byte 7 higher bits

        //        if (next & 0b1000_0000 == 0) || (shift >= 27) {
        //            break;
        //        }
        //    }
        //}

        //// is signed?
        //if b & 0b1000_0000 == 128 { -1 * value as i32 } else { value as i32 }

        public static UInt32 WriteBit6(this BinaryWriter stream, int c)
        {
            if (c == 0)
            {
                stream.Write((byte) 128);
                return 1;
            }

            UInt32 written = 0;
            var str2 = Convert.ToString(c, 2);

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

                stream.Write((byte) bytes[i]);
                written += 1;
            }
            return written;
        }
    }
}