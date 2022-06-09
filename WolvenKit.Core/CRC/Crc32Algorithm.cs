using System;
using System.Security.Cryptography;
using System.Text;

namespace WolvenKit.Core.CRC
{
    /// <summary>
    /// Implementation of CRC-32.
    /// This class supports several convenient static methods returning the CRC as UInt32.
    /// </summary>
    public class Crc32Algorithm : HashAlgorithm
    {
        private readonly bool _isBigEndian = true;

        /// <summary>
        /// Get the current hash value as a UInt32 value;
        /// </summary>
        public uint HashUInt32 { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32Algorithm"/> class.
        /// </summary>
        public Crc32Algorithm()
        {
#if !NETCORE13
            HashSizeValue = 32;
#endif
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32Algorithm"/> class.
        /// </summary>
        /// <param name="isBigEndian">Should return bytes result as big endian or little endian</param>
        // Crc32 by dariogriffo uses big endian, so, we need to be compatible and return big endian as default
        public Crc32Algorithm(bool isBigEndian = true)
            : this()
        {
            _isBigEndian = isBigEndian;
        }

        /// <summary>
        /// Computes CRC-32 from multiple buffers.
        /// Call this method multiple times to chain multiple buffers.
        /// </summary>
        /// <param name="initial">
        /// Initial CRC value for the algorithm. It is zero for the first buffer.
        /// Subsequent buffers should have their initial value set to CRC value returned by previous call to this method.
        /// </param>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <param name="offset">Offset of the input data within the buffer.</param>
        /// <param name="length">Length of the input data in the buffer.</param>
        /// <returns>Accumulated CRC-32 of all buffers processed so far.</returns>
        public static uint Append(uint initial, byte[] input, int offset, int length)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (offset < 0 || length < 0 || offset + length > input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            return AppendInternal(initial, input, offset, length);
        }

        /// <summary>
        /// Computes CRC-32 from multiple buffers.
        /// Call this method multiple times to chain multiple buffers.
        /// </summary>
        /// <param name="initial">
        /// Initial CRC value for the algorithm. It is zero for the first buffer.
        /// Subsequent buffers should have their initial value set to CRC value returned by previous call to this method.
        /// </param>
        /// <param name="input">Input buffer containing data to be checksummed.</param>
        /// <returns>Accumulated CRC-32 of all buffers processed so far.</returns>
        public static uint Append(uint initial, byte[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            return AppendInternal(initial, input, 0, input.Length);
        }

        /// <summary>
        /// Computes CRC-32 from an ASCII string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>CRC-32 of the <paramref name="input"/>.</returns>
        public static uint Compute(string input) => Compute(input, Encoding.ASCII);

        /// <summary>
        /// Computes CRC-32 from a string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="encoding">The encoding of the string.</param>
        /// <returns>CRC-32 of the <paramref name="input"/>.</returns>
        public static uint Compute(string input, Encoding encoding)
        {
            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            var bytes = encoding.GetBytes(input);
            return Append(0, bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Computes CRC-32 from input buffer.
        /// </summary>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <param name="offset">Offset of the input data within the buffer.</param>
        /// <param name="length">Length of the input data in the buffer.</param>
        /// <returns>CRC-32 of the data in the buffer.</returns>
        public static uint Compute(byte[] input, int offset, int length) => Append(0, input, offset, length);

        /// <summary>
        /// Computes CRC-32 from input buffer.
        /// </summary>
        /// <param name="input">Input buffer containing data to be checksummed.</param>
        /// <returns>CRC-32 of the buffer.</returns>
        public static uint Compute(byte[] input) => Append(0, input);

        /// <summary>
        /// Resets internal state of the algorithm. Used internally.
        /// </summary>
        public override void Initialize() => HashUInt32 = 0;

        /// <summary>
		/// Appends CRC-32 from multiple buffers, using the currently stored hash value.
		/// Call this method multiple times to chain multiple buffers.
		/// </summary>
		/// <param name="input">Input buffer with data to be checksummed.</param>
        public void Append(byte[] input) => HashCore(input, 0, input.Length);

        /// <summary>
		/// Appends CRC-32 from multiple buffers, using the currently stored hash value.
		/// Call this method multiple times to chain multiple buffers.
		/// </summary>
		/// <param name="input">Input buffer with data to be checksummed.</param>
		/// <param name="offset">Offset of the input data within the buffer.</param>
		/// <param name="length">Length of the input data in the buffer.</param>
        public void Append(byte[] input, int offset, int length) => HashCore(input, offset, length);

        public void Append(uint value) => Append(BitConverter.GetBytes(value));

        public void Append(ulong value) => Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Appends CRC-32 from given buffer
        /// </summary>
        protected override void HashCore(byte[] input, int offset, int length) => HashUInt32 = AppendInternal(HashUInt32, input, offset, length);

        /// <summary>
        /// Computes CRC-32 from <see cref="HashCore"/>
        /// </summary>
        protected override byte[] HashFinal()
        {
            if (_isBigEndian)
            {
                return new[] { (byte)(HashUInt32 >> 24), (byte)(HashUInt32 >> 16), (byte)(HashUInt32 >> 8), (byte)HashUInt32 };
            }
            else
            {
                return new[] { (byte)HashUInt32, (byte)(HashUInt32 >> 8), (byte)(HashUInt32 >> 16), (byte)(HashUInt32 >> 24) };
            }
        }

        private static readonly SafeProxy _proxy = new();

        private static uint AppendInternal(uint initial, byte[] input, int offset, int length)
        {
            if (length > 0)
            {
                return _proxy.Append(initial, input, offset, length);
            }
            else
            {
                return initial;
            }
        }
    }
}
