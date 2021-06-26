using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Catel.MVVM;
using HandyControl.Controls;
using HandyControl.Data;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.HomePage
{
    public class HomePageViewModel : ViewModelBase
    {
        // #needs_MVVM

        #region Fields

        private readonly ISettingsManager _settingsManager;

        
        


        public static HomePageViewModel GlobalHomePageVM;

        #endregion Fields

        #region Constructors

        public HomePageViewModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;

            GlobalHomePageVM = this;
            RegisterCommands();
            SetCurrentPage("Welcome");
            CurrentWindowState = WindowState.Maximized;
        }

        #endregion Constructors

        #region Properties

        // Static Reference of self for page switching.
        public bool AboutPV { get; set; }

        // Close HomePage (Navigates to Project Editor
        public ICommand CloseHomePage { get; private set; }

        // Closes any open page on the homepage and returns to the welcome page.
        public ICommand ClosePage { get; private set; }

        public WindowState CurrentWindowState { get; set; }

        public bool DebugPV { get; set; }

        public bool FirstSWV { get; set; }

        public bool GithubPV { get; set; }

        public bool IntegratedTPV { get; set; }

        // Minimize Shell Window
        public ICommand MinimizeWindow { get; set; }

        public bool ProjectWV { get; set; }

        public bool RecentPV { get; set; }

        // Restore Shell Window.
        public ICommand RestoreWindow { get; set; }

        public bool ReturnButtonVisibile { get; set; }

        public bool SettingsPV { get; set; }

        // Helps with switching pages , Listens to the selectionchanged on a sidemenu.  , SetCurrentPage deals with the actual "Decision" of what page needs to be shown.
        public Command<FunctionEventArgs<object>> SwitchItemCmd => new Lazy<Command<FunctionEventArgs<object>>>(() =>
            new Command<FunctionEventArgs<object>>(SwitchItem)).Value;

        public bool UserPV { get; set; }

        public bool WebsitePV { get; set; }

        public bool WelcomePV { get; set; }

        public bool WikitPV { get; set; }

        public string VersionNumber => _settingsManager.GetVersionNumber();

        #endregion Properties

        #region Methods

        public bool CanMinimizeWindow() => true;

        public bool CanRestoreWindow() => true;

        public void ExecuteMinimizeWindow()
        {
            CurrentWindowState = WindowState.Minimized;
        }

        public void ExecuteRestoreWindow()
        {
            if (CurrentWindowState == WindowState.Maximized)
            { CurrentWindowState = WindowState.Normal; }
            else
            { CurrentWindowState = WindowState.Maximized; }
        }

        // Register VM commands
        public void RegisterCommands()
        {
            CloseHomePage = new RelayCommand(ExecuteHome, CanHome);
            ClosePage = new RelayCommand(ExecPage, CanPage);
            RestoreWindow = new RelayCommand(ExecuteRestoreWindow, CanRestoreWindow);
            MinimizeWindow = new RelayCommand(ExecuteMinimizeWindow, CanMinimizeWindow);
        }

        public void SetCurrentPage(string page)
        {
            AboutPV = false;
            DebugPV = false;
            FirstSWV = false;
            GithubPV = false;
            IntegratedTPV = false;
            ProjectWV = false;
            RecentPV = false;
            SettingsPV = false;
            UserPV = false;
            WebsitePV = false;
            WelcomePV = false;
            WikitPV = false;
            switch (page)
            {
                case "Get Started":
                case "Welcome":
                    WelcomePV = true;
                    ReturnButtonVisibile = false;
                    DiscordHelper.SetDiscordRPCStatus("Home");
                    break;

                case "Project":
                case "Open Recent Project":
                    RecentPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Recent projects.");
                    break;

                case "Integrated Tools":
                    IntegratedTPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Integrated tools.");
                    break;

                case "Settings":
                    SettingsPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Adjusting settings.");
                    break;

                case "Account":
                    UserPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Profile.");
                    break;

                case "Information":
                case "Wiki":
                    WikitPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Integrated Wiki.");
                    break;

                case "Github":
                    GithubPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Github page.");
                    break;

                case "SDK":
                    break;

                case "About":
                    AboutPV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("About section.");
                    break;

                case "Website":
                    WebsitePV = true;
                    ReturnButtonVisibile = true;

                    DiscordHelper.SetDiscordRPCStatus("Integrated website.");
                    break;

                case "DEBUG":
                    //DiscordHelper.SetDiscordRPCStatus("DEBUG");
                    break;
            }
        }

        private bool CanHome() => true;

        private bool CanPage() => true;

        private void ExecPage()
        {
            SetCurrentPage("Welcome");
        }

        private void ExecuteHome()
        {
            RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;
        }

        private void SwitchItem(FunctionEventArgs<object> info) => SetCurrentPage((info.Info as SideMenuItem)?.Header.ToString());

        #endregion Methods
    }
}
