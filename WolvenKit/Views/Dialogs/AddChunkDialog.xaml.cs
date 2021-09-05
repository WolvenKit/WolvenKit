using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class AddChunkDialog : ReactiveUserControl<AddChunkDialogViewModel>
    {
        #region Constructors

        public AddChunkDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<AddChunkDialogViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors
    }
}
