using System;
using System.IO;
using System.Threading.Tasks;
using WolvenManager.Installer.Models;

namespace WolvenManager.Installer.Services
{
    public interface IUpdateService
    {
        bool IsUpdateAvailable { get; set; }
        bool IsUpdateReadyToInstall { get; set; }
        bool IsInitialized { get; set; }

        Task CheckForUpdatesAsync();
        public void SetUpdateChannel(EUpdateChannel channel);

        /// <summary>
        /// /releases/latest/download/
        /// </summary>
        /// <param name="updateUrls"></param>
        /// <param name="assemblyName"></param>
        /// <param name="updateAction"></param>
        void Init(string[] updateUrls, string assemblyName, Action<FileInfo, bool> updateAction, Action<string, Func<bool, bool>> askAction);
    }
}
