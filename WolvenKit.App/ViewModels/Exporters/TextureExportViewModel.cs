using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using DynamicData;
using Newtonsoft.Json;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Importers;
public partial class TextureExportViewModel : ToolViewModel
{
    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly ISettingsManager _settingsManager;
    private readonly IWatcherService _watcherService;
    private readonly IProgressService<double> _progressService;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IArchiveManager _archiveManager;
    private readonly IPluginService _pluginService;
    private readonly IModTools _modTools;

    public TextureExportViewModel(
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IWatcherService watcherService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        INotificationService notificationService,
        IArchiveManager archiveManager,
        IPluginService pluginService,
        IModTools modTools,
        IProgressService<double> progressService) : base("TextureExportViewModel")
    {
        _gameController = gameController;
        _settingsManager = settingsManager;
        _watcherService = watcherService;
        _loggerService = loggerService;
        _projectManager = projectManager;
        _notificationService = notificationService;
        _archiveManager = archiveManager;
        _pluginService = pluginService;
        _modTools = modTools;
        _progressService = progressService;

        ProcessAllCommand = ReactiveCommand.CreateFromTask(ExecuteProcessAll);
        ProcessSelectedCommand = ReactiveCommand.CreateFromTask(ExecuteProcessSelected);
        CopyArgumentsTemplateToCommand = new DelegateCommand<string>(ExecuteCopyArgumentsTemplateTo, CanCopyArgumentsTemplateTo);

        LoadFiles();
    }

    private void LoadFiles()
    {
        var files = Directory.GetFiles(_projectManager.ActiveProject.ModDirectory, "*", SearchOption.AllDirectories)
            .Where(CanExport)
            .Select(x => new ExportableItemViewModel(x));

        ExportableItems = new(files);
    }

    private static bool CanExport(string x)
    {
        var ext = Path.GetExtension(x).TrimStart('.');

        if (!Enum.TryParse<ECookedFileFormat>(ext, out var _))
        {
            return false;
        }

        return true;
    }

    //public override ReactiveCommand<Unit, Unit> CancelCommand { get; }
    //public override ReactiveCommand<Unit, Unit> OkCommand { get; }

    /// <summary>
    /// Selected object , returns a Importable/Exportable ItemVM based on "IsImportsSelected"
    /// </summary>
    [Reactive] public ExportableItemViewModel SelectedObject { get; set; }

    /// <summary>
    /// Public Exportable items.
    /// </summary>
    public ObservableCollection<ExportableItemViewModel> ExportableItems { get; set; }

    [Reactive] public bool IsProcessing { get; set; } = false;




    /// <summary>
    /// Process all in Import / Export Grid Command.
    /// </summary>
    public ReactiveCommand<Unit, Unit> ProcessAllCommand { get; private set; }
    /// <summary>
    /// Process selected in Import / Export Grid Command
    /// </summary>
    public ICommand ProcessSelectedCommand { get; private set; }


    /// <summary>
    /// Helper Task to Execute Bulk Processing in Import / Export Grid Command
    /// 
    /// </summary>
    private async Task ExecuteProcessBulk(bool all = false)
    {
        IsProcessing = true;
        _watcherService.IsSuspended = true;
        var progress = 0;
        _progressService.Report(0);

        var total = 0;
        var sucessful = 0;

        //prepare a list of failed items
        var failedItems = new List<string>();

        var toBeExported = ExportableItems.Where(_ => all || _.IsChecked).ToList();
        total = toBeExported.Count;
        foreach (var item in toBeExported)
        {
            if (await Task.Run(() => ExportSingle(item)))
            {
                sucessful++;
            }
            else
            {
                failedItems.Add(item.FullName);
            }

            Interlocked.Increment(ref progress);
            _progressService.Report(progress / (float)total);
        }

        IsProcessing = false;

        _watcherService.IsSuspended = false;
        await _watcherService.RefreshAsync(_projectManager.ActiveProject);
        _progressService.IsIndeterminate = false;

        _notificationService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");
        _loggerService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");

        //We format the list of failed export/import items here
        if (failedItems.Count > 0)
        {
            var failedItemsErrorString = $"The following items failed:\n{string.Join("\n", failedItems)}";
            _notificationService.Error(failedItemsErrorString); //notify once only 
            _loggerService.Error(failedItemsErrorString);
        }

        _progressService.Completed();
    }

    /// <summary>
    /// Execute Process all in Import / Export Grid Command.
    /// Uses ExecuteProcessBulk
    /// </summary>
    private async Task ExecuteProcessAll() => await ExecuteProcessBulk(true); //the all parameter is set to true

    /// <summary>
    /// Execute Process Selected in Import / Export Grid Command.
    /// Uses ExecuteProcessBulk
    /// </summary>
    private async Task ExecuteProcessSelected() => await ExecuteProcessBulk(); //the all parameter's default is false


    /// <summary>
    /// Export Single Item
    /// </summary>
    /// <param name="item"></param>
    private bool ExportSingle(ExportableItemViewModel item)
    {
        var proj = _projectManager.ActiveProject;
        var fi = new FileInfo(item.FullName);
        if (fi.Exists)
        {
            if (item.Properties is MeshExportArgs meshExportArgs)
            {
                meshExportArgs.Archives.Clear();
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    meshExportArgs.Archives.AddRange(_archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList());
                }

                meshExportArgs.Archives.Insert(0, new FileSystemArchive(_projectManager.ActiveProject.ModDirectory));

                meshExportArgs.MaterialRepo = _settingsManager.MaterialRepositoryPath;
            }
            if (item.Properties is MorphTargetExportArgs morphTargetExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    morphTargetExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
                morphTargetExportArgs.ModFolderPath = _projectManager.ActiveProject.ModDirectory;
            }
            if (item.Properties is OpusExportArgs opusExportArgs)
            {
                opusExportArgs.RawFolderPath = proj.RawDirectory;
                opusExportArgs.ModFolderPath = proj.ModDirectory;
            }
            if (item.Properties is EntityExportArgs entExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    entExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
            }
            if (item.Properties is AnimationExportArgs animationExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    animationExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
            }

            if (proj != null)
            {

            }

            var settings = new GlobalExportArgs().Register(item.Properties as ExportArgs);
            return _modTools.Export(fi, settings,
                new DirectoryInfo(proj.ModDirectory),
                new DirectoryInfo(proj.RawDirectory));
        }

        return false;
    }




    public ICommand CopyArgumentsTemplateToCommand { get; private set; }

    private bool CanCopyArgumentsTemplateTo(string param) => true;

    private void ExecuteCopyArgumentsTemplateTo(string param)
    {
        //var current = SelectedObject.Properties;


        //if (current is not ExportArgs exportArgs)
        //{
        //    return;
        //}

        //var json = SerializeArgs(exportArgs);

        //var results = param switch
        //{
        //    s_selectedInGrid => ExportableItems.Where(_ => _.IsChecked),
        //    _ => ExportableItems
        //};

        //foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
        //{
        //    item.Properties = (ExportArgs)json.Deserialize(exportArgs.GetType(), s_jsonSerializerSettings);
        //}


        //SaveSettings();
        //_notificationService.Success($"Template has been copied to the selected items.");
    }

}
