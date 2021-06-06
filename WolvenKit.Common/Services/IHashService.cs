using System.Collections.Generic;

namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        #region Methods

        bool Contains(ulong key);

        string Get(ulong key);

        void Add(string path);

        public IEnumerable<ulong> GetAllHashes();

        #endregion Methods
    }
}
