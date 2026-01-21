using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ExtractEmbeddedFileDialogViewModel : DialogViewModel
{
    [ObservableProperty]
    private string _embeddedFilePath;
    [ObservableProperty]
    private string _newFilePath;
    public string ProjectPath { get; set; }
    public AppViewModel AppViewModel { get; set; }
    public bool UserCanceled = false;

    private readonly TaskCompletionSource<bool> _tcs = new();

    public ExtractEmbeddedFileDialogViewModel(AppViewModel appVM, string embeddedFilePath, string projectPath)
    {
        EmbeddedFilePath = embeddedFilePath;
        NewFilePath = embeddedFilePath;
        ProjectPath = projectPath;
        AppViewModel = appVM;
    }

    public Task WaitAsync() => _tcs.Task;

    public void Close()
    {
        AppViewModel.CloseModalCommand.Execute(null);
        _tcs.SetResult(true);
    }
}
