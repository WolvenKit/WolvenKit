using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

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


            this.WhenActivated(disposables =>
            {
                //this.Bind(ViewModel,
                //    vm => vm.Plugins,
                //    v => v.PluginList.ItemsSource)
                //    .DisposeWith(disposables);

            });

        }
    }
}
