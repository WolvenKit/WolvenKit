
using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.ViewModels.Others;
using WolvenKit.MVVM.Views.Components.Wizards;
using WolvenKit.MVVM.Views.Others;


namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages
{
    public partial class WelcomePageView
    {
        public WelcomePageView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
               DiscordHelper.SetDiscordRPCStatus("Welcome");

            }

        }

        private void CreateProjectButton_Click(object sender, RoutedEventArgs e)
        {
            FirstSetupWizardView rpv = new FirstSetupWizardView();
            UserControlHostWindowViewModel zxc = new UserControlHostWindowViewModel(rpv);
            UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
            uchwv.Show();
        }

        private void OpenProjectButton_Click(object sender, RoutedEventArgs e)
        {
            FirstSetupWizardView rpv = new FirstSetupWizardView();
            UserControlHostWindowViewModel zxc = new UserControlHostWindowViewModel(rpv);
            UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
            uchwv.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageView.GlobalHomePage.SettingsPV);
          
        }

        private void TutorialsButton_Click(object sender, RoutedEventArgs e)
        {
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageView.GlobalHomePage.WikitPV);
        }

        private void WikiButton_Click(object sender, RoutedEventArgs e)
        {
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageView.GlobalHomePage.WikitPV);
        }

        private void irathernot_Click(object sender, RoutedEventArgs e)
        {
                        System.Diagnostics.Process.Start("");

            // backup if this joke doesnt work

        }
    }
}
