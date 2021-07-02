using System;
using System.IO;
using System.Threading.Tasks;

namespace WolvenManager.Installer
{
    public interface IUpdateService
    {
        bool IsUpdateAvailable { get; set; }
        bool IsUpdateReadyToInstall { get; set; }
        Task CheckForUpdatesAsync();

        /// <summary>
        /// /releases/latest/download/
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="assemblyName"></param>
        /// <param name="updateAction"></param>
        void Init(string uri, string assemblyName, Action<FileInfo> updateAction);
    }
}
