using ReactiveUI;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    public partial class DocumentView : ReactiveUserControl<RedDocumentViewModel>
    {
        #region Constructors

        public DocumentView()
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

        #endregion Constructors
    }
}
