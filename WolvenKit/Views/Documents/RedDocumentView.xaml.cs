using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.ViewModels.Documents;

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
                if (DataContext is not RedDocumentViewModel vm)
                {
                    return;
                }

                SetCurrentValue(ViewModelProperty, vm);
                RedDocumentViewToolbar.CurrentTab = vm.SelectedTabItemViewModel;
            });
        }

        private void TabControl_OnSelectedItemChangedEvent(object sender, SelectedItemChangedEventArgs e)
        {
            
            if (e?.NewSelectedItem?.DataContext is RedDocumentTabViewModel newTab)
            {
                RedDocumentViewToolbar.CurrentTab = newTab;
                newTab.Load();
            }
            else
            {
                RedDocumentViewToolbar.CurrentTab = null;
            }

            if (e?.OldSelectedItem?.DataContext is RedDocumentTabViewModel oldTab)
            {
                oldTab.Unload();
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
