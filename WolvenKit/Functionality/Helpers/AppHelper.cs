using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using AutoUpdaterDotNET;
using Catel.IoC;
using Orchestra.Services;
using Orchestra.Views;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
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

        private static async Task ShellInnerInit()
        {
            HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
            var shellService = ServiceLocator.Default.ResolveType<IShellService>();

            await shellService.CreateAsync<ShellWindow>();
            var sh = (ShellWindow)shellService.Shell;
            StaticReferences.GlobalShell = sh;
            sh.MinWidth = 1;
            sh.MinHeight = 1;
         
            sh.WindowState = WindowState.Maximized;
            sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Binding ws = new Binding();
            ws.Source = HomePageViewModel.GlobalHomePageVM;
            ws.Path = new PropertyPath("CurrentWindowState");
            ws.Mode = BindingMode.TwoWay;
            ws.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(sh, ShellWindow.WindowStateProperty, ws);
            sh.Closed += Sh_Closed;

            StaticReferences.GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
            StaticReferences.GlobalShell.SetCurrentValue(Window.TitleProperty, "");
        }

        private static void Sh_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private static void ThemeInnerInit()
        {
            var SettingsManag = ServiceLocator.Default.ResolveType<ISettingsManager>();
            if (SettingsManag.ThemeAccent != default)
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current,
                    ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark",
                        SettingsManag.ThemeAccent, false));
            }
            else
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current,
                    ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark",
                        (Color)ColorConverter.ConvertFromString("#DF2935"), false));
            }
        }
    }


}
