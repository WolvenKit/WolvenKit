using Catel.IoC;
using Catel.Logging;
using Catel.Reflection;
using Catel.Windows;
using Orchestra.Services;
using Orchestra.Views;
using System.Windows;
using WolvenKitUI.Views;
using Catel.MVVM;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using MWindowInterfacesLib.Interfaces;
using MLib.Interfaces;
using MLib;
using WolvenKit.App.ViewModels;

namespace WolvenKitUI
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

        protected override void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif

            Log.Info("Starting application");

            var serviceLocator = ServiceLocator.Default;
            //var workspaceinstance = new WorkSpaceViewModel();
            //serviceLocator.RegisterInstance(typeof(WorkSpaceViewModel), workspaceinstance);

            // Register Viewmodels
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            
            viewModelLocator.NamingConventions.Add("WolvenKit.App.ViewModels.[VW]ViewModel");

            viewModelLocator.Register(typeof(MainView), typeof(WorkSpaceViewModel));
            //viewModelLocator.Register(typeof(RibbonView), typeof(RibbonViewModel));


            
            



            
            var shellService = serviceLocator.ResolveType<IShellService>();
            shellService.CreateAsync<ShellWindow>();

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