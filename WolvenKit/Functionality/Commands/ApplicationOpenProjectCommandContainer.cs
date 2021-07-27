using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationOpenProjectCommandContainer : ProjectCommandContainerBase
    {
        #region Fields

        private readonly IOpenFileService _openFileService;
        private new readonly IPleaseWaitService _pleaseWaitService;
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly Cp77Controller _cp77Controller;
        private readonly Tw3Controller _tw3Controller;




        #endregion Fields

        #region Constructors

        public ApplicationOpenProjectCommandContainer(
            ICommandManager commandManager,
            IProjectManager projectManager,
            IOpenFileService openFileService,
            IPleaseWaitService pleaseWaitService,
            INotificationService notificationService,
            IRecentlyUsedItemsService recentlyUsedItemsService,
            ILoggerService loggerService,
            Tw3Controller tw3Controller,
            Cp77Controller cp77Controller
            )
            : base(AppCommands.Application.OpenProject, commandManager, projectManager, notificationService,
                loggerService)
        {
            Argument.IsNotNull(() => openFileService);
            Argument.IsNotNull(() => pleaseWaitService);
            Argument.IsNotNull(() => recentlyUsedItemsService);

            _pleaseWaitService = pleaseWaitService;
            _openFileService = openFileService;
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
                

                if (string.IsNullOrWhiteSpace(location) || !File.Exists(location))
                {
                    // file was moved or deleted
                    if (_recentlyUsedItemsService.Items.Items.Any(_ => _.Name == location))
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
                if (!File.Exists(location))
                {
                    return;
                }

                RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
                RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;

                // if a valid location has been set
                //using (_pleaseWaitService.PushInScope())
                {
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

                    //TODO:ORC
                    //if (StaticReferences.GlobalShell != null)
                    //{
                    //    StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.TitleProperty, Path.GetFileNameWithoutExtension(location));
                    //}

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
