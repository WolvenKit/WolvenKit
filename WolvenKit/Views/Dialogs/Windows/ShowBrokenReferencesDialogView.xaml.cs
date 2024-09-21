using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class ShowBrokenReferencesDialogView : IViewFor<ShowBrokenReferencesDialogViewModel>
{
    public object ViewModel { get; set; }

    public ShowBrokenReferencesDialogView(string title, Dictionary<string, List<string>> brokenRefs)
    {
        ViewModel = new ShowBrokenReferencesDialogViewModel(title, brokenRefs);
        DataContext = ViewModel;
        InitializeComponent();
    }

    ShowBrokenReferencesDialogViewModel IViewFor<ShowBrokenReferencesDialogViewModel>.ViewModel { get; set; }

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

        if (e.Key is not (Key.Escape or Key.Enter) || ContentTextBox.Focus())
        {
            return;
        }

        DialogResult = e.Key == Key.Enter;
        e.Handled = true;
        Close();
    }
}