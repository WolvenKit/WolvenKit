using System;
using System.Collections.Specialized;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.Modkit.Scripting;
using SelectionChangedEventArgs = System.Windows.Controls.SelectionChangedEventArgs;

namespace WolvenKit.Views.Dialogs;
/// <summary>
/// Interaktionslogik für ScriptManagerView.xaml
/// </summary>
public partial class RedTypeTemplateManagerView : ReactiveUserControl<RedTypeTemplateManagerViewModel>
{
    public RedTypeTemplateManagerView()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.BindCommand(ViewModel, viewModel => viewModel.CancelCommand, view => view.CloseButton)
                .DisposeWith(disposables);
        });
    }

    private async void Run_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: ScriptFileViewModel scriptFile })
        {
            return;
        }

        await ViewModel.EditFile(scriptFile);
    }

    private async void Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: ScriptFileViewModel scriptFile })
        {
            return;
        }

        await ViewModel.DeleteFile(scriptFile);
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        ViewModel.AddScript(FileNameTextBox.Text);
    }
}
