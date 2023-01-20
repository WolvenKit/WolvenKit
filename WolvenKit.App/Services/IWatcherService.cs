using System.Threading.Tasks;
using DynamicData;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;

namespace WolvenKit.Functionality.Services
{
    public interface IWatcherService
    {
        public bool IsSuspended { get; set; }

        public IObservableCache<FileModel, ulong> Files { get; }

        public FileModel? LastSelect { get; set; }
        public Task RefreshAsync(Cp77Project? proj);

        public FileModel? GetFileModelFromHash(ulong hash);
    }
}
