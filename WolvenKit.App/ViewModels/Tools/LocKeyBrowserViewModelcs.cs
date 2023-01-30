using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using ReactiveUI;
using Splat;
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
    private readonly IArchiveManager _archive;

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
        IArchiveManager archive
    ) : base(ToolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _watcherService = watcherService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _archive = archive;
        _locKeyService = Locator.Current.GetService<LocKeyService>().NotNull();

        //State = DockState.Document;


        if (_archive.IsManagerLoaded)
        {
            SetupLocKeys();
        }
        else
        {
            _archive.WhenAnyValue(x => x.IsManagerLoaded).Subscribe(x =>
            {
                if (x)
                {
                    SetupLocKeys();
                }
            });
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
