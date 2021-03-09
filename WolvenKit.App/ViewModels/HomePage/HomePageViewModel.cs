using System;
using System.Windows;
using System.Windows.Input;
using Catel.MVVM;
using HandyControl.Controls;
using HandyControl.Data;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.HomePage
{
    public class HomePageViewModel : ViewModelBase
    {
        // #needs_MVVM


        public HomePageViewModel()
        {
            GlobalHomePageVM = this;
            RegisterCommands();
            SetCurrentPage("Welcome");
        }




        // Register VM commands
        public void RegisterCommands()
        {
            CloseHomePage = new RelayCommand(ExecuteHome, CanHome);
            ClosePage = new RelayCommand(ExecPage, CanPage);
            RestoreWindow = new RelayCommand(ExecuteRestoreWindow, CanRestoreWindow);
            MinimizeWindow = new RelayCommand(ExecuteMinimizeWindow, CanMinimizeWindow);
        }


        public static HomePageViewModel GlobalHomePageVM;  // Static Reference of self for page switching.
        public bool AboutPV { get; set; }
        public bool DebugPV { get; set; }
        public bool FirstSWV { get; set; }
        public bool GithubPV { get; set; }
        public bool IntegratedTPV { get; set; }
        public bool ProjectWV { get; set; }
        public bool RecentPV { get; set; }
        public bool SettingsPV { get; set; }
        public bool UserPV { get; set; }
        public bool WebsitePV { get; set; }
        public bool WelcomePV { get; set; }
        public bool WikitPV { get; set; }
        public bool ReturnButtonVisibile { get; set; }
        public WindowState CurrentWindowState { get; set; }





        // Restore Shell Window.
        public ICommand RestoreWindow { get; set; }
        public bool CanRestoreWindow() => true;
        public void ExecuteRestoreWindow()
        {
            if (CurrentWindowState == WindowState.Maximized)
            { CurrentWindowState = WindowState.Normal; }
            else
            { CurrentWindowState = WindowState.Maximized; }
        }




        // Minimize Shell Window
        public ICommand MinimizeWindow { get; set; }
        public bool CanMinimizeWindow() => true;
        public void ExecuteMinimizeWindow()
        {
            CurrentWindowState = WindowState.Minimized;
        }





        // Close HomePage (Navigates to Project Editor
        public ICommand CloseHomePage { get; private set; }
        private bool CanHome() => true;
        private void ExecuteHome()
        {
            // StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(StartScreen.ShownProperty, false);
            //  StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
        }




        // Closes any open page on the homepage and returns to the welcome page.
        public ICommand ClosePage { get; private set; }
        private bool CanPage() => true;
        private void ExecPage()
        {
            SetCurrentPage("Welcome");
        }






        // Helps with switching pages , Listens to the selectionchanged on a sidemenu.  , SetCurrentPage deals with the actual "Decision" of what page needs to be shown.
        public Command<FunctionEventArgs<object>> SwitchItemCmd => new Lazy<Command<FunctionEventArgs<object>>>(() =>
            new Command<FunctionEventArgs<object>>(SwitchItem)).Value;
        private void SwitchItem(FunctionEventArgs<object> info) => SetCurrentPage((info.Info as SideMenuItem)?.Header.ToString());
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
                    DiscordHelper.SetDiscordRPCStatus("Home");
                    break;

                case "Project":
                case "Open Recent Project":
                    RecentPV = true;
                    DiscordHelper.SetDiscordRPCStatus("Recent projects.");
                    break;

                case "Integrated Tools":
                    IntegratedTPV = true;
                    DiscordHelper.SetDiscordRPCStatus("Integrated tools.");
                    break;

                case "Settings":
                    SettingsPV = true;
                    DiscordHelper.SetDiscordRPCStatus("Adjusting settings.");
                    break;

                case "Account":
                    UserPV = true;
                    DiscordHelper.SetDiscordRPCStatus("Profile.");
                    break;

                case "Information":
                case "Wiki":
                    WikitPV = true;
                    DiscordHelper.SetDiscordRPCStatus("Integrated Wiki.");
                    break;

                case "Github":
                    GithubPV = true;
                    DiscordHelper.SetDiscordRPCStatus("Github page.");
                    break;

                case "SDK":
                    break;

                case "About":
                    AboutPV = true;
                    DiscordHelper.SetDiscordRPCStatus("About section.");
                    break;

                case "Website":
                    WebsitePV = true;
                    DiscordHelper.SetDiscordRPCStatus("Integrated website.");
                    break;

                case "DEBUG":
                    DiscordHelper.SetDiscordRPCStatus("DEBUG");
                    break;
            }
        }




    }
}
