using WolvenKit.App.Controllers;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.Services;

namespace WolvenKit.App.Factories;

public interface IFactory<T> where T : class
{

}

public class ChunkViewmodelFactory : IChunkViewmodelFactory, IFactory<ChunkViewModel>
{
    private readonly IDocumentTabViewmodelFactory _tabViewmodelFactory;
    private readonly IHashService _hashService;
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameController;
    private readonly ISettingsManager _settingsManager;
    private readonly IAppArchiveManager _archiveManager;
    private readonly ITweakDBService _tweakDbService;
    private readonly ILocKeyService _locKeyService;
    private readonly Red4ParserService _parserService;
    private readonly CRUIDService _cruidService;

    public ChunkViewmodelFactory(
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IAppArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        Red4ParserService parserService,
        CRUIDService cruidService)
    {
        _tabViewmodelFactory = tabViewmodelFactory;
        _hashService = hashService;
        _loggerService = loggerService;
        _projectManager = projectManager;
        _gameController = gameController;
        _settingsManager = settingsManager;
        _archiveManager = archiveManager;
        _tweakDbService = tweakDbService;
        _locKeyService = locKeyService;
        _parserService = parserService;
        _cruidService = cruidService;
    }
    
    public ChunkViewModel ChunkViewModel(IRedType rootChunk, string name, AppViewModel appViewModel,
        ChunkViewModel? parent = null, bool isReadOnly = false) =>
        new ChunkViewModel(rootChunk, name, appViewModel,
            this,
            _tabViewmodelFactory,
            _hashService,
            _loggerService,
            _projectManager,
            _gameController,
            _settingsManager,
            _archiveManager,
            _tweakDbService,
            _locKeyService,
            _parserService,
            _cruidService,
            parent,
            isReadOnly).SetInitialExpansionState();

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, ReferenceSocket socket, AppViewModel appViewModel,
        bool isReadOnly = false) =>
        new ChunkViewModel(rootChunk, socket, appViewModel,
            this,
            _tabViewmodelFactory,
            _hashService,
            _loggerService,
            _projectManager,
            _gameController,
            _settingsManager,
            _archiveManager,
            _tweakDbService,
            _locKeyService,
            _parserService,
            _cruidService,
            isReadOnly).SetInitialExpansionState();

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, RDTDataViewModel tab, AppViewModel appViewModel,
        bool isReadOnly = false) =>
        new ChunkViewModel(rootChunk, tab, appViewModel,
            this,
            _tabViewmodelFactory,
            _hashService,
            _loggerService,
            _projectManager,
            _gameController,
            _settingsManager,
            _archiveManager,
            _tweakDbService,
            _locKeyService,
            _parserService,
            _cruidService,
            isReadOnly).SetInitialExpansionState();
}