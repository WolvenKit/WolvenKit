using System;
using System.IO;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using Orc.ProjectManagement;
using Orchestra.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.MVVM.Model.Wizards;
using WolvenKit.MVVM.ViewModels.Components.Wizards;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationCreateNewProjectCommandContainer : ProjectCommandContainerBase
    {
        #region Fields

        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;

        #endregion Fields

        #region Constructors

        public ApplicationCreateNewProjectCommandContainer(
            ICommandManager commandManager,
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            IGrowlNotificationService notificationService,
            ILoggerService loggerService)
            : base(AppCommands.Application.CreateNewProject, commandManager, projectManager, notificationService, loggerService)
        {
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => saveFileService);

            _loggerService = loggerService;
            _saveFileService = saveFileService;
        }

        #endregion Constructors

        #region Events

        public event Action OnCommandCompleted;

        #endregion Events

        #region Methods

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
                    location = Path.Combine(res.Path, res.Name);
                    if (res.Type == ProjectWizardModel.WitcherGameName)
                    {
                        filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj";
                        location = location + ".w3modproj";
                    }
                    else if (res.Type == ProjectWizardModel.CyberpunkGameName)
                    {
                        filter = "Cyberpunk 2077 Project (*.cpmodproj)|*.cpmodproj";
                        location = location + ".cpmodproj";
                    }
                }
                else
                {
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
                                saveProjectImg(location);
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
                                saveProjectImg(location);
                                break;
                            }
                            default:
                                _loggerService.LogString("Invalid project path!", Logtype.Error);
                                break;
                        }
                    }
                    await _projectManager.LoadAsync(location);
                    StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.StartScreen.ShownProperty, false);
                    StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
                    StaticReferences.MainView.OnLoadLayoutAsync();

                }
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to create a new project!", Logtype.Error);
            }

            OnCommandCompleted?.Invoke();
        }

        private void saveProjectImg(string ProjectPath)
        {
            var imagePath = Path.Combine(Path.GetDirectoryName(ProjectPath), Path.GetFileNameWithoutExtension(ProjectPath));
            var _pwvm = ServiceLocator.Default.ResolveType<ProjectWizardViewModel>();
            var src = (System.Windows.Media.Imaging.BitmapSource)_pwvm?.ProfileImageBrush?.ImageSource;
            if (src != null)
            {
                using var fs1 = new FileStream(Path.Combine(imagePath, "img.png"), FileMode.OpenOrCreate);
                var frame = System.Windows.Media.Imaging.BitmapFrame.Create(src);
                var enc = new System.Windows.Media.Imaging.PngBitmapEncoder();
                enc.Frames.Add(frame);
                enc.Save(fs1);
            }
        }

        #endregion Methods
    }
}
