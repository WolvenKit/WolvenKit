using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Catel.Logging;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Others;
using WolvenKit.Views.Others;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.Helpers
{
    public static partial class Helpers
    {


        // Show the first time setup to the user.
        public static void ShowFirstTimeSetup(ISettingsManager settings, INotificationService growl)
        {
            var messages = settings.IsHealthy();
            if (!messages.Any())
            {
                return;
            }

            foreach (var message in messages)
            {
                //growl.Error(message);
            }

            try
            {
                // Try to show First time setup.
                Task.Run(() =>
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        var rpv = new FirstSetupWizardView();
                        var zxc = new UserControlHostWindowViewModel(rpv, 400, 600);
                        var uchwv = new UserControlHostWindowView(zxc);
                        rpv.ViewModelChanged += (_s, _e) =>
                        {
                            if (rpv.ViewModel == null)
                            {
                                return;
                            }

                            rpv.ViewModel.ClosedAsync += async (s, e) => await Task.Run(() => Application.Current.Dispatcher.Invoke(() => uchwv.Close()));
                        };
                        uchwv.Show();
                    }));
            }

            catch (Exception e)
            {
                // Log error.
                StaticReferences.Logger.Error(e.Message);

            }
        }


        // Check for program updates.
        //public static void CheckForUpdates()
        //{
        //    try
        //    {
        //        // Start Auto updater.
        //        AutoUpdater.Start("https://raw.githubusercontent.com/WolvenKit/WolvenKit/master/Update.xml");
        //    }
        //    catch (Exception e)
        //    {
        //        // Log Error
        //        StaticReferences.Logger.Error(e.Message);
        //    }
        //}




    }


}
