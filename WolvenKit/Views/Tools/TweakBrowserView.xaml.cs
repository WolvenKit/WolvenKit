using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for TweakBrowserView.xaml
    /// </summary>
    public partial class TweakBrowserView : ReactiveUserControl<TweakBrowserViewModel>
    {
        public TweakBrowserView()
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
                TextBox tBox = (TextBox)sender;
                DependencyProperty prop = TextBox.TextProperty;

                BindingExpression binding = BindingOperations.GetBindingExpression(tBox, prop);
                if (binding != null)
                { binding.UpdateSource(); }
            }
        }
    }
}
