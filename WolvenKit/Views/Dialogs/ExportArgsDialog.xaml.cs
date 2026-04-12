using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Dialogs;

public partial class ExportArgsDialog : ReactiveUserControl<ExportArgsDialogViewModel>
{
    public ExportArgsDialog()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.WhenAnyValue(x => x.ViewModel)
                .Where(vm => vm is not null)
                .Subscribe(vm =>
                {
                    if (FindName("OverlayPropertyGrid") is PropertyGrid opg)
                    {
                        opg.SelectedObject = ExportArgsWrapper.From(vm!.Args);
                    }
                })
                .DisposeWith(disposables);
        });
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button { DataContext: ExportArgsDialogViewModel vm })
        {
            return;
        }

        vm.UserCanceled = false;
        vm.Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button { DataContext: ExportArgsDialogViewModel vm })
        {
            return;
        }

        vm.UserCanceled = true;
        vm.Close();
    }
}

