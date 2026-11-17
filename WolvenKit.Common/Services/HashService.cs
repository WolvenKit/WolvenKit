using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Helpers;
using WolvenKit.Core.Unmanaged;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.Common.Services
{
    public class HashService : IHashService
    {
        #region Fields

        private const string s_used = "WolvenKit.Common.Resources.usedhashes.kark";
        private const string s_nodeRefs = "WolvenKit.Common.Resources.noderefs.kark";
        private const string s_tweakDbStr = "WolvenKit.Common.Resources.tweakdbstr.kark";
        private const string s_missing = "WolvenKit.Common.Resources.missinghashes.json";

        private static readonly int _maxDoP = Environment.ProcessorCount > 2 ? (Environment.ProcessorCount - 2) : 1;

        private readonly Dictionary<ulong, SAsciiString> _hashes = new();

        private Dictionary<ulong, string> _missing = new();

        private volatile bool _isLoaded;
        private readonly TaskCompletionSource _loader = new();

        public Task Loaded => _loader.Task;

        #endregion Fields

        #region Constructors

        public HashService() : this(true)
        {
        }

        public HashService(bool autoLoad)
        {
            if (autoLoad)
            {
                Load();
            }
        }

        #endregion Constructors

        #region Methods

        public void Load()
        {
            if (_isLoaded)
            {
                return;
            }

            try
            {
                ReadHashes(DecompressEmbeddedFile(s_used));
                ReadNodeRefs(DecompressEmbeddedFile(s_nodeRefs));
                ReadTweakNames(DecompressEmbeddedFile(s_tweakDbStr));

                LoadMissingHashes();

                _isLoaded = true;
                _loader.SetResult();
            }
            catch (Exception e)
            {
                _loader.SetException(e);
                throw;
            }
        }

        public IEnumerable<ulong> GetAllHashes() => _hashes.Keys;

        public IEnumerable<ulong> GetMissingHashes() => _missing.Keys;

        public bool Contains(ulong key, bool checkUserHashes = true)
        {
            if (ResourcePathPool.IsNative(key))
            {
                return true;
            }

            if (checkUserHashes && ResourcePathPool.IsRuntime(key))
            {
                return true;
            }

            if (_missing.ContainsKey(key))
            {
                return false;
            }

            return false;
        }

        public string? GetGuessedExtension(ulong key)
        {
            if (_missing.TryGetValue(key, out var ext))
            {
                return ext;
            }
            return null;
        }

        public string? Get(ulong key)
        {
            if (ResourcePathPool.ResolveHash(key) is { } value)
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Decompresses an embedded KARK resource straight into an unmanaged <see cref="StringBlob"/>.
        /// </summary>
        private static unsafe StringBlob DecompressEmbeddedFile(string resourceName)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName).NotNull();

            // read KARK header
            var oodleCompression = stream.ReadStruct<uint>();

            if (oodleCompression != Oodle.KARK)
            {
                throw new DecompressionException("Incorrect hash file.");
            }

            var outputSize = stream.ReadStruct<uint>();

            var compressedBufferLength = (int)(stream.Length - (sizeof(uint) * 2));
            using var compressedBuffer = UnmanagedMemory.Allocate(compressedBufferLength);
            var decompressedBuffer = StringBlob.Allocate((int)outputSize);

            // read the rest of the stream
            var read = stream.Read(compressedBuffer.GetSpan());

            if (read != compressedBufferLength)
            {
                decompressedBuffer.Dispose();
                throw new InvalidOperationException("Read less bytes than expected!");
            }

            Oodle.Decompress(
                compressedBuffer.Pointer, compressedBuffer.Size,
                decompressedBuffer.Pointer, decompressedBuffer.Size);

            return decompressedBuffer;
        }

        /// <summary>
        /// Splits a newline-delimited blob into exactly-sized <see cref="StringRef"/> entries that
        /// point back into the blob. No strings and no intermediate list are created.
        /// </summary>
        private static StringRef[] SplitLines(StringBlob blob)
        {
            var span = blob.AsSpan();

            var bodyStart = span.Length >= 3
                            && span[0] == 0xEF
                            && span[1] == 0xBB
                            && span[2] == 0xBF ? 3 : 0;

            var body = span[bodyStart..];
            var count = body.Count((byte)'\n');

            if (body.Length > 0 && body[^1] != (byte)'\n')
            {
                count++;
            }

            var references = new StringRef[count];
            var written = 0;
            var position = 0;

            while (position < body.Length && written < count)
            {
                var newline = body[position..].IndexOf((byte)'\n');
                var end = newline < 0 ? body.Length : position + newline;
                var lineEnd = end;

                if (lineEnd > position && body[lineEnd - 1] == (byte)'\r')
                {
                    lineEnd--;
                }

                references[written++] =
                    new StringRef(bodyStart + position, lineEnd - position);

                if (newline < 0)
                {
                    break;
                }

                position = end + 1;
            }

            if (written != references.Length)
            {
                Array.Resize(ref references, written);
            }

            return references;
        }

        /// <summary>
        /// Span-based equivalent of <c>BinaryReaderExtensions.ReadVLQInt32</c>,
        /// so the tweak name table can be parsed without a <see cref="BinaryReader"/>
        /// or per-entry buffers.
        /// </summary>
        private static int ReadVlqInt32(ReadOnlySpan<byte> span, ref int position)
        {
            const byte continuation = 0b10000000;
            const byte valueMask = 0b01111111;

            var b = span[position++];
            var isNegative = (b & 0b10000000) != 0;
            var value = b & 0b00111111;

            if ((b & 0b01000000) != 0)
            {
                b = span[position++];
                value |= (b & valueMask) << 6;

                if ((b & continuation) != 0)
                {
                    b = span[position++];
                    value |= (b & valueMask) << 13;

                    if ((b & continuation) != 0)
                    {
                        b = span[position++];
                        value |= (b & valueMask) << 20;

                        if ((b & continuation) != 0)
                        {
                            b = span[position++];
                            value |= (b & valueMask) << 27;

                            if ((b & continuation) != 0)
                            {
                                throw new InvalidDataException("Continuation bit set on 5th byte");
                            }
                        }
                    }
                }
            }

            return isNegative ? -value : value;
        }

        private void ProcessLinesConcurrently(Stream memoryStream, Action<string> lineAction)
        {
            var collection = new BlockingCollection<string>();

            var readerTask = Task.Run(() =>
            {
                using var sr = new StreamReader(memoryStream);

                while (true)
                {
                    var nextLine = sr.ReadLine();

                    if (nextLine == null)
                    {
                        break;
                    }

                    collection.Add(nextLine);
                }

                collection.CompleteAdding();
            });

            Parallel.ForEach(collection.GetConsumingEnumerable(), new ParallelOptions
            {
                MaxDegreeOfParallelism = _maxDoP,
            }, lineAction);

            readerTask.Wait();
        }

        private void LoadMissingHashes()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s_missing).NotNull();
            _missing = JsonSerializer.Deserialize<Dictionary<ulong, string>>(stream).NotNull();
        }

        private void ReadHashes(StringBlob blob)
        {
            ResourcePathPool.SetNative(
                new LookupTable(blob, SplitLines(blob), _maxDoP, ResourcePath.CalculateHashUtf8));
        }

        private void ReadNodeRefs(StringBlob blob)
        {
            NodeRefPool.SetNative(
                new LookupTable(blob, SplitLines(blob), _maxDoP, NodeRef.CalculateHashUtf8));
        }

        /// <summary>
        /// Parses the length-prefixed tweak name table.
        /// </summary>
        private void ReadTweakNames(StringBlob blob)
        {
            const int headerSize = 20;

            var span = blob.AsSpan();

            // Pass one: count entries, so the reference array is sized exactly.
            var count = 0;
            var position = headerSize;
            while (position < span.Length)
            {
                var prefix = ReadVlqInt32(span, ref position);
                var byteCount = prefix > 0 ? Math.Abs(prefix) * 2 : Math.Abs(prefix);

                if (position + byteCount > span.Length)
                {
                    break;
                }

                position += byteCount;
                count++;
            }

            // Pass two: compact into a UTF-8 blob.
            var references = new StringRef[count];
            using var builder = new StringBlobBuilder(Math.Max(span.Length - headerSize, 64));

            position = headerSize;
            for (var i = 0; i < count; i++)
            {
                var prefix = ReadVlqInt32(span, ref position);
                var length = Math.Abs(prefix);

                if (length == 0)
                {
                    references[i] = new StringRef(builder.Length, 0);
                    continue;
                }

                if (prefix > 0)
                {
                    // UTF-16 payload, transcoded without ever creating a string
                    references[i] = builder.AddUtf16(MemoryMarshal.Cast<byte, char>(span.Slice(position, length * 2)));
                    position += length * 2;
                }
                else
                {
                    references[i] = builder.AddUtf8(span.Slice(position, length));
                    position += length;
                }
            }

            var compacted = builder.Build();
            blob.Dispose();

            TweakDBIDPool.SetNative(
                new LookupTable(compacted, references, _maxDoP, TweakDBID.CalculateHashUtf8));
        }

        #endregion Methods
    }
}
