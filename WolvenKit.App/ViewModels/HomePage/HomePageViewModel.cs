using System;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Commands.Base;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.HomePage
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
            SystemCommands.MinimizeWindow((Window)Locator.Current.GetService<IViewFor<AppViewModel>>());
            CurrentWindowState = WindowState.Minimized;
        }

        private void ExecuteRestoreWindow()
        {
            if (CurrentWindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow((Window)Locator.Current.GetService<IViewFor<AppViewModel>>());
                CurrentWindowState = WindowState.Normal;
            }
            else
            {
                SystemCommands.MaximizeWindow((Window)Locator.Current.GetService<IViewFor<AppViewModel>>());
                CurrentWindowState = WindowState.Maximized;
            }
        }

        private bool CanHome() => true;

        private void ExecuteHome()
        {
            var main = Locator.Current.GetService<AppViewModel>();
            main.CloseModalCommand.Execute(null);
        }

        #endregion Methods
    }
}
