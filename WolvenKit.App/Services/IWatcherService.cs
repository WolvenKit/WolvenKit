using DynamicData;
using WolvenKit.App.Models;

namespace WolvenKit.App.Services;

public interface IWatcherService
{
    public bool IsSuspended { get; set; }
    
    public IObservableCache<FileModel, ulong> Files { get; }

    public FileModel? LastSelect { get; set; }
    public void QueueRefresh();

    public FileModel? GetFileModelFromHash(ulong hash);
}
