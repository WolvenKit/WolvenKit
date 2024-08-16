using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Unmanaged;
using WolvenKit.RED4.TweakDB.Helper;
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

        private static readonly int _maxDoP = (Environment.ProcessorCount - 2) > 1 ? Environment.ProcessorCount : 1;

        private readonly Dictionary<ulong, SAsciiString> _hashes = new();

        private Dictionary<ulong, string> _missing = new();

        #endregion Fields

        #region Constructors

        public HashService() => Load();

        #endregion Constructors

        #region Methods

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

        private void Load()
        {
            var hashesMemory = DecompressEmbeddedFile(s_used);
            ReadHashes(hashesMemory.GetStream());
            
            hashesMemory.Dispose();
            
            var nodeRefsMemory = DecompressEmbeddedFile(s_nodeRefs);
            ReadNodeRefs(nodeRefsMemory.GetStream());
            
            nodeRefsMemory.Dispose();
            
            var tweakNamesMemory = DecompressEmbeddedFile(s_tweakDbStr);
            ReadTweakNames(tweakNamesMemory.GetStream());
            
            tweakNamesMemory.Dispose();
            
            LoadMissingHashes();
        }
        
        private static unsafe UnmanagedMemory DecompressEmbeddedFile(string resourceName)
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
            var decompressedBuffer = UnmanagedMemory.Allocate((int) outputSize);
            
            // read the rest of the stream
            var read = stream.Read(compressedBuffer.GetSpan());

            if (read != compressedBufferLength)
                throw new InvalidOperationException("Read less bytes than expected!");

            Oodle.Decompress(
                compressedBuffer.Pointer, compressedBuffer.Size,
                decompressedBuffer.Pointer, decompressedBuffer.Size);
            
            return decompressedBuffer;
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
                        break;
                    
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

        private void ReadHashes(Stream memoryStream)
        {
            var dict = new ConcurrentDictionary<ulong, string>();
            
            ProcessLinesConcurrently(memoryStream, line =>
            {
                dict.GetOrAdd(ResourcePath.CalculateHash(line), line);
            });
            
            ResourcePathPool.SetNative(dict);
        }

        private void ReadNodeRefs(Stream memoryStream) => 
            ProcessLinesConcurrently(memoryStream, line => NodeRefPool.AddOrGetHash(line));

        private void ReadTweakNames(Stream memoryStream)
        {
            var tweakHelper = new TweakDBStringHelper();
            tweakHelper.LoadFromStream(memoryStream);

            var hashes = new HashSet<ulong>();
            var dict = new Dictionary<ulong, string>();
            foreach (var (hash, value) in tweakHelper.GetAll())
            {
                if (!hashes.Add(hash))
                {
                    continue;
                }
                
                dict.Add(hash, value);
            }
            TweakDBIDPool.SetNative(dict);
        }

        #endregion Methods
    }
}
