using System;
using System.Windows;
using System.Windows.Input;
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
            RestoreWindow = new RelayCommand(ExecuteRestoreWindow);
            MinimizeWindow = new RelayCommand(ExecuteMinimizeWindow);

            CurrentWindowState = WindowState.Normal;
        }

        #endregion Constructors

        #region Properties


        // Close HomePage (Navigates to Project Editor
        public ICommand CloseHomePage { get; private set; }


        // Restore Shell Window.
        public ICommand RestoreWindow { get; set; }

        public ICommand SwitchItemCmd { get; private set; }

        public WindowState CurrentWindowState { get; set; }

        // Minimize Shell Window
        public ICommand MinimizeWindow { get; set; }

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

        private bool CanHome() => true;

        private void ExecuteHome()
        {
            var ribbon = Locator.Current.GetService<RibbonViewModel>();
            ribbon.StartScreenShown = false;
            ribbon.BackstageIsOpen = false;
        }

        #endregion Methods
    }
}
