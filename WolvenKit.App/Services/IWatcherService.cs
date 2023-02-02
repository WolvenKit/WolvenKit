using System.Threading.Tasks;
using DynamicData;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Services;

public interface IWatcherService
{
    public bool IsSuspended { get; set; }

    public IObservableCache<FileModel, ulong> Files { get; }

    public FileModel? LastSelect { get; set; }
    public Task RefreshAsync(Cp77Project? proj);

    public FileModel? GetFileModelFromHash(ulong hash);
}
