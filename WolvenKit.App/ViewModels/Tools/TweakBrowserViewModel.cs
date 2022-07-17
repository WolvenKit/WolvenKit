using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
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


        private string _searchText = string.Empty;
        private bool _showNonResolvableEntries;
        private bool _showInlineEntries;
        private string _selectedRecordType = "";

        private TweakEntry _selectedRecordEntry;
        private TweakEntry _selectedFlatEntry;
        private TweakEntry _selectedQueryEntry;
        private TweakEntry _selectedGroupTagEntry;

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

            _tweakDB.Loaded += Load;
        }

        #endregion constructors

        #region Properties

        public ICollectionView Records { get; set; }
        public ICollectionView Flats { get; set; }
        public ICollectionView Queries { get; set; }
        public ICollectionView GroupTags { get; set; }

        public List<string> RecordTypes { get; set; }

        public string RecordsHeader => $"Records ({Records.Cast<object>().Count()})";
        public string FlatsHeader => $"Flats ({Flats.Cast<object>().Count()})";
        public string QueriesHeader => $"Queries ({Queries.Cast<object>().Count()})";
        public string GroupTagsHeader => $"GroupTags ({GroupTags.Cast<object>().Count()})";

        public ObservableCollection<ChunkViewModel> SelectedRecord { get; set; } = new();
        [Reactive] public ChunkViewModel SelectedFlat { get; set; }
        [Reactive] public ChunkViewModel SelectedQuery { get; set; }
        [Reactive] public ChunkViewModel SelectedGroupTag { get; set; }

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                this.RaisePropertyChanged(nameof(SearchText));

                Refresh();
            }
        }

        public bool ShowNonResolvableEntries
        {
            get => _showNonResolvableEntries;
            set
            {
                _showNonResolvableEntries = value;
                this.RaisePropertyChanged(nameof(ShowNonResolvableEntries));

                Refresh();
            }
        }

        public bool ShowInlineEntries
        {
            get => _showInlineEntries;
            set
            {
                _showInlineEntries = value;
                this.RaisePropertyChanged(nameof(ShowInlineEntries));

                Refresh();
            }
        }

        public string SelectedRecordType
        {
            get => _selectedRecordType;
            set
            {
                _selectedRecordType = value;
                this.RaisePropertyChanged(nameof(SelectedRecordType));

                Refresh();
            }
        }

        public TweakEntry SelectedRecordEntry
        {
            get => _selectedRecordEntry;
            set
            {
                _selectedRecordEntry = value;
                this.RaisePropertyChanged(nameof(SelectedRecordEntry));
                if (_selectedRecordEntry != null)
                {
                    SelectedRecord.Clear();
                    SelectedRecord.Add(new ChunkViewModel(_tweakDB.GetRecord(_selectedRecordEntry.Item), null, true));
                }
                else
                {
                    SelectedRecord.Clear();
                }
                this.RaisePropertyChanged(nameof(SelectedRecord));
            }
        }

        public TweakEntry SelectedFlatEntry
        {
            get => _selectedFlatEntry;
            set
            {
                _selectedFlatEntry = value;
                this.RaisePropertyChanged(nameof(SelectedFlatEntry));
                if (_selectedFlatEntry != null)
                {
                    SelectedFlat = new ChunkViewModel(_tweakDB.GetFlat(_selectedFlatEntry.Item), null, true);
                }
                else
                {
                    SelectedFlat = null;
                }
                this.RaisePropertyChanged(nameof(SelectedFlat));
            }
        }

        public TweakEntry SelectedQueryEntry
        {
            get => _selectedQueryEntry;
            set
            {
                _selectedQueryEntry = value;
                this.RaisePropertyChanged(nameof(SelectedQueryEntry));
                if (_selectedQueryEntry != null)
                {
                    var arr = new CArray<TweakDBID>();
                    foreach (var query in _tweakDB.GetQuery(_selectedQueryEntry.Item))
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

        public TweakEntry SelectedGroupTagEntry
        {
            get => _selectedGroupTagEntry;
            set
            {
                _selectedGroupTagEntry = value;
                this.RaisePropertyChanged(nameof(SelectedGroupTagEntry));
                if (_selectedGroupTagEntry != null)
                {
                    SelectedGroupTag = new ChunkViewModel((CUInt8)_tweakDB.GetGroupTag(_selectedGroupTagEntry.Item), null, true);
                }
                else
                {
                    SelectedGroupTag = null;
                }
                this.RaisePropertyChanged(nameof(SelectedGroupTag));
            }
        }

        #endregion

        #region Methods

        private void Load(object sender, EventArgs eventArgs)
        {
            var records = _tweakDB.GetRecords().Select(x => new TweakEntry(x, _tweakDB, true)).ToList();
            Records = CollectionViewSource.GetDefaultView(records);
            Records.Filter = Filter;

            var classes = new HashSet<string>();
            classes.Add("");
            foreach (var record in records)
            {
                classes.Add(record.RecordTypeName);
            }

            RecordTypes = classes.ToList();
            RecordTypes.Sort();

            Flats = CollectionViewSource.GetDefaultView(_tweakDB.GetFlats().Select(x => new TweakEntry(x, _tweakDB)).ToList());
            Flats.Filter = Filter;

            Queries = CollectionViewSource.GetDefaultView(_tweakDB.GetQueries().Select(x => new TweakEntry(x, _tweakDB)).ToList());
            Queries.Filter = Filter;

            GroupTags = CollectionViewSource.GetDefaultView(_tweakDB.GetGroupTags().Select(x => new TweakEntry(x, _tweakDB)).ToList());
            GroupTags.Filter = Filter;
        }

        private void Refresh()
        {
            Records.Refresh();
            this.RaisePropertyChanged(nameof(RecordsHeader));

            Flats.Refresh();
            this.RaisePropertyChanged(nameof(FlatsHeader));

            Queries.Refresh();
            this.RaisePropertyChanged(nameof(QueriesHeader));

            GroupTags.Refresh();
            this.RaisePropertyChanged(nameof(GroupTagsHeader));
        }

        private bool Filter(object obj)
        {
            var entry = (TweakEntry)obj;

            if (!ShowNonResolvableEntries && !entry.IsResolved)
            {
                return false;
            }

            if (!ShowInlineEntries && entry.IsInlineRecord)
            {
                return false;
            }

            if (SelectedRecordType != "" && entry.RecordTypeName != SelectedRecordType)
            {
                return false;
            }

            if (string.IsNullOrEmpty(SearchText))
            {
                return true;
            }

            if (SearchText.Contains(":"))
            {
                var parts = SearchText.Split(':');

                if (parts[0] == "class")
                {
                    return entry.RecordTypeName == parts[1];
                }
            }
            else
            {
                if (entry.Item.ToString().Contains(SearchText, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion


        public class TweakEntry
        {
            private static Regex s_inlineRegex = new("_inline[0-9]+");

            public TweakDBID Item { get; }

            public uint CRC32 => (uint)(Item & 0xFFFFFFFF);
            public uint Length => (uint)(Item >> 32);

            public string DisplayName { get; }
            public bool IsResolved { get; }

            public bool IsInlineRecord { get; }
            public string RecordTypeName { get; }

            public TweakEntry(TweakDBID item, TweakDBService tweakDbService, bool isRecord = false)
            {
                Item = item;

                DisplayName = $"<TDBID:{CRC32:X8}:{Length:X2}>";
                if (Item.ResolvedText != null)
                {
                    DisplayName = Item.ResolvedText;
                    IsResolved = true;
                }

                if (isRecord)
                {
                    if (Item.ResolvedText != null)
                    {
                        IsInlineRecord = s_inlineRegex.IsMatch(Item.ResolvedText);
                    }

                    var type = tweakDbService.GetType(Item);
                    RecordTypeName = type.Name.Substring(8, type.Name.Length - 15);
                }
            }
        }
    }
}
