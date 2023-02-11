using WolvenKit.App.Controllers;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.Services;

namespace WolvenKit.App.Factories;

public class ChunkViewmodelFactory : IChunkViewmodelFactory
{
    private readonly ITabViewmodelFactory _tabViewmodelFactory;

    private readonly ILoggerService _loggerService;
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IArchiveManager _archiveManager;
    private readonly AppViewModel _appViewModel;
    private readonly TweakDBService _tweakDbService;
    private readonly LocKeyService _locKeyService;
    private readonly Red4ParserService _parserService;

    public ChunkViewmodelFactory(
        ITabViewmodelFactory tabViewmodelFactory,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IArchiveManager archiveManager,
        AppViewModel appViewModel,
        TweakDBService tweakDbService,
        LocKeyService locKeyService,
        Red4ParserService parserService)
    {
        _tabViewmodelFactory = tabViewmodelFactory;
        _loggerService = loggerService;
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _gameController = gameController;
        _archiveManager = archiveManager;
        _appViewModel = appViewModel;
        _tweakDbService = tweakDbService;
        _locKeyService = locKeyService;
        _parserService = parserService;
    }

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, ReferenceSocket socket)
    {
        return new ChunkViewModel(rootChunk, socket,
            this,
            _tabViewmodelFactory,
            _loggerService,
            _projectManager,
            _gameController,
            _settingsManager,
            _archiveManager,
            _appViewModel,
            _tweakDbService,
            _locKeyService,
            _parserService);
    }

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, RDTDataViewModel tab)
    {
        return new ChunkViewModel(rootChunk, tab,
            this,
            _tabViewmodelFactory,
            _loggerService,
            _projectManager,
            _gameController,
            _settingsManager,
            _archiveManager,
            _appViewModel,
            _tweakDbService,
            _locKeyService,
            _parserService);
    }

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, string name, ChunkViewModel? parent = null, bool isReadOnly = false)
    {
        return new ChunkViewModel(rootChunk, name,
            this,
            _tabViewmodelFactory,
            _loggerService,
            _projectManager,
            _gameController,
            _settingsManager,
            _archiveManager,
            _appViewModel,
            _tweakDbService,
            _locKeyService,
            _parserService,
            parent,
            isReadOnly);
    }
}