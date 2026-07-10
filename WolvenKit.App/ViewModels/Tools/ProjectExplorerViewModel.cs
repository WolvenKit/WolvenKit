using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic.FileIO;
using ReactiveUI;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using Clipboard = System.Windows.Clipboard;
using FileMode = System.IO.FileMode;
using Key = System.Windows.Input.Key;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using SearchOption = System.IO.SearchOption;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel : ToolViewModel
{
    #region fields

    /// <summary>
    /// Identifies the <see ref="ContentId"/> of this tool window.
    /// </summary>
    private const string s_toolContentId = "ProjectExplorer_Tool";

    /// <summary>
    /// Identifies the caption string used for this tool window.
    /// </summary>
    private const string s_toolTitle = "Project Explorer";

    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly IProjectManager _projectManager;
    private readonly IModTools _modTools;
    private readonly IProgressService<double> _progressService;
    private readonly IGameControllerFactory _gameController;
    private readonly AppViewModel _appViewModel;
    public readonly IModifierViewStateService ModifierStateService;
    private readonly WatcherService _projectWatcher;
    private readonly IProjectEvents _projectEvents;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private IPluginService _pluginService;

    private readonly ISettingsManager _settingsManager;
    private readonly IArchiveManager _archiveManager;
    private readonly ProjectResourceTools _projectResourceTools;
    private Guid _loadingCompletion = Guid.NewGuid();
    private CancellationTokenSource _deferredRefreshCts = new();
    private readonly ImportExportHelper _importExportHelper;
    private readonly TimeSpan _singleOperationTimeout = TimeSpan.FromMilliseconds(100);

    public DispatchedObservableCollection<FileSystemModel> FileTree => _projectWatcher.FileTree;
    public DispatchedObservableCollection<FileSystemModel> FileList => _projectWatcher.FileList;
    public WatcherState FileWatcherState => _projectWatcher.WatcherState;
    public Func<CancellationToken, TimeSpan, Task, Task>? BeginDeferredRefreshContext { get; set; }
    public Dictionary<string, bool> ExpansionStateDictionary = [];
    public bool IsKeyUpEventAssigned { get; set; }

    #endregion fields

    private static ProjectExplorerViewModel? s_instance;
    public ProjectExplorerViewModel(
        AppViewModel appViewModel,
        IProjectManager projectManager,
        ILoggerService loggerService,
        INotificationService notificationService,
        IProgressService<double> progressService,
        IModTools modTools,
        IGameControllerFactory gameController,
        IPluginService pluginService,
        ISettingsManager settingsManager,
        IModifierViewStateService modifierSvc,
        IArchiveManager archiveManager,
        ProjectResourceTools projectResourceTools,
        ImportExportHelper importExportHelper,
        IProjectEvents projectEvents
    ) : base(s_toolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _notificationService = notificationService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _pluginService = pluginService;
        _settingsManager = settingsManager;
        _archiveManager = archiveManager;
        _projectResourceTools = projectResourceTools;
        _importExportHelper = importExportHelper;
        ModifierStateService = modifierSvc;
        _projectEvents = projectEvents;

        _appViewModel = appViewModel;

        _projectWatcher = new WatcherService(GetDesiredExpansionState, loggerService, projectEvents);

        SideInDockedMode = DockSide.Left;

        IsShowRelativePath = true;
        ModifierStateService.ModifierStateChanged += OnModifierUpdateEvent;

        SetupToolDefaults();

        _appViewModel.PropertyChanged += AppViewModelOnPropertyChanged;
        _appViewModel.OpenDocumentChanged += OnOpenDocumentChanged;

        SelectedTabIndex = ActiveProject?.ActiveTab ?? 0;

        DispatcherHelper.StartRepeatingAction(
            () => Svc_ThreadIdleTenSeconds(null, EventArgs.Empty),
            TimeSpan.FromSeconds(10));

        s_instance = this;

        _projectManager.WhenAnyValue(x => x.ActiveProject)
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(project =>
            {
                if (project == null)
                {
                    return;
                }

                var isReload = project.FileDirectory == _activeProject?.FileDirectory;

                // If a modal or overlay is currently visible (e.g. HomePage, settings, etc.),
                // defer the (potentially very expensive) watcher + tree build until after the
                // overlay has finished fading out. This prevents the 0.3s OverlayFadeOut animation
                // from becoming extremely choppy on large projects.
                _appViewModel.RunAfterModalClosed(() =>
                {
                    StartWatcher_AndLoadProject(project, isReload);
                });
            });
    }


    private void Svc_ThreadIdleTenSeconds(object? sender, EventArgs e)
    {
        SaveProjectExplorerExpansionStateIfDirty();
        SaveProjectExplorerTabIfDirty();
    }

    /// <summary>
    /// Set status of "scroll to open file" button (disable if we don't have one open)
    /// </summary>
    private void AppViewModelOnPropertyChanged(object? sender, PropertyChangedEventArgs e) =>
        CanScrollToOpenFile = HasSelectedItem && _appViewModel.ActiveDocument is not null;

    #region Project_Loading

    /// <summary>
    /// Loads a project and starts watching it.
    /// If isReload is true then we won't show `Loading` in the files pane.
    /// </summary>
    /// <param name="activeProject"></param>
    /// <param name="isReload"></param>
    public void StartWatcher_AndLoadProject(Cp77Project activeProject, bool isReload)
    {
        if (_appViewModel.IsDialogShown || _appViewModel.IsOverlayShown)
        {
            _appViewModel.RunAfterModalClosed(() => StartWatcher_AndLoadProject(activeProject, isReload));
            return;
        }

        if (ActiveProject != null)
        {
            SaveProjectState();
        }

        LoadExpansionStateDictionary(activeProject);
        EnableLoadingMode(isReload);
        ActiveProject = null;
        UnwatchProject();

        DispatcherHelper.DelayOnMainThread(() =>
        {
            try
            {
                ActiveProject = activeProject;
                _projectWatcher.StartWatcher_AndLoadProject(activeProject);
            }
            catch (Exception e)
            {
                _loggerService.Error($"Error refreshing project: {e.Message}");
            }
            finally
            {
                if (!isReload)
                {
                    RestoreProjectState(ActiveProject!);
                    CheckForOneDriveInPath();
                }
            }
        }, 50);
    }

    /// <summary>
    /// Reload the active project from disk to ensure consistency.
    /// </summary>
    public void ResumeWatcher_AndReloadProject()
    {
        if (ActiveProject is null) return;
        StartWatcher_AndLoadProject(ActiveProject, true);
    }

    private void EnableLoadingMode(bool isReload)
    {
        _loadingCompletion = DispatcherHelper.StartRepeatingAction(
            () =>
            {
                _progressService.IsIndeterminate = true;
                _progressService.Status = EStatus.Running;
            },
            _singleOperationTimeout,
            DisableLoadingMode
        );

        _projectWatcher.CompletionTimer = _loadingCompletion;
        OnSetLoading?.Invoke(this, (true, isReload));
    }

    private void DisableLoadingMode()
    {
        _progressService.IsIndeterminate = false;
        OnSetLoading?.Invoke(this, (false, false));
        _loggerService?.Success($"Loaded project: {ActiveProject!.ProjectDirectory} ({FileList.Count} files). File watcher active.");
    }

    /// <summary>
    /// Whenever the document changes, save open file paths to <see cref="Cp77Project.ProjectFileExtension"/> file
    /// </summary>
    private void OnOpenDocumentChanged(object? sender, EventArgs e) => SaveOpenFilePaths();

    private void SaveProjectState()
    {
        if (ActiveProject != null)
        {
            _hasUnsavedFileTreeChanges = true;
            SaveOpenFilePaths();
            SaveProjectExplorerExpansionStateIfDirty();
            SaveProjectExplorerTabIfDirty();
            _hasUnsavedFileTreeChanges = false;
        }
    }

    private void CheckForOneDriveInPath()
    {
        if (_projectManager.ActiveProject is null ||
            !FilePathHelper.IsOneDrivePath(_projectManager.ActiveProject.Location))
        {
            return;
        }

        List<string> warningText =
        [
            "Hey, choom!",
            "",
            "Don't store Wolvenkit projects inside your OneDrive folder!",
            "This can cause all kinds of issues!"
        ];

        DispatcherHelper.RunOnMainThread(() => _ = Interactions.ShowConfirmation((
            string.Join('\n', warningText),
            "OneDrive Warning",
            WMessageBoxImage.Warning,
            WMessageBoxButtons.Ok
        )));
    }

    public bool? GetExpansionStateOrNull(string relPath) => ExpansionStateDictionary.TryGetValue(relPath, out var state) ? state : null;

    #endregion Project_Loading

    /// <summary>
    /// Enable ConvertTo and ConvertFrom
    /// If the item is in the archive folder, it can be converted to json
    /// If the item is in the raw folder, it can be converted from json
    /// </summary>
    partial void OnSelectedItemChanged(FileSystemModel? value)
    {
        HasSelectedItem = value is not null;
        CanScrollToOpenFile = HasSelectedItem && _appViewModel.ActiveDocument is not null;
        if (value is null)
        {
            return;
        }

        _appViewModel.SelectFileCommand.SafeExecute(value);
    }

    #region properties

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RefreshCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenRootFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(OverwriteWithGameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CreateNewDirectoryCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
    [NotifyCanExecuteChangedFor(nameof(ToggleFlatModeCommand))]
    [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertRawFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInAssetBrowserCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private Cp77Project? _activeProject;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(OverwriteWithGameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CreateNewDirectoryCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
    [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInAssetBrowserCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertRawFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ExportArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ImportRawFileCommand))]
    private FileSystemModel? _selectedItem;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertRawFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ExportArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ImportRawFileCommand))]
    private ObservableCollection<object>? _selectedItems = new();

    [ObservableProperty] private bool _isFlatModeEnabled;

    [ObservableProperty] private int _selectedTabIndex;

    [ObservableProperty] private bool _canScrollToOpenFile;

    [ObservableProperty] private bool _hasSelectedItem;

    #region INotifyCollectionChanged

    public NotifyCollectionChangedEventHandler? NotifyCollectionChangedEventHandler { get; set; }

    #endregion INotifyCollectionChanged

    #endregion properties

    #region commands

    #region general commands

    /// <summary>
    /// Refreshes all files in the Grid
    /// </summary>
    private bool CanRefresh() => ActiveProject != null;

    [RelayCommand(CanExecute = nameof(CanRefresh))]
    private void Refresh() => ResumeWatcher_AndReloadProject();

    private string GetActiveFolderPath() => SelectedTabIndex switch
    {
        0 => ActiveProject.NotNull().FileDirectory,
        1 => ActiveProject.NotNull().ModDirectory,
        2 => ActiveProject.NotNull().RawDirectory,
        3 => ActiveProject.NotNull().ResourcesDirectory,
        _ => ActiveProject.NotNull().Location
    };

    /// <summary>
    /// Opens the currently active tab's root folder in Windows Explorer (the project root if shift key is pressed).
    /// </summary>
    private bool CanOpenRootFolder() => ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanOpenRootFolder))]
    private void OpenRootFolder() => Commonfunctions.ShowFolderInExplorer(
        ActiveProject is not null && ModifierViewStateService.IsShiftBeingHeld ? ActiveProject.ProjectDirectory : GetActiveFolderPath()
    );

    /// <summary>
    /// Copies selected node to the clipboard.
    /// </summary>
    private bool CanCopyFile() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCopyFile))]
    private void CopyFile() => Clipboard.SetDataObject(SelectedItem.NotNull().FullName);

    /// <summary>
    /// If neither control nor shift is being held, show "Copy relative path" context menu entry.
    /// This will also return the relative path of the current game file if executed from raw folder view.
    /// </summary>
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToRawFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToArchiveFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFolderCommand))]
    private bool _isShowRelativePath;

    /// <summary>
    /// When holding Ctrl+Shift and right-clicking an archive item or folder, the context menu will show "Copy absolute path to raw folder".
    /// </summary>
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToRawFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToArchiveFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFolderCommand))]
    private bool _isShowAbsolutePathToRawFolder;

    /// <summary>
    /// When holding Ctrl+Shift and right-clicking an item in "raw", the context menu will show "Copy absolute path to archive folder".
    /// </summary>
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToRawFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToArchiveFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFolderCommand))]
    private bool _isShowAbsolutePathToArchiveFolder;

    /// <summary>
    /// When holding Shift, the context menu will show "Copy absolute path".
    /// </summary>
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToRawFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToArchiveFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFolderCommand))]
    private bool _isShowAbsolutePathToCurrentFile;

    /// <summary>
    /// When holding Control, the context menu will show "Copy absolute path to folder".
    /// </summary>
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToRawFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToArchiveFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyAbsPathToCurrentFolderCommand))]
    private bool _isShowAbsolutePathToCurrentFolder;

    /// <summary>
    /// When holding Control, the context menu will show "Copy absolute path to folder".
    /// </summary>
    [ObservableProperty] private bool _isShiftKeyPressed;

    /// <summary>
    /// Do we have an open file?
    /// </summary>
    [ObservableProperty] private bool _hasOpenFile;

    private static readonly string s_rawFolder = $"{Path.DirectorySeparatorChar}raw{Path.DirectorySeparatorChar}";

    private static readonly string s_archiveFolder =
        $"{Path.DirectorySeparatorChar}archive{Path.DirectorySeparatorChar}";

    private bool _hasUnsavedFileTreeChanges;

    private bool _projectExplorerTabChanged;

    [GeneratedRegex(@".*\.\S+\.glb$")]
    private static partial Regex TypedGlbRegex();

    /// <summary>
    /// Copies the path to an item in clipboard
    /// </summary>
    /// <param name="isAbsolute"></param>
    /// <param name="switchToRaw"></param>
    /// <param name="gamefileOnly"></param>
    /// <param name="cutOffFileName"></param>
    private void CopyItemPathToClipboard(
        bool isAbsolute = false,
        bool switchToRaw = false,
        bool gamefileOnly = false,
        bool cutOffFileName = false)
    {
        List<FileSystemModel> items = [];
        List<string> itemPaths = [];

        if (SelectedItems is null || SelectedItems.Count == 0)
        {
            if (SelectedItem is null)
            {
                return;
            }

            items.Add(SelectedItem);
        }
        else
        {
            items.AddRange(SelectedItems.OfType<FileSystemModel>());
        }

        foreach (var relativePath in items.Select(selectedItem => selectedItem.FullName))
        {
            if (!Path.Exists(relativePath))
            {
                return;
            }

            var activeItemPath = relativePath.Replace('/', Path.DirectorySeparatorChar);
            if (!isAbsolute)
            {
                activeItemPath = ActiveProject!.GetRelativePath(activeItemPath);
            }

            if (switchToRaw)
            {
                if (activeItemPath.Contains(s_rawFolder) || gamefileOnly)
                {
                    activeItemPath = activeItemPath.Replace(s_rawFolder, s_archiveFolder);
                    // it's a .morphtarget.glb or .anims.glb or...
                    if (TypedGlbRegex().IsMatch(activeItemPath))
                    {
                        activeItemPath = activeItemPath.Replace(".glb", "");
                    }
                    else if (activeItemPath.EndsWith(".glb"))
                    {
                        activeItemPath = activeItemPath.Replace(".glb", ".mesh");
                    }
                    else if (activeItemPath.EndsWith(".json"))
                    {
                        activeItemPath = activeItemPath.Replace(".json", "");
                    }
                }
                else if (activeItemPath.Contains(s_archiveFolder) && !gamefileOnly)
                {
                    activeItemPath = activeItemPath.Replace(s_archiveFolder, s_rawFolder);

                    switch (Path.GetExtension(activeItemPath))
                    {
                        case ".mesh":
                            activeItemPath = activeItemPath.Replace(".mesh", ".glb");
                            break;
                        case ".morphtarget":
                        case ".anims":
                            activeItemPath = $"{activeItemPath}.glb";
                            break;
                        default:
                            break;
                    }
                }
            }

            if (gamefileOnly && activeItemPath.Contains(s_archiveFolder))
            {
                activeItemPath = activeItemPath.Replace(s_archiveFolder, s_rawFolder);
                activeItemPath = Path.GetDirectoryName(activeItemPath) ?? activeItemPath;
            }

            if (cutOffFileName)
            {
                activeItemPath = Path.Combine(Path.GetDirectoryName(activeItemPath) ?? "",
                    Path.GetFileNameWithoutExtension(activeItemPath));
            }

            if (isAbsolute && !Path.Exists(activeItemPath))
            {
                activeItemPath = Path.GetDirectoryName(activeItemPath);
            }

            if (!string.IsNullOrEmpty(activeItemPath))
            {
                itemPaths.Add(activeItemPath);
            }
        }

        if (itemPaths.Count > 0)
        {
            Clipboard.SetDataObject(string.Join("\n", itemPaths));
        }
    }

    private bool CanCopyRelPath() => IsShowRelativePath;

    /// <summary>
    /// Copy relative path to game file. If the current file is under "raw", switch to "archive" and cut off extension.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyRelPath() => CopyItemPathToClipboard(false, false, true);

    private bool CanCopyAbsPathToCurrentFile => IsShowAbsolutePathToCurrentFile;
    /// <summary>
    /// Copy absolute path to current file. Don't change anything else.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyAbsPathToCurrentFile))]
    private void CopyAbsPathToCurrentFile() => CopyItemPathToClipboard(true);

    private bool CanCopyAbsPathToCurrentFolder => IsShowAbsolutePathToCurrentFolder;
    /// <summary>
    /// Copy absolute path to current folder. If currently selected item _is_ a folder, don't cut off the file name.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyAbsPathToCurrentFolder))]
    private void CopyAbsPathToCurrentFolder() =>
        CopyItemPathToClipboard(true, false, false,
            SelectedItem?.FullName is not null && Directory.Exists(SelectedItem?.FullName));


    private bool CanCopyAbsPathToRawFolder => IsShowAbsolutePathToRawFolder;
    /// <summary>
    /// Ctrl+Shift with /archive/ file or folder selected: Copy absolute path to raw folder (convenience for quick switching)
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyAbsPathToRawFolder))]
    private void CopyAbsPathToRawFolder() => CopyItemPathToClipboard(true, true, false, true);


    private bool CanCopyAbsPathToArchiveFolder => IsShowAbsolutePathToArchiveFolder;
    /// <summary>
    /// Ctrl+Shift with /raw/ file or folder selected: Copy absolute path to archive folder (convenience for quick switching)
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyAbsPathToArchiveFolder))]
    private void CopyAbsPathToArchiveFolder() => CopyItemPathToClipboard(true, true, true);


    /// <summary>
    /// Reimports the game file to replace the current one
    /// </summary>
    private bool CanAddDependencies() => ActiveProject != null && IsInRawFolder(SelectedItem) &&
                                         SelectedItem!.Extension.Contains("xml",
                                             StringComparison.CurrentCultureIgnoreCase);
    [RelayCommand(CanExecute = nameof(CanAddDependencies))]
    private async Task AddDependencies()
    {
        if (SelectedItem.NotNull().IsDirectory)
        {
            return;
        }

        // parse xml
        var filename = SelectedItem.FullName;
        var serializer = new XmlSerializer(typeof(MaterialXmlModel));

        await using Stream reader = new FileStream(filename, FileMode.Open);
        // Call the Deserialize method to restore the object's state.
        if (serializer.Deserialize(reader) is MaterialXmlModel model)
        {
            var materials = new List<string>();
            if (model.Materials is not null)
            {
                foreach (var material in model.Materials)
                {
                    if (material.Param is null)
                    {
                        continue;
                    }

                    foreach (var param in material.Param)
                    {
                        if (string.IsNullOrEmpty(param.Value) || string.IsNullOrEmpty(param.Type) ||
                            !param.Type.StartsWith("rRef:"))
                        {
                            continue;
                        }

                        var path = param.Value;
                        if (!materials.Contains(path))
                        {
                            materials.Add(path);
                        }
                    }
                }
            }

            // add from AB
            foreach (var material in materials)
            {
                var relPath = ActiveProject!.GetRelativePath(material);
                var hash = FNV1A64HashAlgorithm.HashString(relPath);
                await Task.Run(() => _gameController.GetController().AddToMod(hash));
            }
        }
    }

    private bool IsGameFile(FileSystemModel? m)
    {
        if (m is null || !(m.GameRelativePath.StartsWith("base") || m.GameRelativePath.StartsWith("ep1")))
        {
            return false;
        }

        return _archiveManager.GetGameFile(m.GameRelativePath, false, false) != null;
    }

    /// <summary>
    /// Reimports the game file to replace the current one
    /// </summary>
    private bool CanOverwriteWithGameFile() => IsInArchiveFolder(SelectedItem) && IsGameFile(SelectedItem);

    [RelayCommand(CanExecute = nameof(CanOverwriteWithGameFile))]
    private async Task OverwriteWithGameFile()
    {
        // Make sure we have something to export
        if (SelectedItem is null && (SelectedItems?.Count ?? 0) == 0)
        {
            return;
        }


        // Collect hashes of all selected items, we'll export them after
        HashSet<ulong> selectedItems = [];

        foreach (var currentItem in (SelectedItems ?? []).Cast<FileSystemModel>())
        {
            if (!currentItem.IsDirectory)
            {
                selectedItems.Add(currentItem.Hash);
                continue;
            }

            var files = Directory.GetFiles(currentItem.FullName, "*", SearchOption.AllDirectories).ToList();
            foreach (var hash in files
                         .Select(file => ActiveProject!.GetRelativePath(file))
                         .Select(FNV1A64HashAlgorithm.HashString))
            {
                selectedItems.Add(hash);
            }
        }

        if (SelectedItem is not null)
        {
            selectedItems.Add(SelectedItem.Hash); // HashSet won't add duplicate items
        }

        // Progress reporting
        var progress = 0;
        _progressService.Report(0);

        // Define var outside of loop
        var controller = _gameController.GetController();

        foreach (var hash in selectedItems)
        {
            await Task.Run(() => controller.AddToMod(hash, ArchiveManagerScope.Basegame));
            progress++;
            _progressService.Report(progress / (float)selectedItems.Count);
        }

        // OK, we're done
        _progressService.Completed();

        _appViewModel.ReloadChangedFiles();
    }

    /// <summary>
    /// Cuts selected node to the clipboard.
    /// </summary>
    private bool CanCutFile() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCutFile))]
    private void CutFile() => throw new NotImplementedException();

    /// <summary>
    /// Deletes selected node.
    /// </summary>
    private bool CanDeleteFile() => ActiveProject != null && SelectedItems != null;
    [RelayCommand(CanExecute = nameof(CanDeleteFile))]
    private async Task DeleteFile()
    {
        var selected = SelectedItems.NotNull().OfType<FileSystemModel>().ToList();
        var delete = Interactions.DeleteFiles(selected.Select(d => d.Name));
        if (!delete)
        {
            return;
        }

        SuspendFileWatcher();

        // Delete the files/directories on disk (to recycle bin). We suspend the watcher so
        // we don't get concurrent Deleted FS events fighting with our manual model cleanup.
        foreach (var item in selected)
        {
            var fullPath = item.FullName;
            try
            {
                if (item.IsDirectory)
                {
                    FileSystem.DeleteDirectory(fullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                else
                {
                    FileSystem.DeleteFile(fullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
            }
            catch (Exception)
            {
                _loggerService.Error("Failed to delete " + fullPath + ".\r\n");
            }
        }

        // Manually remove the corresponding models from the watcher collections.
        // We do this under BeginDeferredRefreshContext so that the Syncfusion TreeGrid
        // (and TreeGridFlat) views are in DeferRefresh mode while the Removes (and their
        // CollectionChanged notifications) happen. This prevents NREs inside
        // TreeGridView.RemoveNode / QueryableView when the item being removed was added
        // via the bypass path (OnFilesImported/CreateFileAndAllNeededDirectories) and
        // may not have had a materialized TreeNode in the grid's internal map (e.g. because
        // the parent folder was not expanded, or due to prior Reset notifications, filters, etc.).
        _deferredRefreshCts = new CancellationTokenSource();

        if (BeginDeferredRefreshContext == null)
        {
            if (TestHelper.InActiveTest)
            {
                _projectWatcher.RemoveItems(selected);
            }
            else
            {
                _projectWatcher.RemoveItems(selected);
            }

            ResumeFileWatcher();
            return;
        }

        var cts = _deferredRefreshCts;
        await BeginDeferredRefreshContext(
            cts.Token,
            TimeSpan.FromMilliseconds(100),
            Task.Run(async () =>
            {
                try
                {
                    _projectWatcher.RemoveItems(selected);

                    // The RemoveItems queue their actual collection mutations via
                    // DispatcherHelper.RunOnMainThread (which is InvokeAsync). Wait here
                    // (on this worker) for the dispatcher to reach a point after our Normal
                    // priority remove actions have executed. This ensures the CC notifications
                    // are delivered while the view's DeferRefresh is still active.
                    try
                    {
                        System.Windows.Application.Current?.Dispatcher?.Invoke(
                            () => { },
                            System.Windows.Threading.DispatcherPriority.ContextIdle);
                    }
                    catch { }
                }
                finally
                {
                    // Always unblock the deferred refresh (so the grids get a chance to
                    // reconcile their node state via Refresh) even if something went wrong.
                    try { await cts.CancelAsync(); } catch { }
                    try { cts.Dispose(); } catch { }
                }
            }));

        ResumeFileWatcher();
    }

    /// <summary>
    /// Opens selected node in File Explorer.
    /// </summary>
    private bool CanOpenInFileExplorer() => ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanOpenInFileExplorer))]
    private void OpenInFileExplorer(FileSystemModel? value)
    {
        var model = value ?? SelectedItem;
        if (model is null)
        {
            return;
        }

        if (model.IsDirectory)
        {
            Commonfunctions.ShowFolderInExplorer(model.FullName);
        }
        else
        {
            Commonfunctions.ShowFileInExplorer(model.FullName);
        }
    }

    [RelayCommand]
    private async Task OpenFile(FileSystemModel? value)
    {
        var model = value ?? SelectedItem;
        if (model is null)
        {
            return;
        }

        await _appViewModel.OpenFileAsync(model);
    }

    /// <summary>
    /// Pastes a file from the clipboard into selected node.
    /// </summary>
    private bool CanPasteFile() => ActiveProject != null && SelectedItem != null && Clipboard.ContainsText();
    [RelayCommand(CanExecute = nameof(CanPasteFile))]
    private void PasteFile()
    {
        if (File.Exists(Clipboard.GetText()))
        {
            var attr = File.GetAttributes(SelectedItem.NotNull().FullName);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                SafeCopy(Clipboard.GetText(), SelectedItem.FullName + "\\" + Path.GetFileName(Clipboard.GetText()));
            }
            else
            {
                SafeCopy(Clipboard.GetText(), Path.GetDirectoryName(SelectedItem.FullName) + "\\" + Path.GetFileName(Clipboard.GetText()));
            }
        }

        static void SafeCopy(string src, string dest)
        {
            foreach (var path in FallbackPaths(dest).Where(path => !File.Exists(path)))
            {
                File.Copy(src, path);
                break;
            }
        }

        static IEnumerable<string> FallbackPaths(string path)
        {
            yield return path;

            var dir = Path.GetDirectoryName(path).NotNull();
            var file = Path.GetFileNameWithoutExtension(path);
            var ext = Path.GetExtension(path);

            yield return Path.Combine(dir, file + "_copy" + ext);
            for (var i = 2; i < 999; i++) // there shouldn't be more than 1k copies... hopefully
            {
                yield return Path.Combine(dir, file + "_copy_" + i + ext);
            }
        }
    }


    private bool CanCreateNewDirectory() => ActiveProject != null && SelectedItem?.IsDirectory == true;

    [RelayCommand(CanExecute = nameof(CanCreateNewDirectory))]
    private void CreateNewDirectory(FileSystemModel? value)
    {
        var model = value ?? SelectedItem;
        if (model is null)
        {
            return;
        }

        // if a file is selected, go up to parent directory
        if (!model.IsDirectory)
        {
            model = model.Parent;
        }

        if (model?.IsDirectory != true)
        {
            return;
        }

        var newFolderPath = Path.Combine(model.FullName, Interactions.AskForTextInput(("Directory name", "")));

        if (Directory.Exists(newFolderPath))
        {
            return;
        }

        Directory.CreateDirectory(newFolderPath);
    }



    /// <summary>
    /// Renames selected node. Works for files and directories.
    /// </summary>
    private bool CanRenameFile() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanRenameFile))]
    private async Task RenameFile()
    {
        if (SelectedItem == null || ActiveProject == null || SelectedItem?.FullName is not string absolutePath)
        {
            return;
        }

        var currentRawRelativePath = SelectedItem.RawRelativePath;

        var (newRawRelativePath, refactor) = Interactions.RenameAndRefactor((
            currentRawRelativePath,
            absolutePath.StartsWith(ActiveProject.ModDirectory)
        ));

        if (string.IsNullOrEmpty(newRawRelativePath) || newRawRelativePath == currentRawRelativePath)
        {
            return;
        }

        _deferredRefreshCts = new CancellationTokenSource();
        var token = _deferredRefreshCts.Token;

        await BeginDeferredRefreshContext!(
            token,
            _singleOperationTimeout,
            InternalRenameFile(SelectedItem, currentRawRelativePath, newRawRelativePath, ActiveProject.FileDirectory, refactor)
        );


        if (string.IsNullOrEmpty(newRelativePath) || newRelativePath == relativePath)
        {
            throw new WolvenKitException(352345, "Internal inconsistency found. Please quit and restart the app.");
        }
    }

    /// <summary>
    /// Renames the supplied FileSystemModel.
    /// You must pass in the old RawRelativePath and new RawRelativePath as well as the path to /source.
    /// 'Refactor' checkbox makes the name change effected in references to that file in the mod.
    /// </summary>
    /// <param name="selectedItem"></param>
    /// <param name="relativePath"></param>
    /// <param name="newRelativePath"></param>
    /// <param name="prefixPath"></param>
    /// <param name="refactor"></param>
    private async Task InternalRenameFile(FileSystemModel selectedItem, string relativePath, string newRelativePath, string prefixPath, bool refactor)
    {
        SuspendFileWatcher();
        try
        {
            await _projectResourceTools.MoveAndRefactorAsync(relativePath, newRelativePath, prefixPath, refactor);
            _appViewModel.ReloadChangedFiles();
        }
        finally
        {
            try { await _deferredRefreshCts.CancelAsync(); } catch { /* token may already be gone */ }
            ResumeFileWatcher();
        }
    }

    public void ResumeFileWatcher()
    {
        _projectWatcher.Resume();
    }

    /// <summary>
    /// Called by the View after a drag-and-drop has moved and/or copied files on disk. Publishes an
    /// authoritative reconciliation so the grids update immediately from what actually happened,
    /// instead of waiting on (flaky) OS file system events. <paramref name="moves"/> are
    /// (fromAbs -&gt; toAbs) relocations; <paramref name="additions"/> are newly created absolute
    /// paths (copy targets). The watcher applies this idempotently, so a live FS event for the same
    /// change is a harmless no-op.
    /// </summary>
    public void NotifyDragDropReconciled(
        IReadOnlyList<(string From, string To)> moves,
        IReadOnlyList<string> additions)
    {
        if (moves.Count == 0 && additions.Count == 0)
        {
            return;
        }

        // Pure additions are modelled as moves with an empty source (OnFilesMoved skips the removal
        // for an empty From and just materializes the destination).
        var payload = new List<(string From, string To)>(moves.Count + additions.Count);
        payload.AddRange(moves);
        payload.AddRange(additions.Select(a => (string.Empty, a)));

        _projectEvents.PublishFilesMoved(new FilesMovedMessage(payload));
    }

    public void UnwatchProject() => _projectWatcher.UnwatchProject();

    public void CloseProject() => _projectWatcher.UnwatchProject();

    #endregion general commands

    #region red4

    private bool IsInArchiveFolder(FileSystemModel? model) =>
        ActiveProject is not null && model is not null && model.FullName.Contains(ActiveProject.ModDirectory);

    private bool IsInRawFolder(FileSystemModel? model) =>
        ActiveProject is not null && model is not null && model.FullName.Contains(ActiveProject.RawDirectory);

    private bool HasCorrespondingConvertFile(FileSystemModel? model)
    {
        if (model is null || ActiveProject is null)
        {
            return false;
        }

        if (IsInArchiveFolder(model))
        {
            return File.Exists(
                $"{model.FullName.Replace(ActiveProject.ModDirectory, ActiveProject.RawDirectory)}.json");
        }

        return IsInRawFolder(model) && model.FullName.EndsWith(".json") &&
               File.Exists(model.FullName.Replace(ActiveProject.RawDirectory, ActiveProject.ModDirectory)
                   .Replace("json", ""));
    }

    // If shift key is pressed, we want to convert any matching files in raw _from_ json
    private bool CanConvertGameFile() => ActiveProject is not null && SelectedItems is not null &&
                                         SelectedItems.All(x =>
                                             x is FileSystemModel { } m && IsInArchiveFolder(m) &&
                                             (!IsShiftKeyPressed || HasCorrespondingConvertFile(m)));

    [RelayCommand(CanExecute = nameof(CanConvertGameFile))]
    internal async Task ConvertArchiveFile()
    {
        if (SelectedItems is null)
        {
            return;
        }

        var selection = SelectedItems.NotNull().OfType<FileSystemModel>().Where(m => IsInArchiveFolder(m)).ToList();

        if (!IsShiftKeyPressed)
        {
            _deferredRefreshCts = new CancellationTokenSource();

            if (BeginDeferredRefreshContext == null)
            {
                if (TestHelper.InActiveTest)
                {
                    await ConvertToJsonInternal(selection);
                    return;
                }

                throw new Exception("Rendering context does not exist.");
            }

            await BeginDeferredRefreshContext(_deferredRefreshCts.Token, TimeSpan.FromSeconds(1.0 * selection.Count), ConvertToJsonInternal(selection));

            return;
        }

        var selectedItemPaths = selection
            .Select(x =>
                $"{x.FullName.Replace($"archive{Path.DirectorySeparatorChar}", $"raw{Path.DirectorySeparatorChar}")}.json")
            .ToList();

        var convertSelection = FileList
            .Where(x => selectedItemPaths.Contains(x.FullName) && File.Exists(x.FullName)).ToList();

        _deferredRefreshCts = new CancellationTokenSource();
        if (BeginDeferredRefreshContext == null)
        {
            throw new Exception("Rendering context does not exist.");
        }

        await BeginDeferredRefreshContext(_deferredRefreshCts.Token, TimeSpan.FromSeconds(3.0 * convertSelection.Count), ConvertToJsonInternal(convertSelection));
    }

    private async Task ConvertToJsonInternal(IEnumerable<FileSystemModel> selection)
    {
        SuspendFileWatcher();

        await Task.Run(async () =>
        {
            var allFiles = selection
                .SelectMany(item =>
                {
                    if (item.IsDirectory)
                    {
                        return Directory.EnumerateFiles(item.FullName, "*", SearchOption.AllDirectories);
                    }
                    return new[] { item.FullName };
                })
                .ToList();

            if (allFiles.Count == 0)
            {
                _progressService.Completed();
                return;
            }

            var validExtensions = Enum.GetNames<ERedExtension>()
                .Select(x => x.ToLowerInvariant())
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var createdJsonFiles = new ConcurrentBag<FileInfo>();

            int progress = 0;
            _progressService.Report(0);

            await Parallel.ForEachAsync(allFiles,
                new ParallelOptions
                {
                    MaxDegreeOfParallelism = Environment.ProcessorCount * 2,
                },
                async (file, ct) =>
                {
                    if (!File.Exists(file))
                    {
                        Interlocked.Increment(ref progress);
                        return;
                    }

                    var ext = Path.GetExtension(file).TrimStart('.').ToLowerInvariant();
                    if (!validExtensions.Contains(ext))
                    {
                        Interlocked.Increment(ref progress);
                        return;
                    }

                    try
                    {
                        var rawOutPath = Path.Combine(
                            ActiveProject.NotNull().RawDirectory,
                            ActiveProject.NotNull().GetRelativePath(file));

                        var outDirectoryPath = Path.GetDirectoryName(rawOutPath);

                        if (outDirectoryPath != null)
                        {
                            Directory.CreateDirectory(outDirectoryPath);

                            await _modTools.ConvertToJsonAndWriteAsync(
                                file,
                                new DirectoryInfo(outDirectoryPath));

                            var jsonFilePath = rawOutPath + ".json";

                            if (File.Exists(jsonFilePath))
                            {
                                var jsonFileInfo = new FileInfo(jsonFilePath);

                                if (_projectWatcher.FileLookup.ContainsKey(jsonFilePath))
                                {
                                    // don't add a duplicate file to the trees
                                    return;
                                }

                                createdJsonFiles.Add(jsonFileInfo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Failed to convert {file}: {ex.Message}");
                    }
                    finally
                    {
                        var currentProgress = Interlocked.Increment(ref progress);
                        _progressService.Report(currentProgress / (float)allFiles.Count);
                    }
                });

            _progressService.Completed();
            // Return list of created JSON files
            _projectEvents.PublishFilesImported(new FilesImportedMessage([],[.. createdJsonFiles.ToList()]));

            // Ensure any ObserveOn-scheduled handler + ProjectAdd dispatches have run to completion
            // (so FileList/FileTree clones are updated) before unblocking awaiters/tests.
            try
            {
                System.Windows.Application.Current?.Dispatcher?.Invoke(
                    () => { },
                    System.Windows.Threading.DispatcherPriority.ContextIdle);
            }
            catch { /* best effort for tests/headless */ }
        });

        await _deferredRefreshCts.CancelAsync();
        _deferredRefreshCts.Dispose();

        // Pair the SuspendFileWatcher (which locked the guard) with resume + force back to Ready.
        // This prevents the guard from being stranded in MakingChangesToFiles after a convert.
        ResumeFileWatcher();
    }

    /// <summary>
    /// Gathers all file paths from selected items, including files contained in all selected folders and subfolders.
    /// The resulting collection does not contain folders.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<string> EnumerateSelectedFilePaths()
    {
        if (SelectedItems is null)
        {
            return [];
        }

        return SelectedItems
            .Cast<FileSystemModel>()
            .SelectMany(x =>
                x.IsDirectory
                    ? new DirectoryInfo(x.FullName)
                        .EnumerateFiles("*", SearchOption.AllDirectories)
                        .Select(f => f.FullName)
                    : [x.FullName])
            .Distinct();
    }

    private bool CanExportSelection() => ActiveProject is not null && SelectedItems is not null &&
                                         SelectedItems.All(x =>
                                             x is FileSystemModel { } m &&
                                             IsInArchiveFolder(m)) &&
                                         EnumerateSelectedFilePaths().Any(ImportExportHelper.CanExportFilepath);

    [RelayCommand (CanExecute = nameof(CanExportSelection))]
    private async Task ExportArchiveFile(string useDefaultArgs)
    {
        if (!bool.TryParse(useDefaultArgs, out var useDefaultArgsBool))
        {
            throw new ArgumentException("useDefaultArgs must be a stringified boolean value");
        }

        var selectedFilePaths = EnumerateSelectedFilePaths()
            .Select(fp => fp.Replace($"{ActiveProject!.ModDirectory}{Path.DirectorySeparatorChar}", "")).ToArray();

        var ineligibleFilePaths = selectedFilePaths.Where(fp => !ImportExportHelper.CanExportFilepath(fp)).ToArray();
        var eligibleFilePaths = selectedFilePaths.Where(ImportExportHelper.CanExportFilepath).ToArray();

        if (ineligibleFilePaths.Length > 0)
        {
            var msg = $"The following files are not exportable and will be skipped:\n {string.Join(",\n", ineligibleFilePaths)}";
            _loggerService.Warning(msg);
            _notificationService.Warning(msg);
        }

        var exportArgs = new GlobalExportArgs();

        if (!_importExportHelper.Finalize(exportArgs))
        {
            const string msg = "Failed to initiate export arguments, aborting.";
            _loggerService.Error(msg);
            _notificationService.Error(msg);
        }

        if (!useDefaultArgsBool)
        {
            var displayExportArgs = new ExportArgsWrapper { Common = exportArgs.Get<CommonExportArgs>() };

            foreach (var filePath in eligibleFilePaths)
            {
                SetExportArgs(displayExportArgs, exportArgs, filePath);
            }

            var dialog = new ExportArgsDialogViewModel(_appViewModel, _archiveManager, _notificationService, displayExportArgs);
            await _appViewModel.SetActiveDialog(dialog);
            await dialog.WaitAsync();
            if (dialog.UserCanceled)
            {
                return;
            }
        }

        var exportTasks = eligibleFilePaths
            .Select(fp => _importExportHelper.Export(new FileInfo(Path.Join(ActiveProject!.ModDirectory, fp)),
                exportArgs,
                new DirectoryInfo(ActiveProject!.ModDirectory),
                new DirectoryInfo(ActiveProject!.RawDirectory)
                )).ToArray();

        await Task.WhenAll(exportTasks);
        _appViewModel.ReloadChangedFiles();

        List<string> failedPaths = [];

        for (var i = 0; i < exportTasks.Length; i++)
        {
            if (!exportTasks[i].Result)
            {
                failedPaths.Add(eligibleFilePaths[i]);
            }
        }

        if (failedPaths.Count == 0)
        {
            var s = exportTasks.Length > 1 ? "s" : "";
            var msg = $"Successfully exported {exportTasks.Length} file{s}";
            _loggerService.Success(msg);
            _notificationService.Success(msg);
        }
        else
        {
            var s = failedPaths.Count > 1 ? "s" : "";
            var msg = $"Failed to export the following {failedPaths.Count} file{s}:\n {string.Join(",\n", failedPaths)}";
            _loggerService.Error(msg);
            _notificationService.Error(msg);
        }

        void SetExportArgs(ExportArgsWrapper displayArgs, GlobalExportArgs args, string fileName)
        {
            var extension = Path.GetExtension(fileName).TrimStart('.');
            if (!Enum.TryParse(extension, out ECookedFileFormat fileFormat))
            {
                return;
            }

            switch (fileFormat)
            {
                case ECookedFileFormat.opusinfo:
                    if (displayArgs.Opus != null)
                    {
                        break;
                    }

                    displayArgs.Opus = args.Get<OpusExportArgs>();
                    break;
                case ECookedFileFormat.mesh:
                case ECookedFileFormat.w2mesh:
                    if (displayArgs.Mesh != null)
                    {
                        break;
                    }

                    displayArgs.Mesh = args.Get<MeshExportArgs>();
                    break;
                case ECookedFileFormat.xbm:
                    if (displayArgs.Xbm != null)
                    {
                        break;
                    }

                    displayArgs.Xbm = args.Get<XbmExportArgs>();
                    break;
                case ECookedFileFormat.wem:
                    if (displayArgs.Wem != null)
                    {
                        break;
                    }

                    displayArgs.Wem = args.Get<WemExportArgs>();
                    break;
                case ECookedFileFormat.mlmask:
                    if (displayArgs.Mlmask != null)
                    {
                        break;
                    }

                    displayArgs.Mlmask = args.Get<MlmaskExportArgs>();
                    break;
                case ECookedFileFormat.fnt:
                    if (displayArgs.Fnt != null)
                    {
                        break;
                    }

                    displayArgs.Fnt = args.Get<FntExportArgs>();
                    break;
                case ECookedFileFormat.morphtarget:
                    if (displayArgs.MorphTarget != null)
                    {
                        break;
                    }

                    displayArgs.MorphTarget = args.Get<MorphTargetExportArgs>();
                    break;
                case ECookedFileFormat.anims:
                    if (displayArgs.Animation != null)
                    {
                        break;
                    }

                    displayArgs.Animation = args.Get<AnimationExportArgs>();
                    break;
                case ECookedFileFormat.inkatlas:
                    if (displayArgs.InkAtlas != null)
                    {
                        break;
                    }

                    displayArgs.InkAtlas = args.Get<InkAtlasExportArgs>();
                    break;
                case ECookedFileFormat.physicalscene:
                    if (displayArgs.Mesh != null)
                    {
                        break;
                    }

                    displayArgs.Mesh = args.Get<MeshExportArgs>();
                    break;
            }
        }
    }

    private bool CanImportRawFile() =>  ActiveProject is not null && SelectedItems is not null &&
                                            SelectedItems.All(x =>
                                                x is FileSystemModel m && IsInRawFolder(m)) &&
                                            EnumerateSelectedFilePaths().Any(ImportExportHelper.CanImportFilepath);

    [RelayCommand (CanExecute = nameof(CanImportRawFile))]
    private async Task ImportRawFile(string useDefaultArgs)
    {
        if (!bool.TryParse(useDefaultArgs, out var useDefaultArgsBool))
        {
            throw new ArgumentException("useDefaultArgs must be a stringified boolean value");
        }

        var selectedFilePaths = EnumerateSelectedFilePaths()
            .Select(fp => fp.Replace($"{ActiveProject!.RawDirectory}{Path.DirectorySeparatorChar}", ""))
            .Distinct().ToArray();

        var ineligibleFilePaths = selectedFilePaths.Where(fp => !ImportExportHelper.CanImportFilepath(fp) && !fp.ToLowerInvariant().EndsWith(".material.json")).ToArray();
        var eligibleFilePaths = selectedFilePaths.Where(ImportExportHelper.CanImportFilepath).ToArray();

        if (ineligibleFilePaths.Length > 0)
        {
            var msg = $"The following files are not importable and will be skipped:\n {string.Join(",\n", ineligibleFilePaths)}";
            _loggerService.Warning(msg);
            _notificationService.Warning(msg);
        }

        var importArgs = new GlobalImportArgs();

        if (!useDefaultArgsBool)
        {
            var displayImportArgs = new ImportArgsWrapper { Common = importArgs.Get<CommonImportArgs>() };

            foreach (var filePath in eligibleFilePaths)
            {
                SetImportArgs(displayImportArgs, importArgs, filePath);
            }

            var dialog = new ImportArgsDialogViewModel(_appViewModel, displayImportArgs);
            await _appViewModel.SetActiveDialog(dialog);
            await dialog.WaitAsync();
            if (dialog.UserCanceled)
            {
                return;
            }
        }

        var importTasks = eligibleFilePaths
            .Select(fp =>
            {
                var instanceImportArgs = importArgs;
                // ReSharper disable InvertIf
                if (fp.ToLowerInvariant().EndsWith(".glb"))
                {
                    var guessedImportFormat = ModTools.GltfImportAsFormatFromFileExt(fp);
                    if (guessedImportFormat is { } extBasedFormat && importArgs.Get<GltfImportArgs>().ImportFormat != extBasedFormat)
                    {
                        instanceImportArgs = DeepCopyGlbArgs(importArgs);
                        instanceImportArgs.Get<GltfImportArgs>().ImportFormat = extBasedFormat;
                    }
                }
                // ReSharper restore InvertIf
                return _importExportHelper.Import(
                    new RedRelativePath(new DirectoryInfo(ActiveProject!.RawDirectory), fp),
                    instanceImportArgs,
                    new DirectoryInfo(ActiveProject!.ModDirectory)
                );
            }).ToArray();

        await Task.WhenAll(importTasks);
        _appViewModel.ReloadChangedFiles();

        List<string> failedPaths = [];

        for (var i = 0; i < importTasks.Length; i++)
        {
            if (!importTasks[i].Result)
            {
                failedPaths.Add(eligibleFilePaths[i]);
            }
        }

        if (failedPaths.Count == 0)
        {
            var s = importTasks.Length > 1 ? "s" : "";
            var msg = $"Successfully imported {importTasks.Length} file{s}";
            _loggerService.Success(msg);
            _notificationService.Success(msg);
        }
        else
        {
            var s = failedPaths.Count > 1 ? "s" : "";
            var msg = $"Failed to import the following {failedPaths.Count} file{s}:\n {string.Join(",\n", failedPaths)}";
            _loggerService.Error(msg);
            _notificationService.Error(msg);
        }

        GlobalImportArgs DeepCopyGlbArgs(GlobalImportArgs args)
        {
            var newArgs = new GlobalImportArgs();

            newArgs.Register([
                args.Get<CommonImportArgs>(),
                args.Get<XbmImportArgs>(),
                JsonSerializer.Deserialize<GltfImportArgs>(JsonSerializer.Serialize(args.Get<GltfImportArgs>()))!,
                args.Get<OpusImportArgs>(),
                args.Get<MlmaskImportArgs>(),
                args.Get<ReImportArgs>(),
                args.Get<FntImportArgs>()
            ]);

            return newArgs;
        }

        void SetImportArgs(ImportArgsWrapper displayArgs, GlobalImportArgs args, string filePath)
        {
            var extension = Path.GetExtension(filePath).TrimStart('.');
            if (!Enum.TryParse(extension, out ERawFileFormat rawFileFormat))
            {
                return;
            }

            switch (rawFileFormat)
            {
                case ERawFileFormat.tga:
                case ERawFileFormat.bmp:
                case ERawFileFormat.jpg:
                case ERawFileFormat.png:
                case ERawFileFormat.tiff:
                case ERawFileFormat.dds:
                case ERawFileFormat.cube:
                    if (displayArgs.Xbm != null)
                    {
                        break;
                    }

                    displayArgs.Xbm = args.Get<XbmImportArgs>();
                    break;
                case ERawFileFormat.glb:
                case ERawFileFormat.gltf:
                    if (displayArgs.Gltf != null)
                    {
                        break;
                    }

                    displayArgs.Gltf = args.Get<GltfImportArgs>();
                    break;
                case ERawFileFormat.ttf:
                    if (displayArgs.Fnt != null)
                    {
                        break;
                    }

                    displayArgs.Fnt = args.Get<FntImportArgs>();
                    break;
                case ERawFileFormat.wav:
                    if (displayArgs.Opus != null)
                    {
                        break;
                    }

                    displayArgs.Opus = args.Get<OpusImportArgs>();
                    break;
                case ERawFileFormat.masklist:
                    if (displayArgs.Mlmask != null)
                    {
                        break;
                    }

                    displayArgs.Mlmask = args.Get<MlmaskImportArgs>();
                    break;
                case ERawFileFormat.re:
                    if (displayArgs.Re != null)
                    {
                        break;
                    }

                    displayArgs.Re = args.Get<ReImportArgs>();
                    break;
            }
        }
    }

    // If shift key is pressed, we want to convert any matching files in archive _to_ json
    private bool CanConvertRawFile() => ActiveProject is not null && SelectedItems is not null &&
                                        SelectedItems.All(x =>
                                            x is FileSystemModel m && IsInRawFolder(m) &&
                                            (!IsShiftKeyPressed || HasCorrespondingConvertFile(m)));

    [RelayCommand(CanExecute = nameof(CanConvertRawFile))]
    private async Task ConvertRawFile()
    {
        if (!IsShiftKeyPressed)
        {
            _deferredRefreshCts = new CancellationTokenSource();
            if (BeginDeferredRefreshContext == null)
            {
                throw new Exception("Rendering context does not exist.");
            }

            await BeginDeferredRefreshContext(
                _deferredRefreshCts.Token,
                TimeSpan.FromSeconds(3.0 * SelectedItems!.Count),
                ConvertFromJsonInternal(SelectedItems!.OfType<FileSystemModel>().Where(IsInRawFolder))
            );

            return;
        }

        var selectedItemPaths = SelectedItems.NotNull().OfType<FileSystemModel>()
            .Select(x => $"{x.GameRelativePath}".Replace(".json", "")).ToList();

        var convertSelection = FileList
            .Where(IsInArchiveFolder)
            .Where(x => selectedItemPaths.Contains(x.GameRelativePath)).ToList();

        _deferredRefreshCts = new CancellationTokenSource();
        if (BeginDeferredRefreshContext == null)
        {
            throw new Exception("Rendering context does not exist.");
        }

        await BeginDeferredRefreshContext(
            _deferredRefreshCts.Token,
            TimeSpan.FromSeconds(3.0 * convertSelection.Count),
            ConvertFromJsonInternal(convertSelection)
        );
    }

    // TODO: Refactor this method to use PublishFilesImported rather than relying on WatcherService.
    private async Task ConvertFromJsonInternal(IEnumerable<FileSystemModel> selection)
    {
        _projectWatcher.Resume();

        var progress = 0;
        _progressService.Report(0);

        List<string> files = new();
        // get all files
        foreach (var item in selection)
        {
            if (item.IsDirectory)
            {
                files.AddRange(Directory.GetFiles(item.FullName, "*.json", SearchOption.AllDirectories)
                    .Where(name => !name.EndsWith(".Material.json")));
            }
            else
            {
                files.Add(item.FullName);
            }
        }

        // convert files
        foreach (var file in files)
        {
            await ConvertFromJsonAsync(file);

            progress++;
            _progressService.Report(progress / (float)files.Count);
        }

        _progressService.Completed();
    }

    private async Task ConvertFromJsonAsync(string file)
    {
        if (!File.Exists(file))
        {
            return;
        }

        if (Path.GetExtension(file).TrimStart('.').ToLower() != ETextConvertFormat.json.ToString())
        {
            return;
        }

        var modPath = Path.Combine(ActiveProject.NotNull().ModDirectory, ActiveProject!.GetRelativePath(file));
        var outDirectoryPath = Path.GetDirectoryName(modPath);
        if (outDirectoryPath is null)
        {
            return;
        }

        Directory.CreateDirectory(outDirectoryPath);

        try
        {
            await _modTools.ConvertFromJsonAndWriteAsync(new FileInfo(file), new DirectoryInfo(outDirectoryPath));
        }
        catch (JsonException err)
        {
            if (err.Message.Contains(" | LineNumber"))
            {
                _loggerService.Error($"Failed to parse JSON in {file}.");
                _loggerService.Error($"The error is in LineNumber{err.Message.Split(" | LineNumber").LastOrDefault()}");
            }
            else
            {
                _loggerService.Error($"Something went _really_ wrong when trying to parse {file}:");
                throw;
            }
        }

        _appViewModel.ReloadChangedFiles();

    }

    /// <summary>
    /// Opens selected node in asset browser.
    /// </summary>
    private bool CanOpenInAssetBrowser() => ActiveProject != null && SelectedItem is { IsDirectory: false };
    [RelayCommand(CanExecute = nameof(CanOpenInAssetBrowser))]
    private void OpenInAssetBrowser()
    {
        _appViewModel.NotNull().GetToolViewModel<AssetBrowserViewModel>().IsVisible = true;
        _appViewModel.GetToolViewModel<AssetBrowserViewModel>().ShowFile(SelectedItem.NotNull());
    }

    private static string GetSecondExtension(FileSystemModel model) => Path.GetExtension(Path.ChangeExtension(model.FullName, "").TrimEnd('.')).TrimStart('.');

    private bool IsMlSetup(FileSystemModel? model)
    {
        if (model is null || model.IsDirectory)
        {
            return false;
        }

        if (IsInArchiveFolder(model))
        {
            return model.Extension.ToLower().Equals(ERedExtension.mlsetup.ToString(), StringComparison.Ordinal);
        }

        return IsInRawFolder(model) && model.Extension.ToLower()
            .Equals(ETextConvertFormat.json.ToString(), StringComparison.Ordinal) && GetSecondExtension(model)
            .Equals(ERedExtension.mlsetup.ToString(), StringComparison.Ordinal);

    }

    private bool CanOpenInMlsb() => ActiveProject != null && IsMlSetup(SelectedItem)
                                                          && PluginService.IsInstalled(EPlugin.mlsetupbuilder);

    [RelayCommand(CanExecute = nameof(CanOpenInMlsb))]
    private async Task OpenInMlsb()
    {
        if (!PluginService.TryGetInstallPath(EPlugin.mlsetupbuilder, out var path) || SelectedItem is null)
        {
            return;
        }

        if (!Directory.Exists(path))
        {
            _loggerService.Error($"MlSetupBuilder not found: {path}");
            return;
        }

        var firstFolder = Directory.GetDirectories(path).FirstOrDefault();
        if (firstFolder is null)
        {
            _loggerService.Error($"MlSetupBuilder not found: {path}");
            return;
        }

        var exe = Path.Combine(firstFolder, "MlSetupBuilder.exe");

        if (!File.Exists(exe))
        {
            _loggerService.Error($"MlSetupBuilder.exe not found: {exe}");
            return;
        }

        var filepath = SelectedItem.FullName;
        if (IsInArchiveFolder(SelectedItem))
        {
            if (ActiveProject is null)
            {
                return;
            }

            filepath = $"{filepath.Replace(ActiveProject.ModDirectory, ActiveProject.RawDirectory)}.json";

            // If file exists: Ask if user wants to re-export it (Hold shift to skip)
            if (!File.Exists(filepath) || (!IsShiftKeyPressed && File.Exists(filepath) &&
                                           Interactions.ShowQuestionYesNo(("Export again (and overwrite)?",
                                               "File already exists"))))
            {
                await ConvertToJsonInternal([SelectedItem]);
            }
        }

        var version = _settingsManager.GetVersionNumber();
        try
        {
            var args = $"-o=\"{filepath}\" -wkit=\"{version}\"";
            _loggerService.Info($"executing: {Path.GetFileName(exe)} {args}");
            Process.Start(exe, args);
        }
        catch (Exception ex)
        {
            _loggerService.Error(ex);
        }
    }

    #endregion

    public event EventHandler? OnToggleFlatMode;

    /// <summary>
    /// Event for `isLoading` and `isReload`.
    /// The latter will be true if the user clicked the "reload" button.
    /// It will be false if the user has loaded a fresh project or changed projects.
    /// </summary>
    public event EventHandler<(bool, bool)>? OnSetLoading;

    [RelayCommand(CanExecute = nameof(CanOpenInFileExplorer))]
    private void ToggleFlatMode() => OnToggleFlatMode?.Invoke(this, EventArgs.Empty);

    #endregion commands

    #region Methods

    public AppViewModel GetAppViewModel() => _appViewModel;

    /// <summary>
    /// Initialize Avalondock specific defaults that are specific to this tool window.
    /// </summary>
    private void SetupToolDefaults() =>
        ContentId = s_toolContentId;
    // Define a unique contentId for this toolwindow
    //BitmapImage bi = new BitmapImage();
    // Define an icon for this toolwindow
    // bi.BeginInit();
    // bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");
    // bi.EndInit();
    // IconSource = bi;


    private void LoadExpansionStateDictionary(Cp77Project project)
    {
        var projectName = Path.GetFileNameWithoutExtension(project.Location);
        if (File.Exists(project.InterfaceProjectTreeStatePath))
        {
            _hasUnsavedFileTreeChanges = false;
            ExpansionStateDictionary =
                JsonSerializer.Deserialize<Dictionary<string, bool>>(
                    File.ReadAllText(project.InterfaceProjectTreeStatePath)) ?? [];
        }
        else
        {
            ExpansionStateDictionary = [];
        }
    }

    private void RestoreProjectState(Cp77Project project)
    {
        // Abort if user doesn't want to reopen any files
        if (!_settingsManager.ReopenFiles || _settingsManager.NumFilesToReopen == 0 ||
            project.OpenProjectFiles.Count == 0)
        {
            return;
        }

        var lastFilePaths = project.OpenProjectFiles
            .OrderBy(x => x.Key) // order by timestamp
            .Select(x => x.Value) // select relative file path
            .Select(project.GetAbsolutePath)
            .Where(File.Exists)
            .Distinct()
            .TakeLast(_settingsManager.NumFilesToReopen)
            .ToList();

        foreach (var path in lastFilePaths)
        {
            _appViewModel.RequestFileOpen(path);
        }
    }

    private async void SaveOpenFilePaths()
    {
        try
        {
            if (ActiveProject is not Cp77Project project)
            {
                return;
            }

            var openProjectFiles = _appViewModel.DockedViews.OfType<IDocumentViewModel>()
                .Where(x => x.FilePath is not null)
                .OrderBy(x => x.OpenedAt)
                .DistinctBy(x => x.FilePath)
                .ToDictionary(x => x.OpenedAt, x => project.GetRelativePath(x.FilePath!));

            // only write if we had a change
            if (project.OpenProjectFiles.Equals(openProjectFiles))
            {
                return;
            }

            project.OpenProjectFiles = openProjectFiles;

            await _projectManager.SaveAsync();
        }
        catch
        {
            // guess we're not saving
        }
    }

    public void SaveProjectExplorerTabIfDirty()
    {
        if (!_projectExplorerTabChanged)
        {
            return;
        }

        _projectManager.SaveAsync();
        _projectExplorerTabChanged = false;
    }

    private void SaveProjectExplorerExpansionStateIfDirty() => SaveProjectExplorerExpansionStateIfDirty(ActiveProject);

    private void SaveProjectExplorerExpansionStateIfDirty(Cp77Project? project)
    {
        if (project is null || !_hasUnsavedFileTreeChanges)
        {
            return;
        }

        // Rebuild from live models in FileList — this is cheap and survives ReplaceAll rebuilds
        RebuildExpansionStateFromFileList();

        File.WriteAllText(project.InterfaceProjectTreeStatePath, JsonSerializer.Serialize(ExpansionStateDictionary));
        _hasUnsavedFileTreeChanges = false;
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(State) when State == DockState.Hidden:
                IsVisible = false;
                break;
            case nameof(SelectedTabIndex) when ActiveProject is not null:
                ActiveProject.ActiveTab = SelectedTabIndex;
                _projectExplorerTabChanged = true;
                break;
        }

        base.OnPropertyChanged(e);
    }

    #endregion Methods

    #region ModifierStateAwareness

    /// <summary>
    /// Reacts to ModifierViewStatesModel's emitted events
    /// </summary>
    private void OnModifierUpdateEvent()
    {
        IsShowAbsolutePathToRawFolder = ModifierStateService.IsCtrlShiftOnlyPressed
                                        && IsInArchiveFolder(SelectedItem);

        IsShowAbsolutePathToArchiveFolder = ModifierStateService.IsCtrlShiftOnlyPressed
                                            && IsInRawFolder(SelectedItem);

        IsShowAbsolutePathToCurrentFile = ModifierStateService.IsShiftKeyPressedOnly;

        IsShowAbsolutePathToCurrentFolder = ModifierStateService.IsCtrlKeyPressedOnly;

        IsShowRelativePath = !(IsShowAbsolutePathToRawFolder || IsShowAbsolutePathToArchiveFolder ||
                               IsShowAbsolutePathToCurrentFile || IsShowAbsolutePathToCurrentFolder) ||
                             ModifierViewStateService.IsNoModifierBeingHeld;

        IsShiftKeyPressed = ModifierViewStateService.IsShiftBeingHeld;
    }

    public IDocumentViewModel? GetActiveEditorFile() => _appViewModel.ActiveDocument;

    #endregion

    public void SaveNodeExpansionState(string rawRelativePath, bool expansionState)
    {
        ExpansionStateDictionary[rawRelativePath] = expansionState;
        _hasUnsavedFileTreeChanges = true;
    }

    /// <summary>
    /// Used by the internal WatcherService when rebuilding the tree to restore previous expansion state onto new model instances.
    /// </summary>
    internal bool GetDesiredExpansionState(string rawRelativePath)
        => ExpansionStateDictionary.TryGetValue(rawRelativePath, out var state) ? state : false;

    /// <summary>
    /// Rebuilds the expansion state dictionary directly from the current models in FileList.
    /// This is robust after tree rebuilds because FileList holds references to the live FileSystemModel instances.
    /// </summary>
    internal void RebuildExpansionStateFromFileList()
    {
        ExpansionStateDictionary = FileList
            .Where(m => m.IsDirectory)
            .ToDictionary(m => m.RawRelativePath, m => m.IsExpanded, StringComparer.OrdinalIgnoreCase);
        _hasUnsavedFileTreeChanges = true;
    }

    /// <summary>
    /// Called by the View when the user expands a directory node.
    /// This is the primary path for dirty tracking expansion state.
    /// </summary>
    public void NotifyDirectoryExpanded(FileSystemModel model)
    {
        if (model is { IsDirectory: true })
        {
            model.IsExpanded = true;
            SaveNodeExpansionState(model.RawRelativePath, true);
        }
    }

    /// <summary>
    /// Called by the View when the user collapses a directory node.
    /// This is the primary path for dirty tracking expansion state.
    /// </summary>
    public void NotifyDirectoryCollapsed(FileSystemModel model)
    {
        if (model is { IsDirectory: true })
        {
            model.IsExpanded = false;
            SaveNodeExpansionState(model.RawRelativePath, false);
        }
    }

    public void SuspendFileWatcher()
    {
        if (ActiveProject is not Cp77Project project)
        {
            return;
        }

        try
        {
            _projectWatcher.Suspend();
        }
        catch
        {
            _loggerService.Error("Failed to suspend file watcher. Please ignore any errors.");
        }
    }

    public void OnKeyStateChanged(KeyEventArgs e)
    {
        if (e.Key == Key.W && (e.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0)
        {
            _appViewModel.CloseLastActiveDocument();
            return;
        }

        ModifierStateService.OnKeystateChanged(e);
    }
}
