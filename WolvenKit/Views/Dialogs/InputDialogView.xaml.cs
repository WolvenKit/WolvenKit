using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for InputDialog.xaml
    /// </summary>
    public partial class InputDialogView : ReactiveUserControl<InputDialogViewModel>
    {
        public InputDialogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<InputDialogViewModel>();
            DataContext = ViewModel;


            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.Text,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
