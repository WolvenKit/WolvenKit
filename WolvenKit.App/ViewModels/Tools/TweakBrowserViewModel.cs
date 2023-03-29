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
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;

namespace WolvenKit.App.ViewModels.Tools;

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

    private readonly AppViewModel _appViewModel;
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;
    private readonly ISettingsManager _settingsManager;
    private readonly INotificationService _notificationService;
    private readonly IProjectManager _projectManager;
    private readonly ILoggerService _loggerService;
    private readonly ITweakDBService _tweakDB;
    private readonly ILocKeyService _locKeyService;

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
        AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory, 
        ISettingsManager settingsManager,
        INotificationService notificationService,
        IProjectManager projectManager,
        ILoggerService loggerService,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService
    ) : base(ToolTitle)
    {
        _appViewModel = appViewModel;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _settingsManager = settingsManager;
        _notificationService = notificationService;
        _projectManager = projectManager;
        _loggerService = loggerService;
        _tweakDB = tweakDbService;
        _locKeyService = locKeyService;
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
                SelectedRecord.Clear();
                if (SelectedRecordEntry != null && _tweakDB.IsLoaded)
                {
                    var vm = _chunkViewmodelFactory.ChunkViewModel(TweakDBService.GetRecord(SelectedRecordEntry.Item).NotNull(), SelectedRecordEntry.DisplayName, _appViewModel, null, true);
                    vm.IsExpanded = true;
                    SelectedRecord.Add(vm);
                }
                OnPropertyChanged(nameof(SelectedRecord));
                break;
            }

            case nameof(SelectedFlatEntry):
            {
                if (SelectedFlatEntry != null && _tweakDB.IsLoaded)
                {
                    var flat = TweakDBService.GetFlat(SelectedFlatEntry.Item);
                    ArgumentNullException.ThrowIfNull(flat);
                    SelectedFlat = _chunkViewmodelFactory.ChunkViewModel(flat, flat.GetType().Name, _appViewModel);
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
                    foreach (var query in TweakDBService.GetQuery(SelectedQueryEntry.Item).NotNull())
                    {
                        arr.Add(query);
                    }

                    SelectedQuery = _chunkViewmodelFactory.ChunkViewModel(arr, nameof(CArray<TweakDBID>), _appViewModel);
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
                    var u = TweakDBService.GetGroupTag(SelectedGroupTagEntry.Item);
                    if (u is not null)
                    {
                        SelectedGroupTag = _chunkViewmodelFactory.ChunkViewModel((CUInt8)u, nameof(CUInt8), _appViewModel);
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
        var records = PrepareList(TweakDBService.GetRecords(), true);
        var flats = PrepareList(TweakDBService.GetFlats());
        var queries = PrepareList(TweakDBService.GetQueries());
        var groupTags = PrepareList(TweakDBService.GetGroupTags());

        var classes = new List<string> { "" };
        foreach (var record in records)
        {
            if (!classes.Contains(record.RecordTypeName.NotNull()))
            {
                classes.Add(record.RecordTypeName);
            }
        }
        classes.Sort();

        DispatcherHelper.RunOnMainThread(() =>
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
            Parallel.ForEach(tweaks, record => tmpRecords.Enqueue(new TweakEntry(record, isRecord)));
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

        var baseRecord = TweakDBService.GetRecord(SelectedRecordEntry.Item).NotNull();
        txl.Type = "gamedata" + SelectedRecordEntry.RecordTypeName + "_Record";

        txl.ID = SelectedRecordEntry.Item;

        baseRecord.GetPropertyNames().ForEach(name => txl.Properties.Add(name, baseRecord.GetProperty(name).NotNull()));

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
                    .WithTypeConverter(new TweakXLYamlTypeConverter(_locKeyService, _tweakDB))
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

        public TweakEntry(TweakDBID item, bool isRecord = false)
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

                if( TweakDBService.TryGetType(Item, out var type))
                {
                    RecordTypeName = type.Name[8..^7];
                }

            }
        }
    }
}
