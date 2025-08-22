using System.Collections.Generic;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        bool IsLoaded { get; }

        Task LoadAsync();

        bool Contains(ulong key, bool checkUserHashes = true);

        string? Get(ulong key);

        public IEnumerable<ulong> GetAllHashes();

        public IEnumerable<ulong> GetMissingHashes();

        public string? GetGuessedExtension(ulong key);
    }
}
