using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaktionslogik für SelectRedTypeDialog.xaml
    /// </summary>
    public partial class SelectRedTypeDialog : ReactiveUserControl<SelectRedTypeDialogViewModel>
    {
        #region Constructors

        public SelectRedTypeDialog()
        {
            InitializeComponent();
        }

        #endregion Constructors

        private void SetSelectedType(object sender, System.Windows.RoutedEventArgs e) => ViewModel.SelectedTypeString = (sender as Button).Content.ToString();
    }
}
