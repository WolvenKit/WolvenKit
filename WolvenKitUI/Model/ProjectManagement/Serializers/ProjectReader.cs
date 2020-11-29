using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel;
using Orc.Notifications;
using Orc.ProjectManagement;
using WolvenKit.App.Model;
using WolvenKit.Common;

namespace WolvenKitUI.Model
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

                Project project = null;
                switch (fi.Extension)
                {
                    case ".w3modproj":
                        // TODO: use the old class because orc.projects don't have parameterless constructors
                        var ser = new XmlSerializer(typeof(W3Mod));
                        await using (var modfile = new FileStream(location, FileMode.Open, FileAccess.Read))
                        {
                            var obj = (W3Mod)ser.Deserialize(modfile);
                            project = new Tw3Project(location)
                            {
                                Name = obj.Name,
                                Version = obj.Version,
                                Author = obj.Author,
                                Email = obj.Email
                            };
                        }
                        break;
                    case ".cpmodproj":
                        // TODO: for cp77 project, move to protobuf
                        project = new Cp77Project(location);
                        break;
                    default:
                        break;
                }


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