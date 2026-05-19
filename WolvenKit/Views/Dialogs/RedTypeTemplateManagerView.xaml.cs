using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.Common.Model;

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

        if (sender is not Button { DataContext: RedTypeTemplateDescriptorManagerExt templateDesc })
        {
            return;
        }

        await ViewModel.DeleteFile(templateDesc);
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
