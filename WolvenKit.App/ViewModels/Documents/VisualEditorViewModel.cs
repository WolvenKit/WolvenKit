using WolvenKit.App.Functionality.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Documents
{
    public class VisualEditorViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "VisualEditor_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Visual Editor";

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;

        #endregion Fields

        #region Constructors

        public VisualEditorViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            SetupToolDefaults();
        }

        #endregion Constructors

        #region Properties

        private EditorProject ActiveMod => _projectManager.ActiveProject;

        #endregion Properties

        #region Methods

        // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();
        // Define an icon for this toolwindow
        //bi.BeginInit();
        //bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");
        //bi.EndInit();
        //IconSource = bi;
        private void SetupToolDefaults() => ContentId = ToolContentId;

        #endregion Methods
    }
}
