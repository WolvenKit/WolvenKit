using Catel;
using Catel.MVVM;
using Catel.Services;
using Orc.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Services;
using WolvenKit.Model;

namespace WolvenKit.ViewModels.CsvEditor
{
    public class CsvEditorViewModel : ToolViewModel
    {

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "CsvEditor_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Csv Editor";
        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;


        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        public CsvEditorViewModel(
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
            //bi.UriSource = new Uri("pack://application:,,/Resources/Images/property-blue.png");
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
