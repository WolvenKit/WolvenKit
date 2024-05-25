using System;
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
            ReadHashes(DecompressEmbeddedFile(s_used));
            ReadNodeRefs(DecompressEmbeddedFile(s_nodeRefs));
            ReadTweakNames(DecompressEmbeddedFile(s_tweakDbStr));
            LoadMissingHashes();
        }

        private MemoryStream DecompressEmbeddedFile(string resourceName)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName).NotNull();

            // read KARK header
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression != Oodle.KARK)
            {
                throw new DecompressionException($"Incorrect hash file.");
            }

            var outputsize = stream.ReadStruct<uint>();

            // read the rest of the stream
            var outputbuffer = new byte[outputsize];

            var inbuffer = stream.ToByteArray(true);

            Oodle.Decompress(inbuffer, outputbuffer);

            return new MemoryStream(outputbuffer);
        }

        private string[] ReadAllLines(Stream memoryStream)
        {
            using var sr = new StreamReader(memoryStream);
            
            var list = new List<string>();
            while (sr.ReadLine() is { } line)
            {
                list.Add(line);
            }

            return list.ToArray();
        }

        private void LoadMissingHashes()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s_missing).NotNull();
            _missing = JsonSerializer.Deserialize<Dictionary<ulong, string>>(stream).NotNull();
        }

        private void ReadHashes(Stream memoryStream)
        {
            var dict = new Dictionary<ulong, string>();
            foreach (var line in ReadAllLines(memoryStream))
            {
                dict.Add(ResourcePath.CalculateHash(line), line);
            }
            ResourcePathPool.SetNative(dict);
        }

        private void ReadNodeRefs(Stream memoryStream) => 
            Parallel.ForEach(ReadAllLines(memoryStream), line => { NodeRefPool.AddOrGetHash(line); });

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
