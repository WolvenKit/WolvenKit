using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel;
using Catel.Services;
using Catel.Threading;
using Orc.ProjectManagement;
using WolvenKit.Common.DDS;


using WolvenKit.Functionality.Commands;
using WolvenKit.Model;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using static WolvenKit.CR2W.Types.Enums;
using static WolvenKit.Common.DDS.TexconvWrapper;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    public class PropertiesViewModel : ToolViewModel
    {

        #region constructors

        public PropertiesViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService
        ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;

            _projectManager.ProjectActivatedAsync += OnProjectActivatedAsync;
            _projectManager.ProjectRefreshedAsync += ProjectManagerOnProjectRefreshedAsync;


            SetupCommands();
            SetupToolDefaults();


        }

        #endregion

        #region Fields
        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Properties_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Properties";

        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;


        #endregion

        //void Importableobjects_ListChanged(object sender, ListChangedEventArgs e) => OnPropertyChanged(nameof(Importableobjects));

        #region Properties


        /// <summary>
        /// Bound to the View via TreeViewBehavior.cs
        /// </summary>
        public ChunkViewModel SelectedChunk { get; set; }


        #endregion

        #region Commands

        #endregion



        #region Methods

        private Task OnProjectActivatedAsync(object sender, ProjectUpdatedEventArgs args)
        {
            var activeProject = args.NewProject;
            if (activeProject == null)
                return TaskHelper.Completed;

            

            return TaskHelper.Completed;
        }

        private Task ProjectManagerOnProjectRefreshedAsync(object sender, ProjectEventArgs e)
        {
            return TaskHelper.Completed;
        }

        /// <summary>
        /// Initialize commands for this window.
        /// </summary>
        private void SetupCommands()
        {

        }

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;           // Define a unique contentid for this toolwindow

            //BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow
            //bi.BeginInit();
            //bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");
            //bi.EndInit();
            //IconSource = bi;
        }

        #endregion

    }
}
