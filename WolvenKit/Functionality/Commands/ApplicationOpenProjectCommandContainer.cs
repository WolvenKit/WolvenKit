using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using Catel;
using Catel.MVVM;
using Catel.Services;
using Orc.FileSystem;
using WolvenKit.Functionality.Services;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Functionality.ProjectManagement;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationOpenProjectCommandContainer : ProjectCommandContainerBase
    {
        #region Fields

        private readonly IFileService _fileService;
        private readonly IOpenFileService _openFileService;
        private new readonly IPleaseWaitService _pleaseWaitService;
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly Cp77Controller _cp77Controller;
        private readonly Tw3Controller _tw3Controller;

        
        

        #endregion Fields

        #region Constructors

        public ApplicationOpenProjectCommandContainer(
            ICommandManager commandManager,
            IFileService fileService,
            IProjectManager projectManager,
            IOpenFileService openFileService,
            IPleaseWaitService pleaseWaitService,
            IGrowlNotificationService notificationService,
            IRecentlyUsedItemsService recentlyUsedItemsService,
            ILoggerService loggerService,
            Tw3Controller tw3Controller,
            Cp77Controller cp77Controller
            )
            : base(AppCommands.Application.OpenProject, commandManager, projectManager, notificationService,
                loggerService)
        {
            Argument.IsNotNull(() => openFileService);
            Argument.IsNotNull(() => fileService);
            Argument.IsNotNull(() => pleaseWaitService);
            Argument.IsNotNull(() => recentlyUsedItemsService);

            _pleaseWaitService = pleaseWaitService;
            _openFileService = openFileService;
            _fileService = fileService;
            _recentlyUsedItemsService = recentlyUsedItemsService;
            _tw3Controller = tw3Controller;
            _cp77Controller = cp77Controller;
        }

        #endregion Constructors

        #region Methods

        protected override bool CanExecute(object parameter) => true;

        protected override async Task ExecuteAsync(object parameter)
        {
            var location = parameter as string;
            // switch from one active project to another
            
            if (_projectManager.ActiveProject != null && !string.IsNullOrEmpty(location))
            {
                if (_projectManager.ActiveProject.Location == location)
                {
                    return;
                }
            }

            try
            {
                RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
                RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;
                
                if (string.IsNullOrWhiteSpace(location) || !_fileService.Exists(location))
                {
                    // file was moved or deleted
                    if (_recentlyUsedItemsService.Items.Any(_ => _.Name == location))
                    {
                        // would you like to locate it?
                        location = await ProjectHelpers.LocateMissingProjectAsync(location);
                        if (string.IsNullOrEmpty(location))
                        {
                            // user canceled locating a project
                            return;
                        }
                    }
                    // open an existing project
                    else
                    {
                        var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
                        {
                            Filter = "Cyberpunk 2077 Project | *.cpmodproj|Witcher 3 Project (*.w3modproj)|*.w3modproj",
                            IsMultiSelect = false,
                            Title = "Please select the WolvenKit project you would like to open."
                        });

                        if (!result.Result)
                        {
                            // user canceled locating a project
                            return;
                        }

                        location = result.FileName;
                    }
                }

                // one last check
                if (!_fileService.Exists(location))
                {
                    return;
                }

                // if a valid location has been set
                //using (_pleaseWaitService.PushInScope())
                {
                    StaticReferences.MainView.OnLoadLayoutAsync();
                    await _projectManager.LoadAsync(location);
                    switch (Path.GetExtension(location))
                    {
                        case ".w3modproj":
                            await _tw3Controller.HandleStartup().ContinueWith(t =>
                            {
                                _notificationService.Success(
                                    "Project " + Path.GetFileNameWithoutExtension(location) +
                                    " loaded!");

                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                            break;
                        case ".cpmodproj":
                            await _cp77Controller.HandleStartup().ContinueWith(
                                t =>
                                {
                                    _notificationService.Success("Project " +
                                                                 Path.GetFileNameWithoutExtension(location) +
                                                                 " loaded!");

                                },
                                TaskContinuationOptions.OnlyOnRanToCompletion);
                            break;
                        default:
                            break;
                    }

                    var btn = StaticReferences.GlobalShell.FindName("ProjectNameDisplay") as System.Windows.Controls.Button;
                    btn?.SetCurrentValue(ContentControl.ContentProperty, Path.GetFileNameWithoutExtension(location));

                    StaticReferencesVM.GlobalStatusBar.CurrentProject = Path.GetFileNameWithoutExtension(location);
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
