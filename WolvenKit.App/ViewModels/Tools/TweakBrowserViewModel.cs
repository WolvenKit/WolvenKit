using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
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

        private Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;

        private readonly ISettingsManager _settingsManager;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
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
            ISettingsManager settingsManager,
            INotificationService notificationService,
            IProjectManager projectManager,
            TweakDBService tweakDbService
        ) : base(ToolTitle)
        {
            _settingsManager = settingsManager;
            _notificationService = notificationService;
            _projectManager = projectManager;
            _tweakDB = tweakDbService;

            _tweakDB.Loaded += Load;
        }

        #endregion constructors

        #region Properties

        [Reactive] public Visibility LoadVisibility { get; set; } = Visibility.Visible;

        [Reactive] public ICollectionView Records { get; set; } = new CollectionView(new List<object>());
        [Reactive] public ICollectionView Flats { get; set; } = new CollectionView(new List<object>());
        [Reactive] public ICollectionView Queries { get; set; } = new CollectionView(new List<object>());
        [Reactive] public ICollectionView GroupTags { get; set; } = new CollectionView(new List<object>());

        [Reactive] public List<string> RecordTypes { get; set; }

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

        public void LoadTweakDB()
        {
            if (_tweakDB.IsLoaded)
            {
                return;
            }

            _tweakDB.LoadDB(Path.Combine(_settingsManager.GetRED4GameRootDir(), "r6", "cache", "tweakdb.bin"));
        }

        private void Load(object sender, EventArgs eventArgs)
        {
            var records = PrepareList(_tweakDB.GetRecords(), true);
            var flats = PrepareList(_tweakDB.GetFlats());
            var queries = PrepareList(_tweakDB.GetQueries());
            var groupTags = PrepareList(_tweakDB.GetGroupTags());

            var classes = new List<string> { "" };
            foreach (var record in records)
            {
                if (!classes.Contains(record.RecordTypeName))
                {
                    classes.Add(record.RecordTypeName);
                }
            }
            classes.Sort();

            _dispatcher.Invoke(() =>
            {
                RecordTypes = classes;

                Records = CollectionViewSource.GetDefaultView(records);
                Records.Filter = Filter;

                Flats = CollectionViewSource.GetDefaultView(flats);
                Flats.Filter = Filter;

                Queries = CollectionViewSource.GetDefaultView(queries);
                Queries.Filter = Filter;

                GroupTags = CollectionViewSource.GetDefaultView(groupTags);
                GroupTags.Filter = Filter;

                Refresh();

                LoadVisibility = Visibility.Collapsed;
                _notificationService.Success($"Tweak Browser is initialized");
            });

            List<TweakEntry> PrepareList(List<TweakDBID> tweaks, bool isRecord = false)
            {
                var tmpRecords = new ConcurrentQueue<TweakEntry>();
                Parallel.ForEach(tweaks, record =>
                {
                    tmpRecords.Enqueue(new TweakEntry(record, _tweakDB, isRecord));
                });
                return tmpRecords.AsParallel().OrderBy(x => x.DisplayName).ToList();
            }
        }

        private void Refresh()
        {
            Records.Refresh();
            this.RaisePropertyChanged(nameof(Records));
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

            if (ulong.TryParse(SearchText, out var u1) && entry.Item == u1)
            {
                return true;
            }

            if (ulong.TryParse(SearchText, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out var u2) && entry.Item == u2)
            {
                return true;
            }

            if (entry.IsResolved && entry.DisplayName.Contains(SearchText, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
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
