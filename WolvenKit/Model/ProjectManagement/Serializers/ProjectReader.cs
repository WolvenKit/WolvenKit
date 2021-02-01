using System.IO;
using System.Threading.Tasks;
using Catel;
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
        protected override Task<IProject> ReadFromLocationAsync(string location)
        {
            try
            {
                var fi = new FileInfo(location);
                if (!fi.Exists)
                    return null;

                EditorProject project = null;
                switch (fi.Extension)
                {
                    case ".w3modproj":
                    {
                        project = new Tw3Project(location);
                        MainController.Get().ActiveMod = project.Data;
                        MainController.Get().SetGame(new Tw3Controller());
                        break;
                    }
                    case ".cpmodproj":
                    {
                        project = new Cp77Project(location);
                        MainController.Get().ActiveMod = project.Data;
                        MainController.Get().SetGame(new Cp77Controller());
                        break;
                    }
                }
                _notificationService.ShowNotification("Success", "Project " + Path.GetFileNameWithoutExtension(location) +
                                                                 " loaded!");
                return Task.FromResult<IProject>(project);

            } catch (IOException ex)
            {
                _notificationService.ShowNotification("Could not open file", ex.Message);
            }

            return null;

        }
        #endregion
    }
}