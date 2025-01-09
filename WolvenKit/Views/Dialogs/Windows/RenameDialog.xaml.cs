using System;
using System.IO;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class RenameDialog : IViewFor<RenameDialogViewModel>
    {
        public bool ShowRefactorCheckbox { get; private set; }
        private static bool? s_lastShowRefactorCheckbox = null;

        private static void SetDefaultValue()
        {
            if (s_lastShowRefactorCheckbox is not null)
            {
                return;
            }

            var settingsManager = Locator.Current.GetService<ISettingsManager>();
            s_lastShowRefactorCheckbox = settingsManager?.RefactoringCheckboxDefaultValue ?? false;
        } 

        public RenameDialog(bool showRefactorCheckbox = false)
        {
            InitializeComponent();
            SetDefaultValue();

            ViewModel = Locator.Current.GetService<RenameDialogViewModel>();
            DataContext = ViewModel;
            ShowRefactorCheckbox = showRefactorCheckbox;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.Text,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.EnableRefactoring,
                        x => x.EnableRefactoringCheckbox.IsChecked)
                    .DisposeWith(disposables);

                if (ViewModel is null)
                {
                    return;
                }

                ViewModel.EnableRefactoring = s_lastShowRefactorCheckbox;

                if (string.IsNullOrEmpty(TextBox.Text) || ViewModel.Text is null)
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

        private void SaveLastSelection() => s_lastShowRefactorCheckbox = ViewModel?.EnableRefactoring == true;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is not TextBox textBox || textBox.Text.ToLower() == textBox.Text)
            {
                return;
            }

            var caretIndex = textBox.CaretIndex;
            textBox.Text = textBox.Text.ToLower();
            textBox.CaretIndex = caretIndex;
        }
    }
}
