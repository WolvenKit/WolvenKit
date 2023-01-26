using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynamicData;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Functionality.Controllers
{
    public class MockGameController : IGameController
    {
        public Task<bool> AddFileToModModal(IGameFile file) => throw new NotImplementedException();
        public Task<bool> AddFileToModModal(ulong hash) => throw new NotImplementedException();
        public bool AddToMod(IGameFile file) => throw new NotImplementedException();
        public bool AddToMod(ulong hash) => throw new NotImplementedException();
        public async Task HandleStartup() => await Task.CompletedTask;
        public Task<bool> LaunchProject(LaunchProfile profile) => throw new NotImplementedException();
        public bool PackProjectHot() => throw new NotImplementedException();
        public bool CleanAll() => throw new NotImplementedException();
    }
}
