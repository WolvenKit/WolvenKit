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
        private static string s_lastSearch = "";
        private static string s_lastReplace = "";
        
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

            if (s_lastSearch != "")
            {
                ViewModel.SearchText = s_lastSearch;
                ViewModel.RememberValues = true;
            }

            if (s_lastReplace == "")
            {
                return;
            }

            ViewModel.ReplaceText = s_lastReplace;
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
                s_lastSearch = "";
                s_lastReplace = "";
                return;
            }

            s_lastSearch = ViewModel.SearchText;
            s_lastReplace = ViewModel.ReplaceText;
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

        private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();
    }
}