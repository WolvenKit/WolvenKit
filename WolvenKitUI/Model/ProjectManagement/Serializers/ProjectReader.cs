using System.Threading.Tasks;
using Catel;
using Orc.Notifications;
using Orc.ProjectManagement;

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
                var project = new Project(location);
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