using System.Reactive.Disposables;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;
/// <summary>
/// Interaktionslogik für ScriptManagerView.xaml
/// </summary>
public partial class ScriptManagerView : ReactiveUserControl<ScriptManagerViewModel>
{
    public ScriptManagerView()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, x => x.Scripts, x => x.ScriptsListView.ItemsSource)
                .DisposeWith(disposables);

            this.Bind(ViewModel, viewModel => viewModel.SelectedItem, view => view.ScriptsListView.SelectedItem)
                .DisposeWith(disposables);
            this.Bind(ViewModel, viewModel => viewModel.FileName, view => view.FileNameTextBox.Text)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, viewModel => viewModel.CancelCommand, view => view.CloseButton)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel, viewModel => viewModel.AddScriptCommand, view => view.AddButton)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel, viewModel => viewModel.DeleteScriptCommand, view => view.DeleteButton)
                .DisposeWith(disposables);
        });
    }

    private void ListViewItem_OnDoubleClick(object sender, MouseButtonEventArgs e)
    {
        ViewModel?.OpenFile();
    }
}
