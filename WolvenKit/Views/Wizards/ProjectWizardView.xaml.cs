using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Wizards.WizardPages.ProjectWizard;

namespace WolvenKit.Views.Wizards
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
            ServiceLocator.Default.RegisterTypeAndInstantiate<ProjectWizardModel>();

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


        private void UserControl_ViewModelChanged(object sender, System.EventArgs e)
        {
            if (ViewModel is ProjectWizardViewModel vm)
            {
                ServiceLocator.Default.RegisterInstance(vm);

                SPTV = new SelectProjectTypeView();
                PCV = new ProjectConfigurationView();
                FSV = new FinalizeSetupView();

                ShowPage();
            }
        }

        #endregion Methods
    }
}
