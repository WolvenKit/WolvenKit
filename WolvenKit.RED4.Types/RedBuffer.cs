using System;
using WolvenKit.RED4.Types;
using WolvenKit.Core.Compression;
using System.Collections.Generic;

namespace WolvenKit.RED4
{
    public class RedBuffer : IRedBuffer, IEquatable<RedBuffer>
    {
        private byte[] _bytes = Array.Empty<byte>();

        public HashSet<string> ParentTypes { get; } = new();
        public RedBaseClass Parent { get; set; }

        public uint Flags { get; set; }
        public bool IsEmpty => _bytes == Array.Empty<byte>();
        public IParseableBuffer Data { get; set; }

        public RedBaseClass RootChunk { get; set; }

        /// <summary>
        /// The length of the uncompressed data
        /// </summary>
        public uint MemSize => (uint)_bytes.Length;

        
        /// <summary>
        /// </summary>
        /// <returns>The decompressed byte[]</returns>
        public byte[] GetBytes() => _bytes;

        /// <summary>
        /// </summary>
        /// <returns>The compressed byte[]</returns>
        public byte[] GetCompressedBytes()
        {
            Oodle.CompressBuffer(_bytes, out var result);
            return result;
        }

        public byte[] GetCompressedBytes(Oodle.CompressionLevel compressionLevel)
        {
            Oodle.CompressBuffer(_bytes, out var result, compressionLevel);
            return result;
        }

        public void SetBytes(byte[] data)
        {
            if (Oodle.IsCompressed(data))
            {
                Oodle.DecompressBuffer(data, out var raw);

                _bytes = raw;
            }
            else
            {
                _bytes = data;
            }
        }


        public static RedBuffer CreateBuffer(uint flags, byte[] data)
        {
            if (Oodle.IsCompressed(data))
            {
                Oodle.DecompressBuffer(data, out var raw);
                return new RedBuffer { Flags = flags, _bytes = raw };
            }

            return new RedBuffer { Flags = flags, _bytes = data };
        }

        private ReadOnlySpan<byte> GetSpan() => new(_bytes);


        public bool Equals(RedBuffer other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (!Equals(Flags, other.Flags))
            {
                return false;
            }

            if (!Equals(_bytes.Length, other._bytes.Length))
            {
                return false;
            }

            if (!GetSpan().SequenceEqual(other.GetSpan()))
            {
                return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((RedBuffer)obj);
        }

        public override int GetHashCode() => HashCode.Combine(_bytes, Flags);
    }
}
