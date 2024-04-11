using System.Windows.Input;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Views.Shell;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentView : ReactiveUserControl<RedDocumentViewModel>
    {
        public RedDocumentView()
        {
            InitializeComponent();

            TabControl.SelectedItemChangedEvent += TabControl_OnSelectedItemChangedEvent;

            this.WhenActivated(disposables =>
            {
                if (DataContext is RedDocumentViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void TabControl_OnSelectedItemChangedEvent(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.NewSelectedItem.DataContext is RDTMeshViewModel meshViewModel)
            {
                meshViewModel.Load();
            }

            if (e.NewSelectedItem.DataContext is RDTGraphViewModel graphViewModel)
            {
                graphViewModel.Load();
            }

            if (e.NewSelectedItem.DataContext is RDTGraphViewModel2 graphViewModel2)
            {
                graphViewModel2.Load();
            }
        }

        private void OnToggleNoobFilter(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount <= 1 || DataContext is not RedDocumentViewModel vm)
            {
                return;
            }

            vm.IsSimpleViewEnabled = !vm.IsSimpleViewEnabled;

            // Send a message to update filtered items source
            MessageBus.Current.SendMessage("UpdateFilteredItemsSource", "Command");


            // var mainWindow = Locator.Current.GetService<AppViewModel>();
            // mainWindow?.ReloadFile();
        }
    }
}
