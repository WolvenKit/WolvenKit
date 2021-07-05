using System;
using System.IO;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.Services;
using Orchestra.Services;
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
                //var filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj| Cyberpunk 2077 Project (*.cpmodproj)|*.cpmodproj";
                //if (location == null && parameter is ProjectWizardModel.TypeAndPath res)
                //{
                //    location = Path.Combine(res.Path, res.Name);
                //    if (res.Type == ProjectWizardModel.WitcherGameName)
                //    {
                //        filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj";
                //        location += ".w3modproj";
                //    }
                //    else if (res.Type == ProjectWizardModel.CyberpunkGameName)
                //    {
                //        filter = "Cyberpunk 2077 Project (*.cpmodproj)|*.cpmodproj";
                //        location += ".cpmodproj";
                //    }
                //}
                //else
                {

                    var viewModel = new UserControlHostWindowViewModel(_serviceLocator.ResolveType<ProjectWizardViewModel>());
                    //var viewModel = _serviceLocator.ResolveType<ProjectWizardViewModel>();

                    var r = await _uIVisualizerService.ShowAsync(viewModel, (sender, args) =>
                    {
                        if (args.DataContext is ProjectWizardViewModel res)
                        {
                            var result = args.Result;
                            if (result.HasValue && result.Value)
                            {
                                location = Path.Combine(res.ProjectPath, res.ProjectName);
                                if (res.Type == ProjectWizardModel.WitcherGameName)
                                {
                                    location += ".w3modproj";
                                }
                                else if (res.Type == ProjectWizardModel.CyberpunkGameName)
                                {
                                    location += ".cpmodproj";
                                }
                            }
                        }

                        
                    });

                    
                    else
                    {
                        
                    }
                }

                if (!string.IsNullOrWhiteSpace(location))
                {
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

