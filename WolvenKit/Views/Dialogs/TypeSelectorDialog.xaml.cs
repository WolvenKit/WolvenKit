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

        // Escape closes the dialog as Cancel does. The keyboard focus starts in the dialog: it stayed on the "+"
        // button of the editor that opened it, where Escape didn't reach the dialog.
        PreviewKeyDown += OnPreviewKeyDown;
        Loaded += (_, _) => Dispatcher.BeginInvoke(() => TypeDataGrid.Focus(),
            System.Windows.Threading.DispatcherPriority.Input);

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

    private void OnPreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Escape || ViewModel is null)
        {
            return;
        }

        ViewModel.CancelCommand.Execute(null);
        e.Handled = true;
    }
}
