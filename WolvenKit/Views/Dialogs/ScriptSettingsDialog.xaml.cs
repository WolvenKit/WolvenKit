using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

public partial class ScriptSettingsDialog : ReactiveUserControl<ScriptSettingsDialogViewModel>
{
    public ScriptSettingsDialog()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel, x => x.Settings, x => x.SettingsGrid.SelectedObject)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                .DisposeWith(disposables);
        });
    }
}
