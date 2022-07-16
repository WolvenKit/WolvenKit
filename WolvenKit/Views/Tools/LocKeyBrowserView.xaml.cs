using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for LocKeyBrowserView.xaml
    /// </summary>
    public partial class LocKeyBrowserView : ReactiveUserControl<LocKeyBrowserViewModel>
    {
        public LocKeyBrowserView()
        {
            InitializeComponent();
            //this.WhenActivated(disposables =>
            //{
            //    this.OneWayBind(ViewModel,
            //            viewModel => viewModel.SelectedRecord,
            //            view => view.redTreeView.ItemsSource)
            //        .DisposeWith(disposables);
            //});
        }
        private void TextBox_KeyEnterUpdate(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var tBox = (TextBox)sender;
                var prop = TextBox.TextProperty;

                var binding = BindingOperations.GetBindingExpression(tBox, prop);
                if (binding != null)
                {
                    binding.UpdateSource();
                }
            }
        }
    }
}
