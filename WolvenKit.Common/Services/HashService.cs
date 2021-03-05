using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Common.Services
{
    public class HashService : IHashService
    {
        #region Fields

        private const string HashFileName = "archivehashes.txt";
        private const string HashZipName = "WolvenKit.Common.Resources.archivehashes.zip";
        private readonly Dictionary<ulong, string> _hashes = new();
        private readonly ILoggerService _loggerService;

        #endregion Fields

        #region Constructors

        public HashService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
            Load();
        }

        #endregion Constructors

        #region Methods

        public bool Contains(ulong key)
        {
            return _hashes.ContainsKey(key);
        }

        public string Get(ulong key)
        {
            _hashes.TryGetValue(key, out var value);
            return value;
        }

        public void ReloadLocally()
        {
            throw new System.NotImplementedException();
        }

        private void AddHashesFromStream(Stream stream)
        {
            string line;
            using var sr = new StreamReader(stream, Encoding.UTF8);
            while ((line = sr.ReadLine()) != null)
            {
                _hashes[FNV1A64HashAlgorithm.HashString(line)] = line;
            }
        }

        private void Load()
        {
            _loggerService.LogString("Loading local filename hashes...", Logtype.Important);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            _hashes.EnsureCapacity(1_500_000);

            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(HashZipName);
            if (stream is null)
            {
                _loggerService.LogString($"'{HashZipName}' not found", Logtype.Error);
                return;
            }

            var archive = new ZipArchive(stream);
            var zipArchiveEntry = archive.GetEntry(HashFileName);
            if (zipArchiveEntry != null)
            {
                using var zipstream = zipArchiveEntry.Open();
                AddHashesFromStream(zipstream);
            }

            stopwatch.Stop();
            _loggerService.LogString($"Loaded {_hashes.Count} hashes in {stopwatch.ElapsedMilliseconds}ms.", Logtype.Success);
        }

        #endregion Methods
    }
}
