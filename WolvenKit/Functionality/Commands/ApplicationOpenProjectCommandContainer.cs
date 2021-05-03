using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using Catel;
using Catel.MVVM;
using Catel.Services;
using Orc.FileSystem;
using WolvenKit.Functionality.Services;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationOpenProjectCommandContainer : ProjectCommandContainerBase
    {
        #region Fields

        private readonly IFileService _fileService;
        private readonly IOpenFileService _openFileService;
        private new readonly IPleaseWaitService _pleaseWaitService;

        #endregion Fields

        #region Constructors

        public ApplicationOpenProjectCommandContainer(
            ICommandManager commandManager,
            IFileService fileService,
            IProjectManager projectManager,
            IOpenFileService openFileService,
            IPleaseWaitService pleaseWaitService,
            IGrowlNotificationService notificationService,
            ILoggerService loggerService)
            : base(AppCommands.Application.OpenProject, commandManager, projectManager, notificationService, loggerService)
        {
            Argument.IsNotNull(() => openFileService);
            Argument.IsNotNull(() => fileService);
            Argument.IsNotNull(() => pleaseWaitService);

            _pleaseWaitService = pleaseWaitService;
            _openFileService = openFileService;
            _fileService = fileService;
        }

        #endregion Constructors

        #region Methods

        protected override bool CanExecute(object parameter) => true;

        protected override async Task ExecuteAsync(object parameter)
        {
            if (_projectManager.ActiveProject != null && parameter != null)
            {
                var a = _projectManager.ActiveProject;
                Debugger.Break();
            }

            try
            {
                RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
                RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;
                var location = parameter as string;

                if (string.IsNullOrWhiteSpace(location) || !_fileService.Exists(location))
                {
                    var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
                    {
                        Filter = "Cyberpunk 2077 Project | *.cpmodproj|Witcher 3 Project (*.w3modproj)|*.w3modproj",
                        IsMultiSelect = false,
                        Title = "Please select the WolvenKit project you would like to open."
                    });

                    if (result.Result)
                    {
                        location = result.FileName;
                    }
                }

                if (!string.IsNullOrWhiteSpace(location))
                {
                    using (_pleaseWaitService.PushInScope())
                    {
                        StaticReferences.MainView.OnLoadLayoutAsync();

                        await _projectManager.LoadAsync(location);
                        var btn = StaticReferences.GlobalShell.FindName("ProjectNameDisplay") as System.Windows.Controls.Button;
                        btn?.SetCurrentValue(ContentControl.ContentProperty, Path.GetFileNameWithoutExtension(location));




                        StaticReferencesVM.GlobalStatusBar.CurrentProject = Path.GetFileNameWithoutExtension(location);
                    }
                }

            }
            catch (Exception)
            {
                // TODO: Are we intentionally swallowing this?
                //Log.Error(ex, "Failed to open file");
            }
        }

        #endregion Methods
    }
}
