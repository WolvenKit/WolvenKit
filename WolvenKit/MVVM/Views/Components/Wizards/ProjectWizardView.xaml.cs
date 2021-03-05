using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Model.Wizards;
using WolvenKit.MVVM.ViewModels.Components.Wizards;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard;
using FinalizeSetupView = WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard.FinalizeSetupView;

namespace WolvenKit.MVVM.Views.Components.Wizards
{
    public partial class ProjectWizardView
    {
        #region Fields

        private FinalizeSetupView FSV;

        private ProjectConfigurationView PCV;

        private SelectProjectTypeView SPTV;

        #endregion Fields

        #region Constructors

        public ProjectWizardView()
        {
            ServiceLocator.Default.RegisterTypeAndInstantiate<FirstSetupWizardModel>();

            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Next();
            ShowPage();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
            ShowPage();
        }

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(SPTV);
                    break;

                case 1:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(PCV);
                    break;

                case 2:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(FSV);
                    break;
            }
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Project Wizard");
            }
        }

        private void UserControl_ViewModelChanged(object sender, System.EventArgs e)
        {
            if (ViewModel == null)
            {
                return;
            }

            ServiceLocator.Default.RegisterInstance(ViewModel as ProjectWizardViewModel);

            SPTV = new SelectProjectTypeView();
            PCV = new ProjectConfigurationView();
            FSV = new FinalizeSetupView();

            ShowPage();
        }

        #endregion Methods
    }
}
