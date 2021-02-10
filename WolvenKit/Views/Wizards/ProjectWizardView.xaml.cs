
using Catel;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Views.Wizards.WizardPages.ProjectWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizardView
    {
        public ProjectWizardView()
        {
            ServiceLocator.Default.RegisterInstance(new Model.Wizards.FirstSetupWizardModel());

            SPTV = new SelectProjectTypeView();
            PCV = new ProjectConfigurationView();
            FSV = new FinalizeSetupView(this);

            InitializeComponent();
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
                DiscordRPCHelper.WhatAmIDoing("Project Wizard");
            }
        }
    }
}
