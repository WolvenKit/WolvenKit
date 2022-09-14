using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynamicData;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Functionality.Controllers
{
    public class MockGameController : IGameController
    {
        public void AddToMod(IGameFile file) => throw new NotImplementedException();
        public void AddToMod(ulong hash) => throw new NotImplementedException();

        public async Task HandleStartup() => await Task.CompletedTask;//Nothing to do here :)

        public bool PackProject() => throw new NotImplementedException();

        public void InstallMod() => throw new NotImplementedException();

        public Task<bool> PackAndInstallProject() => throw new NotImplementedException();
        public Task<bool> DeployRedmod() => throw new NotImplementedException();

        public bool PackAndInstallRunProject() => throw new NotImplementedException();

        public bool HotInstallProject() => throw new NotImplementedException();
    }
}
