using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Dialogs
{
    public partial class RenameDialog : IViewFor<RenameDialogViewModel>
    {
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

            });
        }

        public RenameDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (RenameDialogViewModel)value; }
    }
}
