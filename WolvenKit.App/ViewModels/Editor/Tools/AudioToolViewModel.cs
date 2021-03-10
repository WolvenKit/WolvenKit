using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;
using Catel;
using Catel.Services;
using Orc.ProjectManagement;
using WolvenKit.Common.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Editor
{
    public class AudioToolViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "AudioTool_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Audio Tool";

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;

        public List<TextBlock> AudioFileList { get; set; } = new List<TextBlock>();


        #endregion Fields

        #region Constructors

        public AudioToolViewModel(
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

        #endregion Constructors

        #region Properties

        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        #endregion Properties

        #region Methods

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: Write initialization code here and subscribe to events

        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods
    }
}
