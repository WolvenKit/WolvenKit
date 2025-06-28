using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Dialogs;
/// <summary>
/// Interaktionslogik für TypeSelectorDialog.xaml
/// </summary>
public partial class TypeSelectorDialog : ReactiveUserControl<TypeSelectorDialogViewModel>
{
    public TypeSelectorDialog()
    {
        InitializeComponent();

        TypeDataGrid.FilterRowCellRenderers.Add("TextBoxExt", new GridFilterRowTextBoxRendererExt());

        this.WhenActivated(disposables =>
        {
            TypeDataGrid.ClearFilters();

            this.Bind(ViewModel, x => x.SelectedMode, x => x.TabControl.SelectedIndex)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.EnteredText, x => x.CustomNameTextBox.Text)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                .DisposeWith(disposables);
        });
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        }
        catch (Exception)
        {
            // Silently handle any exceptions when opening the link
        }
        e.Handled = true;
    }
}
