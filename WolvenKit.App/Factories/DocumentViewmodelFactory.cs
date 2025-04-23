using Microsoft.Extensions.Options;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.Factories;

public class DocumentViewmodelFactory : IDocumentViewmodelFactory
{
    private readonly IDocumentTabViewmodelFactory _tabViewmodelFactory;
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;

    private readonly IProjectManager _projectManager;
    private readonly ILoggerService _loggerService;
    private readonly IOptions<Globals> _globals;
    private readonly Red4ParserService _parserService;
    private readonly IArchiveManager _archiveManager;
    private readonly AppScriptService _scriptService;
    private readonly IHookService _hookService;
    private readonly INodeWrapperFactory _nodeWrapperFactory;
    private readonly ISettingsManager _settingsManager;
    private readonly Cr2WTools _cr2WTools;


    public DocumentViewmodelFactory(
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IOptions<Globals> globals,
        Red4ParserService parserService,
        IArchiveManager archiveManager,
        AppScriptService scriptService,
        IHookService hookService,
        INodeWrapperFactory nodeWrapperFactory,
        ISettingsManager settingsManager,
        IHashService hashService,
        Cr2WTools cr2WTools
    )
    {
        _tabViewmodelFactory = tabViewmodelFactory;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _projectManager = projectManager;
        _loggerService = loggerService;
        _globals = globals;
        _parserService = parserService;
        _archiveManager = archiveManager;
        _scriptService = scriptService;
        _hookService = hookService;
        _nodeWrapperFactory = nodeWrapperFactory;
        _settingsManager = settingsManager;
        _cr2WTools = cr2WTools;
    }

    public RedDocumentViewModel RedDocumentViewModel(CR2WFile file, string path, AppViewModel appViewModel, bool isReadOnly = false)
        => new(file, path, appViewModel, _tabViewmodelFactory, _chunkViewmodelFactory, _projectManager, _loggerService, _globals,
            _parserService, _archiveManager, _hookService, _nodeWrapperFactory,
            _cr2WTools, _settingsManager, isReadOnly);

    public WScriptDocumentViewModel WScriptDocumentViewModel(string path) => new(path, _scriptService);

    public TweakXLDocumentViewModel TweakXLDocumentViewModel(string path) => new(path);
}
