using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class DeleteOrMoveFilesListDialogView : IViewFor<DeleteOrMoveFilesListDialogViewModel>
{
    private readonly Cp77Project _currentProject;
    public object ViewModel { get; set; }

    public DeleteOrMoveFilesListDialogView(string title, List<string> files, Cp77Project currentProject)
    {
        ViewModel = new DeleteOrMoveFilesListDialogViewModel(title, files);
        DataContext = ViewModel;
        InitializeComponent();
        _currentProject = currentProject;
    }

    DeleteOrMoveFilesListDialogViewModel IViewFor<DeleteOrMoveFilesListDialogViewModel>.ViewModel { get; set; }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (ContentTextBox.Focus() && ContentTextBox.GetBindingExpression(TextBox.TextProperty) is BindingExpression be)
        {
            if (e.Key is Key.Z && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                be?.UpdateTarget();
            }
            else if (e.Key is Key.Enter)
            {
                be?.UpdateSource();
            }

            return;
        }

        if (e.Key is not (Key.Enter or Key.Escape) || ViewModel is not DeleteOrMoveFilesListDialogViewModel vm || ContentTextBox.Focus())
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

    private void DeleteFilesTextbox_OnKeyUp(object sender, KeyEventArgs e)
    {
        if (ViewModel is not DeleteOrMoveFilesListDialogViewModel vm)
        {
            return;
        }

        vm.HasFiles = vm.Files.Count > 0;
    }

    private void OnNextButtonClicked(object sender, RoutedEventArgs e)
    {
        if (ViewModel is not DeleteOrMoveFilesListDialogViewModel vm ||
            Interactions.AskForFolderPathInput(("Enter a folder path", _currentProject)) is not string path)
        {
            return;
        }

        vm.MoveToPath = path;

        DialogResult = true;
        e.Handled = true;
        Close();
    }
}