using System;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs
{
    public partial class CopyMeshAppearancesDialog : IViewFor<CopyMeshAppearancesDialogViewModel>
    {
        private static string s_lastSelectedOption;
        private static bool s_lastAppend;

        public CopyMeshAppearancesDialog(Cp77Project activeProject, ISettingsManager settingsManager)
        {
            InitializeComponent();

            ViewModel = new CopyMeshAppearancesDialogViewModel(activeProject, settingsManager)
            {
                IsAppend = s_lastAppend, SelectedOption = s_lastSelectedOption
            };
            DataContext = ViewModel;
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
