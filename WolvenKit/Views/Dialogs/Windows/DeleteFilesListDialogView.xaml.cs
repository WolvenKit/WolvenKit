using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class DeleteFilesListDialogView : IViewFor<DeleteFilesListDialogViewModel>
{
    public object ViewModel { get; set; }

    public DeleteFilesListDialogView(string title, List<string> files)
    {
        ViewModel = new DeleteFilesListDialogViewModel(title, files);
        DataContext = ViewModel;
        InitializeComponent();
    }

    DeleteFilesListDialogViewModel IViewFor<DeleteFilesListDialogViewModel>.ViewModel { get; set; }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key is not (Key.Enter or Key.Escape) || ViewModel is not DeleteFilesListDialogViewModel vm)
        {
            return;
        }

        if (e.Key is Key.Escape)
        {
            vm.Files.Clear();
            DialogResult = false;
        }
        else
        {
            DialogResult = true;
        }

        e.Handled = true;
        Close();
    }
}