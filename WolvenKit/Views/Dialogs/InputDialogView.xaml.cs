using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for InputDialog.xaml
    /// </summary>
    public partial class InputDialogView : ReactiveUserControl<InputDialogViewModel>
    {
        #region Constructors

        public InputDialogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<InputDialogViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors
    }
}
