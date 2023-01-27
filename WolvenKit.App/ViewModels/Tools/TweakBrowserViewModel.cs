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
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Tools
{
    public partial class TweakBrowserViewModel : ToolViewModel
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

        private readonly Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;

        private readonly ISettingsManager _settingsManager;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly ILoggerService _loggerService;
        private readonly TweakDBService _tweakDB;
        public string Extension { get; set; } = "tweak";


        [ObservableProperty] private string _searchText = string.Empty;
        [ObservableProperty] private bool _showNonResolvableEntries;
        [ObservableProperty] private bool _showInlineEntries;
        [ObservableProperty] private string _selectedRecordType = "";

        [ObservableProperty] private TweakEntry? _selectedRecordEntry;
        [ObservableProperty] private TweakEntry? _selectedFlatEntry;
        [ObservableProperty] private TweakEntry? _selectedQueryEntry;
        [ObservableProperty] private TweakEntry? _selectedGroupTagEntry;

        #endregion fields

        #region constructors

        public TweakBrowserViewModel(
            ISettingsManager settingsManager,
            INotificationService notificationService,
            IProjectManager projectManager,
            ILoggerService loggerService,
            TweakDBService tweakDbService
        ) : base(ToolTitle)
        {
            _settingsManager = settingsManager;
            _notificationService = notificationService;
            _projectManager = projectManager;
            _loggerService = loggerService;
            _tweakDB = tweakDbService;

            _tweakDB.Loaded += Load;

            PropertyChanged += InternalPropertyChanged;
        }

        private void InternalPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(SearchText):
                case nameof(ShowNonResolvableEntries):
                case nameof(ShowInlineEntries):
                case nameof(SelectedRecordType):
                    Refresh();
                    break;

                case nameof(SelectedRecordEntry):
                {
                    if (SelectedRecordEntry != null && _tweakDB.IsLoaded)
                    {
                        SelectedRecord.Clear();
                        SelectedRecord.Add(new ChunkViewModel(_tweakDB.GetRecord(SelectedRecordEntry.Item), null, SelectedRecordEntry.DisplayName, true) { IsExpanded = true });
                    }
                    else
                    {
                        SelectedRecord.Clear();
                    }
                    OnPropertyChanged(nameof(SelectedRecord));
                    break;
                }

                case nameof(SelectedFlatEntry):
                {
                    if (SelectedFlatEntry != null && _tweakDB.IsLoaded)
                    {
                        SelectedFlat = new ChunkViewModel(_tweakDB.GetFlat(SelectedFlatEntry.Item));
                    }
                    else
                    {
                        SelectedFlat = null;
                    }
                    OnPropertyChanged(nameof(SelectedFlat));
                    break;
                }

                case nameof(SelectedQueryEntry):
                {
                    if (SelectedQueryEntry != null && _tweakDB.IsLoaded)
                    {
                        var arr = new CArray<TweakDBID>();
                        foreach (var query in _tweakDB.GetQuery(SelectedQueryEntry.Item))
                        {
                            arr.Add(query);
                        }

                        SelectedQuery = new ChunkViewModel(arr);
                    }
                    else
                    {
                        SelectedQuery = null;
                    }
                    OnPropertyChanged(nameof(SelectedQuery));
                    break;
                }

                case nameof(SelectedGroupTagEntry):
                {
                    if (SelectedGroupTagEntry != null && _tweakDB.IsLoaded)
                    {
                        var u = _tweakDB.GetGroupTag(SelectedGroupTagEntry.Item);
                        if (u is not null)
                        {
                            SelectedGroupTag = new ChunkViewModel((CUInt8)u);
                        }
                    }
                    else
                    {
                        SelectedGroupTag = null;
                    }
                    OnPropertyChanged(nameof(SelectedGroupTag));
                    break;
                }

                default:
                    break;
            }
        }

        #endregion constructors

        #region Properties

        [ObservableProperty] private Visibility _loadVisibility = Visibility.Visible;

        [ObservableProperty] private ICollectionView _records = new CollectionView(new List<object>());
        [ObservableProperty] private ICollectionView _flats = new CollectionView(new List<object>());
        [ObservableProperty] private ICollectionView _queries = new CollectionView(new List<object>());
        [ObservableProperty] private ICollectionView _groupTags = new CollectionView(new List<object>());

        [ObservableProperty] private List<string> _recordTypes = new();

        public string RecordsHeader => $"Records ({Records.Cast<object>().Count()})";
        public string FlatsHeader => $"Flats ({Flats.Cast<object>().Count()})";
        public string QueriesHeader => $"Queries ({Queries.Cast<object>().Count()})";
        public string GroupTagsHeader => $"GroupTags ({GroupTags.Cast<object>().Count()})";

        public ObservableCollection<ChunkViewModel> SelectedRecord { get; set; } = new();
        [ObservableProperty] private ChunkViewModel? _selectedFlat;
        [ObservableProperty] private ChunkViewModel? _selectedQuery;
        [ObservableProperty] private ChunkViewModel? _selectedGroupTag;

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

        private void Load(object? sender, EventArgs eventArgs)
        {
            var records = PrepareList(_tweakDB.GetRecords(), true);
            var flats = PrepareList(_tweakDB.GetFlats());
            var queries = PrepareList(_tweakDB.GetQueries());
            var groupTags = PrepareList(_tweakDB.GetGroupTags());

            var classes = new List<string> { "" };
            foreach (var record in records)
            {
                if (!classes.Contains(record.RecordTypeName.NotNull()))
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
                Parallel.ForEach(tweaks, record => tmpRecords.Enqueue(new TweakEntry(record, _tweakDB, isRecord)));
                return tmpRecords.AsParallel().OrderBy(x => x.DisplayName).ToList();
            }
        }

        private void Refresh()
        {
            Records.Refresh();
            OnPropertyChanged(nameof(Records));
            OnPropertyChanged(nameof(RecordsHeader));

            Flats.Refresh();
            OnPropertyChanged(nameof(FlatsHeader));

            Queries.Refresh();
            OnPropertyChanged(nameof(QueriesHeader));

            GroupTags.Refresh();
            OnPropertyChanged(nameof(GroupTagsHeader));
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

        private RelayCommand? convertToYAML;
        public ICommand ConvertToYAML => convertToYAML ??= new RelayCommand(ExecuteConvertToYAML, CanExecuteConvertToYAML);
        public bool CanExecuteConvertToYAML() => true; //Locator.Current.GetService<IProjectManager>().IsProjectLoaded;

        private void ExecuteConvertToYAML()
        {
            if (SelectedRecordEntry is null)
            {
                return;
            }

            var txl = new TweakXL
            {
                ID = SelectedRecordEntry.DisplayName
            };

            var baseRecord = _tweakDB.GetRecord(SelectedRecordEntry.Item);
            txl.Type = "gamedata" + SelectedRecordEntry.RecordTypeName + "_Record";

            txl.ID = SelectedRecordEntry.Item;

            baseRecord.GetPropertyNames().ForEach(name => txl.Properties.Add(name, baseRecord.GetProperty(name)));

            var txlFile = new TweakXLFile { txl };

            Stream myStream;
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "YAML files (*.yaml; *.yml)|*.yaml;*.yml|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = $"{SelectedRecordEntry.DisplayName}.yaml",
                InitialDirectory = _projectManager.ActiveProject?.ResourcesDirectory
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                if ((myStream = saveFileDialog.OpenFile()) is not null)
                {
                    var serializer = new SerializerBuilder()
                        .WithTypeConverter(new TweakXLYamlTypeConverter())
                        .WithIndentedSequences()
                        .Build();

                    var yaml = serializer.Serialize(txlFile);
                    myStream.Write(yaml.ToCharArray().Select(c => (byte)c).ToArray());
                    myStream.Close();

                    _loggerService.Success($"{SelectedRecordEntry.DisplayName} TweakXL written to: {saveFileDialog.FileName}");
                }
                else
                {
                    _loggerService.Error($"Could not open file: {saveFileDialog.FileName}");
                }
            }
        }

        #endregion


        public class TweakEntry
        {
            private static readonly Regex s_inlineRegex = new("_inline[0-9]+");

            public TweakDBID Item { get; }

            public uint CRC32 => (uint)(Item & 0xFFFFFFFF);
            public uint Length => (uint)(Item >> 32);

            public string DisplayName { get; }
            public bool IsResolved { get; }

            public bool IsInlineRecord { get; }
            public string? RecordTypeName { get; }

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
                    if (type != null)
                    {
                        RecordTypeName = type.Name[8..^7];
                    }

                }
            }
        }
    }
}
