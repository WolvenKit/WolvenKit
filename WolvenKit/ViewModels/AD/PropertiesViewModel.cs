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

namespace WolvenKit.ViewModels
{


    using Commands;
    using Model;
    using Common;
    using Common.Extensions;
    using Common.Tools.FNV1A;
    using Common.Model;
    using Common.Services;
    using Common.Tools;
    using Common.Tools.DDS;
    using Common.Wcc;
    using CR2W;
    using CR2W.Types;
    using static CR2W.Types.Enums;
    using static Common.Tools.DDS.TexconvWrapper;

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
            //bi.UriSource = new Uri("pack://application:,,/Resources/Images/property-blue.png");
            //bi.EndInit();
            //IconSource = bi;
        }

        #endregion

    }
}
