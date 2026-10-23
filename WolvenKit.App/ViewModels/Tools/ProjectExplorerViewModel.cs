using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

    public bool IsDragging { get; set; } = false;

    /// <summary>
    /// Identifies the caption string used for this tool window.
    /// </summary>
    private const string s_toolTitle = "Project Explorer";

    public const string LoadProjectPurpose = "ProjectExplorer load project";

    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly IProjectManager _projectManager;
    private readonly IModTools _modTools;
    private readonly IProgressService<double> _progressService;
    private readonly IGameControllerFactory _gameController;
    private readonly AppViewModel _appViewModel;
    public readonly IModifierViewStateService ModifierStateService;
    private readonly IProjectEvents _projectEvents;

    private DispatcherHelper.RepeatingActionHandle? _autoSaveCancelToken;

    /// <summary>
    /// Autosave is per view model, so it gets a purpose unique to this instance. A shared
    /// purpose would let a second Project Explorer either collide with, or silently inherit,
    /// the first instance's autosave callback.
    /// </summary>
    private readonly string _autoSavePurpose = $"ProjectExplorer autosave {Guid.NewGuid():N}";

    /// <summary>
    /// Live claim on the project-load progress heartbeat, or null when no load is in flight.
    /// Owned here rather than on the watcher: the view model is what arms and disarms it.
    /// </summary>
    private DispatcherHelper.RepeatingActionHandle? _loadingIndicatorHandle;

    private readonly ISettingsManager _settingsManager;
    private readonly IArchiveManager _archiveManager;
    private readonly ProjectResourceTools _projectResourceTools;

    private readonly ImportExportHelper _importExportHelper;
    private readonly TimeSpan _projectLoadPollingInterval = TimeSpan.FromMilliseconds(50);

    public DispatchedObservableCollection<FileSystemModel> FileList { get; } = new();
    public DispatchedObservableCollection<FileSystemModel> FileTree { get; } = new();

    public Func<Func<Task>, Task>? BeginDeferredRefreshContext { get; set; }

    public Dictionary<string, bool> ExpansionStateDictionary { get; set; } = [];

    public bool IsKeyUpEventAssigned { get; set; }

    #endregion fields

    #region constructor

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

        SideInDockedMode = DockSide.Left;

        IsShowRelativePath = true;
        ModifierStateService.ModifierStateChanged += OnModifierUpdateEvent;

        SetupToolDefaults();

        _appViewModel.PropertyChanged += AppViewModelOnPropertyChanged;
        _appViewModel.OpenDocumentChanged += OnOpenDocumentChanged;

        SelectedTabIndex = ActiveProject?.ActiveTab ?? 0;

        _autoSaveCancelToken = null;
        _appViewModel.OnInitialProjectLoaded += AppViewModel_OnInitialProjectLoaded;

        InitializeProjectWatcher();

        DispatcherHelper.StopRepeatingAction(_autoSaveCancelToken);
        _autoSaveCancelToken = DispatcherHelper.StartRepeatingAction(
            purpose: _autoSavePurpose, () => Svc_ThreadIdleTenSeconds(null, EventArgs.Empty),
            TimeSpan.FromSeconds(10));

        s_instance = this;
    }

    #endregion constructor

    #region properties

    [ObservableProperty]
    private LoadingMode _currentLoadingMode;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private IPluginService _pluginService;

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
    private ObservableCollection<object>? _treeSelectedItems = new();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertRawFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ExportArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ImportRawFileCommand))]
    private ObservableCollection<object>? _flatSelectedItems = new();

    /// <summary>
    /// The selection of whichever grid is on screen.
    /// </summary>
    public ObservableCollection<object>? SelectedItems => IsFlatModeEnabled ? FlatSelectedItems : TreeSelectedItems;

    partial void OnTreeSelectedItemsChanged(ObservableCollection<object>? value) =>
        OnPropertyChanged(nameof(SelectedItems));

    partial void OnFlatSelectedItemsChanged(ObservableCollection<object>? value) =>
        OnPropertyChanged(nameof(SelectedItems));

    [ObservableProperty] private bool _isFlatModeEnabled;

    partial void OnIsFlatModeEnabledChanged(bool value)
    {
        // SelectedItems resolves to the other grid's collection
        OnPropertyChanged(nameof(SelectedItems));

        DeleteFileCommand.NotifyCanExecuteChanged();
        ConvertArchiveFileCommand.NotifyCanExecuteChanged();
        ConvertRawFileCommand.NotifyCanExecuteChanged();
        ExportArchiveFileCommand.NotifyCanExecuteChanged();
        ImportRawFileCommand.NotifyCanExecuteChanged();
    }

    [ObservableProperty] private int _selectedTabIndex;

    [ObservableProperty] private bool _canScrollToOpenFile;

    [ObservableProperty] private bool _hasSelectedItem;

    private bool _loading;

    public bool Loading
    {
        get => _loading;
        set
        {
            _loading = value;
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(_loading)));
        }
    }

    #endregion properties

    #region commands

    #region general commands

    /// <summary>
    /// Refreshes all files in the Grid
    /// </summary>
    private bool CanRefresh() => ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanRefresh))]
    private void Refresh()
    {
        EnableLoadingMode(LoadingMode.ReloadingSameProject);

        if (IsWatcherStopped)
        {
            ResumeFileWatcher();
        }
        else
        {
            RefreshWatcher();
        }

        DisableLoadingMode();
    }

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
    private void DeleteFile()
    {
        var selected = SelectedItems.NotNull().OfType<FileSystemModel>().ToList();
        var delete = Interactions.DeleteFiles(selected.Select(d => d.Name));
        if (!delete)
        {
            return;
        }

        DeleteRecursively(selected);
    }

    private void DeleteRecursively(List<FileSystemModel> selected)
    {
        foreach (var item in selected)
        {
            var fullPath = item.FullName;
            try
            {
                if (item.IsDirectory)
                {
                    if (
                        item.FullName == ActiveProject!.ModDirectory ||
                        item.FullName == ActiveProject!.RawDirectory ||
                        item.FullName == ActiveProject!.ResourcesDirectory
                    )
                    {
                        var children = item.Children.ToList();
                        DeleteRecursively(children);
                        continue;
                    }

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
        if (_projectManager.ActiveProject is null || SelectedItem?.FullName is not string absolutePath)
        {
            return;
        }

        var (prefixPath, relativePath) = _projectManager.ActiveProject.SplitFilePath(absolutePath);

        if (absolutePath.StartsWith(_projectManager.ActiveProject.ModDirectory))
        {
            relativePath = absolutePath[(_projectManager.ActiveProject.ModDirectory.Length + 1)..];
        }

        var (newRelativePath, refactor) = Interactions.RenameAndRefactor((
            relativePath,
            absolutePath.StartsWith(_projectManager.ActiveProject.ModDirectory)
        ));

        if (string.IsNullOrEmpty(newRelativePath) || newRelativePath == relativePath)
        {
            return;
        }

        await _projectResourceTools.MoveAndRefactorAsync(relativePath, newRelativePath, prefixPath, refactor);
        _appViewModel.ReloadChangedFiles();
    }


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
            if (BeginDeferredRefreshContext == null)
            {
                await ConvertToJsonInternal(selection);
                return;
            }

            await BeginDeferredRefreshContext(() => ConvertToJsonInternal(selection));

            return;
        }

        var selectedItemPaths = selection
            .Select(x =>
                $"{x.FullName.Replace($"archive{Path.DirectorySeparatorChar}", $"raw{Path.DirectorySeparatorChar}")}.json")
            .ToList();

        var convertSelection = FileList
            .Where(x => selectedItemPaths.Contains(x.FullName) && File.Exists(x.FullName)).ToList();

        if (BeginDeferredRefreshContext == null)
        {
            await ConvertToJsonInternal(selection);
            return;
        }

        await BeginDeferredRefreshContext(() => ConvertToJsonInternal(convertSelection));
    }

    private async Task ConvertToJsonInternal(IEnumerable<FileSystemModel> selection)
    {
        var createdJsonFiles = new ConcurrentBag<FileInfo>();

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

                                if (FileLookup.ContainsKey(jsonFilePath))
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
        });

        _ = Task.Run(() =>
        {
            var logMsg = "";

            createdJsonFiles.ToList().ForEach(file =>
            {
                logMsg += $"JSON file converted: ${file.FullName}.\r\n";
            });

            _loggerService.Info(logMsg);
        });
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
    internal async Task ConvertRawFile()
    {
        if (!IsShiftKeyPressed)
        {
            var selection = SelectedItems!.OfType<FileSystemModel>().Where(IsInRawFolder).ToList();
            EnableLoadingMode(LoadingMode.ShowLoadingDuringOperation);

            if (BeginDeferredRefreshContext == null)
            {
                await ConvertFromJsonInternal(selection);
                return;
            }

            await BeginDeferredRefreshContext(() => ConvertFromJsonInternal(selection));
            DisableLoadingMode();
            return;
        }

        var selectedItemPaths = SelectedItems.NotNull().OfType<FileSystemModel>()
            .Select(x => $"{x.GameRelativePath}".Replace(".json", "")).ToList();

        var convertSelection = FileList
            .Where(IsInArchiveFolder)
            .Where(x => selectedItemPaths.Contains(x.GameRelativePath)).ToList();

        EnableLoadingMode(LoadingMode.ShowLoadingDuringOperation);

        if (BeginDeferredRefreshContext == null)
        {
            await ConvertFromJsonInternal(convertSelection);
            return;
        }

        await BeginDeferredRefreshContext(() => ConvertFromJsonInternal(convertSelection));
        DisableLoadingMode();
    }

    private async Task ConvertFromJsonInternal(IEnumerable<FileSystemModel> selection)
    {
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

    public event Action? OnProjectChanged;

    /// <summary>
    /// Event for `isLoading` and `isReload`.
    /// The latter will be true if the user clicked the "reload" button.
    /// It will be false if the user has loaded a fresh project or changed projects.
    /// </summary>
    public event EventHandler<LoadingMode>? OnSetLoading;

    /// <summary>
    /// Gets called when we add files to the tree, so that
    /// auto-expansion can occur in the view.
    /// </summary>
    public event Action<FileSystemModel>? OnFileMaterialized;

    [RelayCommand(CanExecute = nameof(CanOpenInFileExplorer))]
    private void ToggleFlatMode() => OnToggleFlatMode?.Invoke(this, EventArgs.Empty);

    #endregion commands

    #region Methods

    #region accessors

    public IDocumentViewModel? GetActiveEditorFile() => _appViewModel.ActiveDocument;

    public AppViewModel GetAppViewModel() => _appViewModel;

    #endregion

    #region responders

    /// <summary>
    /// Whenever the document changes, save open file paths to <see cref="Cp77Project.ProjectFileExtension"/> file
    /// </summary>
    private void OnOpenDocumentChanged(object? sender, EventArgs e) => SaveOpenFilePaths();

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
            case nameof(SelectedItem) when ActiveProject is not null:
            case nameof(SelectedItems) when ActiveProject is not null:
                if (IsDragging)
                {
                    return;
                }

                break;
        }

        base.OnPropertyChanged(e);
    }

    /// <summary>
    /// Set status of "scroll to open file" button (disable if we don't have one open)
    /// </summary>
    private void AppViewModelOnPropertyChanged(object? sender, PropertyChangedEventArgs e) =>
        CanScrollToOpenFile = HasSelectedItem && _appViewModel.ActiveDocument is not null;

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

    #endregion

    #region Project_Loading

    // When opening projects from launch args, change detection for dependent objects isn't working yet.
    private void RefreshProjectData()
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            // Save changes in active project
            if (ActiveProject != null)
            {
                _hasUnsavedFileTreeChanges = true;
                SaveProjectExplorerExpansionStateIfDirty();
                UnwatchProject(ActiveProject);
            }

            if (ActiveProject?.Equals(_projectManager.ActiveProject) == true)
            {
                OnProjectChanged?.Invoke();

                return;
            }
            ActiveProject = _projectManager.ActiveProject;
            if (ActiveProject is not null)
            {
                RestoreProjectState(ActiveProject);
                WatchProject(ActiveProject);
            }

            OnProjectChanged?.Invoke();
            _progressService.IsIndeterminate = false;
        }, DispatcherPriority.ContextIdle);
    }

    /// <summary>
    /// Announces that a different project is about to load: flushes the outgoing project's state
    /// and arms the loading chrome. Must be called before the project manager swaps its active
    /// project, or the outgoing state is saved against the incoming one.
    ///
    /// Idempotent — the welcome page arms the chrome on click for responsiveness and the load path
    /// announces the same load again; only the first call flushes.
    /// </summary>
    public void ProjectWillLoad(string projectPath)
    {
        if (CurrentLoadingMode == LoadingMode.LoadingNewProject)
        {
            return;
        }

        if (ActiveProject != null)
        {
            if (IsSameProjectPath(ActiveProject, projectPath))
            {
                return;
            }

            SaveProjectState();
        }

        EnableLoadingMode(LoadingMode.LoadingNewProject);
    }

    /// <summary>
    /// Clears project-load loading chrome without reporting a successful load.
    /// Use on cancel / failed open / same-project no-op after ProjectWillLoad armed the UI.
    /// </summary>
    public void CancelProjectLoad() => DisableLoadingMode(reportResult: false);

    private void AppViewModel_OnInitialProjectLoaded(object? sender, EventArgs e)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            try
            {
                // Enable Loading... indicator if the project dir has changed and the
                // indicator is not already being shown.
                if (_projectManager.ActiveProject?.ProjectDirectory is { } newProjectDir
                    && newProjectDir != ActiveProject?.ProjectDirectory
                    && CurrentLoadingMode != LoadingMode.LoadingNewProject)
                {
                    EnableLoadingMode(LoadingMode.LoadingNewProject);
                }

                RefreshProjectData();

                CheckForOneDriveInPath();
            }
            catch (Exception e)
            {
                _loggerService.Error($"Error refreshing project: {e.Message}. Try reloading the app. If this error persists, please reach out on the WolvenKit discord.");

                CancelProjectLoad();
            }
            finally
            {
                RestoreProjectState(ActiveProject!);
                CheckForOneDriveInPath();
                DisableLoadingMode();
            }
        });
    }

    public void StopWatcher() => ForceStop();

    public void SuspendFileWatcher()
    {
        if (ActiveProject is not Cp77Project project)
        {
            return;
        }

        try
        {
            UnwatchProject(project);
            ForceStop();
        }
        catch
        {
            _loggerService.Error("Failed to suspend file watcher. Please ignore any errors.");
        }
    }

    public static void SuspendFileWatcherStatic() => s_instance?.SuspendFileWatcher();
    public static void ResumeFileWatcherStatic() => s_instance?.ResumeFileWatcher();

    public void ResumeFileWatcher()
    {
        if (ActiveProject is not Cp77Project project)
        {
            return;
        }

        try
        {
            WatchProject(project);
            _hasUnsavedFileTreeChanges = false;
        }
        catch
        {
            _loggerService.Error(
                "Failed to resume file watcher. Please hit the refresh button in the project browser.");
            _loggerService.Error("If that doesn't solve the problem, restart WolvenKit.");
        }

    }

    private static bool IsSameProjectPath(Cp77Project activeProject, string projectPath)
    {
        if (string.IsNullOrWhiteSpace(projectPath))
        {
            return false;
        }

        try
        {
            var requested = Path.GetFullPath(projectPath);
            var location = Path.GetFullPath(activeProject.Location);
            if (string.Equals(requested, location, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            var projectDirectory = Path.GetFullPath(activeProject.ProjectDirectory);
            return string.Equals(requested, projectDirectory, StringComparison.OrdinalIgnoreCase)
                   || requested.StartsWith(projectDirectory + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase)
                   || requested.StartsWith(projectDirectory + Path.AltDirectorySeparatorChar, StringComparison.OrdinalIgnoreCase);
        }
        catch (Exception)
        {
            return string.Equals(activeProject.Location, projectPath, StringComparison.OrdinalIgnoreCase);
        }
    }

    public enum LoadingMode
    {
        Ready,
        LoadingNewProject,
        ReloadingSameProject,
        ShowLoadingDuringOperation
    }

    private void EnableLoadingMode(LoadingMode mode)
    {
        if (mode != LoadingMode.LoadingNewProject && mode != LoadingMode.ReloadingSameProject && mode != LoadingMode.ShowLoadingDuringOperation)
        {
            return;
        }

        if (mode != CurrentLoadingMode)
        {
            OnSetLoading?.Invoke(this, mode);
            CurrentLoadingMode = mode;
        }

        if (_loadingIndicatorHandle is not null)
        {
            return;
        }

        _loadingIndicatorHandle = DispatcherHelper.StartRepeatingAction(
            purpose: LoadProjectPurpose,
            () =>
            {
                _progressService.IsIndeterminate = true;
                _progressService.Status = EStatus.Running;
            },
            _projectLoadPollingInterval
        );
    }

    public void DisableLoadingMode() => DisableLoadingMode(reportResult: true);

    private void DisableLoadingMode(bool reportResult)
    {
        if (CurrentLoadingMode == LoadingMode.Ready)
        {
            return;
        }

        var completedMode = CurrentLoadingMode;

        _progressService.IsIndeterminate = false;
        _progressService.Status = EStatus.Ready;
        CurrentLoadingMode = LoadingMode.Ready;
        OnSetLoading?.Invoke(this, CurrentLoadingMode);

        DispatcherHelper.StopRepeatingAction(_loadingIndicatorHandle);
        _loadingIndicatorHandle = null;

        if (!reportResult)
        {
            return;
        }

        if (completedMode is not (LoadingMode.LoadingNewProject or LoadingMode.ReloadingSameProject))
        {
            return;
        }

        if (ActiveProject != null)
        {
            _loggerService?.Success($"Loaded project: {ActiveProject!.ProjectDirectory} ({FileList.Count} files). File watcher active.");
        }
        else
        {
            _loggerService.Warning(
                $"Loading the project has seemed to fail. Please restart WolvenKit and try again. If this issue persists, please contact support on the WolvenKit discord.");
        }
    }

    /// <summary>
    /// Initialize Avalondock specific defaults that are specific to this tool window.
    /// </summary>
    private void SetupToolDefaults() =>
        ContentId = s_toolContentId;

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

    #endregion Project_Loading

    #region save/restore

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

    private void Svc_ThreadIdleTenSeconds(object? sender, EventArgs e)
    {
        SaveProjectExplorerExpansionStateIfDirty();
        SaveProjectExplorerTabIfDirty();
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

    #endregion

    #region expansion state

    public bool? GetExpansionStateOrNull(string relPath) => ExpansionStateDictionary.TryGetValue(relPath, out var state) ? state : null;

    public void SaveNodeExpansionState(string rawRelativePath, bool expansionState)
    {
        ExpansionStateDictionary[rawRelativePath] = expansionState;
        _hasUnsavedFileTreeChanges = true;
    }

    private void SaveProjectExplorerExpansionStateIfDirty() => SaveProjectExplorerExpansionStateIfDirty(ActiveProject);

    private void SaveProjectExplorerExpansionStateIfDirty(Cp77Project? project)
    {
        if (project is null || !_hasUnsavedFileTreeChanges)
        {
            return;
        }

        File.WriteAllText(project.InterfaceProjectTreeStatePath, JsonSerializer.Serialize(ExpansionStateDictionary));
        _hasUnsavedFileTreeChanges = false;
    }

    #endregion expansion state

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

    public void OnKeyStateChanged(KeyEventArgs e)
    {
        if (e.Key == Key.W && (e.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0)
        {
            _appViewModel.CloseLastActiveDocument();
            return;
        }

        ModifierStateService.OnKeystateChanged(e);
    }

    #endregion

    /// <summary>
    ///  Since the previous implementation would sometimes fail silently and claim that perfectly viable files weren't found,
    /// here's an attempt at implementing everything in a more robust way that's also more in line with windows move/copy behaviour.
    /// </summary>
    public void ProcessFileAction(IReadOnlyList<string> sourceFiles, string targetDirectory)
    {
        var isCopy = ModifierViewStateService.IsCtrlBeingHeld;

        // Abort if a directory is dragged on itself or its parent
        if (!isCopy && sourceFiles.Count == 1 &&
            (sourceFiles[0] == targetDirectory || Path.GetDirectoryName(sourceFiles[0]) == targetDirectory))
        {
            return;
        }

        // Split files and directories apart for cleaner handling
        var directories = sourceFiles.Where(s => File.GetAttributes(s).HasFlag(FileAttributes.Directory)).ToList();

        // Create a dictionary to map source files to target files
        var fileMap = new Dictionary<string, string>();

        // Add files directly under the source directories to the map
        foreach (var sourceFile in sourceFiles.Where(s => !directories.Contains(s)))
        {
            var targetFile = Path.Combine(targetDirectory, Path.GetFileName(sourceFile));
            fileMap[sourceFile] = targetFile;
        }

        // Add files under the subdirectories of the source directories to the map
        foreach (var directory in directories.Where(Directory.Exists))
        {
            var directoryParent = Path.GetDirectoryName(directory) ?? directory;
            foreach (var sourceFile in Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories))
            {
                // we don't care about directories, just about files
                if (File.GetAttributes(sourceFile).HasFlag(FileAttributes.Directory))
                {
                    continue;
                }

                var relativePath = sourceFile.Substring(directoryParent.Length).TrimStart(Path.DirectorySeparatorChar);
                var targetFile = Path.Combine(targetDirectory, relativePath);
                if (targetFile == sourceFile && isCopy)
                {
                    var directoryName = Path.GetFileName(Path.GetDirectoryName(sourceFile)) ?? "INVALID";
                    relativePath = relativePath.Replace(directoryName, $"{directoryName}_copy");
                    targetFile = Path.Combine(targetDirectory, relativePath);
                }

                fileMap[sourceFile] = targetFile;
            }
        }

        var existingFiles = fileMap.Values.Where(File.Exists)
            .Select(s => s.Replace(targetDirectory, "").TrimStart(Path.DirectorySeparatorChar)).OrderBy(s => s).Distinct()
            .ToList();

        // If we have 0 - 10 files, we'll show one dialogue. Otherwise, we'll ask for each file individually.
        var isOverwrite = existingFiles.Count == 0;
        var isAskIndividually = existingFiles.Count > 10;
        var skipDialogue = false;

        // We're copying or moving a file on itself - offer rename operation
        if (fileMap.Count == 1 && existingFiles.Count == 1 &&
            ActiveProject is Cp77Project project &&
            targetDirectory == Path.GetDirectoryName(fileMap.Keys.First()))
        {
            var filePath = fileMap.Keys.First();
            var relativePath = filePath.Replace($"{project.ModDirectory}{Path.DirectorySeparatorChar}", "");
            var destPath = Interactions.Rename(relativePath);
            if (string.IsNullOrEmpty(destPath))
            {
                // user cancelled dialogue
                return;
            }

            if (destPath != relativePath)
            {
                fileMap[filePath] = filePath.Replace(relativePath, destPath);
                existingFiles.Clear();
            }
            else
            {
                // we can't overwrite a file with itself, so we'll create a copy
                isCopy = true;
                skipDialogue = true;
            }
        }

        // 1 - 10 files: Show a single dialogue that asks for confirmation
        if (existingFiles.Count is < 10 and > 0)
        {
            var messageBoxResult = Interactions.ShowMessageBox(
                $"Overwrite the following files? \n\n  {string.Join("\n  ", existingFiles)}",
                "File Overwrite Confirmation", WMessageBoxButtons.YesNoCancel);

            if (messageBoxResult == WMessageBoxResult.Cancel)
            {
                return;
            }

            isOverwrite = messageBoxResult == WMessageBoxResult.Yes;
        }

        foreach (var copyMe in fileMap)
        {
            var targetFile = copyMe.Value ?? "";

            var canWriteToTargetFile =
                !File.Exists(targetFile)
                || isOverwrite
                || (!skipDialogue && isAskIndividually && Interactions.ShowMessageBox(
                    $"Overwrite the following file? {targetFile}",
                    "File Overwrite Confirmation",
                    WMessageBoxButtons.YesNo) == WMessageBoxResult.Yes);
            if (!canWriteToTargetFile)
            {
                if (!isCopy)
                {
                    continue;
                }

                var filenameWithoutExtension = Path.GetFileNameWithoutExtension(targetFile);
                targetFile = targetFile.Replace(filenameWithoutExtension, $"{filenameWithoutExtension}_copy");
            }

            var containingDirectory = Path.GetDirectoryName(targetFile) ?? "";
            if (!Directory.Exists(containingDirectory))
            {
                Directory.CreateDirectory(containingDirectory);
            }

            if (isCopy)
            {
                File.Copy(copyMe.Key, targetFile, true);
            }
            else
            {
                File.Move(copyMe.Key, targetFile, true);
                _projectEvents.PublishFilesMoved(
                    new FilesMovedMessage([(copyMe.Key, targetFile)]));
            }
        }

        if (isCopy)
        {
            return;
        }

        foreach (var directory in directories.OrderByDescending(dir => dir.Length).ToList())
        {
            if (Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories).Any())
            {
                continue;
            }

            Directory.Delete(directory, true);
        }
    }

    #endregion Methods
}
