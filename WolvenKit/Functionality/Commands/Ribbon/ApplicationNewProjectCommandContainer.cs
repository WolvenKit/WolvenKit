using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Others;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationNewProjectCommandContainer : ProjectCommandContainerBase
    {
        #region Fields

        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;
        private readonly IUIVisualizerService _uIVisualizerService;
        private readonly Cp77Controller _cp77Controller;
        private readonly Tw3Controller _tw3Controller;
        private readonly IServiceLocator _serviceLocator;

        #endregion Fields

        #region Constructors

        public ApplicationNewProjectCommandContainer(
            ICommandManager commandManager,
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            INotificationService notificationService,
            IUIVisualizerService uIVisualizerService,
            ILoggerService loggerService,
            IServiceLocator serviceLocator,
            Tw3Controller tw3Controller,
            Cp77Controller cp77Controller
        )
            : base(AppCommands.Application.NewProject, commandManager, projectManager, notificationService, loggerService)
        {
            _loggerService = loggerService;
            _saveFileService = saveFileService;
            _tw3Controller = tw3Controller;
            _cp77Controller = cp77Controller;
            _uIVisualizerService = uIVisualizerService;
            _serviceLocator = serviceLocator;
        }

        #endregion Constructors

        #region Methods

        protected override bool CanExecute(object parameter) => true;

        protected override async void Execute(object parameter)
        {
            try
            {
                var location = parameter as string;
                var viewModel = _serviceLocator.ResolveType<ProjectWizardViewModel>();

                var r = await _uIVisualizerService.ShowAsync(viewModel, (sender, args) =>
                {
                    if (args.DataContext is not ProjectWizardViewModel res)
                    {
                        return;
                    }

                    var result = args.Result;
                    if (!result.HasValue || !result.Value)
                    {
                        return;
                    }

                    location = Path.Combine(res.ProjectPath, res.ProjectName);
                    var type = res.ProjectType.First();
                    if (type.Equals(ProjectWizardViewModel.WitcherGameName))
                    {
                        location += ".w3modproj";
                    }
                    else if (type.Equals(ProjectWizardViewModel.CyberpunkGameName))
                    {
                        location += ".cpmodproj";
                    }


                });

                if (string.IsNullOrWhiteSpace(location))
                {
                    return;
                }

                RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
                RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;
                using (_pleaseWaitService.PushInScope())
                {
                    switch (Path.GetExtension(location))
                    {
                        case ".w3modproj":
                        {
                            var np = new Tw3Project(location)
                            {
                                Name = Path.GetFileNameWithoutExtension(location),
                                Author = "WolvenKit",
                                Email = "",
                                Version = "1.0"

                            };
                            _projectManager.ActiveProject = np;
                            await _projectManager.SaveAsync();
                            np.CreateDefaultDirectories();
                            //saveProjectImg(location);
                            break;
                        }
                        case ".cpmodproj":
                        {
                            var np = new Cp77Project(location)
                            {
                                Name = Path.GetFileNameWithoutExtension(location),
                                Author = "WolvenKit",
                                Email = "",
                                Version = "1.0"
                            };
                            _projectManager.ActiveProject = np;
                            await _projectManager.SaveAsync();
                            np.CreateDefaultDirectories();
                            //saveProjectImg(location);
                            break;
                        }
                        default:
                            _loggerService.LogString("Invalid project path!", Logtype.Error);
                            break;
                    }
                }

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
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to create a new project!", Logtype.Error);
            }
        }

        #endregion Methods
    }
}

