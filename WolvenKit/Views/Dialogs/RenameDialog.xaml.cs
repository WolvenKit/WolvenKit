using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class RenameDialog : ReactiveUserControl<RenameDialogViewModel>
    {
        #region Constructors

        public RenameDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<RenameDialogViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.Text,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        x => x.OkCommand,
                        x => x.ConfirmButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        x => x.CancelCommand,
                        x => x.CancelButton)
                    .DisposeWith(disposables);
            });
        }

        #endregion Constructors
    }
}
