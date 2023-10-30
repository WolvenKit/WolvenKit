using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ISettingsManager settingsManager) : base(ToolTitle)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _watcherService = watcherService;
        _modTools = modTools;
        _progressService = progressService;
        _gameController = gameController;
        _pluginService = pluginService;
        _settingsManager = settingsManager;

        _mainViewModel = appViewModel;

        SideInDockedMode = DockSide.Left;

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
    [NotifyCanExecuteChangedFor(nameof(ReimportFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
    [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(Bk2ImportCommand))]
    [NotifyCanExecuteChangedFor(nameof(Bk2ExportCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInAssetBrowserCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
    private Cp77Project? _activeProject;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CopyFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(ReimportFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
    [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(Bk2ImportCommand))]
    [NotifyCanExecuteChangedFor(nameof(Bk2ExportCommand))]
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

    /// <summary>
    /// Copies relative path of node.
    /// </summary>
    private bool CanCopyRelPath() => ActiveProject != null && SelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyRelPath() => Clipboard.SetDataObject(FileModel.GetRelativeName(SelectedItem.NotNull().FullName, ActiveProject.NotNull()));

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
    private bool CanReimportFile() => ActiveProject != null && SelectedItem != null && !IsInRawFolder(SelectedItem);
    [RelayCommand(CanExecute = nameof(CanReimportFile))]
    private async Task ReimportFile()
    {
        if (SelectedItem.NotNull().IsDirectory)
        {
            _watcherService.IsSuspended = true;

            var progress = 0;
            _progressService.Report(0);

            var files = Directory.GetFiles(SelectedItem.FullName, "*", SearchOption.AllDirectories).ToList();
            foreach (var file in files)
            {
                var relPath = FileModel.GetRelativeName(file, ActiveProject.NotNull());
                var hash = FNV1A64HashAlgorithm.HashString(relPath);
                await Task.Run(() => _gameController.GetController().AddToMod(hash));

                progress++;
                _progressService.Report(progress / (float)files.Count);
            }

            _watcherService.IsSuspended = false;

            _progressService.Completed();
        }
        else
        {
            _gameController.GetController().AddToMod(SelectedItem.Hash);
        }
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
    /// Renames selected node.
    /// </summary>
    private bool CanRenameFile() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
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

    private bool CanBk2Import() => SelectedItem != null && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("avi") && ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanBk2Import))]
    private void Bk2Import()
    {
        var modpath = Path.Combine(ActiveProject.NotNull().ModDirectory, FileModel.GetRelativeName(SelectedItem.NotNull().FullName, ActiveProject));
        modpath = Path.ChangeExtension(modpath, ".bk2");
        var directoryName = Path.GetDirectoryName(modpath).NotNull();
       
    }

    private bool CanBk2Export() => SelectedItem != null && !IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("bk2") && ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanBk2Export))]
    private void Bk2Export()
    {
        var rawpath = Path.Combine(ActiveProject.NotNull().RawDirectory, FileModel.GetRelativeName(SelectedItem.NotNull().FullName, ActiveProject));
        rawpath = Path.ChangeExtension(rawpath, ".avi");
        var directoryName = Path.GetDirectoryName(rawpath).NotNull();
        
    }

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
        if (outDirectoryPath != null)
        {
            Directory.CreateDirectory(outDirectoryPath);

            await _modTools.ConvertFromJsonAndWriteAsync(new FileInfo(file), new DirectoryInfo(outDirectoryPath));
        }

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
}
