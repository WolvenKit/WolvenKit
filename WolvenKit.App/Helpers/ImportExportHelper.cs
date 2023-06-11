using System.IO;
using System.Linq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.Helpers;

public class ImportExportHelper
{
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IArchiveManager _archiveManager;
    private readonly ISettingsManager _settingsManager;
    private readonly IPluginService _pluginService;

    public ImportExportHelper(
        ILoggerService loggerService,
        IProjectManager projectManager, 
        IGameControllerFactory gameController, 
        IArchiveManager archiveManager, 
        ISettingsManager settingsManager,
        IPluginService pluginService)
    {
        _loggerService = loggerService;
        _projectManager = projectManager;
        _gameController = gameController;
        _archiveManager = archiveManager;
        _settingsManager = settingsManager;
        _pluginService = pluginService;
    }

    public bool Finalize(GlobalExportArgs args) =>
        Finalize(args.Get<MeshExportArgs>()) &&
        Finalize(args.Get<MorphTargetExportArgs>()) &&
        Finalize(args.Get<OpusExportArgs>()) &&
        Finalize(args.Get<EntityExportArgs>()) &&
        Finalize(args.Get<AnimationExportArgs>());

    public bool Finalize(MeshExportArgs args)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return false;
        }

        args.Archives.Clear();
        if (_gameController.GetController() is RED4Controller)
        {
            args.Archives.AddRange(_archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList());
        }

        args.Archives.Insert(0, proj.AsArchive());
        args.MaterialRepo = _settingsManager.MaterialRepositoryPath;

        return true;
    }

    public bool Finalize(MorphTargetExportArgs args)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return false;
        }

        args.Archives.Clear();
        if (_gameController.GetController() is RED4Controller)
        {
            args.Archives.AddRange(_archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList());
        }

        args.ModFolderPath = proj.ModDirectory;

        return true;
    }

    public bool Finalize(OpusExportArgs args)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return false;
        }

        args.RawFolderPath = proj.RawDirectory;
        args.ModFolderPath = proj.ModDirectory;

        return true;
    }

    public bool Finalize(EntityExportArgs args)
    {
        args.Archives.Clear();
        if (_gameController.GetController() is RED4Controller)
        {
            args.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
        }

        return true;
    }

    public bool Finalize(AnimationExportArgs args)
    {
        args.Archives.Clear();
        if (_gameController.GetController() is RED4Controller)
        {
            args.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
        }

        return true;
    }

    public bool Finalize(GlobalImportArgs args) =>
        Finalize(args.Get<GltfImportArgs>()) &&
        Finalize(args.Get<ReImportArgs>());

    public bool Finalize(GltfImportArgs args)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return false;
        }

        args.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
        args.Archives.Insert(0, proj.AsArchive());

        return true;
    }

    public bool Finalize(ReImportArgs args)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return false;
        }

        if (!_pluginService.IsInstalled(EPlugin.redmod))
        {
            _loggerService.Error("Redmod plugin needs to be installed to import animations");
            return false;
        }

        args.Depot = proj.ModDirectory;
        args.RedMod = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");

        return true;
    }
}