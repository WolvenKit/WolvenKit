using System;
using System.Threading.Tasks;
using System.Windows;
using AutoUpdaterDotNET;
using Catel.Logging;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Others;
using WolvenKit.Views.Others;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.Helpers
{
    public static partial class Helpers
    {
        /// <summary>
        /// Check for application Updates.
        /// </summary>
        public static void CheckForUpdates()
        {
            try
            { AutoUpdater.Start("https://raw.githubusercontent.com/WolvenKit/WolvenKit/master/Update.xml"); }
            catch (Exception p_Exception) { StaticReferences.Logger.Error(p_Exception.Message); }
        }

        /// <summary>
        /// Present the first time setup to the user.
        /// </summary>
        public static void ShowFirstTimeSetup()
        {
            if (SettingsManager.FirstTimeSetupForUser)
            {
                try
                {
                    Task.Run(() =>
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            var m_FirstSetupWizardView = new FirstSetupWizardView();
                            var m_UserControlHostWindowViewModel = new UserControlHostWindowViewModel(m_FirstSetupWizardView);
                            var m_UserControlHostWindowView = new UserControlHostWindowView(m_UserControlHostWindowViewModel);
                            m_FirstSetupWizardView.ViewModelChanged += (_s, _e) =>
                            {
                                if (m_FirstSetupWizardView.ViewModel == null)
                                { return; }
                                m_FirstSetupWizardView.ViewModel.ClosedAsync += async (s, e) => await Task.Run(() => Application.Current.Dispatcher.Invoke(() => m_UserControlHostWindowView.Close()));
                            };
                            m_UserControlHostWindowView.Show();
                        }));
                }
                catch (Exception p_Exception) { StaticReferences.Logger.Error(p_Exception.Message); }
            }
        }
    }
}
