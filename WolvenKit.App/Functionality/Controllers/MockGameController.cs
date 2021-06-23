using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Functionality.Controllers;

namespace WolvenKit.Functionality.Controllers
{
    public class MockGameController : IGameController
    {
        #region Methods

        public List<IGameArchiveManager> GetArchiveManagers(bool loadmods) => new List<IGameArchiveManager>();

        public void AddToMod(IGameFile file) => throw new NotImplementedException();

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
