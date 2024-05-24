using System;
using System.IO;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using Window = System.Windows.Window;

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


                if (string.IsNullOrEmpty(TextBox.Text) || ViewModel?.Text is null)
                {
                    return;
                }

                var fileNameStart = TextBox.Text.LastIndexOf(@"\", StringComparison.Ordinal);
                fileNameStart = (fileNameStart < 0) ? 0 : fileNameStart + 1;

                var fileNameEnd = TextBox.Text.IndexOf(@".", fileNameStart, StringComparison.Ordinal);
                fileNameEnd = (fileNameEnd < 0) ? ViewModel.Text.Length - 1 : fileNameEnd;
                // it's a folder
                if (ViewModel.Text.EndsWith(ResourcePath.DirectorySeparatorChar) || !ViewModel.Text.Contains('.'))
                {
                    fileNameEnd += 1;
                }

                TextBox.Select(fileNameStart, fileNameEnd - fileNameStart);
                TextBox.Focus();

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
