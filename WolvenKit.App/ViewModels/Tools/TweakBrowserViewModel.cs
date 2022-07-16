using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
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

            _tweakDB.Loaded += (_, args) =>
            {
                Records = CollectionViewSource.GetDefaultView(_tweakDB.GetRecords());
                Flats = CollectionViewSource.GetDefaultView(_tweakDB.GetFlats());
                Queries = CollectionViewSource.GetDefaultView(_tweakDB.GetQueries());
                GroupTags = CollectionViewSource.GetDefaultView(_tweakDB.GetGroupTags());
            };
        }

        #endregion constructors

        public ICollectionView Records { get; set; }
        public ICollectionView Flats { get; set; }
        public ICollectionView Queries { get; set; }
        public ICollectionView GroupTags { get; set; }

        public string RecordsHeader => $"Records ({Records.Cast<object>().Count()})";
        public string FlatsHeader => $"Flats ({Flats.Cast<object>().Count()})";
        public string QueriesHeader => $"Queries ({Queries.Cast<object>().Count()})";
        public string GroupTagsHeader => $"GroupTags ({GroupTags.Cast<object>().Count()})";

        private string _searchText = string.Empty;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                if (!string.IsNullOrEmpty(_searchText))
                {
                    Records.Filter = o => o.ToString().Contains(_searchText, StringComparison.InvariantCultureIgnoreCase);
                    Flats.Filter = o => o.ToString().Contains(_searchText, StringComparison.InvariantCultureIgnoreCase);
                    Queries.Filter = o => o.ToString().Contains(_searchText, StringComparison.InvariantCultureIgnoreCase);
                    GroupTags.Filter = o => o.ToString().Contains(_searchText, StringComparison.InvariantCultureIgnoreCase);
                }
                else
                {
                    Records.Filter = null;
                    Flats.Filter = null;
                    Queries.Filter = null;
                    GroupTags.Filter = null;
                }
                this.RaisePropertyChanged(nameof(SearchText));

                this.RaisePropertyChanged(nameof(RecordsHeader));
                this.RaisePropertyChanged(nameof(FlatsHeader));
                this.RaisePropertyChanged(nameof(QueriesHeader));
                this.RaisePropertyChanged(nameof(GroupTagsHeader));
            }
        }

        private TweakDBID _selectedRecordEntry;
        public TweakDBID SelectedRecordEntry
        {
            get => _selectedRecordEntry;
            set
            {
                _selectedRecordEntry = value;
                this.RaisePropertyChanged(nameof(SelectedRecordEntry));
                if (_selectedRecordEntry != null)
                {
                    SelectedRecord.Clear();
                    SelectedRecord.Add(new ChunkViewModel(_tweakDB.GetRecord(_selectedRecordEntry), null, true));
                }
                else
                {
                    SelectedRecord.Clear();
                }
                this.RaisePropertyChanged(nameof(SelectedRecord));
            }
        }

        public ObservableCollection<ChunkViewModel> SelectedRecord { get; set; } = new();

        private TweakDBID _selectedFlatEntry;
        public TweakDBID SelectedFlatEntry
        {
            get => _selectedFlatEntry;
            set
            {
                _selectedFlatEntry = value;
                this.RaisePropertyChanged(nameof(SelectedFlatEntry));
                if (_selectedFlatEntry != null)
                {
                    SelectedFlat = new ChunkViewModel(_tweakDB.GetFlat(_selectedFlatEntry), null, true);
                }
                else
                {
                    SelectedFlat = null;
                }
                this.RaisePropertyChanged(nameof(SelectedFlat));
            }
        }

        [Reactive] public ChunkViewModel SelectedFlat { get; set; }


        private TweakDBID _selectedQueryEntry;
        public TweakDBID SelectedQueryEntry
        {
            get => _selectedQueryEntry;
            set
            {
                _selectedQueryEntry = value;
                this.RaisePropertyChanged(nameof(SelectedQueryEntry));
                if (_selectedQueryEntry != null)
                {
                    var arr = new CArray<TweakDBID>();
                    foreach (var query in _tweakDB.GetQuery(_selectedQueryEntry))
                    {
                        arr.Add(query);
                    }

                    SelectedQuery = new ChunkViewModel(arr, null, true);
                }
                else
                {
                    SelectedQuery = null;
                }
                this.RaisePropertyChanged(nameof(SelectedQuery));
            }
        }

        [Reactive] public ChunkViewModel SelectedQuery { get; set; }


        private TweakDBID _selectedGroupTagEntry;
        public TweakDBID SelectedGroupTagEntry
        {
            get => _selectedGroupTagEntry;
            set
            {
                _selectedGroupTagEntry = value;
                this.RaisePropertyChanged(nameof(SelectedGroupTagEntry));
                if (_selectedGroupTagEntry != null)
                {
                    SelectedGroupTag = new ChunkViewModel((CUInt8)_tweakDB.GetGroupTag(_selectedGroupTagEntry), null, true);
                }
                else
                {
                    SelectedGroupTag = null;
                }
                this.RaisePropertyChanged(nameof(SelectedGroupTag));
            }
        }

        [Reactive] public ChunkViewModel SelectedGroupTag { get; set; }
    }
}
