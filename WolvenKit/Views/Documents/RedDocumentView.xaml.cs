using ReactiveUI;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentView : ReactiveUserControl<RedDocumentViewModel>
    {

        public RedDocumentView()
        {

            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is RedDocumentViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });
        }

    }
}
