using System.Threading.Tasks;
using DynamicData;
using WolvenKit.App.Functionality.ProjectManagement.Project;
using WolvenKit.App.Models;

namespace WolvenKit.App.Services
{
    public interface IWatcherService
    {
        public bool IsSuspended { get; set; }

        public IObservableCache<FileModel, ulong> Files { get; }

        public FileModel LastSelect { get; set; }
        public Task RefreshAsync(EditorProject proj);

        public FileModel GetFileModelFromHash(ulong hash);
    }
}
