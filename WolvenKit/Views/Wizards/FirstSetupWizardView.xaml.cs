using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.ViewModels.Components.Wizards;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.FirstSetupWizard;

namespace WolvenKit.MVVM.Views.Components.Wizards
{
    public partial class FirstSetupWizardView
    {
        #region Fields

        private CreateUserView CUV;

        private FinalizeSetupView FSV;

        private LocateGameDateView LGDV;

        private SetInitialPreferencesView SIPV;

        private SelectThemeView STV;

        #endregion Fields

        #region Constructors

        public FirstSetupWizardView()
        {
            ServiceLocator.Default.RegisterTypeAndInstantiate<Model.Wizards.ProjectWizardModel>();

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

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("First Setup Wizard");
            }
        }

        private void UserControl_ViewModelChanged(object sender, System.EventArgs e)
        {
            if (ViewModel == null)
            {
                return;
            }

            ServiceLocator.Default.RegisterInstance(ViewModel as FirstSetupWizardViewModel);

            CUV = new CreateUserView();
            STV = new SelectThemeView();
            LGDV = new LocateGameDateView();
            FSV = new FinalizeSetupView();
            SIPV = new SetInitialPreferencesView();

            ShowPage();
        }

        #endregion Methods
    }
}
