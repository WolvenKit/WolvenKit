
using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.ViewModels.Components.Wizards;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard;
using FinalizeSetupView = WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard.FinalizeSetupView;

namespace WolvenKit.MVVM.Views.Components.Wizards
{
    public partial class ProjectWizardView
    {
        public ProjectWizardView()
        {
            ServiceLocator.Default.RegisterTypeAndInstantiate<Model.Wizards.FirstSetupWizardModel>();

            InitializeComponent();
        }

        private void UserControl_ViewModelChanged(object sender, System.EventArgs e)
        {
            if (ViewModel == null)
                return;

            ServiceLocator.Default.RegisterInstance(ViewModel as ProjectWizardViewModel);

            SPTV = new SelectProjectTypeView();
            PCV = new ProjectConfigurationView();
            FSV = new FinalizeSetupView();

            ShowPage();
        }

        private SelectProjectTypeView SPTV;
        private ProjectConfigurationView PCV;
        private FinalizeSetupView FSV;

        private void ShowPage()
        {
            switch(StepMain.StepIndex)
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

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Project Wizard");
            }
        }
    }
}
