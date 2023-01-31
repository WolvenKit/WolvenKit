using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WolvenKit.App.Controllers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Tools;

public class LocKeyBrowserViewModel : ToolViewModel
{
    #region fields

    /// <summary>
    /// Identifies the <see ref="ContentId"/> of this tool window.
    /// </summary>
    public const string ToolContentId = "LocKeyBrowser_Tool";

    /// <summary>
    /// Identifies the caption string used for this tool window.
    /// </summary>
    public const string ToolTitle = "LocKey Browser";

    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IWatcherService _watcherService;
    private readonly IModTools _modTools;
    private readonly IProgressService<double> _progressService;
    private readonly IGameControllerFactory _gameController;
    private readonly LocKeyService _locKeyService;
    private readonly IArchiveManager _archiveManager;

    public string Extension { get; set; } = "json";

    #endregion fields

    #region constructors

    public LocKeyBrowserViewModel(
        IProjectManager projectManager,
        ILoggerService loggerService,
        IWatcherService watcherService,
        IProgressService<double> progressService,
        IModTools modTools,
        IGameControllerFactory gameController,
        IArchiveManager archive,
        LocKeyService locKeyService) : base(ToolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _watcherService = watcherService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _archiveManager = archive;

        //State = DockState.Document;

        _archiveManager.PropertyChanged += ArchiveManager_PropertyChanged;
        if (_archiveManager.IsManagerLoaded)
        {
            SetupLocKeys();
        }

        _locKeyService = locKeyService;
    }

    private void ArchiveManager_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IArchiveManager.IsManagerLoaded))
        {
            SetupLocKeys();
        }
    }

    #endregion constructors

    public ICollectionView? LocKeys { get; set; }


    public void SetupLocKeys()
    {
        var entries = _locKeyService.GetEntries();
        LocKeys = CollectionViewSource.GetDefaultView(entries);
        LocKeys.SortDescriptions.Add(new SortDescription("SecondaryKey", ListSortDirection.Ascending));
        OnPropertyChanged(nameof(LocKeys));
    }

    private string _searchText = "";
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            if (LocKeys != null)
            {
                LocKeys.Filter = _searchText != ""
                ? ((obj) =>
                {
                    if (obj is localizationPersistenceOnScreenEntry entry)
                    {
                        if (entry.FemaleVariant.ToString() != null)
                        {
                            return entry.FemaleVariant.ToString().Contains(_searchText);
                        }
                    }
                    return false;
                })
                : null;
            }

            OnPropertyChanged();
        }
    }

    private localizationPersistenceOnScreenEntry? _selectedLocKey;
    public localizationPersistenceOnScreenEntry? SelectedLocKey
    {
        get => _selectedLocKey;
        set
        {
            _selectedLocKey = value;
            OnPropertyChanged();
            if (_selectedLocKey != null)
            {
                SelectedChunk.Clear();
                SelectedChunk.Add(new ChunkViewModel(_selectedLocKey, _selectedLocKey.GetType().Name, null, false)
                {
                    IsReadOnly = true,
                    IsExpanded = true
                });
            }
            else
            {
                SelectedChunk.Clear();
            }
            OnPropertyChanged(nameof(SelectedChunk));
        }
    }

    public ObservableCollection<ChunkViewModel> SelectedChunk { get; set; } = new();
}
