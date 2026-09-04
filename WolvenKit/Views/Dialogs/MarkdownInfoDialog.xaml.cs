using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

public partial class MarkdownInfoDialog : ReactiveUserControl<MarkdownInfoViewModel>
{
    public MarkdownInfoDialog()
    {
        InitializeComponent();
    }

    private void Ok_OnClick(object sender, RoutedEventArgs e)
    {
        if (sender is not Button || DataContext is not MarkdownInfoViewModel vm)
        {
            return;
        }

        vm.AppViewModel.CloseDialogCommand.Execute(null);
    }
}

