using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic.FileIO;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
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
    private readonly IProjectManager _projectManager;
    private readonly IModTools _modTools;
    private readonly IProgressService<double> _progressService;
    private readonly IGameControllerFactory _gameController;
    private readonly AppViewModel _appViewModel;
    public readonly IModifierViewStateService ModifierStateService;
    private readonly IWatcherService _projectWatcher;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private IPluginService _pluginService;

    private readonly ISettingsManager _settingsManager;
    private readonly IArchiveManager _archiveManager;
    private readonly ProjectResourceTools _projectResourceTools;

    #endregion fields

    private static ProjectExplorerViewModel? s_instance;
    public ProjectExplorerViewModel(
        AppViewModel appViewModel,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IProgressService<double> progressService,
        IModTools modTools,
        IGameControllerFactory gameController,
        IPluginService pluginService,
        ISettingsManager settingsManager,
        IModifierViewStateService modifierSvc,
        IArchiveManager archiveManager,
        ProjectResourceTools projectResourceTools
    ) : base(s_toolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _pluginService = pluginService;
        _settingsManager = settingsManager;
        _archiveManager = archiveManager;
        _projectResourceTools = projectResourceTools;
        ModifierStateService = modifierSvc;

        _appViewModel = appViewModel;

        _projectWatcher = Locator.Current.GetService<IWatcherService>()!;

        SideInDockedMode = DockSide.Left;

        IsShowRelativePath = true;
        ModifierStateService.ModifierStateChanged += OnModifierUpdateEvent;

        SetupToolDefaults();

        _appViewModel.PropertyChanged += AppViewModelOnPropertyChanged;
        _appViewModel.OpenDocumentChanged += OnOpenDocumentChanged;

        _projectManager.PropertyChanged += ProjectManager_OnPropertyChanged;

        SelectedTabIndex = ActiveProject?.ActiveTab ?? 0;

        _appViewModel.OnInitialProjectLoaded += AppViewModel_OnInitialProjectLoaded;

        if (Locator.Current.GetService<AppIdleStateService>() is not AppIdleStateService svc)
        {
            return;
        }

        svc.ThreadIdleTenSeconds += Svc_ThreadIdleTenSeconds;

        s_instance = this;
    }

    /// <summary>
    /// Whenever the document changes, save open file paths to <see cref="Cp77Project.ProjectFileExtension"/> file 
    /// </summary>
    private void OnOpenDocumentChanged(object? sender, EventArgs e) => SaveOpenFilePaths();
    
    private void Svc_ThreadIdleTenSeconds(object? sender, EventArgs e)
    {
        SaveProjectExplorerExpansionStateIfDirty();
        SaveProjectExplorerTabIfDirty();
    }

    private void AppViewModel_OnInitialProjectLoaded(object? sender, EventArgs e)
    {
        RefreshProjectData();
        
        CheckForOneDriveInPath();
        
        // On first project load, we're already initialized, so this won't fire
        Refresh();
        OnProjectChanged?.Invoke();
    }

    /// <summary>
    /// Save project browser expansion state (will be written to <see cref="Cp77Project.InterfaceProjectTreeStatePath"/>)
    /// </summary>
    public Dictionary<string, bool> ExpansionStateDictionary = [];

    public bool? GetExpansionStateOrNull(string relPath) => ExpansionStateDictionary.TryGetValue(relPath, out var state) ? state : null;

    /// <summary>
    /// Set status of "scroll to open file" button (disable if we don't have one open)
    /// </summary>
    private void AppViewModelOnPropertyChanged(object? sender, PropertyChangedEventArgs e) =>
        CanScrollToOpenFile = HasSelectedItem && _appViewModel.ActiveDocument is not null;

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
    public event Action? OnProjectChanged;
    
    private void ProjectManager_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(ProjectManager.ActiveProject))
        {
            return;
        }

        RefreshProjectData();
    }

    // When opening projects from launch args, change detection for dependent objects isn't working yet. 
    private void RefreshProjectData()
    {
        // Save changes in active project
        if (ActiveProject != null)
        {
            _hasUnsavedFileTreeChanges = true;
            SaveProjectExplorerExpansionStateIfDirty();
            _projectWatcher.UnwatchProject(ActiveProject);
        }
        
        OnProjectChanged?.Invoke();

        DispatcherHelper.RunOnMainThread(() =>
        {
            if (ActiveProject?.Equals(_projectManager.ActiveProject) == true)
            {
                return;
            }
            ActiveProject = _projectManager.ActiveProject;
            if (ActiveProject is not null)
            {
                RestoreProjectState(ActiveProject);
                _projectWatcher.WatchProject(ActiveProject);
            }

            OnProjectChanged?.Invoke();
        }, DispatcherPriority.ContextIdle);
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

    public DispatchedObservableCollection<FileSystemModel> FileTree => _projectWatcher.FileTree;
    public DispatchedObservableCollection<FileSystemModel> FileList => _projectWatcher.FileList;

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

    public bool IsKeyUpEventAssigned { get; set; }

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
    private FileSystemModel? _selectedItem;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertArchiveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertRawFileCommand))]
    private ObservableCollection<object>? _selectedItems = new();

    [ObservableProperty] private bool _isFlatModeEnabled;

    [ObservableProperty] private int _selectedTabIndex;

    [ObservableProperty] private bool _canScrollToOpenFile;

    [ObservableProperty] private bool _hasSelectedItem;

    #endregion properties

    #region commands

    #region general commands

    //[RelayCommand]
    //private void ExpandAll() {  }

    //[RelayCommand]
    //private void CollapseAll() { }

    //[RelayCommand]
    //private void CollapseChildren() { }

    //[RelayCommand]
    //private void ExpandChildren() { }

    /// <summary>
    /// Refreshes all files in the Grid
    /// </summary>
    private bool CanRefresh() => ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanRefresh))]
    private void Refresh()
    {
        if (_projectWatcher.IsWatcherStopped)
        {
            ResumeFileWatcher();
        }
        else
        {
            _projectWatcher.Refresh();
        }
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
        var activeItemPath = SelectedItem.NotNull().FullName;
        if (!Path.Exists(activeItemPath))
        {
            return;
        }

        activeItemPath = activeItemPath.Replace('/', Path.DirectorySeparatorChar);
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

        if (activeItemPath is not null)
        {
            Clipboard.SetDataObject(activeItemPath);
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

        // Delete from file structure
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

        StopWatcher();
        var (prefixPath, relativePath) = _projectManager.ActiveProject.SplitFilePath(absolutePath);

        if (absolutePath.StartsWith(_projectManager.ActiveProject.ModDirectory))
        {
            relativePath = absolutePath[(_projectManager.ActiveProject.ModDirectory.Length + 1)..];
        }

        var (newRelativePath, refactor) = Interactions.RenameAndRefactor(relativePath);

        if (string.IsNullOrEmpty(newRelativePath))
        {
            return;
        }

        await _projectResourceTools.MoveAndRefactorAsync(relativePath, newRelativePath, prefixPath, refactor);
        _appViewModel.ReloadChangedFiles();
        ResumeFileWatcher();
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
    private async Task ConvertArchiveFile()
    {
        if (SelectedItems is null)
        {
            return;
        }

        var selection = SelectedItems.NotNull().OfType<FileSystemModel>().Where(m => IsInArchiveFolder(m)).ToList();
        
        if (!IsShiftKeyPressed)
        {
            await ConvertToJsonInternal(selection);
            return;
        }

        var selectedItemPaths = selection
            .Select(x =>
                $"{x.FullName.Replace($"archive{Path.DirectorySeparatorChar}", $"raw{Path.DirectorySeparatorChar}")}.json")
            .ToList();

        var convertSelection = FileList
            .Where(x => selectedItemPaths.Contains(x.FullName) && File.Exists(x.FullName)).ToList();

        await ConvertFromJsonInternal(convertSelection);
    }


    private async Task ConvertToJsonInternal(IEnumerable<FileSystemModel> selection)
    {
        List<string> files = new();

        // get all files
        foreach (var item in selection)
        {
            if (item.IsDirectory)
            {
                files.AddRange(Directory.GetFiles(item.FullName, "*", SearchOption.AllDirectories));
            }
            else
            {
                files.Add(item.FullName);
            }
        }

        var progress = 0;
        _progressService.Report(0);

        // convert files
        foreach (var file in files)
        {
            if (!File.Exists(file) || !Enum.GetNames<ERedExtension>()
                    .Contains(Path.GetExtension(file).TrimStart('.').ToLower()))
            {
                progress++;
                continue;
            }

            var rawOutPath = Path.Combine(ActiveProject.NotNull().RawDirectory, ActiveProject!.GetRelativePath(file));
            var outDirectoryPath = Path.GetDirectoryName(rawOutPath);
            if (outDirectoryPath != null)
            {
                Directory.CreateDirectory(outDirectoryPath);

                await _modTools.ConvertToJsonAndWriteAsync(file, new DirectoryInfo(outDirectoryPath));
            }

            progress++;
            _progressService.Report(progress / (float)files.Count);
        }

        _progressService.Completed();
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
            await ConvertFromJsonInternal(SelectedItems!.OfType<FileSystemModel>().Where(IsInRawFolder));
            return;
        }

        var selectedItemPaths = SelectedItems.NotNull().OfType<FileSystemModel>()
            .Select(x => $"{x.GameRelativePath}".Replace(".json", "")).ToList();

        var convertSelection = FileList
            .Where(IsInArchiveFolder)
            .Where(x => selectedItemPaths.Contains(x.GameRelativePath)).ToList();

        await ConvertToJsonInternal(convertSelection);
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


    private void RestoreProjectState(Cp77Project project)
    {
        
        // read tree state from file
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

        File.WriteAllText(project.InterfaceProjectTreeStatePath, JsonSerializer.Serialize(ExpansionStateDictionary));
        _hasUnsavedFileTreeChanges = false;
    }

    public void StopWatcher() => _projectWatcher.ForceStop();

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

    public void SuspendFileWatcher()
    {
        if (ActiveProject is not Cp77Project project)
        {
            return;
        }

        try
        {
            _projectWatcher.UnwatchProject(project);
            _projectWatcher.ForceStop();
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
            _projectWatcher.WatchProject(project);
        }
        catch
        {
            _loggerService.Error(
                "Failed to resume file watcher. Please hit the refresh button in the project browser.");
            _loggerService.Error("If that doesn't solve the problem, restart WolvenKit.");
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
