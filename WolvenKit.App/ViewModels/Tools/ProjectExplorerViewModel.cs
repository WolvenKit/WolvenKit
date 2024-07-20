using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

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
    private readonly AppViewModel _mainViewModel;
    public readonly IModifierViewStateService ModifierViewStateService;

    private readonly WatcherService _projectWatcher;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private IPluginService _pluginService;

    private readonly ISettingsManager _settingsManager;

    #endregion fields

    public ProjectExplorerViewModel(
        AppViewModel appViewModel,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IProgressService<double> progressService,
        IModTools modTools,
        IGameControllerFactory gameController,
        IPluginService pluginService,
        ISettingsManager settingsManager,
        IModifierViewStateService modifierSvc
    ) : base(s_toolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _pluginService = pluginService;
        _settingsManager = settingsManager;
        ModifierViewStateService = modifierSvc;

        _mainViewModel = appViewModel;

        _projectWatcher = new WatcherService(_loggerService);

        SideInDockedMode = DockSide.Left;

        RegisterModifierStateAwareness();
        
        SetupToolDefaults();

        ModifierViewStateService.RefreshModifierStates();

        _mainViewModel.PropertyChanged += MainViewModel_OnPropertyChanged;

        _projectManager.PropertyChanged += ProjectManager_OnPropertyChanged;

        SelectedTabIndex = ActiveProject?.ActiveTab ?? 0;

        if (Locator.Current.GetService<AppIdleStateService>() is not AppIdleStateService svc)
        {
            return;
        }

        svc.ThreadIdleTenSeconds += (_, _) => SaveProjectExplorerExpansionStateIfDirty();
        svc.ThreadIdleTenSeconds += (_, _) => SaveProjectExplorerTabIfDirty();

    }


    public Dictionary<string, bool> ExpansionStateDictionary = new();

    public bool GetExpansionState(string relPath) => GetExpansionStateOrNull(relPath) ?? false;

    public bool? GetExpansionStateOrNull(string relPath) => ExpansionStateDictionary.TryGetValue(relPath, out var state) ? state : null;

    /// <summary>
    /// Set status of "scroll to open file" button, based on whether or not we have one opened
    /// </summary>
    private void MainViewModel_OnPropertyChanged(object? sender, PropertyChangedEventArgs e) =>
        CanScrollToOpenFile = _mainViewModel.ActiveDocument is not null;

    public event Action? OnProjectChanged;
    
    private void ProjectManager_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(ProjectManager.ActiveProject))
        {
            return;
        }

        // Save changes in active project
        if (ActiveProject != null)
        {
            _hasUnsavedFileTreeChanges = true;
            SaveProjectExplorerExpansionStateIfDirty();
            _projectWatcher.UnwatchProject(ActiveProject);
        }

        DispatcherHelper.RunOnMainThread(() => ActiveProject = _projectManager.ActiveProject, DispatcherPriority.ContextIdle);
        OnProjectChanged?.Invoke();

        if (_projectManager.ActiveProject == null)
        {
            return;
        }

        LoadFileTreeState(_projectManager.ActiveProject);
        _projectWatcher.WatchProject(_projectManager.ActiveProject);
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
        if (value is null)
        {
            return;
        }

        _mainViewModel.SelectFileCommand.SafeExecute(value);
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
    [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
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
    [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
    private FileSystemModel? _selectedItem;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
    private ObservableCollection<object>? _selectedItems = new();

    [ObservableProperty] private bool _isFlatModeEnabled;

    [ObservableProperty] private int _selectedTabIndex;

    [ObservableProperty] private bool _canScrollToOpenFile;

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
    private void Refresh() => _projectWatcher.Refresh();

    public string GetActiveFolderPath() => SelectedTabIndex switch
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
        IsShiftKeyPressed ? ActiveProject.NotNull().Location : GetActiveFolderPath()
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
    private void CopyAbsPathToRawFolder() => CopyItemPathToClipboard(true, true, false);


    private bool CanCopyAbsPathToArchiveFolder => IsShowAbsolutePathToArchiveFolder;
    /// <summary>
    /// Ctrl+Shift with /raw/ file or folder selected: Copy absolute path to archive folder (convenience for quick switching)
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyAbsPathToArchiveFolder))]
    private void CopyAbsPathToArchiveFolder() => CopyItemPathToClipboard(true, true, true);


    /// <summary>
    /// Reimports the game file to replace the current one
    /// </summary>
    private bool CanAddDependencies() => ActiveProject != null && SelectedItem != null && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("xml");
    [RelayCommand(CanExecute = nameof(CanAddDependencies))]
    private async Task AddDependencies()
    {
        if (SelectedItem.NotNull().IsDirectory)
        {
            await Task.CompletedTask;
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

        await Task.CompletedTask;
    }
    
    /// <summary>
    /// Reimports the game file to replace the current one
    /// </summary>
    private bool CanOverwriteWithGameFile() => ActiveProject != null && SelectedItem != null && !IsInRawFolder(SelectedItem);

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
            await Task.Run(() => controller.AddToMod(hash, ArchiveManagerScope.Everywhere));
            progress++;
            _progressService.Report(progress / (float)selectedItems.Count);
        }

        // OK, we're done
        _progressService.Completed();
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
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(fullPath
                        , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                        , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
                else
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fullPath
                        , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                        , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
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

        await _mainViewModel.OpenFileAsync(model);
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

            yield return Path.Combine(dir, file + " - Copy" + ext);
            for (var i = 2; i < 999; i++) // there shouldn't be more than 1k copies... hopefully
            {
                yield return Path.Combine(dir, file + " - Copy " + i + ext);
            }
        }
    }


    private bool CanCreateNewDirectory() => ActiveProject != null && SelectedItem?.IsDirectory == true;

    [RelayCommand(CanExecute = nameof(CanCreateNewDirectory))]
    private void CreateNewDirectory(FileSystemModel? value)
    {
        var model = value ?? SelectedItem;
        if (model?.IsDirectory != true)
        {
            return;
        }

        var newFolderPath = Path.Combine(model.FullName, Interactions.AskForTextInput("Directory name"));

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
        if (_projectManager.ActiveProject is null || SelectedItem?.FullName is not string filePath)
        {
            return;
        }

        var (prefix, relativePath) = _projectManager.ActiveProject.SplitFilePath(filePath);

        if (filePath.StartsWith(_projectManager.ActiveProject.ModDirectory))
        {
            prefix = _projectManager.ActiveProject.ModDirectory;
            relativePath = filePath[(prefix.Length + 1)..];
        }

        var (newFilename, refactor) = Interactions.RenameAndRefactor(relativePath);

        if (string.IsNullOrEmpty(newFilename))
        {
            return;
        }

        var newFullPath = Path.Combine(prefix, newFilename);

        if (filePath == newFullPath)
        {
            return;
        }

        if (File.Exists(newFullPath))
        {
            var response = await Interactions.ShowMessageBoxAsync($"Do you want to overwrite the existing file {relativePath}?",
                "File already exists!");
            if (response is not (WMessageBoxResult.OK or WMessageBoxResult.Yes))
            {
                return;
            }

            File.Delete(newFullPath);
        }
        
        try
        {
            if (!SelectedItem.IsDirectory)
            {
                var parentDir = Path.GetDirectoryName(newFullPath);

                if (!Directory.Exists(parentDir) && parentDir is not null)
                {
                    Directory.CreateDirectory(parentDir);
                }

                if (File.Exists(newFullPath))
                {
                    File.Delete(newFullPath);
                }

                File.Move(filePath, newFullPath);
               
            }
            else
            {
                var overwriteFiles = true;
                if (Directory.Exists(filePath))
                {
                    var response = await Interactions.ShowMessageBoxAsync(
                        $"Directory {relativePath} already exists. Do you want to overwrite existing files?", "Directory already exists!");
                    overwriteFiles = response is (WMessageBoxResult.OK or WMessageBoxResult.Yes);
                }

                FileHelper.MoveRecursively(filePath, newFullPath, overwriteFiles, _loggerService);
            }

            _loggerService.Info($"Moved {relativePath} to {newFilename}");
          
        }
        catch
        {
            // Swallow error
        }

        if (!refactor || ActiveProject is null)
        {
            return;
        }

        var oldRelPath = ActiveProject.GetResourcePathFromRoot(filePath);
        var newRelPath = ActiveProject.GetResourcePathFromRoot(newFullPath);

        ReplacePathInProject(oldRelPath, newRelPath);
    }

    #endregion general commands

    #region red4

    private bool IsInArchiveFolder(FileSystemModel? model) =>
        ActiveProject is not null && model is not null && model.FullName.Contains(ActiveProject.ModDirectory);

    private bool IsInRawFolder(FileSystemModel? model) =>
        ActiveProject is not null && model is not null && model.FullName.Contains(ActiveProject.RawDirectory);

    private bool CanConvertTo() => ActiveProject is not null && SelectedItems is not null &&
                                   SelectedItems.All(x => x is FileSystemModel m && IsInArchiveFolder(m));
    [RelayCommand(CanExecute = nameof(CanConvertTo))]
    private async Task ConvertTo()
    {
        var progress = 0;
        _progressService.Report(0);

        List<string> files = new();

        // get all files
        foreach (var item in SelectedItems.NotNull().OfType<FileSystemModel>().Where(x => !IsInRawFolder(x)))
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

        // convert files
        foreach (var file in files)
        {
            await ConvertToJson(file);

            progress++;
            _progressService.Report(progress / (float)files.Count);
        }

        _progressService.Completed();
    }

    private async Task ConvertToJson(string file)
    {
        if (!File.Exists(file))
        {
            return;
        }

        if (!Enum.GetNames<ERedExtension>().Contains(Path.GetExtension(file).TrimStart('.').ToLower()))
        {
            return;
        }

        var rawOutPath = Path.Combine(ActiveProject.NotNull().RawDirectory, ActiveProject!.GetRelativePath(file));
        var outDirectoryPath = Path.GetDirectoryName(rawOutPath);
        if (outDirectoryPath != null)
        {
            Directory.CreateDirectory(outDirectoryPath);

            await _modTools.ConvertToJsonAndWriteAsync(file, new DirectoryInfo(outDirectoryPath));
        }
    }


    private bool CanConvertFromJson() => ActiveProject is not null && SelectedItems is not null &&
                                         SelectedItems.All(x => x is FileSystemModel m && IsInRawFolder(m));
    [RelayCommand(CanExecute = nameof(CanConvertFromJson))]
    private async Task ConvertFrom()
    {
        var progress = 0;
        _progressService.Report(0);

        List<string> files = new();

        // get all files
        foreach (var item in SelectedItems.NotNull().OfType<FileSystemModel>().Where(IsInRawFolder))
        {
            if (item.IsDirectory)
            {
                files.AddRange(Directory.GetFiles(item.FullName, "*.json", SearchOption.AllDirectories).Where(name => !name.EndsWith(".Material.json")));
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

        await _modTools.ConvertFromJsonAndWriteAsync(new FileInfo(file), new DirectoryInfo(outDirectoryPath));

        _mainViewModel.ReloadChangedFiles();

    }

    /// <summary>
    /// Opens selected node in asset browser.
    /// </summary>
    private bool CanOpenInAssetBrowser() => ActiveProject != null && SelectedItem is { IsDirectory: false };
    [RelayCommand(CanExecute = nameof(CanOpenInAssetBrowser))]
    private void OpenInAssetBrowser()
    {
        _mainViewModel.NotNull().GetToolViewModel<AssetBrowserViewModel>().IsVisible = true;
        _mainViewModel.GetToolViewModel<AssetBrowserViewModel>().ShowFile(SelectedItem.NotNull());
    }

    private static string GetSecondExtension(FileSystemModel model) => Path.GetExtension(Path.ChangeExtension(model.FullName, "").TrimEnd('.')).TrimStart('.');

    private bool CanOpenInMlsb() =>
        ActiveProject != null
        && SelectedItem is { IsDirectory: false }
        && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower()
            .Equals(ETextConvertFormat.json.ToString(), StringComparison.Ordinal)
        && GetSecondExtension(SelectedItem).Equals(ERedExtension.mlsetup.ToString(), StringComparison.Ordinal)
        && PluginService.IsInstalled(EPlugin.mlsetupbuilder);

    [RelayCommand(CanExecute = nameof(CanOpenInMlsb))]
    private void OpenInMlsb()
    {
        if (PluginService.TryGetInstallPath(EPlugin.mlsetupbuilder, out var path))
        {
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

            var filepath = SelectedItem.NotNull().FullName;
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
    }

    #endregion

    #endregion commands

    #region Methods

    public AppViewModel GetAppViewModel() => _mainViewModel;

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

    private void ReplacePathInProject(ResourcePath oldPath, ResourcePath newPath)
    {
        if (oldPath == newPath ||
            ActiveProject is null)
        {
            return;
        }

        List<string> failedFiles = [];

        var files = Directory.GetFiles(ActiveProject.ModDirectory, "*.*", SearchOption.AllDirectories);
        Parallel.ForEach(files, file =>
        {
            var hash = ActiveProject.GetResourcePathFromRoot(file);
            if (hash == newPath)
            {
                return;
            }

            try
            {
                ReplacePathInFile(file, oldPath, newPath);
            }
            catch (Exception)
            {
                failedFiles.Add(file.RelativePath(ActiveProject.ModDirectory));
            }
        });

        if (failedFiles.Count > 0)
        {
            _loggerService.Error($"Failed to auto-update references in the following files:");
            failedFiles.ForEach((path) => _loggerService.Error($"  {path}"));
        }
        _mainViewModel.ReloadChangedFiles();
    }

    private void ReplacePathInFile(string filePath, ResourcePath oldPath, ResourcePath newPath)
    {
        if (oldPath == newPath || 
            !File.Exists(filePath))
        {
            return;
        }

        var oldPathStr = oldPath.GetResolvedText();
        var newPathStr = newPath.GetResolvedText();

        CR2WFile? cr2W;
        var wasModified = false;
        var isDirectory = newPathStr != null && Directory.Exists(Path.Join(ActiveProject?.ModDirectory, newPathStr));
        if (isDirectory)
        {
            // Can't replace path if either is null
            if (oldPathStr == null || newPathStr == null)
            {
                return;
            }

            oldPathStr += ResourcePath.DirectorySeparatorChar;
            newPathStr += ResourcePath.DirectorySeparatorChar;
        }


        using (var fs = File.Open(filePath, FileMode.Open))
        using (var cr = new CR2WReader(fs))
        {
            if (cr.ReadFile(out cr2W) != EFileReadErrorCodes.NoError)
            {
                return;
            }

            foreach (var result in cr2W!.FindType(typeof(IRedRef)))
            {
                if (result.Value is not IRedRef resourceReference || resourceReference.DepotPath == ResourcePath.Empty)
                {
                    continue;
                }

                var oldDepotPathStr = resourceReference.DepotPath.GetResolvedText();

                ResourcePath newDepotPath;
                if (isDirectory)
                {
                    if (oldDepotPathStr == null)
                    {
                        continue;
                    }

                    var isArchiveXL = oldDepotPathStr.StartsWith('*');
                    if (isArchiveXL)
                    {
                        oldDepotPathStr = oldDepotPathStr[1..];
                    }

                    if (!oldDepotPathStr.StartsWith(oldPathStr!))
                    {
                        continue;
                    }

                    var newDepotPathStr = newPathStr! + oldDepotPathStr[oldPathStr!.Length..];
                    if (isArchiveXL)
                    {
                        newDepotPathStr = "*" + newDepotPathStr;
                    }

                    newDepotPath = newDepotPathStr;
                }
                else
                {
                    if (resourceReference.DepotPath != oldPath)
                    {
                        continue;
                    }

                    newDepotPath = newPath;
                }
                    
                var parentPath = string.Join('.', result.Path.Split('.')[..^1]);

                var newValue = (IRedRef)RedTypeManager.CreateRedType(resourceReference.RedType, newDepotPath, resourceReference.Flags);

                if (result.Name.Contains(':'))
                {
                    var parts = result.Name.Split(':');
                    if (parts.Length != 2 || !int.TryParse(parts[1], out var index))
                    {
                        throw new Exception();
                    }

                    var parentArray = cr2W.GetFromXPath(string.Join('.', parentPath, parts[0]));
                    if (!parentArray.Item1 || parentArray.Item2 is not IList arr)
                    {
                        throw new Exception();
                    }

                    _loggerService.Debug($"Replaced \"{result.Path}\" in \"{filePath}\"");
                    arr[index] = newValue;
                }
                else
                {
                    var parentClass = cr2W.GetFromXPath(parentPath);
                    if (!parentClass.Item1 || parentClass.Item2 is not RedBaseClass cls)
                    {
                        throw new Exception();
                    }

                    _loggerService.Debug($"Replaced \"{result.Path}\" in \"{filePath}\"");
                    cls.SetProperty(result.Name, newValue);
                }

                wasModified = true;
            }
        }

        if (!wasModified)
        {
            return;
        }

        using var fs2 = File.Open(filePath, FileMode.Create);
        using var cw = new CR2WWriter(fs2);

        cw.WriteFile(cr2W);
    }

    private const string s_treestateFileName = "fileTreeState.json";
    private void LoadFileTreeState(Cp77Project project)
    {
        var statePath = GetTreeStateFilePath(project);
        if (File.Exists(statePath))
        {
            _hasUnsavedFileTreeChanges = false;
            ExpansionStateDictionary = JsonSerializer.Deserialize<Dictionary<string, bool>>(File.ReadAllText(statePath)) ?? new();
        }
        else
        {
            ExpansionStateDictionary = [];
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

    public void SaveProjectExplorerExpansionStateIfDirty() => SaveProjectExplorerExpansionStateIfDirty(ActiveProject);

    private static string GetTreeStateFilePath(Cp77Project project) => Path.Combine(project.ProjectDirectory, s_treestateFileName);

    private void SaveProjectExplorerExpansionStateIfDirty(Cp77Project? project)
    {
        if (project is null || !_hasUnsavedFileTreeChanges)
        {
            return;
        }

        File.WriteAllText(GetTreeStateFilePath(project), JsonSerializer.Serialize(ExpansionStateDictionary));
        _hasUnsavedFileTreeChanges = false;
    }

    public void StopWatcher() => _projectWatcher.ForceStop();

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(SelectedTabIndex) || ActiveProject is null)
        {
            return;
        }

        ActiveProject.ActiveTab = SelectedTabIndex;
        _projectExplorerTabChanged = true;
    }

    #endregion Methods

    #region ModifierStateAwareness

    // ####################################################################################
    // Integrate with _modifierViewStatesModel to expose keys to view 
    // ####################################################################################

    public bool IsShiftKeyPressed => ModifierViewStateService.IsShiftKeyPressed;
    public bool IsShiftKeyPressedOnly => ModifierViewStateService.IsShiftKeyPressedOnly;
    public bool IsCtrlKeyPressed => ModifierViewStateService.IsCtrlKeyPressed;
    public bool IsCtrlKeyPressedOnly => ModifierViewStateService.IsCtrlKeyPressedOnly;
    public bool IsNoModifierPressed => ModifierViewStateService.IsNoModifierPressed;

    /// <summary>
    /// Called in constructor
    /// </summary>
    private void RegisterModifierStateAwareness()
    {
        ModifierViewStateService.ModifierStateChanged += OnModifierUpdateEvent;
        ModifierViewStateService.PropertyChanged += OnModifierChanged;
    }

    /// <summary>
    /// Reacts to ModifierViewStatesModel's emitted events
    /// </summary>
    private void OnModifierUpdateEvent()
    {
        IsShowAbsolutePathToRawFolder = ModifierViewStateService.IsCtrlShiftOnlyPressed && IsInArchiveFolder(SelectedItem);
        IsShowAbsolutePathToArchiveFolder = ModifierViewStateService.IsCtrlShiftOnlyPressed && IsInRawFolder(SelectedItem);

        IsShowAbsolutePathToCurrentFile = ModifierViewStateService.IsShiftKeyPressedOnly;

        IsShowAbsolutePathToCurrentFolder = ModifierViewStateService.IsCtrlKeyPressedOnly;

        IsShowRelativePath = !ModifierViewStateService.IsShiftKeyPressedOnly && !ModifierViewStateService.IsCtrlKeyPressedOnly;
    }

    /// <summary>
    /// Forward ModifierViewStateModel's PropertyChanged events to the view
    /// </summary>
    private void OnModifierChanged(object? sender, PropertyChangedEventArgs e) => OnPropertyChanged(e.PropertyName);

    /// <summary>
    /// Passes key state changes from view down to ModifierViewStatesModel
    /// </summary>
    public void RefreshModifierStates() => ModifierViewStateService.RefreshModifierStates();

    public IDocumentViewModel? GetActiveEditorFile() => _mainViewModel.ActiveDocument;

    #endregion

    public void SaveNodeExpansionState(string rawRelativePath, bool expansionState)
    {
        ExpansionStateDictionary[rawRelativePath] = expansionState;
        _hasUnsavedFileTreeChanges = true;
    }
}
