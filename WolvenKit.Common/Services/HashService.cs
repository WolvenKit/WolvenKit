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
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Oodle;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.Common.Services
{
    public class HashService : IHashService
    {
        #region Fields

        private const string s_hashZipName = "WolvenKit.Common.Resources.archivehashes.kark";

        private Dictionary<ulong, string> _hashes = new ();
        private Dictionary<ulong, string> _userHashes = new ();

        #endregion Fields

        #region Constructors

        public HashService()
        {
            Load();
        }

        #endregion Constructors

        #region Methods

        public bool Contains(ulong key) => _hashes.ContainsKey(key) || _userHashes.ContainsKey(key);

        public string Get(ulong key)
        {
            if (_hashes.ContainsKey(key))
            {
                return _hashes[key];
            }

            return _userHashes.ContainsKey(key) ? _userHashes[key] : "";
        }

        public void Add(string path)
        {
            var hash = FNV1A64HashAlgorithm.HashString(path);
            if (!Contains(hash))
            {
                _userHashes.Add(hash, path);
            }
        }

        private void Load()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s_hashZipName);

            // read KARK header
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression != OodleHelper.KARK)
            {
                throw new DecompressionException($"Incorrect hash file.");
            }
            var outputsize = stream.ReadStruct<uint>();

            // read the rest of the stream
            var outputbuffer = new byte[outputsize];

            var inbuffer = stream.ToByteArray(true);

            OozNative.Kraken_Decompress(inbuffer, inbuffer.Length, outputbuffer, outputbuffer.Length);

            _hashes.EnsureCapacity(1_500_000);

            using var ms = new MemoryStream(outputbuffer);
            using var sr = new StreamReader(ms);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                _hashes.Add(FNV1A64HashAlgorithm.HashString(line), line);
            }
        }



        #endregion Methods
    }
}
