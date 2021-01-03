using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel;
using Catel.Logging;
using Orc.Notifications;
using Orc.ProjectManagement;
using WolvenKit.Model;
using WolvenKit.Common;

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
                    return null;

                EditorProject project = null;
                switch (fi.Extension)
                {
                    case ".w3modproj":
                    {
                        project = new Tw3Project(location);
                        break;
                    }
                    case ".cpmodproj":
                    {
                        project = new Cp77Project(location);
                        break;
                    }
                }

                _notificationService.ShowNotification("Success", "Project " + Path.GetFileNameWithoutExtension(location) +
                                                      " loaded!");
                return project;

            } catch (System.IO.IOException ex)
            {
                _notificationService.ShowNotification("Could not open file", ex.Message);
            }

            return null;

        }
        #endregion
    }
}