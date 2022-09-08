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
        public MockGameController()
        {
            _rootCache = new SourceList<RedFileSystemModel>();
        }


        #region Methods

        private readonly SourceList<RedFileSystemModel> _rootCache;

        public bool IsManagerLoaded { get; set; } = true;

        public IObservable<IChangeSet<RedFileSystemModel>> ConnectHierarchy() => _rootCache.Connect();

        public List<IArchiveManager> GetArchiveManagers(bool loadmods) => new List<IArchiveManager>();

        public void AddToMod(IGameFile file) => throw new NotImplementedException();
        public void AddToMod(ulong hash) => throw new NotImplementedException();

        public List<string> GetAvaliableClasses() => new List<string>();

        public async Task HandleStartup() => await Task.CompletedTask;//Nothing to do here :)

        public Task<bool> PackProject() =>
            //Nothing to do here :)
            Task.FromResult(true);

        public void InstallMod()
        {
        }

        public Task<bool> PackAndInstallProject() =>
            //Nothing to do here :)
            new Task<bool>(new Func<bool>(() => true));
        public Task<bool> DeployRedmod() => throw new NotImplementedException();

        #endregion Methods
    }
}
