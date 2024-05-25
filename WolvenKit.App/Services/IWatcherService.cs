using WolvenKit.App.Models;

namespace WolvenKit.App.Services;

public interface IWatcherService
{
    public DispatchedObservableCollection<FileSystemModel> FileTree { get; }
    public DispatchedObservableCollection<FileSystemModel> FileList { get; }
    
    public void Refresh();
}
