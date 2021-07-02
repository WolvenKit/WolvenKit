using System;
using System.IO;
using System.Threading.Tasks;

namespace WolvenManager.Installer.Services
{
    public interface IUpdateService
    {
        bool IsUpdateAvailable { get; set; }
        bool IsUpdateReadyToInstall { get; set; }
        Task CheckForUpdatesAsync();

        /// <summary>
        /// /releases/latest/download/
        /// </summary>
        /// <param name="updateUrl"></param>
        /// <param name="assemblyName"></param>
        /// <param name="updateAction"></param>
        void Init(string updateUrl, string assemblyName, Action<FileInfo, bool> updateAction);
    }
}
