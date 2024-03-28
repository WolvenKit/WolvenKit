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
        private static string LastSearch = "";
        private static string LastReplace = "";
        
        public SearchAndReplaceDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<SearchAndReplaceDialogViewModel>();
            DataContext = ViewModel;

            LoadLastSelection();
            
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
                this.Bind(ViewModel,
                        x => x.RememberValues,
                        x => x.RememberValuesCheckBox.IsChecked)
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

        private void LoadLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (LastSearch != "")
            {
                ViewModel.SearchText = LastSearch;
                ViewModel.RememberValues = true;
            }

            if (LastReplace == "")
            {
                return;
            }

            ViewModel.ReplaceText = LastReplace;
            ViewModel.RememberValues = true;
        }

        private void SaveLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!ViewModel.RememberValues)
            {
                LastSearch = "";
                LastReplace = "";
                return;
            }

            LastSearch = ViewModel.SearchText;
            LastReplace = ViewModel.ReplaceText;
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            SaveLastSelection();
            e.Handled = true;
            DialogResult = true;
            Close();
        }
    }
}