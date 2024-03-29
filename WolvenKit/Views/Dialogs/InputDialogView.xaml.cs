using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class InputDialogView : IViewFor<InputDialogViewModel>
    {
        public InputDialogView(string dialogTitle = "")
        {
            DialogTitle = dialogTitle;
            
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

        public string DialogTitle;

        public InputDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (InputDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }
    }
}