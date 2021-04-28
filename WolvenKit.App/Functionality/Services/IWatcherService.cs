using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using WolvenKit.Models;

namespace WolvenManager.App.Services
{
    public interface IWatcherService
    {
        public bool IsSuspended { get; set; }

        //public IObservable<IChangeSet<FileModel, ulong>> Connect();
        public IObservableCache<FileModel, ulong> Files { get; }

        public Task RefreshAsync();
    }
}
