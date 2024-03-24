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
    public partial class SearchAndReplaceDialog : IViewFor<SearchAndReplaceDialogViewModel>
    {
        public SearchAndReplaceDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<SearchAndReplaceDialogViewModel>();
            DataContext = ViewModel;


            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.SearchText,
                        x => x.SearchTextBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ReplaceText,
                        x => x.ReplaceTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.IgnoreCase,
                        x => x.IgnoreCaseCheckBox.IsChecked)
                    .DisposeWith(disposables);
            });
        }

        public SearchAndReplaceDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SearchAndReplaceDialogViewModel)value; }

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