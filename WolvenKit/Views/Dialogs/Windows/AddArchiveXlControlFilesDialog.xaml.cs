using System;
using System.IO;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AxlControlFilesDialog : IViewFor<AxlControlFilesDialogViewModel>
    {
        public AxlControlFilesDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<AxlControlFilesDialogViewModel>();
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.DepotPath,
                        x => x.DepotPathTextBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.FileName,
                        x => x.FileNameTextBox.Text)
                    .DisposeWith(disposables);
            });
        }

        public AxlControlFilesDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AxlControlFilesDialogViewModel)value; }

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

        private void DepotPath_OnKeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FileName_OnKeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}