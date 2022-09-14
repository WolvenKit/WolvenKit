using System.Collections.Generic;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public interface ITweakDBService
    {
        public string GetString(ulong hash);
        public Task LoadDB(string path);
    }
}
