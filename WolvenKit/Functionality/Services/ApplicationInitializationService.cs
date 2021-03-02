using Catel;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
using Orchestra.Services;
using System;
using System.IO;
using System.Threading.Tasks;
using Catel.Services;
using Orc.ProjectManagement;
using WolvenKit.Common.Services;
using WolvenKit.Model.ProjectManagement;
using System.Windows.Media;
using WolvenKit.Commands;

namespace WolvenKit.Functionality.Services
{
    public class ApplicationInitializationService : ApplicationInitializationServiceBase
    {
        #region fields

        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        private readonly IServiceLocator _serviceLocator;
        private readonly ICommandManager _commandManager;
        private readonly IPleaseWaitService _pleaseWaitService;

        public override bool ShowSplashScreen => true;
        public override bool ShowShell => true;

        #endregion

        #region constructors

        public ApplicationInitializationService(IServiceLocator serviceLocator, ICommandManager commandManager,
            IPleaseWaitService pleaseWaitService)
        {
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => pleaseWaitService);

            _serviceLocator = serviceLocator;
            _commandManager = commandManager;
            _pleaseWaitService = pleaseWaitService;
        }

        #endregion

        #region events

        public override async Task InitializeBeforeCreatingShellAsync()
        {
            // Non-async first
            RegisterTypes();
            InitializeFonts();
            InitializeCommands();
            InitializeWatchers();

            // async
            await RunAndWaitAsync(new Func<Task>[]
            {
                InitializePerformanceAsync,
                CheckForUpdatesAsync
            });
        }

        // TODO: update main window title?
        /*public override Task InitializeAfterCreatingShellAsync()
        {
        }*/

        public override async Task InitializeAfterShowingShellAsync()
        {
            await base.InitializeAfterShowingShellAsync();

            await LoadProjectAsync();

        }

        #endregion

        #region methods
        private Task InitializePerformanceAsync()
        {
            Log.Info("Improving performance");

            Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;
            
            return Task.CompletedTask;
        }

        private void InitializeFonts()
        {
            Orc.Theming.FontImage.RegisterFont("FontAwesome", new FontFamily(new Uri("pack://application:,,,/WolvenKit;component/Resources/Fonts/", UriKind.RelativeOrAbsolute), "./#FontAwesome"));
            Orc.Theming.FontImage.DefaultFontFamily = "FontAwesome";
            Orc.Theming.FontImage.DefaultBrush = new SolidColorBrush(Color.FromArgb(255, 87, 87, 87));
        }

