using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using AutoUpdaterDotNET;
using WolvenKit.ViewModels.Others;
using WolvenKit.Views.Others;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class AppHelper
    {

        public static string VideoPlayer_GetCaptureFilePath(string mediaPrefix, string extension)
        {
            var date = DateTime.UtcNow;
            var dateString = $"{date.Year:0000}-{date.Month:00}-{date.Day:00} {date.Hour:00}-{date.Minute:00}-{date.Second:00}.{date.Millisecond:000}";
            var targetFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "ffmeplay");
            if (Directory.Exists(targetFolder) == false)
            { Directory.CreateDirectory(targetFolder); }
            var targetFilePath = Path.Combine(targetFolder, $"{mediaPrefix} {dateString}.{extension}");
            if (File.Exists(targetFilePath))
            { File.Delete(targetFilePath); }

            return targetFilePath;
        }

        public static void ShowFirstTimeSetup()
        {
            if (Functionality.Services.SettingsManager.FirstTimeSetupForUser)
            {
                Task.Run(() =>
                    //await Task.Delay(5000);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        var rpv = new FirstSetupWizardView();
                        var zxc = new UserControlHostWindowViewModel(rpv);
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
        }

        public static void CheckForUpdates()
        {
            try
            {
                AutoUpdater.Start("https://raw.githubusercontent.com/WolvenKit/WolvenKit/master/Update.xml");
            }
            catch (Exception)
            {

            }
        }

    }


}
