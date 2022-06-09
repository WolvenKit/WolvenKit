using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using ReactiveUI;
using Splat;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Tools
{
    public class TweakBrowserViewModel : ToolViewModel
    {
        #region fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "TweakBrowser_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Tweak Browser";

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;
        private readonly IModTools _modTools;
        private readonly IProgressService<double> _progressService;
        private readonly IGameControllerFactory _gameController;
        private readonly TweakDBService _tweakDB;

        private EditorProject ActiveMod => _projectManager.ActiveProject;

        public string Extension { get; set; } = "tweak";

        #endregion fields

        #region constructors

        public TweakBrowserViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IWatcherService watcherService,
            IProgressService<double> progressService,
            IModTools modTools,
            IGameControllerFactory gameController
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _watcherService = watcherService;
            _modTools = modTools;
            _progressService = progressService;
            _gameController = gameController;
            _tweakDB = Locator.Current.GetService<TweakDBService>();

            //State = DockState.Document;

            _tweakDB.Loaded += new EventHandler((_, args) => TweakDBIDs = CollectionViewSource.GetDefaultView(_tweakDB.GetRecords()));
        }

        #endregion constructors

        public ICollectionView TweakDBIDs { get; set; }

        private string _searchText = string.Empty;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                if (!string.IsNullOrEmpty(_searchText))
                {
                    TweakDBIDs.Filter = (o) => o.ToString().Contains(_searchText);
                }
                else
                {
                    TweakDBIDs.Filter = null;
                }
                this.RaisePropertyChanged(nameof(SearchText));
            }
        }

        private TweakDBID _selectedTweakDBID;
        public TweakDBID SelectedTweakDBID
        {
            get => _selectedTweakDBID;
            set
            {
                _selectedTweakDBID = value;
                this.RaisePropertyChanged(nameof(SelectedTweakDBID));
                if (_selectedTweakDBID != null)
                {
                    SelectedRecord.Clear();
                    SelectedRecord.Add(new ChunkViewModel(_tweakDB.GetRecord(_selectedTweakDBID), null)
                    {
                        IsReadOnly = true
                    });
                }
                else
                {
                    SelectedRecord.Clear();
                }
                this.RaisePropertyChanged(nameof(SelectedRecord));
            }
        }

        public ObservableCollection<ChunkViewModel> SelectedRecord { get; set; } = new();
    }
}
