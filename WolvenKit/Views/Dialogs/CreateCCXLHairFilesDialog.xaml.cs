using System;
using System.ComponentModel;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HandyControl.Tools.Extension;
using ReactiveUI;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Interfaces.Extensions;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs
{

    /// <summary>
    /// Interaction logic for CreateCCXLHairFilesDialog.xaml
    /// </summary>
    public partial class CreateCCXLHairFilesDialog : IViewFor<CreateCCXLHairFilesDialogViewModel>
    {

        private string s_hairModName = "";
        private string s_ccCDisplayName = "";
        private string s_selectedInkCCFile = "";

        private string s_selectedMainAppFile = "";
        private string s_selectedCybAppFile = "";

        private string s_selectedShadowAppFile = "";


        private string s_selectedMainMeshFile = "";
        private string s_selectedCybMeshFile = "";

        private string s_selectedShadowMeshFile = "";
        private string s__selectedRigFile = "";
        private string s_selectedAnimGraphFile = "";
        private string s_selectedJsonFile = "";




        public CreateCCXLHairFilesDialog(Cp77Project activeProject, ISettingsManager settingsManager,
                ProjectResourceTools projectResourceTools)
        {
            InitializeComponent();

            ViewModel = new CreateCCXLHairFilesDialogViewModel(activeProject, settingsManager, projectResourceTools)
            {
                HairmodName = s_hairModName,
                CcDisplayName = s_ccCDisplayName,
                SelectedInkCCFile = s_selectedInkCCFile,
                SelectedMainAppFile = s_selectedMainAppFile,
                SelectedCybAppFile = s_selectedCybAppFile,
                SelectedShadowAppFile = s_selectedShadowAppFile,
                SelectedMainMeshFile = s_selectedMainMeshFile,
                SelectedCybMeshFile = s_selectedCybMeshFile,
                SelectedShadowMeshFile = s_selectedShadowMeshFile,
                SelectedRigFile = s__selectedRigFile,
                SelectedAnimGraphFile = s_selectedAnimGraphFile,
                SelectedJsonFile = s_selectedJsonFile
            };
            DataContext = ViewModel;

            this.WhenActivated(_ =>
            {
                ViewModel?.SetFiles();
            });
        }

        public CreateCCXLHairFilesDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (CreateCCXLHairFilesDialogViewModel)value; }

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

        private void WizardControl_OnFinish(object sender, RoutedEventArgs e) { }
    }


}
