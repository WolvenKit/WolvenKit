using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Catel;
using HandyControl.Controls;
using Orc.ProjectManagement;
using Orchestra.Services;
using WolvenKit.Controllers;
using WolvenKit.Services;

namespace WolvenKit.Model.ProjectManagement
{
    public class ProjectReader : ProjectReaderBase
    {
        #region Fields
        private readonly IGrowlNotificationService _notificationService;
        #endregion

        #region Constructors
        public ProjectReader(IGrowlNotificationService notificationService)
        {
            Argument.IsNotNull(() => notificationService);

            _notificationService = notificationService;
        }
        #endregion

        #region Methods
        protected override async Task<IProject> ReadFromLocationAsync(string location)
        {
            try
            {
                var fi = new FileInfo(location);
                if (!fi.Exists)
                {
                    return null;
                }

                EditorProject project = null;
                switch (fi.Extension)
                {
                    case ".w3modproj":
                    {
                        project = new Tw3Project(location);
                        MainController.Get().ActiveMod = project.Data;
                        await MainController.SetGame(new Tw3Controller()).ContinueWith(t =>
                            {
                                 _notificationService.Success( "Project " + Path.GetFileNameWithoutExtension(location) +
                                   " loaded!");

                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                    case ".cpmodproj":
                    {
                        project = new Cp77Project(location);
                        MainController.Get().ActiveMod = project.Data;
                        await MainController.SetGame(new Cp77Controller()).ContinueWith(t =>
                            {
                                _notificationService.Success( "Project " + Path.GetFileNameWithoutExtension(location) + " loaded!");
                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                }

                return await Task.FromResult<IProject>(project);

            }
            catch (IOException ex)
            {
                _notificationService.Error(ex.Message);
            }

            return null;

        }
        #endregion
    }
}
