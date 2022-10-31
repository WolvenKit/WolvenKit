using System;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.HomePage
{
    public enum EHomePage
    {
        Welcome,
        Mods,
        Plugins,
        Settings,
        Wiki,
        Github,
        Website
    }

    public class HomePageViewModel : ReactiveObject
    {
        // #needs_MVVM

        #region Fields

        private readonly ISettingsManager _settingsManager;
        private readonly IPluginService _pluginService;

        #endregion Fields

        #region Constructors

        public HomePageViewModel(ISettingsManager settingsManager, IPluginService pluginService)
        {
            _settingsManager = settingsManager;
            _pluginService = pluginService;

            CloseHomePage = new DelegateCommand(ExecuteHome, CanHome);
            RestoreWindow = new DelegateCommand(ExecuteRestoreWindow);
            MinimizeWindow = new DelegateCommand(ExecuteMinimizeWindow);

            CurrentWindowState = WindowState.Normal;
        }

        #endregion Constructors

        #region Properties

        [Reactive] public int SelectedIndex { get; set; }

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
            var main = Locator.Current.GetService<AppViewModel>();
            main.CloseModalCommand.Execute(null);
        }

        public void NavigateTo(EHomePage page) => SelectedIndex = (int)page;

        #endregion Methods
    }
}
