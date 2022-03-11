using System.Collections.Generic;

namespace WolvenKit.Common.Services
{
    public interface ITweakDBService
    {
        public string GetString(ulong hash);
        public void LoadDB(string path);
    }
}
