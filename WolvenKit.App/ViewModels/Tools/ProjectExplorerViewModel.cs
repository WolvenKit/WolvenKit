using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using DynamicData.Binding;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel : ToolViewModel
{
    #region fields

    /// <summary>
    /// Identifies the <see ref="ContentId"/> of this tool window.
    /// </summary>
    public const string ToolContentId = "ProjectExplorer_Tool";

    /// <summary>
    /// Identifies the caption string used for this tool window.
    /// </summary>
    public const string ToolTitle = "Project Explorer";

    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IWatcherService _watcherService;
    private readonly IModTools _modTools;
    private readonly IProgressService<double> _progressService;
    private readonly IGameControllerFactory _gameController;
    private readonly AppViewModel _mainViewModel;
    private readonly IModifierViewStateService _modifierViewStateService;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private IPluginService _pluginService;

    private readonly ISettingsManager _settingsManager;
    private readonly IObservableList<FileModel> _observableList;

    #endregion fields

    public ProjectExplorerViewModel(
        AppViewModel appViewModel,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IWatcherService watcherService,
        IProgressService<double> progressService,
        IModTools modTools,
        IGameControllerFactory gameController,
        IPluginService pluginService,
        ISettingsManager settingsManager,
        IModifierViewStateService modifierSvc
    ) : base(ToolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _watcherService = watcherService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _pluginService = pluginService;
        _settingsManager = settingsManager;
        _modifierViewStateService = modifierSvc;

        _mainViewModel = appViewModel;

        SideInDockedMode = DockSide.Left;

        RegisterModifierStateAwareness();
        
        SetupToolDefaults();

        _watcherService.Files
            .Connect()
            //.ObserveOn(RxApp.MainThreadScheduler)
            .BindToObservableList(out _observableList)
            .Subscribe(OnNext);

        _projectManager.ActiveProjectChanged += ProjectManager_ActiveProjectChanged;
    }

    private void ProjectManager_ActiveProjectChanged(object? sender, ActiveProjectChangedEventArgs e)
    {
        if (e.Project is not null)
        {
            DispatcherHelper.RunOnMainThread( () => 
            {
                ActiveProject = e.Project;
            }, DispatcherPriority.ContextIdle);
        }
    }

    partial void OnSelectedItemChanged(FileModel? value)
    {
        if (value is not null)
        {
            _mainViewModel.SelectFileCommand.SafeExecute(value);
                
            // toggle context menu buttons
            if (SelectedItems is not null && SelectedItems.Any())
            {
                var selected = SelectedItems.OfType<FileModel>().ToList();
                // if all are in raw folder, then enable convertFrom
                if (selected.All(x => IsInRawFolder(x)))
                {
                    ConvertToIsEnabled = false;
                    ConvertFromIsEnabled = true;
                }
                // if all are in archive folder, then enable convertTo
                else if (selected.All(x => IsInArchiveFolder(x)))
                {
                    ConvertToIsEnabled = true;
                    ConvertFromIsEnabled = false;
                }
                // else disable both
                else
                {
                    ConvertToIsEnabled = false;
                    ConvertFromIsEnabled = false;
                }
            }
            else if (value is not null)
            {
                if (IsInRawFolder(value))
                {
                    ConvertToIsEnabled = false;
                    ConvertFromIsEnabled = true;
                }
                // if all are in archive folder, then enable convertTo
                else if (IsInArchiveFolder(value))
                {
                    ConvertToIsEnabled = true;
                    ConvertFromIsEnabled = false;
                }
                // else disable both
                else
                {
                    ConvertToIsEnabled = false;
                    ConvertFromIsEnabled = false;
                }
            }
        }
    }

    private void OnNext(IChangeSet<FileModel, ulong> obj)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            BindGrid1 = new ObservableCollection<FileModel>(_observableList.Items);
        }, DispatcherPriority.ContextIdle);
    }

    #region properties

    public bool IsKeyUpEventAssigned { get; set; }

    


    [ObservableProperty]
    private ObservableCollection<FileModel> _bindGrid1 = new();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RefreshCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenRootFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(OverwriteWithGameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
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
    [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
    [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInAssetBrowserCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private FileModel? _selectedItem;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
    private ObservableCollection<object>? _selectedItems = new();

    [ObservableProperty] private bool _isFlatModeEnabled;

    [ObservableProperty] private int _selectedTabIndex;

    [ObservableProperty] private bool _convertToIsEnabled;
    [ObservableProperty] private bool _convertFromIsEnabled;

    public FileModel? LastSelected => _watcherService.LastSelect;

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
    private void Refresh() => _watcherService.QueueRefresh();

    /// <summary>
    /// Opens the currently selected folder in the tab
    /// </summary>
    private bool CanOpenRootFolder() => ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanOpenRootFolder))]
    private void OpenRootFolder()
    {
        switch (SelectedTabIndex)
        {
            case 0:
                Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().FileDirectory);
                break;
            case 1:
                Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().ModDirectory);
                break;
            case 2:
                Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().RawDirectory);
                break;
            case 3:
                Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().ResourcesDirectory);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Copies selected node to the clipboard.
    /// </summary>
    private bool CanCopyFile() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCopyFile))]
    private void CopyFile() => Clipboard.SetDataObject(SelectedItem.NotNull().FullName);

    private bool _isShowRelativePath;

    /// <summary>
    /// If neither control nor shift is being held, show "Copy relative path" context menu entry.
    /// This will also return the relative path of the current game file if executed from raw folder view.
    /// </summary>
    public bool IsShowRelativePath
    {
        get => _isShowRelativePath;
        set
        {
            if (_isShowRelativePath == value)
            {
                return;
            }

            _isShowRelativePath = value;
            OnPropertyChanged();
        }
    }

    private bool _isShowAbsolutePathToRawFolder;

    /// <summary>
    /// When holding Ctrl+Shift and right-clicking an archive item or folder, the context menu will show "Copy absolute path to raw folder".
    /// </summary>

    public bool IsShowAbsolutePathToRawFolder
    {
        get => _isShowAbsolutePathToRawFolder;
        set
        {
            if (_isShowAbsolutePathToRawFolder == value)
            {
                return;
            }

            _isShowAbsolutePathToRawFolder = value;
            OnPropertyChanged();
        }
    }

    private bool _isShowAbsolutePathToArchiveFolder;

    /// <summary>
    /// When holding Ctrl+Shift and right-clicking an item in "ra", the context menu will show "Copy absolute path to archive folder".
    /// </summary>

    public bool IsShowAbsolutePathToArchiveFolder
    {
        get => _isShowAbsolutePathToArchiveFolder;
        set
        {
            if (_isShowAbsolutePathToArchiveFolder == value)
            {
                return;
            }

            _isShowAbsolutePathToArchiveFolder = value;
            OnPropertyChanged();
        }
    }

    private bool _isShowAbsolutePathToCurrentFile;

    /// <summary>
    /// When holding Shift, the context menu will show "Copy absolute path".
    /// </summary>

    public bool IsShowAbsolutePathToCurrentFile
    {
        get => _isShowAbsolutePathToCurrentFile;
        set
        {
            if (_isShowAbsolutePathToCurrentFile == value)
            {
                return;
            }

            _isShowAbsolutePathToCurrentFile = value;
            OnPropertyChanged();
        }
    }

    private bool _isShowAbsolutePathToCurrentFolder;

    /// <summary>
    /// When holding Control, the context menu will show "Copy absolute path to folder".
    /// </summary>

    public bool IsShowAbsolutePathToCurrentFolder
    {
        get => _isShowAbsolutePathToCurrentFolder;
        set
        {
            if (_isShowAbsolutePathToCurrentFolder == value)
            {
                return;
            }

            _isShowAbsolutePathToCurrentFolder = value;
            OnPropertyChanged();
        }
    }

    private static readonly string s_rawFolder = $"{Path.DirectorySeparatorChar}raw{Path.DirectorySeparatorChar}";

    private static readonly string s_archiveFolder =
        $"{Path.DirectorySeparatorChar}archive{Path.DirectorySeparatorChar}";

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
            activeItemPath = FileModel.GetRelativeName(activeItemPath, ActiveProject.NotNull());
        }

        if (switchToRaw && !gamefileOnly && activeItemPath.Contains(s_rawFolder))
        {
            activeItemPath = activeItemPath.Replace(s_rawFolder, s_archiveFolder);
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
            return;
        }

        Clipboard.SetDataObject(activeItemPath);
    }
    
    private bool CanCopyRelPath() => ActiveProject != null && SelectedItem != null;

    /// <summary>
    /// Copy relative path to game file. If the current file is under "raw", switch to "archive" and cut off extension.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyRelPath() => CopyItemPathToClipboard(false, false, true);

    /// <summary>
    /// Copy absolute path to current file. Don't change anything else.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyAbsPathToCurrentFile() => CopyItemPathToClipboard(true);

    /// <summary>
    /// Copy absolute path to current folder. If currently selected item _is_ a folder, don't cut off the file name.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyAbsPathToCurrentFolder() =>
        CopyItemPathToClipboard(true, false, false,
            SelectedItem?.FullName is not null && Directory.Exists(SelectedItem?.FullName));


    /// <summary>
    /// Ctrl+Shift with /archive/ file or folder selected: Copy absolute path to raw folder (convenience for quick switching)
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyAbsPathToRawFolder() => CopyItemPathToClipboard(true, true, false);


    /// <summary>
    /// Ctrl+Shift with /raw/ file or folder selected: Copy absolute path to archive folder (convenience for quick switching)
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyAbsPathToArchiveFolder() => CopyItemPathToClipboard(true, true, true);


    /// <summary>
    /// Reimports the game file to replace the current one
    /// </summary>
    private bool CanAddDependencies() => ActiveProject != null && SelectedItem != null && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("xml");
    [RelayCommand(CanExecute = nameof(CanAddDependencies))]
    private async Task AddDependencies()
    {
        if (!SelectedItem.NotNull().IsDirectory)
        {
            // parse xml
            var filename = SelectedItem.FullName;
            var serializer = new XmlSerializer(typeof(MaterialXmlModel));

            using Stream reader = new FileStream(filename, FileMode.Open);
            // Call the Deserialize method to restore the object's state.
            if (serializer.Deserialize(reader) is MaterialXmlModel model)
            {
                var materials = new List<string>();
                if (model.Materials is not null)
                {
                    foreach (var material in model.Materials)
                    {
                        if (material.Param is not null)
                        {
                            foreach (var param in material.Param)
                            {
                                if (!string.IsNullOrEmpty(param.Value) && !string.IsNullOrEmpty(param.Type) && param.Type.StartsWith("rRef:"))
                                {
                                    var path = param.Value;
                                    if (!materials.Contains(path))
                                    {
                                        materials.Add(path);
                                    }
                                }
                            }
                        }
                    }
                }

                // add from AB
                foreach (var material in materials)
                {
                    var relPath = FileModel.GetRelativeName(material, ActiveProject.NotNull());
                    var hash = FNV1A64HashAlgorithm.HashString(relPath);
                    await Task.Run(() => _gameController.GetController().AddToMod(hash));
                }
            }
        }

        await Task.CompletedTask;
    }
    
    /// <summary>
    /// Reimports the game file to replace the current one
    /// </summary>
    private bool CanOverwriteWithGameFile() =>
        ActiveProject != null && SelectedItem != null && !IsInRawFolder(SelectedItem);

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

        foreach (var currentItem in (SelectedItems ?? []).Cast<FileModel>())
        {
            if (!currentItem.IsDirectory)
            {
                selectedItems.Add(currentItem.Hash);
                continue;
            }

            var files = Directory.GetFiles(currentItem.FullName, "*", SearchOption.AllDirectories).ToList();
            foreach (var hash in files
                         .Select(file => FileModel.GetRelativeName(file, ActiveProject.NotNull()))
                         .Select(FNV1A64HashAlgorithm.HashString))
            {
                selectedItems.Add(hash);
            }
        }

        if (SelectedItem is not null)
        {
            selectedItems.Add(SelectedItem.Hash); // HashSet won't add duplicate items
        }

        // Suspend file watcher, then export everything
        _watcherService.IsSuspended = true;

        // Progress nreporting
        var progress = 0;
        _progressService.Report(0);

        // Define var outside of loop
        var controller = _gameController.GetController();

        foreach (var hash in selectedItems)
        {
            await Task.Run(() => controller.AddToMod(hash));
            progress++;
            _progressService.Report(progress / (float)selectedItems.Count);
        }

        // OK, we're done
        _progressService.Completed();

        // un-suspend watcher service again
        _watcherService.IsSuspended = false;
    }

    /// <summary>
    /// Cuts selected node to the clipboard.
    /// </summary>
    private bool CanCutFile() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCutFile))]
    private void CutFile() => throw new NotImplementedException();

    /// <summary>
    /// Delets selected node.
    /// </summary>
    private bool CanDeleteFile() => ActiveProject != null && SelectedItems != null;
    [RelayCommand(CanExecute = nameof(CanDeleteFile))]
    public void DeleteFile()
    {
        var selected = SelectedItems.NotNull().OfType<FileModel>().ToList();
        var delete = Interactions.DeleteFiles(selected.Select(_ => _.Name));
        if (!delete)
        {
            return;
        }

        // Delete from file structure
        foreach (var item in selected)
        {
            var fullpath = item.FullName;
            try
            {
                if (item.IsDirectory)
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(fullpath
                        , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                        , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
                else
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fullpath
                        , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                        , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
            }
            catch (Exception)
            {
                _loggerService.Error("Failed to delete " + fullpath + ".\r\n");
            }
        }
    }

    /// <summary>
    /// Opens selected node in File Explorer.
    /// </summary>
    private bool CanOpenInFileExplorer() => ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanOpenInFileExplorer))]
    private void OpenInFileExplorer(FileModel value)
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
    private async Task OpenFile(FileModel value)
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
            for (var i = 2; ; i++)
            {
                yield return Path.Combine(dir, file + " - Copy " + i + ext);
            }
        }
    }


    /// <summary>
    /// Renames selected node. Works for files and directories.
    /// </summary>
    private bool CanRenameFile() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanRenameFile))]
    private void RenameFile()
    {
        var filename = SelectedItem.NotNull().FullName;
        var newfilename = Interactions.Rename(filename);

        if (string.IsNullOrEmpty(newfilename))
        {
            return;
        }

        var newfullpath = Path.Combine(Path.GetDirectoryName(filename).NotNull(), newfilename);

        if (File.Exists(newfullpath))
        {
            return;
        }

        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(newfullpath).NotNull());
            if (SelectedItem.IsDirectory)
            {
                Directory.Move(filename, newfullpath);
            }
            else
            {
                File.Move(filename, newfullpath);
            }
        }
        catch
        {
        }


    }

    #endregion general commands

    #region red4

    private bool IsInArchiveFolder(FileModel model) => ActiveProject is not null && model.FullName.Contains(ActiveProject.ModDirectory);
    private bool IsInRawFolder(FileModel model) => ActiveProject is not null && model.FullName.Contains(ActiveProject.RawDirectory);

    private bool CanConvertTo() => SelectedItems != null && ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanConvertTo))]
    private async Task ConvertToAsync()
    {
        _watcherService.IsSuspended = true;
        
        var progress = 0;
        _progressService.Report(0);

        List<string> files = new();

        // get all files
        foreach (var item in SelectedItems.NotNull().OfType<FileModel>().Where(x => !IsInRawFolder(x)))
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
            await ConvertToJsonAsync(file);

            progress++;
            _progressService.Report(progress / (float)files.Count);
        }

        _watcherService.IsSuspended = false;

        _progressService.Completed();
    }

    private async Task ConvertToJsonAsync(string file)
    {
        if (!File.Exists(file))
        {
            return;
        }

        if (!Enum.GetNames<ERedExtension>().Contains(Path.GetExtension(file).TrimStart('.').ToLower()))
        {
            return;
        }

        var rawOutPath = Path.Combine(ActiveProject.NotNull().RawDirectory, FileModel.GetRelativeName(file, ActiveProject));
        var outDirectoryPath = Path.GetDirectoryName(rawOutPath);
        if (outDirectoryPath != null)
        {
            Directory.CreateDirectory(outDirectoryPath);

            await _modTools.ConvertToJsonAndWriteAsync(file, new DirectoryInfo(outDirectoryPath));
        }
    }


    private bool CanConvertFromJson() => SelectedItems != null && ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanConvertFromJson))]
    private async Task ConvertFromAsync()
    {
        _watcherService.IsSuspended = true;

        var progress = 0;
        _progressService.Report(0);

        List<string> files = new();

        // get all files
        foreach (var item in SelectedItems.NotNull().OfType<FileModel>().Where(x => IsInRawFolder(x)))
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

        _watcherService.IsSuspended = false;

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

        var modPath = Path.Combine(ActiveProject.NotNull().ModDirectory, FileModel.GetRelativeName(file, ActiveProject));
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
    private bool CanOpenInAssetBrowser() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
    [RelayCommand(CanExecute = nameof(CanOpenInAssetBrowser))]
    private void OpenInAssetBrowser()
    {
        _mainViewModel.NotNull().GetToolViewModel<AssetBrowserViewModel>().IsVisible = true;
        _mainViewModel.GetToolViewModel<AssetBrowserViewModel>().ShowFile(SelectedItem.NotNull());
    }

    private static string GetSecondExtension(FileModel model) => Path.GetExtension(Path.ChangeExtension(model.FullName, "").TrimEnd('.')).TrimStart('.');

    private bool CanOpenInMlsb()
    {
        return ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory 
            && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Equals(ETextConvertFormat.json.ToString(), StringComparison.Ordinal) 
            && GetSecondExtension(SelectedItem).Equals(ERedExtension.mlsetup.ToString(), StringComparison.Ordinal)
            && PluginService.IsInstalled(EPlugin.mlsetupbuilder);
    }

    [RelayCommand(CanExecute = nameof(CanOpenInMlsb))]
    private void OpenInMlsb()
    {
        if (PluginService.TryGetInstallPath(EPlugin.mlsetupbuilder, out var path))
        {
            if (!Directory.Exists(path))
            {
                _loggerService.Error($"Mlsetupbuilder not found: {path}");
                return;
            }

            var firstFolder = Directory.GetDirectories(path).FirstOrDefault();
            if (firstFolder is null)
            {
                _loggerService.Error($"Mlsetupbuilder not found: {path}");
                return;
            }

            var exe = Path.Combine(firstFolder, "MlsetupBuilder.exe");

            if (!File.Exists(exe))
            {
                _loggerService.Error($"Mlsetupbuilder exe not found: {exe}");
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
    private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

    #endregion Methods

    #region ModifierStateAwareness

    // ####################################################################################
    // Integrate with _modifierViewStatesModel to expose keys to view 
    // ####################################################################################

    public bool IsShiftKeyPressedOnly => _modifierViewStateService.IsShiftKeyPressedOnly;
    public bool IsCtrlKeyPressedOnly => _modifierViewStateService.IsCtrlKeyPressedOnly;
    public bool IsNoModifierPressed => _modifierViewStateService.IsNoModifierPressed;

    /// <summary>
    /// Called in constructor
    /// </summary>
    private void RegisterModifierStateAwareness()
    {
        _modifierViewStateService.SetLogger(_loggerService);
        _modifierViewStateService.ModifierStateChanged += OnModifierUpdateEvent;
        _modifierViewStateService.PropertyChanged += OnModifierChanged;
    }

    /// <summary>
    /// Reacts to ModifierViewStatesModel's emitted events
    /// </summary>
    private void OnModifierUpdateEvent()
    {
        IsShowAbsolutePathToRawFolder =
            _modifierViewStateService.IsCtrlShiftOnlyPressed &&
            SelectedItem?.FullName.Contains(s_archiveFolder) == true;

        IsShowAbsolutePathToArchiveFolder =
            _modifierViewStateService.IsCtrlShiftOnlyPressed && SelectedItem?.FullName.Contains(s_rawFolder) == true;
    }

    /// <summary>
    /// Forward ModifierViewStateModel's PropertyChanged events to the view
    /// </summary>
    private void OnModifierChanged(object? sender, PropertyChangedEventArgs e) => OnPropertyChanged(e.PropertyName);

    /// <summary>
    /// Passes key state changes from view down to ModifierViewStatesModel
    /// </summary>
    public void RefreshModifierStates() => _modifierViewStateService.RefreshModifierStates();

    #endregion
}
