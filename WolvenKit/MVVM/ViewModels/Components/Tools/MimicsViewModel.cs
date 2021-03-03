using System.Threading.Tasks;
using Catel;
using Catel.Services;
using Orc.ProjectManagement;
using WolvenKit.Common.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.MVVM.ViewModels.Shell.Editor;

namespace WolvenKit.MVVM.ViewModels.Components.Tools
{
    public class MimicsViewModel : ToolViewModel
    {
        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Mimics_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Mimics";

        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;

        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        public MimicsViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService,
           IMessageService messageService) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            SetupToolDefaults();
        }

        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;           // Define a unique contentid for this toolwindow

            //BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow
            //bi.BeginInit();
            //bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");
            //bi.EndInit();
            //IconSource = bi;
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: Write initialization code here and subscribe to events
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events

            return base.CloseAsync();
        }
    }
}
