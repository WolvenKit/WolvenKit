using System;
using System.Threading.Tasks;
using System.Windows.Media;
using Catel;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
using Catel.Services;
using Orchestra.Services;
using ProtoBuf.Meta;
using WolvenKit.Functionality.Services;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Functionality.Services
{
    public class ApplicationInitializationService : ApplicationInitializationServiceBase
    {
        #region fields

        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        private readonly ICommandManager _commandManager;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IServiceLocator _serviceLocator;
        public override bool ShowShell => true;
        public override bool ShowSplashScreen => true;

        #endregion fields

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

        #endregion constructors

        #region events

        public override async Task InitializeAfterShowingShellAsync()
        {
            await base.InitializeAfterShowingShellAsync();

            LoadProject();
        }

        public override async Task InitializeBeforeCreatingShellAsync()
        {
            //protobuf
            RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));

            // Non-async first
            InitializeFonts();
            InitializeCommands();

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

        #endregion events

        #region methods

        private Task CheckForUpdatesAsync() =>
            //TODO: enable
            Task.CompletedTask;//            Log.Info("Checking for updates");//            var updateService = _serviceLocator.ResolveType<IUpdateService>();//            updateService.Initialize(Settings.Application.AutomaticUpdates.AvailableChannels, Settings.Application.AutomaticUpdates.DefaultChannel,//                Settings.Application.AutomaticUpdates.CheckForUpdatesDefaultValue);//#pragma warning disable 4014//            // Not dot await, it's a background thread//            updateService.InstallAvailableUpdatesAsync(new SquirrelContext());//#pragma warning restore 4014

        private void InitializeCommands()
        {
            // global commands
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Exit));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.About));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Settings), nameof(AppCommands.Settings.General));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Options));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.BugReport));

            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.NewProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.PublishProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenLink));

            // application-wide commands that viewmodels can subscribe to
            // Workspace Viewmodel
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.DelProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveAsProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveProject));

            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveFile));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveAll));


            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowAbout));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowFeedback));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowSettings));

            _commandManager.CreateCommand(AppCommands.Application.ShowLog);
            _commandManager.CreateCommand(AppCommands.Application.ShowProjectExplorer);
            _commandManager.CreateCommand(AppCommands.Application.ShowImportUtility);
            _commandManager.CreateCommand(AppCommands.Application.ShowProperties);
            _commandManager.CreateCommand(AppCommands.Application.ShowPackageInstaller);
            _commandManager.CreateCommand(AppCommands.Application.ShowMimicsTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowCR2WEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowImportExportTool);

            _commandManager.CreateCommand(AppCommands.Application.ShowAssetBrowser);
            _commandManager.CreateCommand(AppCommands.Application.ShowBulkEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowCsvEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowHexEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowJournalEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowVisualEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowAnimationTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowAudioTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowVideoTool);

            _commandManager.CreateCommand(AppCommands.Application.ShowCodeEditor);

            _commandManager.CreateCommand(AppCommands.Application.ShowImporterTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowCR2WToTextTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowGameDebuggerTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowMenuCreatorTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowPluginManager);
            //_commandManager.CreateCommand(AppCommands.Application.ShowRadishTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowWccTool);

            _commandManager.CreateCommand(AppCommands.Application.OpenFile);
            _commandManager.CreateCommand(AppCommands.Application.NewFile);
            _commandManager.CreateCommand(AppCommands.Application.PackMod);
            _commandManager.CreateCommand(AppCommands.Application.BackupMod);
            _commandManager.CreateCommand(AppCommands.Application.PublishMod);

            _commandManager.CreateCommand(AppCommands.ProjectExplorer.Refresh);
            _commandManager.CreateCommand(AppCommands.Application.FileSelected);

            _commandManager.CreateCommand(AppCommands.Application.ViewSelected);
        }

        private void InitializeFonts()
        {
            // Orc.Theming.FontImage.RegisterFont("FontAwesome", new FontFamily(new Uri("pack://application:,,,/WolvenKit;component/Resources/Fonts/", UriKind.RelativeOrAbsolute), "./#FontAwesome"));
            Orc.Theming.FontImage.DefaultFontFamily = "Segoe UI";
            Orc.Theming.FontImage.DefaultBrush = new SolidColorBrush(Color.FromArgb(255, 87, 87, 87));
        }

        private Task InitializePerformanceAsync()
        {
            Log.Info("Improving performance");

            Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;

            return Task.CompletedTask;
        }

        private void LoadProject()
        {
            using (_pleaseWaitService.PushInScope())
            {
                var projectManager = _serviceLocator.ResolveType<IProjectManager>();
                if (projectManager == null)
                {
                    const string error = "Failed to resolve project manager.";
                    Log.Error(error);
                    throw new Exception(error);
                }
            }
        }

        #endregion methods
    }
}
