using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class CreateClassDialog : ReactiveUserControl<CreateClassDialogViewModel>
    {
        #region Constructors

        public CreateClassDialog()
        {
            InitializeComponent();
        }

        #endregion Constructors

        private void SetSelectedClass(object sender, System.Windows.RoutedEventArgs e) => ViewModel.SelectedClass = (sender as Button).Content.ToString();
    }
}
