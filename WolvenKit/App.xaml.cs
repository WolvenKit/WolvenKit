using Catel.IoC;
using Catel.Logging;
using Catel.Reflection;
using Catel.Windows;
using Orc.Squirrel;
using Orchestra.Services;
using Orchestra.Views;
using System.Windows;
using WolvenKit.Views;
using Catel.MVVM;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using WolvenKit.ViewModels;
using WolvenKit.Views.Dialogs;

namespace WolvenKit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region fields
        #endregion fields

        #region constructors
        static App()
        {


        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public App()
        {

        }
        #endregion constructors



        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        protected override async void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif
            Log.Info("Starting application");

            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();


            var serviceLocator = ServiceLocator.Default;


            // Register Viewmodels
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels");

            //TODO: rename later to MainViewModel
            viewModelLocator.Register(typeof(Views.MainView), typeof(ViewModels.WorkSpaceViewModel));

            // local VMs
            viewModelLocator.Register(typeof(Views.OpenFileView), typeof(ViewModels.OpenFileViewModel));
            viewModelLocator.Register(typeof(Views.RecentlyUsedItemsView), typeof(ViewModels.RecentlyUsedItemsViewModel));

            viewModelLocator.Register(typeof(Views.HomePageView), typeof(ViewModels.HomePageViewModel));  // HomePage 



            var viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();
            viewLocator.Register(typeof(ViewModels.SettingsViewModel), typeof(Views.SettingsWindow));
            viewLocator.Register(typeof(ViewModels.InputDialogViewModel), typeof(Views.Dialogs.InputDialog));



            var shellService = serviceLocator.ResolveType<IShellService>();
            await shellService.CreateAsync<ShellWindow>();


            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, "Dark.Red");

            Log.Info("Calling base.OnStartup");

            base.OnStartup(e);
        }


        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}