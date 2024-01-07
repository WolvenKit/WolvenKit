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
                if (DataContext is RedDocumentViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });
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
    }
}
