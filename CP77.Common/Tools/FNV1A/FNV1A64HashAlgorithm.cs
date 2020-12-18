using System;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Hash algorithm, Fowler–Noll–Vo
/// </summary>
namespace CP77.Common.Tools.FNV1A
{
    public sealed class FNV1A64HashAlgorithm : HashAlgorithm
    {
        private const ulong FnvHashPrime = 0x00000100000001B3;
        private const ulong FnvHashInitial = 0xCBF29CE484222325;

        private ulong fnvhash;
        private Encoding encoding;

        public ulong HashUInt64
        {
            get
            {
                if (fnvhash == FnvHashInitial)
                {
                    return 0;
                }
                return fnvhash;
            }
        }

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
            if (String.IsNullOrEmpty(value))
                return;

            var buffer = new char[nullEnded ? value.Length + 1 : value.Length];
            value.CopyTo(0, buffer, 0, value.Length);

            var data = encoding.GetBytes(buffer);

            HashCore(data, 0, data.Length);
        }

        public static ulong HashString(string value)
        {
            return HashString(value, Encoding.ASCII, false);
        }
        public static ulong HashString(string value, Encoding encoding)
        {
            return HashString(value, encoding, false);
        }
        public static ulong HashString(string value, Encoding encoding, bool nullEnded)
        {
            if (String.IsNullOrEmpty(value))
                return 0;

            var buffer = new char[nullEnded ? value.Length + 1 : value.Length];
            value.CopyTo(0, buffer, 0, value.Length);

            var fnv1a = new FNV1A64HashAlgorithm();
            var data = encoding.GetBytes(buffer);

            fnv1a.HashCore(data, 0, data.Length);

            return fnv1a.fnvhash;
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
                    this.fnvhash ^= array[i];
                    this.fnvhash *= FnvHashPrime;
                }
            }
        }

        protected override byte[] HashFinal()
        {
            return BitConverter.GetBytes(this.HashUInt64);
        }
    }
}