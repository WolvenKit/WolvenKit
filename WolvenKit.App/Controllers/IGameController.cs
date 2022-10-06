using System;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.App.Models;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Controllers
{
    public interface IGameController
    {
        public void AddToMod(IGameFile file);
        Task AddFileToModModal(IGameFile file);
        Task AddFileToModModal(ulong hash);
        public Task HandleStartup();

        Task<bool> LaunchProject(LaunchProfile profile);
        bool PackProjectHot();
    }
}
