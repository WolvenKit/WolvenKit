using System;
using System.Security.Cryptography;
using System.Text;

namespace WolvenKit.Common.FNV1A
{
    /// <summary>
    /// Implementation of the Fowler–Noll–Vo 32 bit hash algorithm.
    /// </summary>
    public sealed class FNV1A32HashAlgorithm : HashAlgorithm
    {
        #region Fields

        private const uint FnvHashInitial = 0x811C9DC5;
        private const uint FnvHashPrime = 0x01000193;
        private readonly Encoding encoding;
        private uint fnvhash;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initialise a new instance of the <see cref="FNV1A32HashAlgorithm"/> class,
        /// using the default <see cref="ASCIIEncoding"/> class for characters.
        /// </summary>
        public FNV1A32HashAlgorithm()
            : this(Encoding.ASCII)
        {
        }

        /// <summary>
        /// Initialise a new instance of the <see cref="FNV1A32HashAlgorithm"/> class, using custom encoding for characters.
        /// </summary>
        /// <param name="encoding">The encoding class to use for characters and strings.</param>
        public FNV1A32HashAlgorithm(Encoding encoding)
        {
            Initialize();
            HashSizeValue = 32;
            this.encoding = encoding ?? Encoding.ASCII;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Current hash value as a 32 bit unsigned integer.
        /// </summary>
        public uint HashUInt32 => fnvhash == FnvHashInitial ? 0 : fnvhash;

        #endregion Properties

        #region Methods

        /// <summary>
        /// Hash a string using the default <see cref="ASCIIEncoding"/> class.
        /// </summary>
        /// <param name="value">The string to hash.</param>
        /// <returns>The 32 bit hash value.</returns>
        public static uint HashString(string value) => HashString(value, Encoding.ASCII, false);

        /// <summary>
        /// Hash a string using a custom encoding class.
        /// </summary>
        /// <param name="value">The string to hash.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The 32 bit hash value.</returns>
        public static uint HashString(string value, Encoding encoding) => HashString(value, encoding, false);

        /// <summary>
        /// Hash a string using a custom encoding class, and specify if a null character should be appended before hashing.
        /// </summary>
        /// <param name="value">The string to hash.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <param name="nullEnded">Append a null character to the end of the string.</param>
        /// <returns>The 32 bit hash value.</returns>
        public static uint HashString(string value, Encoding encoding, bool nullEnded)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }

            var buffer = nullEnded ? new char[value.Length + 1] : new char[value.Length];
            value.CopyTo(0, buffer, 0, value.Length);

            var fnv1a = new FNV1A32HashAlgorithm();
            var data = encoding.GetBytes(buffer);

            fnv1a.HashCore(data, 0, data.Length);
            return fnv1a.HashUInt32;
        }

        /// <summary>
        /// Append a string to the current hash value using the encoding for this instance.
        /// </summary>
        /// <param name="value">The string to append to the current hash value.</param>
        public void AppendString(string value) => AppendString(value, false);

        /// <summary>
        /// Append a string to the current hash value using the encoding for this instance,
        /// and specify if a null characters should be appended before hashing.
        /// </summary>
        /// <param name="value">The string to append to the current hash value.</param>
        /// <param name="nullEnded">Append a null character to the end of the string.</param>
        public void AppendString(string value, bool nullEnded)
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            var buffer = nullEnded ? new char[value.Length + 1] : new char[value.Length];
            value.CopyTo(0, buffer, 0, value.Length);
            var data = encoding.GetBytes(buffer);

            HashCore(data, 0, data.Length);
        }

        /// <summary>
        /// Initialise this instance and reset the current hash value.
        /// </summary>
        public override void Initialize() => fnvhash = FnvHashInitial;

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
                for (var i = ibStart; i < ibEnd; i++)
                {
                    fnvhash ^= array[i];
                    fnvhash *= FnvHashPrime;
                }
            }
        }

        /// <summary>
        /// Get the current 32 bit hash as a 4 byte array.
        /// </summary>
        /// <returns>The computed hash.</returns>
        protected override byte[] HashFinal() => BitConverter.GetBytes(HashUInt32);

        #endregion Methods
    }
}
