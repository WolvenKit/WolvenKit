using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Types;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class RenameDialog : IViewFor<RenameDialogViewModel>
    {
        /// <summary>
        /// Refactor checkbox visibility (don't show it for files in raw)
        /// </summary>
        public bool ShowRefactorCheckbox { get; private set; }

        /// <summary>
        /// Refactor checkbox visibility (don't show it for files in raw)
        /// </summary>
        private bool _refactorDefaultState = true;

        /// <summary>
        /// Preserve checkbox state
        /// </summary>
        private static bool? s_lastShowRefactorCheckbox = null;

        private void SetDefaultValue()
        {
            if (!ShowRefactorCheckbox || s_lastShowRefactorCheckbox is not null)
            {
                return;
            }

            var settingsManager = Locator.Current.GetService<ISettingsManager>();
            _refactorDefaultState = settingsManager?.RefactoringCheckboxDefaultValue ?? false;
            s_lastShowRefactorCheckbox = _refactorDefaultState;
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

                if (ShowRefactorCheckbox)
                {
                    ViewModel.EnableRefactoring = s_lastShowRefactorCheckbox;
                }

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

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter && e.Key != Key.Escape)
            {
                return;
            }

            e.Handled = true;
            CloseDialogue(e.Key == Key.Enter);
        }

        private void CloseDialogue(bool result)
        {
            SaveRefactoringPreference();
            DialogResult = result;
            Close();
        }

        private void WizardControl_OnFinish(object _, RoutedEventArgs e) => SaveRefactoringPreference();

        private void SaveRefactoringPreference()
        {
            // Do not save preference if checkbox status has been changed via shift key
            if (!ShowRefactorCheckbox || ModifierViewStateService.IsShiftBeingHeldOnly)
            {
                return;
            }

            s_lastShowRefactorCheckbox = ViewModel?.EnableRefactoring == true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is not TextBox textBox ||
                textBox.Text.Equals(textBox.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                return;
            }

            var caretIndex = textBox.CaretIndex;
            textBox.Text = textBox.Text.ToFilePath();
            textBox.CaretIndex = caretIndex;
        }

        private void TextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Escape or Key.Enter)
            {
                e.Handled = true;
                CloseDialogue(e.Key == Key.Enter);
                return;
            }

            if (!ShowRefactorCheckbox || !ModifierViewStateService.IsShiftBeingHeldOnly ||
                DataContext is not RenameDialogViewModel vm)
            {
                return;
            }

            // Pressing shift will temporarily invert the refactoring checkbox
            vm.EnableRefactoring = !_refactorDefaultState;
        }

        // Releasing shift will un-invert the refactoring checkbox
        private void TextBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (!ShowRefactorCheckbox || e.Key is not (Key.LeftShift or Key.RightShift) ||
                DataContext is not RenameDialogViewModel vm)
            {
                return;
            }

            vm.EnableRefactoring = _refactorDefaultState;
        }
    }
}
