using System;
using System.Buffers;
using System.Security.Cryptography;
using System.Text;

namespace CP77.Common.Tools.FNV1A
{
    /// <summary>
    /// Hash algorithm, Fowler–Noll–Vo
    /// </summary>
    public sealed class FNV1A64HashAlgorithm : HashAlgorithm
    {
        private const ulong FnvHashPrime = 0x00000100000001B3;
        private const ulong FnvHashInitial = 0xCBF29CE484222325;

        private ulong fnvhash;
        private Encoding encoding;

        public ulong HashUInt64 => fnvhash == FnvHashInitial ? 0 : fnvhash;

        public FNV1A64HashAlgorithm()
            : this(Encoding.ASCII)
        {
        }

        public FNV1A64HashAlgorithm(Encoding encoding)
        {
            this.Initialize();
            this.HashSizeValue = 64;
            this.encoding = encoding ?? Encoding.ASCII;
        }

        public override void Initialize()
        {
            this.fnvhash = FnvHashInitial;
        }

        public void AppendString(string value)
        {
            AppendString(value, false);
        }

        public void AppendString(string value, bool nullEnded)
        {
            if (string.IsNullOrEmpty(value))
                return;

            var length = encoding.GetMaxByteCount(nullEnded ? value.Length + 1 : value.Length);
            var buffer = ArrayPool<byte>.Shared.Rent(length);
            try
            {
                var encodedLength = encoding.GetBytes(value.AsSpan(), buffer.AsSpan());
                if (nullEnded)
                {
                    buffer[encodedLength] = 0;
                    encodedLength++;
                }

                HashCore(buffer, 0, encodedLength);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            var ibEnd = ibStart + cbSize;
            if (ibEnd > array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            unchecked
            {
                for (int i = ibStart; i < ibEnd; i++)
                {
                    this.fnvhash = (this.fnvhash ^ array[i]) * FnvHashPrime;
                }
            }
        }

        protected override byte[] HashFinal()
        {
            return BitConverter.GetBytes(this.HashUInt64);
        }


        public static ulong HashString(string value)
        {
            return HashString(value, Encoding.ASCII, false);
        }

        public static ulong HashString(string value, Encoding encoding, bool nullEnded = false)
        {
            var length = encoding.GetMaxByteCount(nullEnded ? value.Length + 1 : value.Length);
            var buffer = ArrayPool<byte>.Shared.Rent(length);
            try
            {
                var encodedLength = encoding.GetBytes(value.AsSpan(), buffer.AsSpan());
                if (nullEnded)
                {
                    buffer[encodedLength] = 0;
                    encodedLength++;
                }

                return HashReadOnlySpan(new ReadOnlySpan<byte>(buffer, 0, encodedLength));
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }

        public static ulong HashReadOnlySpan(ReadOnlySpan<char> source)
        {
            var hash = FnvHashInitial;
            foreach (var b in source)
            {
                unchecked
                {
                    hash = (hash ^ b) * FnvHashPrime;
                }
            }

            return hash;
        }

        public static ulong HashReadOnlySpan(ReadOnlySpan<byte> source)
        {
            var hash = FnvHashInitial;
            foreach (var b in source)
            {
                unchecked
                {
                    hash = (hash ^ b) * FnvHashPrime;
                }
            }

            return hash;
        }
    }
}