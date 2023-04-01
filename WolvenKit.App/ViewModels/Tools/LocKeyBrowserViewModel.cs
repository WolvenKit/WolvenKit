using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
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

public record LocKeyViewModel(ulong PrimaryKey, string SecondaryKey, string Content);

public partial class LocKeyBrowserViewModel : ToolViewModel
{
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
    private readonly ILocKeyService _locKeyService;
    private readonly IArchiveManager _archiveManager;

    public string Extension { get; set; } = "json";

    public LocKeyBrowserViewModel(
        IProjectManager projectManager,
        ILoggerService loggerService,
        IWatcherService watcherService,
        IProgressService<double> progressService,
        IModTools modTools,
        IGameControllerFactory gameController,
        IArchiveManager archive,
        ILocKeyService locKeyService) : base(ToolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _watcherService = watcherService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _archiveManager = archive;
        _locKeyService = locKeyService;

        _archiveManager.PropertyChanged += ArchiveManager_PropertyChanged;
        if (_archiveManager.IsManagerLoaded)
        {
            SetupLocKeys();
        }

        _locKeyService.PropertyChanged += LocKeyService_OnPropertyChanged;
    }

    private void ArchiveManager_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IArchiveManager.IsManagerLoaded))
        {
            SetupLocKeys();
        }
    }

    private void LocKeyService_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ILocKeyService.Language))
        {
            SetupLocKeys();
        }
    }

    public ObservableCollection<LocKeyViewModel> LocKeys { get; set; } = new();

    public void SetupLocKeys()
    {
        LocKeys = new(_locKeyService.GetEntries().Select(x => new LocKeyViewModel(x.PrimaryKey, x.SecondaryKey, x.FemaleVariant)));
        OnPropertyChanged(nameof(LocKeys));
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SelectedContent))]
    private LocKeyViewModel? _selectedLocKey;

    public string SelectedContent => SelectedLocKey?.Content ?? "";
}
