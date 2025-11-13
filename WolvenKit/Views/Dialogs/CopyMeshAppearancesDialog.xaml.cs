using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using System.Reactive.Disposables;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs
{
    public partial class CopyMeshAppearancesDialog : IViewFor<CopyMeshAppearancesDialogViewModel>
    {
        private static string s_lastSelectedOption;
        private static bool s_lastAppend;

        public CopyMeshAppearancesDialog(List<string> options)
        {
            InitializeComponent();

            ViewModel = new CopyMeshAppearancesDialogViewModel(options)
            {
                IsAppend = s_lastAppend, SelectedOption = s_lastSelectedOption
            };
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.SelectedOption,
                        x => x.Dropdown.SelectedOption)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.SelectedOption,
                        x => x.TextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.OptionsDict,
                        x => x.Dropdown.Options)
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
                s_lastSelectedOption = ViewModel.SelectedOption;
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
    }
}
