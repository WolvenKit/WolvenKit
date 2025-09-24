using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class ShowDictionaryForCopyDialogView : IViewFor<ShowDictionaryForCopyDialogViewModel>
{
    public object ViewModel { get; set; }


    public ShowDictionaryForCopyDialogView(string title, string text, IDictionary<string, List<string>> brokenRefs,
        bool isExperimental)
    {
        ViewModel = new ShowDictionaryForCopyDialogViewModel(title, text, brokenRefs, isExperimental);
        DataContext = ViewModel;

        MaxHeight = Math.Max(SystemParameters.WorkArea.Height * 0.8, 1200);
        Height = MaxHeight;
        InitializeComponent();
    }

    ShowDictionaryForCopyDialogViewModel IViewFor<ShowDictionaryForCopyDialogViewModel>.ViewModel { get; set; }

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
