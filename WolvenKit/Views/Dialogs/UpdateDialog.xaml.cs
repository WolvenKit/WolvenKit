using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

public partial class UpdateDialog : ReactiveUserControl<UpdateDialogViewModel>
{
    public UpdateDialog()
    {
        InitializeComponent();
    }
    
    private void OnDynamicButtonClick(object sender, RoutedEventArgs e)
    {
        if (sender is not Button btn || DataContext is not UpdateDialogViewModel vm)
        {
            return;
        }

        var label = btn.Content as string;

        switch (label)
        {
            case "Retry":
            case "Update":
                vm.SetDialogToUpdateExecutingState();
                break;
            case "OK":
            case "Ignore":
                vm._appvm.CloseDialogCommand.Execute(null);
                break;
            default:
                vm._logger.Error($"unknown ({label}) button clicked");
                break;
        }
    }

}