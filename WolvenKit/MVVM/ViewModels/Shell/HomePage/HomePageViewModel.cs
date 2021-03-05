using System;
using System.Windows;
using System.Windows.Input;
using Catel.MVVM;
using Fluent;
using HandyControl.Controls;
using HandyControl.Data;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Components.Wizards;
using WolvenKit.MVVM.Views.Shell.HomePage;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages;

namespace WolvenKit.MVVM.ViewModels.Shell.HomePage
{
    internal class HomePageViewModel : ViewModelBase
    {
        #region Fields

        public static HomePageViewModel GlobalHomePageVM;
        public AboutPageView AboutPV;
        public DebugPageView DebugPV;
        public FirstSetupWizardView FirstSWV;
        public GithubPageView GithubPV;
        public IntegratedToolsPageView IntegratedTPV;
        public ProjectWizardView ProjectWV;
        public RecentProjectView RecentPV;
        public SettingsPageView SettingsPV;
        public UserPageView UserPV;
        public WebsitePageView WebsitePV;
        public WelcomePageView WelcomePV;
        public WikiPageView WikitPV;

        #endregion Fields

        #region Constructors

        public HomePageViewModel()
        {
            InitializePages();
            GlobalHomePageVM = this;
            SetCurrentPage("Welcome");
            CloseHomePage = new RelayCommand(ExecuteHome, CanHome);
            ClosePage = new RelayCommand(ExecPage, CanPage);

            CloseWkit = new RelayCommand(ExecuteCloseWkit, CanCloseWkit);
            RestoreWkit = new RelayCommand(ExecuteRestoreWkit, CanRestoreWkit);
            MinimizeWkit = new RelayCommand(ExecuteMinimizeWkit, CanMinimizeWkit);
        }

        #endregion Constructors

        #region Properties

        public ICommand CloseHomePage { get; private set; }
        public ICommand ClosePage { get; private set; }

        public ICommand CloseWkit { get; private set; }
        public ICommand MinimizeWkit { get; private set; }
        public ICommand RestoreWkit { get; private set; }

        public Command<FunctionEventArgs<object>> SwitchItemCmd => new Lazy<Command<FunctionEventArgs<object>>>(() =>
            new Command<FunctionEventArgs<object>>(SwitchItem)).Value;

        #endregion Properties

        #region Methods

        // Current page.
        public void SetCurrentPage(string page)
        {
            switch (page)
            {
                case "Get Started":

                case "Welcome":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(WelcomePV);
                    DiscordHelper.SetDiscordRPCStatus("Home");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Hidden);
                    break;

                case "Project":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(WelcomePV);
                    DiscordHelper.SetDiscordRPCStatus("Home");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Hidden);

                    break;

                case "Open Recent Project":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(RecentPV);
                    DiscordHelper.SetDiscordRPCStatus("Viewing recent projects.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Integrated Tools":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(IntegratedTPV);
                    DiscordHelper.SetDiscordRPCStatus("Checking out the integrated tools.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Settings":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(SettingsPV);
                    DiscordHelper.SetDiscordRPCStatus("Adjusting settings.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Account":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(UserPV);
                    DiscordHelper.SetDiscordRPCStatus("Looking at their profile.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Information":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(WikitPV);
                    DiscordHelper.SetDiscordRPCStatus("Reading the integrated Wiki.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Wiki":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(WikitPV);
                    DiscordHelper.SetDiscordRPCStatus("Reading the integrated Wiki.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Github":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(GithubPV);
                    DiscordHelper.SetDiscordRPCStatus("Viewing integrated Github page.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "SDK":

                    break;

                case "About":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(AboutPV);
                    DiscordHelper.SetDiscordRPCStatus("Reading the about section.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "Website":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(WebsitePV);
                    DiscordHelper.SetDiscordRPCStatus("Viewing integrated website.");
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    break;

                case "DEBUG":
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
                    HomePageView.GlobalHomePage.PageViewGrid.Children.Add(DebugPV);
                    HomePageView.GlobalHomePage.PageCloseButton.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Visible);

                    DiscordHelper.SetDiscordRPCStatus("DEBUG");
                    break;
            }
        }

        private bool CanCloseWkit() => true;

        private bool CanHome() => true;
        private bool CanPage() => true;


        private bool CanMinimizeWkit() => true;

        private bool CanRestoreWkit() => true;

        private void ExecuteCloseWkit() =>
            // Add dialog here?
            Application.Current.Shutdown();


        private void ExecPage()
        {
            SetCurrentPage("Welcome");
        }

        private void ExecuteHome()
        {
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(StartScreen.ShownProperty, false);
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
        }

        private void ExecuteMinimizeWkit() => StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Minimized);

        private void ExecuteRestoreWkit()
        {
            if (StaticReferences.GlobalShell.WindowState == WindowState.Maximized)
            {
                StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Normal);
            }
            else
            {
                StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Maximized);
            }
        }

        //Init pages on home.
        private void InitializePages()
        {
            WelcomePV = new WelcomePageView();
            FirstSWV = new FirstSetupWizardView();
            RecentPV = new RecentProjectView();
            ProjectWV = new ProjectWizardView();
            WikitPV = new WikiPageView();
            AboutPV = new AboutPageView();
            SettingsPV = new SettingsPageView();
            WebsitePV = new WebsitePageView();
            UserPV = new UserPageView();
            GithubPV = new GithubPageView();
            IntegratedTPV = new IntegratedToolsPageView();
            DebugPV = new DebugPageView();
        }

        private void SwitchItem(FunctionEventArgs<object> info) => SetCurrentPage((info.Info as SideMenuItem)?.Header.ToString());

        #endregion Methods
    }
}
