using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Catel;
using HandyControl.Controls;
using Orc.Notifications;
using Orc.ProjectManagement;
using WolvenKit.Controllers;

namespace WolvenKit.Model.ProjectManagement
{
    public class ProjectReader : ProjectReaderBase
    {
        #region Fields
        private readonly INotificationService _notificationService;
        #endregion

        #region Constructors
        public ProjectReader(INotificationService notificationService)
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
                                // _notificationService.ShowNotification("Success", "Project " + Path.GetFileNameWithoutExtension(location) +
                                //   " loaded!");

                                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => { Growl.SuccessGlobal("Project " + Path.GetFileNameWithoutExtension(location) + " loaded!"); }));
                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                    case ".cpmodproj":
                    {
                        project = new Cp77Project(location);
                        MainController.Get().ActiveMod = project.Data;
                        await MainController.SetGame(new Cp77Controller()).ContinueWith(t =>
                            {
                               // _notificationService.ShowNotification("Success", "Project " + Path.GetFileNameWithoutExtension(location) + " loaded!");
                                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => { Growl.SuccessGlobal("Project " + Path.GetFileNameWithoutExtension(location) + " loaded!"); }));
                            }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    }
                }

                return await Task.FromResult<IProject>(project);

            }
            catch (IOException ex)
            {
               // _notificationService.ShowNotification("Could not open file", ex.Message);
                await Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => { Growl.ErrorGlobal("Could not open file : "+ ex.Message); }));

            }

            return null;

        }
        #endregion
    }
}
