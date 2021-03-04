using System.Windows;
using WolvenKit.MVVM.ViewModels.Others;
using WolvenKit.MVVM.ViewModels.Shell.HomePage;
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
        }

        private void CreateProjectButton_Click(object sender, RoutedEventArgs e)
        {
            var rpv = new FirstSetupWizardView();
            var zxc = new UserControlHostWindowViewModel(rpv);
            var uchwv = new UserControlHostWindowView(zxc);
            uchwv.Show();
        }

        private void OpenProjectButton_Click(object sender, RoutedEventArgs e)
        {
            var rpv = new FirstSetupWizardView();
            var zxc = new UserControlHostWindowViewModel(rpv);
            var uchwv = new UserControlHostWindowView(zxc);
            uchwv.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageViewModel.GlobalHomePageVM.SettingsPV);
        }

        private void TutorialsButton_Click(object sender, RoutedEventArgs e)
        {
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageViewModel.GlobalHomePageVM.WikitPV);
        }

        private void WikiButton_Click(object sender, RoutedEventArgs e)
        {
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageViewModel.GlobalHomePageVM.WikitPV);
        }

        private void irathernot_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start("");// backup if this joke doesnt work
    }
}
