using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class FirstSetupWizardView
    {
        #region Fields

        private CreateUserView CUV;

        private FinalizeSetupView FSV;

        private LocateGameDateView LGDV;

        #endregion Fields

        #region Constructors

        public FirstSetupWizardView()
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
                    PageGrid.Children.Add(CUV);
                    break;

                case 1:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(LGDV);
                    break;

                case 2:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(FSV);
                    break;
            }
        }

        private void UserControl_ViewModelChanged(object sender, System.EventArgs e)
        {
            if (ViewModel is FirstSetupWizardViewModel vm)
            {
                ServiceLocator.Default.RegisterInstance(vm);

                CUV = new CreateUserView();
                LGDV = new LocateGameDateView();
                FSV = new FinalizeSetupView();

                ShowPage();
            }
        }

        #endregion Methods
    }
}
