using System.Collections.Generic;

namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        #region Methods

        bool Contains(ulong key);

        string Get(ulong key);

        void AddCustom(string path);

        public IEnumerable<ulong> GetAllHashes();

        public IEnumerable<ulong> GetMissingHashes();

        #endregion Methods
    }
}
