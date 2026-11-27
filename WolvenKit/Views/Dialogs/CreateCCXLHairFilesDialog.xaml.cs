
using System.Reactive.Disposables;
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

    /// <summary>
    /// Interaction logic for CreateCCXLHairFilesDialog.xaml
    /// </summary>
    public partial class CreateCCXLHairFilesDialog : IViewFor<CreateCCXLHairFilesDialogViewModel>
    {

        private bool s_vType = true;
        private string s_axlFile = "";

        private string s_parentFolderName = "";
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

        private bool s_isPhysEnabled = false;
        private bool s_isAppEnabled = false;

        private bool s_isJsonEnabled = false;
        private bool s_isInkCCEnabled = false;
        private bool s_isCybMeshEnabled = false;
        private bool s_isShadowMeshEnabled = false;



        public CreateCCXLHairFilesDialog(Cp77Project activeProject, ISettingsManager settingsManager,
                ProjectResourceTools projectResourceTools)
        {
            InitializeComponent();

            ViewModel = new CreateCCXLHairFilesDialogViewModel(activeProject, settingsManager, projectResourceTools)
            {
                VType = s_vType,
                AxlFile = s_axlFile,
                ParentFolderName = s_parentFolderName,
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
                SelectedJsonFile = s_selectedJsonFile,
                IsPhysEnabled = s_isPhysEnabled,
                IsAppEnabled = s_isAppEnabled,
                IsJsonEnabled = s_isJsonEnabled,
                IsInkCCEnabled = s_isInkCCEnabled,
                IsCybMeshEnabled = s_isCybMeshEnabled,
                IsShadowMeshEnabled = s_isShadowMeshEnabled

            };
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                   x => x.ProjectFolders,
                   x => x.FilterableDropdownMenu.Options)
               .DisposeWith(disposables);

                this.Bind(ViewModel,
                    x => x.ParentFolderName,
                    x => x.ParentFolderPathBox.Text)
                .DisposeWith(disposables);

                ViewModel?.SetFiles();
            });
        }

        public CreateCCXLHairFilesDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (CreateCCXLHairFilesDialogViewModel)value;
        }


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
