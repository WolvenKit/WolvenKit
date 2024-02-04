using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Tools;

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

                BindingOperations.GetBindingExpression(tBox, prop)?.UpdateSource();
            }
        }

        private void primaryKeyBtn_Click(object sender, System.Windows.RoutedEventArgs e) => Clipboard.SetDataObject(primaryKeyTextBox.Text);

        private void secondaryKeyBtn_Click(object sender, System.Windows.RoutedEventArgs e) => Clipboard.SetDataObject(secondaryKeyTextBox.Text);

        private void contentBtn_Click(object sender, System.Windows.RoutedEventArgs e) => Clipboard.SetDataObject(contentTextBox.Text);
    }
}