        private void InitializeCommands()
        {
            // global commands
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Exit));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.About));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Settings), nameof(AppCommands.Settings.General));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Options));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.BugReport));

            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.NewProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.CreateNewProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenLink));


            // application-wide commands that viewmodels can subscribe to
            // Workspace Viewmodel
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.DelProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveAsProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveProject));


            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowAbout));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowFeedback));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowSettings));




            _commandManager.CreateCommand((AppCommands.Application.ShowLog));
            _commandManager.CreateCommand((AppCommands.Application.ShowProjectExplorer));
            _commandManager.CreateCommand((AppCommands.Application.ShowImportUtility));
            _commandManager.CreateCommand((AppCommands.Application.ShowProperties));
            _commandManager.CreateCommand((AppCommands.Application.ShowPackageInstaller));
            _commandManager.CreateCommand((AppCommands.Application.ShowMimicsTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowCR2WEditor));

            _commandManager.CreateCommand((AppCommands.Application.ShowAssetBrowser));
            _commandManager.CreateCommand((AppCommands.Application.ShowBulkEditor));
            _commandManager.CreateCommand((AppCommands.Application.ShowCsvEditor));
            _commandManager.CreateCommand((AppCommands.Application.ShowHexEditor));
            _commandManager.CreateCommand((AppCommands.Application.ShowJournalEditor));
            _commandManager.CreateCommand((AppCommands.Application.ShowVisualEditor));
            _commandManager.CreateCommand((AppCommands.Application.ShowAnimationTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowAudioTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowImporterTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowCR2WToTextTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowGameDebuggerTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowMenuCreatorTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowPluginManager));
            _commandManager.CreateCommand((AppCommands.Application.ShowRadishTool));
            _commandManager.CreateCommand((AppCommands.Application.ShowWccTool));


            _commandManager.CreateCommand((AppCommands.Application.OpenFile));
            _commandManager.CreateCommand((AppCommands.Application.NewFile));
            _commandManager.CreateCommand((AppCommands.Application.PackMod));
            _commandManager.CreateCommand((AppCommands.Application.BackupMod));
            _commandManager.CreateCommand((AppCommands.Application.PublishMod));

            // Project Explorer Viewmodel
            _commandManager.CreateCommand(AppCommands.ProjectExplorer.ExpandAll);
            _commandManager.CreateCommand(AppCommands.ProjectExplorer.Expand);
            _commandManager.CreateCommand(AppCommands.ProjectExplorer.CollapseAll);
            _commandManager.CreateCommand(AppCommands.ProjectExplorer.Collapse);
            _commandManager.CreateCommand(AppCommands.ProjectExplorer.Refresh);


            _commandManager.CreateCommand(AppCommands.Application.ViewSelected);

        }

        private void RegisterTypes()
        {
            // project management
            _serviceLocator.RegisterType<IGrowlNotificationService, GrowlNotificationService>();


            _serviceLocator.RegisterType<IProjectSerializerSelector, ProjectSerializerSelector>();  //TODO: not needed?
            _serviceLocator.RegisterType<ISaveProjectChangesService, SaveProjectChangesService>();
            _serviceLocator.RegisterType<IInitialProjectLocationService, Model.ProjectManagement.InitialProjectLocationService>();
            _serviceLocator.RegisterType<IProjectInitializer, FileProjectInitializer>();
            _serviceLocator.RegisterType<IProjectRefresherSelector, MyProjectRefresherSelector>();
            _serviceLocator.RegisterType<IProjectRefresher, WolvenKitProjectRefresher>(RegistrationType.Transient);

            //_serviceLocator.RegisterType<IMainWindowTitleService, MainWindowTitleService>();      //TODO: 
            //_serviceLocator.RegisterType<IProjectValidator, WkitProjectValidator>();

            _serviceLocator.RegisterTypeAndInstantiate<ProjectManagementCloseApplicationWatcher>();


            // Orchestra
            _serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();


            // Wkit
            _serviceLocator.RegisterType<ILoggerService, LoggerService>();

            var config = SettingsManager.Load();
            _serviceLocator.RegisterInstance(typeof(ISettingsManager), config);
        }

        private void InitializeWatchers()
        {
            _serviceLocator.RegisterTypeAndInstantiate<RecentlyUsedItemsProjectWatcher>();
        }

        private Task CheckForUpdatesAsync()
        {
            //TODO: enable
            return Task.CompletedTask;
//            Log.Info("Checking for updates");

//            var updateService = _serviceLocator.ResolveType<IUpdateService>();
//            updateService.Initialize(Settings.Application.AutomaticUpdates.AvailableChannels, Settings.Application.AutomaticUpdates.DefaultChannel,
//                Settings.Application.AutomaticUpdates.CheckForUpdatesDefaultValue);

//#pragma warning disable 4014
//            // Not dot await, it's a background thread
//            updateService.InstallAvailableUpdatesAsync(new SquirrelContext());
//#pragma warning restore 4014
        }

        private async Task LoadProjectAsync()
        {
            using (_pleaseWaitService.PushInScope())
            {
                var projectManager = _serviceLocator.ResolveType<IProjectManager>();
                if (projectManager == null)
                {
                    const string error = "Failed to resolve project manager";
                    Log.Error(error);
                    throw new Exception(error);
                }

                await projectManager.InitializeAsync();
            }
        }
        #endregion

    }
}
