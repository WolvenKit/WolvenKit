using System.Reactive.Disposables;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class CreateClassDialog : ReactiveUserControl<CreateClassDialogViewModel>
    {
        public CreateClassDialog()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                    .DisposeWith(disposables);
            });
        }

        private void SetSelectedClass(object sender, System.Windows.RoutedEventArgs e) => ViewModel.SelectedClass = (sender as Button).Content.ToString();
    }
}
