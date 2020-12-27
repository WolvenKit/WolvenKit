using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP77Tools.Common.Services
{
    public interface IHashService
    {
        public Dictionary<ulong, string> Hashdict { get; }
        
        Task<bool> RefreshAsync();

        Task ReloadLocally();
        
    }
}
