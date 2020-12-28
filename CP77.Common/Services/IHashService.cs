using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP77.Common.Services
{
    public interface IHashService
    {
        public Dictionary<ulong, string> Hashdict { get; }
        
        Task<bool> RefreshAsync();

        void ReloadLocally();
        
    }
}
