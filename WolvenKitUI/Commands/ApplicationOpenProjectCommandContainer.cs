using System;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;
using Catel.Logging;
using Orc.FileSystem;
using Orc.ProjectManagement;
using WolvenKit.App;
using WolvenKit.Common.Services;
using Orc.Notifications;

namespace WolvenKitUI
{
    public class ApplicationOpenProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly IOpenFileService _openFileService;
        private readonly IFileService _fileService;
        private readonly IPleaseWaitService _pleaseWaitService;

        public ApplicationOpenProjectCommandContainer(
            ICommandManager commandManager,
            IFileService fileService,
            IProjectManager projectManager,
            IOpenFileService openFileService,
            IPleaseWaitService pleaseWaitService,
            INotificationService notificationService,
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

        protected override bool CanExecute(object parameter) => true;

        protected override async Task ExecuteAsync(object parameter)
        {
            try
            {
                var location = parameter as string;

                if (string.IsNullOrWhiteSpace(location) || !_fileService.Exists(location))
                {
                    var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
                    {
                        Filter = "Witcher 3 Project (*.w3modproj)|*.w3modproj| Cyberpunk 2077 Project | *.cpmodproj",
                        IsMultiSelect = false,
                        Title = "Please select the Wolvenkit project you would like to open"
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
                        await _projectManager.LoadAsync(location);
                    }
                }
            }
            catch (Exception ex)
            {
                //Log.Error(ex, "Failed to open file");
            }
        }
    }
}