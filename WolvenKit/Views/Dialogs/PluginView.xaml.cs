using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class PluginView : ReactiveUserControl<PluginViewModel>
    {
        public PluginView()
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
