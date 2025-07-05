using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public interface ITweakDBService
    {
        event EventHandler? Loaded;

        public string? GetString(ulong hash);
        public Task LoadDB(string path);
        public bool IsLoaded { get; set; }
    }
}
