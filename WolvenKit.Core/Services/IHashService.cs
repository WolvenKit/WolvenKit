using System.Collections.Generic;

namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        bool Contains(ulong key, bool checkUserHashes = true);

        string? Get(ulong key);

        void AddCustom(string path);

        public IEnumerable<ulong> GetAllHashes();

        public IEnumerable<ulong> GetMissingHashes();

        public string? GetGuessedExtension(ulong key);
    }
}
