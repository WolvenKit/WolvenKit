using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace WolvenKit.Functionality.Controllers
{
    internal class MockGameController : IGameController
    {
        #region Methods

        public List<IGameArchiveManager> GetArchiveManagersManagers(bool loadmods) => new List<IGameArchiveManager>();

        public List<string> GetAvaliableClasses() => new List<string>();

        public async Task HandleStartup() => await Task.CompletedTask;//Nothing to do here :)

        public Task<bool> PackageMod() =>
            //Nothing to do here :)
            Task.FromResult(true);

        public void InstallMod()
        {
        }

        public Task<bool> PackAndInstallProject() =>
            //Nothing to do here :)
            new Task<bool>(new Func<bool>(() => true));

        #endregion Methods
    }
}
