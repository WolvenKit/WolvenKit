using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ExtractEmbeddedFileDialogViewModel : DialogViewModel
{
    [ObservableProperty]
    private string _embeddedFilePath;
    [ObservableProperty]
    private string _newFilePath;
    public string ProjectPath { get; }
    private readonly AppViewModel _appViewModel;
    public INotificationService? NotificationService { get; }

    public bool UserCanceled = false;

    private readonly TaskCompletionSource<bool> _tcs = new();

    public ExtractEmbeddedFileDialogViewModel(AppViewModel appVM, INotificationService? notificationService, string embeddedFilePath, string projectPath)
    {
        EmbeddedFilePath = embeddedFilePath;
        NewFilePath = embeddedFilePath;
        ProjectPath = projectPath;
        _appViewModel = appVM;
        NotificationService = notificationService;
    }

    public Task WaitAsync() => _tcs.Task;

    public void Close()
    {
        _appViewModel.CloseModalCommand.Execute(null);
        _tcs.SetResult(true);
    }
}
