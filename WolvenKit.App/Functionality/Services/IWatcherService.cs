using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Editor.Basic;

namespace WolvenManager.App.Services
{
    public interface IWatcherService
    {
        public bool IsSuspended { get; set; }

        //public IObservable<IChangeSet<FileModel, ulong>> Connect();
        public IObservable<IChangeSet<FileViewModel, ulong>> Connect();

        public IObservableCache<FileModel, ulong> Files { get; }

        public Task RefreshAsync(EditorProject proj);
    }
}
