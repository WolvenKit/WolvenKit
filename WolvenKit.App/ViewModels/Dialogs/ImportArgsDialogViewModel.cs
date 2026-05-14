using System.Threading.Tasks;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.Helpers;


namespace WolvenKit.App.ViewModels.Dialogs;

public class ImportArgsDialogViewModel : DialogViewModel
{
    private TaskCompletionSource<bool> _tcs = new();
    private readonly AppViewModel _appViewModel;
    public ImportArgsWrapper Args { get; set; }
    public bool UserCanceled { get; set; } = false;

    public ImportArgsDialogViewModel(AppViewModel appViewModel, ImportArgsWrapper args)
    {
        Args = args;
        _appViewModel = appViewModel;
    }

    public Task WaitAsync() => _tcs.Task;

    public void Close()
    {
        _appViewModel.CloseModalCommand.Execute(null);
        _tcs.SetResult(true);
    }
}
