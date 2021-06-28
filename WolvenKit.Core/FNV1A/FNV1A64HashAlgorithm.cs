using System;
using System.Buffers;
using System.Security.Cryptography;
using System.Text;

namespace WolvenKit.Common.FNV1A
{
    /// <summary>
    /// Hash algorithm, Fowler–Noll–Vo
    /// </summary>
    public sealed class FNV1A64HashAlgorithm : HashAlgorithm
    {
        #region Fields

        private const ulong FnvHashInitial = 0xCBF29CE484222325;
        private const ulong FnvHashPrime = 0x00000100000001B3;
        private Encoding encoding;
        private ulong fnvhash;

        #endregion Fields

        #region Constructors

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

        #endregion Constructors

        #region Properties

        public ulong HashUInt64 => fnvhash == FnvHashInitial ? 0 : fnvhash;

        #endregion Properties

        #region Methods

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

        public static ulong HashReadOnlySpan(ReadOnlySpan<sbyte> source)
        {
            var hash = FnvHashInitial;
            foreach (var b in source)
            {
                unchecked
                {
                    hash = (hash ^ (uint)b) * FnvHashPrime;
                }
            }

            return hash;
        }

        public static ulong HashString(string value)
        {
            return HashString(value, Encoding.ASCII, false, false);
        }

        public static ulong HashString(string value, Encoding encoding, bool nullEnded = false, bool useSignedBuffer = false)
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

                if (useSignedBuffer)
                {
                    var signedBuffer = (sbyte[])(Array)buffer;
                    return HashReadOnlySpan(new ReadOnlySpan<sbyte>(signedBuffer, 0, encodedLength));
                }
                else
                {
                    return HashReadOnlySpan(new ReadOnlySpan<byte>(buffer, 0, encodedLength));
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
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

        public override void Initialize()
        {
            this.fnvhash = FnvHashInitial;
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

        #endregion Methods
    }
}
