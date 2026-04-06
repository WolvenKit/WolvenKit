using System;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Model.Arguments;

using System.Linq;
using System.Windows.Controls;


namespace WolvenKit.App.ViewModels.Dialogs;

public class ExportArgsDialogViewModel : DialogViewModel
{
    private TaskCompletionSource<bool> _tcs = new();
    private readonly AppViewModel _appViewModel;
    public GlobalExportArgs Args { get; set; }
    public bool UserCanceled { get; set; } = false;

    public ExportArgsDialogViewModel(GlobalExportArgs args, AppViewModel appViewModel)
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
