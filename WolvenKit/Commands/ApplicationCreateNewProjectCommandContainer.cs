using System;
using System.IO;
using System.Text;
using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Orc.Notifications;
using Orc.ProjectManagement;
using Settings = Orc.Squirrel.Settings;

namespace WolvenKit
{
    using Model;
    using Common;
    using Common.Model;
    using Common.Services;
    using WolvenKit.Model.Wizards;

    public class ApplicationCreateNewProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;

        public ApplicationCreateNewProjectCommandContainer(
            ICommandManager commandManager,
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            INotificationService notificationService,
            ILoggerService loggerService)
            : base(AppCommands.Application.CreateNewProject, commandManager, projectManager, notificationService, loggerService)
        {
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => saveFileService);

            _loggerService = loggerService;
            _saveFileService = saveFileService;
        }

        protected override bool CanExecute(object parameter) => true;

        protected override async void Execute(object parameter)
        {
            try
            {
                var location = parameter as string;
                var filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj| Cyberpunk 2077 Project (*.cpmodproj)|*.cpmodproj";
                if (location == null && parameter is ProjectWizardModel.TypeAndPath)
                {
                    var res = parameter as ProjectWizardModel.TypeAndPath;
                    location = res.Path;
                    if (res.Type == ProjectWizardModel.WitcherGameName)
                        filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj";
                    else if (res.Type == ProjectWizardModel.CyberpunkGameName)
                        filter = "Cyberpunk 2077 Project (*.cpmodproj)|*.cpmodproj";
                }

                var result = await _saveFileService.DetermineFileAsync(new DetermineSaveFileContext()
                {
                    Filter = filter,
                    Title = "Please select a location to save your WolvenKit project",
                    InitialDirectory = location,
                });

                if (result.Result)
                {
                    location = result.FileName;
                }

                if (!string.IsNullOrWhiteSpace(location) && result.Result)
                {
                    using (_pleaseWaitService.PushInScope())
                    {
                        switch (Path.GetExtension(location))
                        {
                            case ".w3modproj":
                                {
                                    var np = new Tw3Project(location)
                                    {
                                        Name = Path.GetFileNameWithoutExtension(location),
                                        Data = new W3Mod()
                                        {
                                            FileName = location,
                                            Name = Path.GetFileNameWithoutExtension(location),
                                            Author = "WolvenKit",
                                            Email = "",
                                            Version = "1.0"
                                        }
                                    };
                                    np.Save(location);
                                    np.CreateDefaultDirectories();
                                    break;
                                }
                            case ".cpmodproj":
                                {
                                    var np = new Cp77Project(location)
                                    {
                                        Name = Path.GetFileNameWithoutExtension(location),
                                        Data = new CP77Mod()
                                        {
                                            FileName = location,
                                            Name = Path.GetFileNameWithoutExtension(location),
                                            Author = "WolvenKit",
                                            Email = "",
                                            Version = "1.0"
                                        }
                                    };
                                    np.Save(location);
                                    np.CreateDefaultDirectories();
                                    break;
                                }
                            default:
                                _loggerService.LogString("Invalid project path!", Logtype.Error);
                                break;

                        }
                    }
                    await _projectManager.LoadAsync(location);
                }
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to create a new project!", Logtype.Error);
            }
            OnCommandCompleted?.Invoke();
        }

        public event Action OnCommandCompleted;
    }
}