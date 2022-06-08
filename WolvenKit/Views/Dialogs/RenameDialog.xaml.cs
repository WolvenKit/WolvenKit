using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

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

            this.WhenActivated(disposables => this.Bind(ViewModel,
                        x => x.Text,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables));
        }

        #endregion Constructors
    }
}
