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
        public TweakBrowserViewModel Context => (TweakBrowserViewModel)DataContext;

        public TweakBrowserView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                Context.LoadTweakDB();
            });
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
    }
}
