using WolvenKit.App.Controllers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Factories;

public class DocumentTabViewmodelFactory : IDocumentTabViewmodelFactory
{
    private readonly ILoggerService _loggerService;
    private readonly Red4ParserService _parserService;
    private readonly ISettingsManager _settingsManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IModTools _modTools;
    private readonly GeometryCacheService _geometryCacheService;

    public DocumentTabViewmodelFactory(
        ILoggerService loggerService,
        Red4ParserService parserService,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController,
        IModTools modTools,
        GeometryCacheService geometryCacheService)
    {
        _loggerService = loggerService;
        _parserService = parserService;
        _settingsManager = settingsManager;
        _gameController = gameController;
        _modTools = modTools;
        _geometryCacheService = geometryCacheService;
    }

    public RDTInkTextureAtlasViewModel RDTInkTextureAtlasViewModel(inkTextureAtlas atlas, RedDocumentViewModel file) => new(atlas, file);
    public RDTTextureViewModel RDTTextureViewModel(RedBaseClass data, RedDocumentViewModel file) => new(data, file, _loggerService, _parserService);
    public RDTLayeredPreviewViewModel RDTLayeredPreviewViewModel(Multilayer_Mask multilayerMask, RedDocumentViewModel file) => new(multilayerMask, file);
    public RDTLayeredPreviewViewModel RDTLayeredPreviewViewModel(CTextureArray textureArray, RedDocumentViewModel file) => new(textureArray, file);
    public RDTLayeredPreviewViewModel RDTLayeredPreviewViewModel(CReflectionProbeDataResource textureArray, RedDocumentViewModel file) => new(textureArray, file);

    public RDTDataViewModel RDTDataViewModel(IRedType data, RedDocumentViewModel parent, AppViewModel appViewModel, IChunkViewmodelFactory chunkViewmodelFactory) 
        => new(data, parent, appViewModel, chunkViewmodelFactory, _settingsManager, _gameController);
    public RDTDataViewModel RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file, AppViewModel appViewModel, IChunkViewmodelFactory chunkViewmodelFactory) 
        => new(header, data, file, appViewModel, chunkViewmodelFactory, _settingsManager, _gameController);

    public RDTMeshViewModel RDTMeshViewModel(CMesh data, RedDocumentViewModel file) 
        => new(data, file, _settingsManager, _gameController, _loggerService, _parserService, _modTools, _geometryCacheService);
    public RDTMeshViewModel RDTMeshViewModel(worldStreamingSector data, RedDocumentViewModel file) 
        => new(data, file, _settingsManager, _gameController, _loggerService, _parserService, _modTools, _geometryCacheService);
    public RDTMeshViewModel RDTMeshViewModel(worldStreamingBlock data, RedDocumentViewModel file) 
        => new(data, file, _settingsManager, _gameController, _loggerService, _parserService, _modTools, _geometryCacheService);
    public RDTMeshViewModel RDTMeshViewModel(entEntityTemplate data, RedDocumentViewModel file) 
        => new(data, file, _settingsManager, _gameController, _loggerService, _parserService, _modTools, _geometryCacheService);
}