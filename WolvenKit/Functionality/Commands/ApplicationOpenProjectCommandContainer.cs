using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using Catel;
using Catel.MVVM;
using Catel.Services;
using Orc.FileSystem;
using Orc.ProjectManagement;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationOpenProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly IOpenFileService _openFileService;
        private readonly IFileService _fileService;
        private new readonly IPleaseWaitService _pleaseWaitService;

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
                        await _projectManager.LoadAsync(location);
                        var btn = (StaticReferences.GlobalShell.FindName("ProjectNameDisplay") as System.Windows.Controls.Button);
                        btn?.SetCurrentValue(ContentControl.ContentProperty, Path.GetFileNameWithoutExtension(location));
                        ;
                    }
                }

                StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.StartScreen.ShownProperty, false);
                StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
            }
            catch (Exception)
            {
                // TODO: Are we intentionally swallowing this?
                //Log.Error(ex, "Failed to open file");
            }
        }
    }
}
