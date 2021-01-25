using System.Collections.Generic;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        public Dictionary<ulong, string> Hashdict { get; }
        
        void ReloadLocally();
        
    }
}
