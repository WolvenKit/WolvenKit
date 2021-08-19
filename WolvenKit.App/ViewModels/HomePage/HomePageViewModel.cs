using System;
using System.Windows;
using System.Windows.Input;
using HandyControl.Controls;
using HandyControl.Data;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.HomePage
{
    public class HomePageViewModel : ReactiveObject
    {
        // #needs_MVVM

        #region Fields

        private readonly ISettingsManager _settingsManager;

        #endregion Fields

        #region Constructors

        public HomePageViewModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;

            CloseHomePage = new RelayCommand(ExecuteHome, CanHome);
            ClosePage = new RelayCommand(ExecPage, CanPage);

            RestoreWindow = new RelayCommand(ExecuteRestoreWindow);
            MinimizeWindow = new RelayCommand(ExecuteMinimizeWindow);

            SwitchItemCmd = new DelegateCommand<FunctionEventArgs<object>>(SwitchItem);

            SetCurrentPage("Welcome");
            CurrentWindowState = WindowState.Maximized;
        }

        #endregion Constructors

        #region Properties



        // Close HomePage (Navigates to Project Editor
        public ICommand CloseHomePage { get; private set; }

        // Closes any open page on the homepage and returns to the welcome page.
        public ICommand ClosePage { get; private set; }

        // Restore Shell Window.
        public ICommand RestoreWindow { get; set; }

        public ICommand SwitchItemCmd { get; private set; }

        public WindowState CurrentWindowState { get; set; }

        // Minimize Shell Window
        public ICommand MinimizeWindow { get; set; }

        // Static Reference of self for page switching.
        [Reactive] public bool AboutPV { get; set; }

        [Reactive] public bool DebugPV { get; set; }

        [Reactive] public bool FirstSWV { get; set; }

        [Reactive] public bool GithubPV { get; set; }

        [Reactive] public bool IntegratedTPV { get; set; }

        [Reactive] public bool ProjectWV { get; set; }

        [Reactive] public bool RecentPV { get; set; }

        [Reactive] public bool ReturnButtonVisibile { get; set; }

        [Reactive] public bool SettingsPV { get; set; }

        // Helps with switching pages , Listens to the selectionchanged on a sidemenu.  , SetCurrentPage deals with the actual "Decision" of what page needs to be shown.
        //public Command<FunctionEventArgs<object>> SwitchItemCmd => new Lazy<Command<FunctionEventArgs<object>>>(() =>
        //    new Command<FunctionEventArgs<object>>(SwitchItem)).Value;

        [Reactive] public bool UserPV { get; set; }

        [Reactive] public bool WebsitePV { get; set; }

        [Reactive] public bool WelcomePV { get; set; }

        [Reactive] public bool WikitPV { get; set; }

        public string VersionNumber => _settingsManager.GetVersionNumber();

        #endregion Properties

        #region Methods

        public void ExecuteMinimizeWindow()
        {
            SystemCommands.MinimizeWindow((System.Windows.Window)Locator.Current.GetService<IViewFor<AppViewModel>>());
            CurrentWindowState = WindowState.Minimized;
        }

        private void ExecuteRestoreWindow()
        {
            if (CurrentWindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow((System.Windows.Window)Locator.Current.GetService<IViewFor<AppViewModel>>());
                CurrentWindowState = WindowState.Normal;
            }
            else
            {
                SystemCommands.MaximizeWindow((System.Windows.Window)Locator.Current.GetService<IViewFor<AppViewModel>>());
                CurrentWindowState = WindowState.Maximized;
            }
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
            var ribbon = Locator.Current.GetService<RibbonViewModel>();
            ribbon.StartScreenShown = false;
            ribbon.BackstageIsOpen = false;
        }

        private void SwitchItem(FunctionEventArgs<object> info) => SetCurrentPage((info.Info as SideMenuItem)?.Header.ToString());

        #endregion Methods
    }
}
