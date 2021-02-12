
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class FirstSetupWizardView
    {
        public FirstSetupWizardView()
        {
            ServiceLocator.Default.RegisterInstance(new Model.Wizards.ProjectWizardModel());
            ServiceLocator.Default.RegisterTypeAndInstantiate<ViewModels.Wizards.FirstSetupWizardViewModel>();
            
            CUV = new CreateUserView();
            STV = new SelectThemeView();
            LGDV = new LocateGameDateView();
            FSV = new FinalizeSetupView();
            SIPV = new SetInitialPreferencesView();

            InitializeComponent();
            ShowPage();
        }


        private CreateUserView CUV ;
        private SelectThemeView STV ;
        private LocateGameDateView LGDV ;
        private FinalizeSetupView FSV ;
        private SetInitialPreferencesView SIPV;

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(CUV);
                    break;
                case 1:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(STV);
                    break;
                case 2:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(SIPV);
                    break;
                case 3:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(LGDV);
                    break;
                case 4:
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
                DiscordRPCHelper.WhatAmIDoing("First Setup Wizard");
            }
        }
    }
}
