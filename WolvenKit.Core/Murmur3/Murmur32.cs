using System;
using System.Buffers.Binary;
using System.Text;

namespace WolvenKit.Core.Murmur3
{
    public static class Murmur32
    {
        // TODO: When .NET 6 is released, this should inherit from System.IO.Hashing.NonCryptographicHashAlgorithm, see https://github.com/dotnet/runtime/pull/53623,
        // https://github.com/dotnet/runtime/blob/main/src/libraries/System.IO.Hashing/src/System/IO/Hashing/NonCryptographicHashAlgorithm.cs.

        private const uint s_c1 = 0xCC9E2D51;
        private const uint s_c2 = 0x1B873593;
        private const byte s_r1 = 15;
        private const byte s_r2 = 13;
        private const byte s_m = 5;
        private const uint s_n = 0xE6546B64;


        public static uint Hash(string source, uint seed, Encoding? encoding = null)
        {
            encoding ??= Encoding.ASCII;

            return Hash(new ReadOnlySpan<byte>(encoding.GetBytes(source)), seed);
        }

        public static uint Hash(ReadOnlySpan<byte> source, uint seed)
        {
            uint k;
            var length = source.Length;

            var val = seed;
            for (var i = source.Length >> 2; i > 0; i--)
            {
                if (BitConverter.IsLittleEndian)
                {
                    k = BinaryPrimitives.ReadUInt32LittleEndian(source);
                }
                else
                {
                    k = BinaryPrimitives.ReadUInt32BigEndian(source);
                }

                source = source[sizeof(uint)..];

                k *= s_c1;
                k = Rotl(k, s_r1);
                k *= s_c2;

                val ^= k;
                val = Rotl(val, s_r2);
                val = (val * s_m) + s_n;
            }

            k = 0;
            for (var i = source.Length & 3; i > 0; i--)
            {
                k <<= 8;
                k |= source[i - 1];
            }

            k *= s_c1;
            k = Rotl(k, s_r1);
            k *= s_c2;
            val ^= k;

            val ^= (uint)length;
            val ^= val >> 16;
            val *= 0x85EBCA6B;
            val ^= val >> 13;
            val *= 0xC2B2AE35;
            val ^= val >> 16;

            return val;
        }

        public static byte[] HashBytes(string source, uint seed, Encoding? encoding = null)
        {
            encoding ??= Encoding.ASCII;

            return HashBytes(new ReadOnlySpan<byte>(encoding.GetBytes(source)), seed);
        }

        public static byte[] HashBytes(ReadOnlySpan<byte> source, uint seed) => BitConverter.GetBytes(Hash(source, seed));

        private static uint Rotl(uint x, byte r) => (uint)((int)x << r) | (x >> (32 - r));
    }
}
