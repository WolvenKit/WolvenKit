using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Catel.IoC;
using Catel.MVVM;
using HandyControl.Tools;
using Orc.Squirrel;
using Orchestra.Services;
using Orchestra.Views;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Others;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Others;
using WolvenKit.Views.Others.PropertyGridEditors;
using WolvenKit.Views.Shell;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class AppHelper
    {
        #region Methods

        public static async Task InitializeMVVM()
        {
            PropertyGridResolver.Initialize();

            ApplicationHelper.StartProfileOptimization();

            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Media/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();

            // Register Viewmodels & Views
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            var viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();

            viewLocator.NamingConventions.Add("WolvenKit.Views.HomePage.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.HomePage.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.HomePage.Pages.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.HomePage.Pages.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.AudioTool.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.AudioTool.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.AudioTool.Radio.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.AudioTool.Radio.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.VisualEditor.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.VisualEditor.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Dialogs.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Dialogs.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Others.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Others.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Shared.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Shared.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Shell.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Shell.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.BugReportWizard.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.BugReportWizard.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.FeedbackWizard.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.FeedbackWizard.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.FirstSetupWizard.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.ProjectWizard.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.ProjectWizard.[VW]ViewModel");

            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.ProjectWizard.[VM]TypeView");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.ProjectWizard.[VW]TypeViewModel");

            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.PublishWizard.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.PublishWizard.[VW]ViewModel");

            viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.UserWizard.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.UserWizard.[VW]ViewModel");


            viewLocator.NamingConventions.Add("WolvenKit.Views.Others.PropertyGridEditors.[VM]View");
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Others.PropertyGridEditors.[VW]ViewModel");


            // Fixes
            // Custom Registrations

            viewModelLocator.Register(typeof(MainView), typeof(WorkSpaceViewModel));
            viewModelLocator.Register(typeof(RecentProjectView), typeof(RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(WelcomePageView), typeof(RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.ProjectWizard.FinalizeSetupViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.PublishWizard.FinalizeSetupViewModel));
        }

        public static async Task InitializeShell()
        {
            await ShellInnerInit();
            ThemeInnerInit();
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

        private static async Task ShellInnerInit()
        {
            HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
            var shellService = ServiceLocator.Default.ResolveType<IShellService>();

            await shellService.CreateAsync<ShellWindow>();
            var sh = (ShellWindow)shellService.Shell;
            StaticReferences.GlobalShell = sh;
            sh.MinWidth = 1;
            sh.MinHeight = 1;
            sh.Height = 830;
            sh.Width = 1540;
            sh.WindowState = WindowState.Normal;
            sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Binding ws = new Binding();
            ws.Source = HomePageViewModel.GlobalHomePageVM;
            ws.Path = new PropertyPath("CurrentWindowState");
            ws.Mode = BindingMode.TwoWay;
            ws.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(sh, ShellWindow.WindowStateProperty, ws);
            sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            StaticReferences.GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
            StaticReferences.GlobalShell.SetCurrentValue(Window.TitleProperty, "");
        }

        private static void ThemeInnerInit()
        {
            var SettingsManag = ServiceLocator.Default.ResolveType<ISettingsManager>();
            if (SettingsManag.ThemeAccent != default)
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", SettingsManag.ThemeAccent, false));
            }
            else
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", (Color)ColorConverter.ConvertFromString("#DF2935"), false));
            }
        }

        #endregion Methods
    }

    public class ValueConverterGroup : List<IValueConverter>, IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return this.Aggregate(value, (current, converter) => converter.Convert(current, targetType, parameter, culture));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion IValueConverter Members
    }
}
