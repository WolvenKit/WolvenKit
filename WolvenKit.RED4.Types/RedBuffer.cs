using System;
using WolvenKit.RED4.Types;
using WolvenKit.Core.Compression;
using System.Collections.Generic;

namespace WolvenKit.RED4
{
    public class RedBuffer : IRedBuffer
    {
        public HashSet<string> ParentTypes { get; } = new();

        private byte[] _bytes = Array.Empty<byte>();


        public uint Flags { get; set; }

        /// <summary>
        /// Contains the compressed (if possible) data
        /// </summary>
        public byte[] Bytes
        {
            get => _bytes;
            protected set => _bytes = value;
        }

        /// <summary>
        /// The length of the uncompressed data
        /// </summary>
        public uint MemSize { get; set; }
        public bool IsCompressed => Oodle.IsCompressed(_bytes);

        public IParseableBuffer Data { get; set; }
        

        public void Compress()
        {
            if (IsCompressed || _bytes.Length <= 0xFF)
            {
                return;
            }

            Oodle.CompressBuffer(_bytes, out _bytes);
        }

        public void Decompress()
        {
            if (!IsCompressed)
            {
                return;
            }

            Oodle.DecompressBuffer(_bytes, out _bytes);
        }

        /// <summary>
        /// </summary>
        /// <returns>The decompressed byte[]</returns>
        public byte[] GetBytes()
        {
            if (IsCompressed)
            {
                Oodle.DecompressBuffer(_bytes, out var result);
                return result;
            }

            return _bytes;
        }

        public void SetBytes(byte[] data)
        {
            if (Oodle.IsCompressed(data))
            {
                _bytes = data;

                Oodle.DecompressBuffer(data, out var raw);
                MemSize = (uint)raw.Length;
            }
            else
            {
                MemSize = (uint)data.Length;
                Oodle.CompressBuffer(data, out _bytes);
            }
        }

        public void SetBytes(byte[] data, uint memSize)
        {
            if (Oodle.IsCompressed(data))
            {
                _bytes = data;
                MemSize = memSize;
            }
            else
            {
                if ((uint)data.Length != memSize)
                {
                    throw new ArgumentException(nameof(memSize));
                }

                Oodle.CompressBuffer(data, out _bytes);
                MemSize = memSize;
            }
        }

        public static RedBuffer CreateBuffer(uint flags, byte[] data)
        {
            if (Oodle.IsCompressed(data))
            {
                Oodle.DecompressBuffer(data, out var raw);
                return new RedBuffer { Flags = flags, Bytes = data, MemSize = (uint)raw.Length };
            }

            Oodle.CompressBuffer(data, out var compressedBuf);
            return new RedBuffer { Flags = flags, Bytes = compressedBuf, MemSize = (uint)data.Length };
        }

        public static RedBuffer CreateBuffer(uint flags, byte[] data, int memSize = -1)
        {
            if (Oodle.IsCompressed(data))
            {
                if (memSize == -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(memSize));
                }

                return new RedBuffer { Flags = flags, Bytes = data, MemSize = (uint)memSize };
            }

            Oodle.CompressBuffer(data, out var compressedBuf);
            return new RedBuffer { Flags = flags, Bytes = compressedBuf, MemSize = (uint)data.Length };
        }
    }
}
