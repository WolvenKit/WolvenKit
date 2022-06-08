using System;
using System.Security.Cryptography;

namespace WolvenKit.Core.CRC
{
    /// <summary>
    /// Implementation of CRC-32C (Castagnoli).
    /// This class supports several convenient static methods returning the CRC as UInt32.
    /// </summary>
    public class Crc32CAlgorithm : HashAlgorithm
    {
        private uint _currentCrc;

        private readonly bool _isBigEndian = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32CAlgorithm"/> class.
        /// </summary>
        public Crc32CAlgorithm()
        {
#if !NETCORE13
            HashSizeValue = 32;
#endif
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32CAlgorithm"/> class.
        /// </summary>
        /// <param name="isBigEndian">Should return bytes result as big endian or little endian</param>
        public Crc32CAlgorithm(bool isBigEndian = true)
            : this()
        {
            _isBigEndian = isBigEndian;
        }

        /// <summary>
        /// Computes CRC-32C from multiple buffers.
        /// Call this method multiple times to chain multiple buffers.
        /// </summary>
        /// <param name="initial">
        /// Initial CRC value for the algorithm. It is zero for the first buffer.
        /// Subsequent buffers should have their initial value set to CRC value returned by previous call to this method.
        /// </param>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <param name="offset">Offset of the input data within the buffer.</param>
        /// <param name="length">Length of the input data in the buffer.</param>
        /// <returns>Accumulated CRC-32C of all buffers processed so far.</returns>
        public static uint Append(uint initial, byte[] input, int offset, int length) => input == null
                ? throw new ArgumentNullException("input")
                : offset < 0 || length < 0 || offset + length > input.Length
                ? throw new ArgumentOutOfRangeException("length")
                : AppendInternal(initial, input, offset, length);

        /// <summary>
        /// Computes CRC-32C from multiple buffers.
        /// Call this method multiple times to chain multiple buffers.
        /// </summary>
        /// <param name="initial">
        /// Initial CRC value for the algorithm. It is zero for the first buffer.
        /// Subsequent buffers should have their initial value set to CRC value returned by previous call to this method.
        /// </param>
        /// <param name="input">Input buffer containing data to be checksummed.</param>
        /// <returns>Accumulated CRC-32C of all buffers processed so far.</returns>
        public static uint Append(uint initial, byte[] input) => input == null ? throw new ArgumentNullException("input") : AppendInternal(initial, input, 0, input.Length);

        /// <summary>
        /// Computes CRC-32C from input buffer.
        /// </summary>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <param name="offset">Offset of the input data within the buffer.</param>
        /// <param name="length">Length of the input data in the buffer.</param>
        /// <returns>CRC-32C of the data in the buffer.</returns>
        public static uint Compute(byte[] input, int offset, int length) => Append(0, input, offset, length);

        /// <summary>
        /// Computes CRC-32C from input buffer.
        /// </summary>
        /// <param name="input">Input buffer containing data to be checksummed.</param>
        /// <returns>CRC-32C of the buffer.</returns>
        public static uint Compute(byte[] input) => Append(0, input);

        /// <summary>
        /// Computes CRC-32C from input buffer and writes it after end of data (buffer should have 4 bytes reserved space for it). Can be used in conjunction with <see cref="IsValidWithCrcAtEnd(byte[],int,int)"/>
        /// </summary>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <param name="offset">Offset of the input data within the buffer.</param>
        /// <param name="length">Length of the input data in the buffer.</param>
        /// <returns>CRC-32C of the data in the buffer.</returns>
        public static uint ComputeAndWriteToEnd(byte[] input, int offset, int length)
        {
            if (length + 4 > input.Length)
            {
                throw new ArgumentOutOfRangeException("length", "Length of data should be less than array length - 4 bytes of CRC data");
            }

            var crc = Append(0, input, offset, length);
            var r = offset + length;
            input[r] = (byte)crc;
            input[r + 1] = (byte)(crc >> 8);
            input[r + 2] = (byte)(crc >> 16);
            input[r + 3] = (byte)(crc >> 24);
            return crc;
        }

        /// <summary>
        /// Computes CRC-32C from input buffer - 4 bytes and writes it as last 4 bytes of buffer. Can be used in conjunction with <see cref="IsValidWithCrcAtEnd(byte[])"/>
        /// </summary>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <returns>CRC-32C of the data in the buffer.</returns>
        public static uint ComputeAndWriteToEnd(byte[] input) => input.Length < 4
                ? throw new ArgumentOutOfRangeException("input", "Input array should be 4 bytes at least")
                : ComputeAndWriteToEnd(input, 0, input.Length - 4);

        /// <summary>
        /// Validates correctness of CRC-32C data in source buffer with assumption that CRC-32C data located at end of buffer in reverse bytes order. Can be used in conjunction with <see cref="ComputeAndWriteToEnd(byte[],int,int)"/>
        /// </summary>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <param name="offset">Offset of the input data within the buffer.</param>
        /// <param name="lengthWithCrc">Length of the input data in the buffer with CRC-32C bytes.</param>
        /// <returns>Is checksum valid.</returns>
        public static bool IsValidWithCrcAtEnd(byte[] input, int offset, int lengthWithCrc) => Append(0, input, offset, lengthWithCrc) == 0x48674BC7;

        /// <summary>
        /// Validates correctness of CRC-32C data in source buffer with assumption that CRC-32C data located at end of buffer in reverse bytes order. Can be used in conjunction with <see cref="ComputeAndWriteToEnd(byte[],int,int)"/>
        /// </summary>
        /// <param name="input">Input buffer with data to be checksummed.</param>
        /// <returns>Is checksum valid.</returns>
        public static bool IsValidWithCrcAtEnd(byte[] input) => input.Length < 4
                ? throw new ArgumentOutOfRangeException("input", "Input array should be 4 bytes at least")
                : Append(0, input, 0, input.Length) == 0x48674BC7;

        /// <summary>
        /// Resets internal state of the algorithm. Used internally.
        /// </summary>
        public override void Initialize() => _currentCrc = 0;

        /// <summary>
        /// Appends CRC-32C from given buffer
        /// </summary>
        protected override void HashCore(byte[] input, int offset, int length) => _currentCrc = AppendInternal(_currentCrc, input, offset, length);

        /// <summary>
        /// Computes CRC-32C from <see cref="HashCore"/>
        /// </summary>
        protected override byte[] HashFinal() => _isBigEndian
                ? (new[] { (byte)(_currentCrc >> 24), (byte)(_currentCrc >> 16), (byte)(_currentCrc >> 8), (byte)_currentCrc })
                : (new[] { (byte)_currentCrc, (byte)(_currentCrc >> 8), (byte)(_currentCrc >> 16), (byte)(_currentCrc >> 24) });

        private static readonly SafeProxyC _proxy = new();

        private static uint AppendInternal(uint initial, byte[] input, int offset, int length) => length > 0 ? _proxy.Append(initial, input, offset, length) : initial;
    }
}
