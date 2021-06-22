using System.Threading.Tasks;
using DynamicData;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.Functionality.Services
{
    public interface IWatcherService
    {
        public bool IsSuspended { get; set; }

        //public IObservable<IChangeSet<FileViewModel>> Connect();
        public IObservableCache<FileModel, ulong> Files { get; }

        public FileModel LastSelect { get; set; }
        public Task RefreshAsync(EditorProject proj);
    }
}
