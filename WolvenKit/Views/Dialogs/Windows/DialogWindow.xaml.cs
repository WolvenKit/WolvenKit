using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    /// <summary>
    /// A wrapper window to show UserControls as dialogs. Used by <see cref="DialogService"/>.
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow(UserControl content)
        {
            InitializeComponent();

            Content = content;
            SizeToContent = SizeToContent.WidthAndHeight;

            if (content is IViewFor { ViewModel: DialogExtViewModel dialogViewModel })
            {
                Title = dialogViewModel.Title;
                dialogViewModel.Closed += DialogViewModel_Closed;
            }
        }

        private void DialogViewModel_Closed(object sender, System.EventArgs e)
        {
            var viewModel = (DialogExtViewModel)sender;
            viewModel.Closed -= DialogViewModel_Closed;

            Close();
        }
    }
}
