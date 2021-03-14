using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace WolvenKit.Functionality.Controllers
{
    internal class MockGameController : GameControllerBase
    {
        #region Methods

        public override List<IGameArchiveManager> GetArchiveManagersManagers() => new List<IGameArchiveManager>();

        public override List<string> GetAvaliableClasses() => new List<string>();

        public override async Task HandleStartup() => await Task.CompletedTask;//Nothing to do here :)

        public override Task<bool> PackageMod() =>
            //Nothing to do here :)
            Task.FromResult(true);

        public override Task<bool> PackAndInstallProject() =>
            //Nothing to do here :)
            new Task<bool>(new Func<bool>(() => true));

        #endregion Methods
    }
}
