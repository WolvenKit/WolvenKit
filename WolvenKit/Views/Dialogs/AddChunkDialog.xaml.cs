using System.Windows.Controls;
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
        }

        #endregion Constructors

        private void SetSelectedClass(object sender, System.Windows.RoutedEventArgs e)
        {
            ViewModel.SelectedClass = (sender as Button).Content.ToString();
        }
    }
}
