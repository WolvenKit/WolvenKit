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
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using Settings = Orc.Squirrel.Settings;

namespace WolvenKitUI
{
    public class ApplicationNewProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly INavigationService _navigationService;
        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;

        public ApplicationNewProjectCommandContainer(
            ICommandManager commandManager, 
            INavigationService navigationService, 
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            INotificationService notificationService,
            ILoggerService loggerService)
            : base(AppCommands.Application.NewProject, commandManager, projectManager, notificationService, loggerService)
        {
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => saveFileService);

            _navigationService = navigationService;
            _loggerService = loggerService;
            _saveFileService = saveFileService;
        }

        protected override bool CanExecute(object parameter) => true;

        protected override async void Execute(object parameter)
        {
            try
            {
                var location = parameter as string;

                var result = await _saveFileService.DetermineFileAsync(new DetermineSaveFileContext()
                {
                    Filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj| Cyberpunk 2077 Project (*.cpmodproj)|*.cpmodproj",
                    Title = "Please select a location to save your WolvenKit project"
                });

                if (result.Result)
                {
                    location = result.FileName;
                }

                if (!string.IsNullOrWhiteSpace(location))
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
                _loggerService.LogString("Failed to create a new project!", Logtype.Error);
            }
        }
    }
}