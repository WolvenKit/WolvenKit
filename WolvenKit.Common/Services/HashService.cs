using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using ProtoBuf;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Common.Services
{
    public class HashService : IHashService
    {
        #region Fields

        private const string s_hashFileName = "archivehashes.txt";
        private const string s_hashZipName = "WolvenKit.Common.Resources.archivehashes.zip";

        private const string s_lookupRes = "WolvenKit.Common.Resources.hash_lookup.bin";
        private const string s_keyRes = "WolvenKit.Common.Resources.hash_keys.bin";

        private static string GetHashCacheZipName(int i) => $"WolvenKit.Common.Resources.hash_cache_{i}.zip";
        private static string GetHashCacheName(int i) => $"hash_cache_{i}.bin";


        private readonly ILoggerService _loggerService;

        private Dictionary<int,Dictionary<ulong, string>> cacheList;
        private readonly Dictionary<int,ulong> _lookup;

        #endregion Fields

        #region Constructors

        public HashService(ILoggerService loggerService)
        {
            _loggerService = loggerService;

            cacheList = new Dictionary<int, Dictionary<ulong, string>>();
            for (var i = 0; i < 11; i++)
            {
                cacheList.Add(i, new Dictionary<ulong, string>());
            }

            //get lookup
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s_lookupRes);
            _lookup = Serializer.Deserialize<Dictionary<int, ulong>>(stream);
        }

        #endregion Constructors

        #region Methods
        private int GetCacheKey(ulong key)
        {
            foreach (var (i, value) in _lookup)
            {
                if (key < value)
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException();
        }

        public bool Contains(ulong key)
        {
            // get the correct cache
            var chacheKey = GetCacheKey(key);

            // lazyly load the cache
            if (cacheList[chacheKey].Count < 1)

            {
                Load(chacheKey);
            }

            return cacheList[chacheKey].ContainsKey(key);
        }

        public string Get(ulong key)
        {
            // get the correct cache
            var chacheKey = GetCacheKey(key);

            // lazyly load the cache
            if (cacheList[chacheKey].Count < 1)
            {
                Load(chacheKey);
            }
            
            return cacheList[chacheKey].ContainsKey(key) ? cacheList[chacheKey][key] : "";
        }


        public void Serialize(string path)
        {
            // load all 
            List<string> _hashes = new();

            using var fs = new FileStream(path, FileMode.Open);
            var archive = new ZipArchive(fs);
            var zipArchiveEntry = archive.GetEntry(s_hashFileName);
            using var zipstream = zipArchiveEntry.Open();
            AddHashesFromStream(zipstream, _hashes);

            var hashes = _hashes
                .Select(s => new KeyValuePair<ulong, string>(FNV1A64HashAlgorithm.HashString(s), s)).ToList();
            var orderedDict = hashes.OrderBy(_ => _.Key).ToList();

            var step = orderedDict.Count / 10;
            var mod = orderedDict.Count % 10;

            var lookup = new Dictionary<int, ulong>();

            var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            for (var i = 0; i < 10; i++)
            {
                using var file = File.Create(Path.Combine(myDocuments, $"hash_cache_{i}.bin"));

                var fragment = orderedDict.GetRange(i * step, step);
                lookup.Add(i, fragment.Last().Key);

                // serialize to protobuf
                var fragmentDict = fragment.Select(_ => _.Value);
                Serializer.Serialize(file, fragmentDict);

                //var fragmentDict = fragment.ToDictionary(_ => _.Key, _ => _.Value);
                //Serializer.Serialize(file, fragmentDict);
            }
            var fragmentMod = orderedDict.GetRange(orderedDict.Count - mod, mod);
            lookup.Add(10, fragmentMod.Last().Key);

            // serialize mod
            var fragmentDictMod = fragmentMod.Select(_ => _.Value);
            using (var fileMod = File.Create(Path.Combine(myDocuments, $"hash_cache_10.bin")))
            {
                Serializer.Serialize(fileMod, fragmentDictMod);
            }

            // serialize lookup
            using (var _fs = File.Create(Path.Combine(myDocuments, $"hash_lookup.bin")))
            {
                Serializer.Serialize(_fs, lookup);
            }

            // serialize keys
            var keys = Path.Combine(myDocuments, $"hash_keys.bin");
            using (var _fs = File.Create(keys))
            {
                Serializer.Serialize(_fs, orderedDict.Select(_ => _.Key));
            }

        }

        public void Add(string path)
        {
            var hash = FNV1A64HashAlgorithm.HashString(path);
            if (!Contains(hash))
            {
                cacheList[10].Add(hash, path);
            }
        }


        public void ReloadLocally() => throw new System.NotImplementedException();

        private void AddHashesFromStream(Stream stream, List<string> _hashes)
        {
            string line;
            using var sr = new StreamReader(stream, Encoding.UTF8);
            while ((line = sr.ReadLine()) != null)
            {
                //_hashes[FNV1A64HashAlgorithm.HashString(line)] = line;
                _hashes.Add(line);
            }
        }

        private void Load(int i)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetHashCacheZipName(i));
            var archive = new ZipArchive(stream);
            var zipArchiveEntry = archive.GetEntry(GetHashCacheName(i));
            using var zipstream = zipArchiveEntry.Open();
            var x = Serializer.Deserialize<IEnumerable<string>>(zipstream);

            cacheList[i] = x.ToDictionary(FNV1A64HashAlgorithm.HashString);
        }



        #endregion Methods
    }
}
