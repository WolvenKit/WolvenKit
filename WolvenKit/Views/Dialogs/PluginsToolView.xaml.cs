using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class PluginsToolView : ReactiveUserControl<PluginsToolViewModel>
    {
        public PluginsToolView()
        {
            InitializeComponent();

            this.WhenActivated(disposables => this.BindCommand(ViewModel,
                    viewModel => viewModel.SyncCommand,
                    view => view.CheckButton));

        }
    }
}
