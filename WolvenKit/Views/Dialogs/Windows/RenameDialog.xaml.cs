using System;
using System.IO;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class RenameDialog : IViewFor<RenameDialogViewModel>
    {
        public RenameDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<RenameDialogViewModel>();
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.Text,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables);


                if (!string.IsNullOrEmpty(TextBox.Text))
                {
                    var fileNameStart = TextBox.Text.LastIndexOf(@"\");
                    fileNameStart = (fileNameStart < 0) ? 0 : fileNameStart+1;

                    var fileNameEnd = TextBox.Text.IndexOf(@".", fileNameStart);
                    fileNameEnd = (fileNameEnd < 0) ? ViewModel.Text.Length - 1 : fileNameEnd;

                    TextBox.Select(fileNameStart, fileNameEnd - fileNameStart);
                    TextBox.Focus();
                }

            });
        }

        public RenameDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (RenameDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                DialogResult = true;
                Close();
            }
        }
    }
}
