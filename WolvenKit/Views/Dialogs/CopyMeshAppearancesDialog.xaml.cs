using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using System.Reactive.Disposables;
using Syncfusion.Windows.Controls.Input;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs
{
    public partial class CopyMeshAppearancesDialog : IViewFor<CopyMeshAppearancesDialogViewModel>
    {
        private static List<string> s_lastSelectedOptions = [];
        private static bool s_lastAppend;

        public CopyMeshAppearancesDialog(List<string> options)
        {
            InitializeComponent();

            ViewModel = new CopyMeshAppearancesDialogViewModel(options, s_lastSelectedOptions)
            {
                IsAppend = s_lastAppend
            };
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.SelectedOption,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.OptionsDict,
                        x => x.FilterableChecklistMenu.CheckboxOptionsAndStates)
                    .DisposeWith(disposables);
            });
        }

        public CopyMeshAppearancesDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (CopyMeshAppearancesDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void SaveLastValues()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(ViewModel.SelectedOption))
            {
                s_lastSelectedOptions = ViewModel.SelectedOptions;
            }

            // save bool flags
            s_lastAppend = ViewModel.IsAppend;
        }


        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter || ViewModel?.CanSave != true)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == true)
            {
                SaveLastValues();
            }

            base.OnClosed(e);
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.UseArchiveXlPatchMesh = true;
            DialogResult = true;
            Close();
        }

        private void ChecklistMenu_OnSelectionChanged(object _, List<string> selection)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.SelectedOptions ??= [];

            ViewModel.SelectedOptions.Clear();
            ViewModel.SelectedOptions.AddRange(selection);
            ViewModel.SetSaveButtonState();
        }

        private void TextBox_OnFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is not SfTextBoxExt tb || ViewModel is null)
            {
                return;
            }

            ViewModel.SelectedOptions.Clear();
            ViewModel.SelectedOptions.Add(tb.Text);
            ViewModel.SetSaveButtonState();
        }
    }
}
