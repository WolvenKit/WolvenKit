using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using Microsoft.IO;
using RED.CRC32;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB
{
    internal class FlatsPool
    {
        private class TypeBucket
        {
            private static readonly RecyclableMemoryStreamManager s_streamManager = new();

            private readonly Dictionary<string, ulong> _flats = new();

            /// <summary>
            /// Used to store the flats with their value index.
            /// </summary>
            /// <remarks>Stored as <code>(name, value hash)</code></remarks>
            public IReadOnlyDictionary<string, ulong> Flats => _flats;

            private readonly Dictionary<ulong, IType> _values = new();

            /// <summary>
            /// Used to store the values.
            /// </summary>
            /// <remarks>
            /// Each value is present only once, for example adding a value of 1, 2 and 1, will result in 1 being preset only once.
            /// Stored as  <code>(value hash, value)</code>
            /// </remarks>
            public IReadOnlyDictionary<ulong, IType> Values => _values;

            public void Add(string flat, IType value)
            {
                if (_flats.ContainsKey(flat))
                {
                    throw new ArgumentException("A flat with the same name is already present in the bucket");
                }

                var valueHash = GetValueHash(value);
                if (!_values.ContainsKey(valueHash))
                {
                    _values.Add(valueHash, value);
                }

                _flats.Add(flat, valueHash);
            }

            private static uint GetValueHash(IType value)
            {
                using var stream = s_streamManager.GetStream();
                using var writer = new BinaryWriter(stream);
                value.Serialize(writer);

                var length = (int)stream.Length;
                var data = ArrayPool<byte>.Shared.Rent(length);

                stream.Seek(0, SeekOrigin.Begin);
                if (stream.Read(data, 0, length) != stream.Length)
                {
                    throw new ApplicationException("stream.Read != stream.Length");
                }

                var hash = Crc32Algorithm.Compute(data, 0, length);
                ArrayPool<byte>.Shared.Return(data);

                return hash;
            }
        }

        /// <summary>
        /// Used to prevent duplicates from being added to the pool.
        /// </summary>
        /// <remarks>Stored as: <code>FNV1a64(text)</code></remarks>
        private readonly HashSet<string> _names = new();
        private readonly Dictionary<ulong, TypeBucket> _types = new();

        /// <summary>
        /// Add a new value to the pool.
        /// </summary>
        /// <param name="name">The name used by the value.</param>
        /// <param name="value">The value to be added.</param>
        public void Add(string name, IType value)
        {
            if (name.Length > byte.MaxValue)
            {
                throw new ArgumentException($"A flat with key must be less or equal with {byte.MaxValue} characters");
            }

            if (_names.Contains(name))
            {
                throw new ArgumentException($"A flat with key '{name}' already exists");
            }

            var type = FNV1A64HashAlgorithm.HashString(value.Name);
            if (!_types.TryGetValue(type, out var bucket))
            {
                bucket = new TypeBucket();
                _types.Add(type, bucket);
            }

            bucket.Add(name, value);
            _names.Add(name);
        }

        /// <summary>
        /// Serialize the pool.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public void Serialize(BinaryWriter writer)
        {
            // Write the types.
            writer.Write(_types.Count);
            foreach (var (name, bucket) in _types)
            {
                writer.Write(name);
                writer.Write(bucket.Values.Count);
            }

            // Will use it to store value indexes for types.
            var indexes = new Dictionary<ulong, uint>();

            // Write the values for every type.
            foreach (var (_, bucket) in _types)
            {
                uint currValueIndex = 0;

                writer.Write(bucket.Values.Count);
                foreach (var (hash, value) in bucket.Values)
                {
                    value.Serialize(writer);

                    if (!indexes.ContainsKey(hash))
                    {
                        indexes.Add(hash, currValueIndex++);
                    }
                }

                writer.Write(bucket.Flats.Count);
                foreach (var (name, valueHash) in bucket.Flats)
                {
                    var hash = Crc32Algorithm.Compute(name);
                    writer.Write(hash);
                    writer.Write((byte)name.Length);
                    writer.Write((byte)0); // TBD offset 0.
                    writer.Write((byte)0); // TBD offset 0.
                    writer.Write((byte)0); // TBD offset 1.

                    writer.Write(indexes[valueHash]);
                }

                indexes.Clear();
            }
        }
    }
}
