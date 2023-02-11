using Microsoft.Extensions.Options;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.Factories;

public class DocumentViewmodelFactory : IDocumentViewmodelFactory
{
    private readonly ITabViewmodelFactory _tabViewmodelFactory;

    private readonly IProjectManager _projectManager;
    private readonly ILoggerService _loggerService;
    private readonly IOptions<Globals> _globals;
    private readonly Red4ParserService _parserService;
    private readonly IWatcherService _watcherService;
    private readonly IArchiveManager _archiveManager;
    private readonly ExtendedScriptService _scriptService;
    private readonly IPaneViewModelFactory _paneViewModelFactory;

    public DocumentViewmodelFactory(
        IProjectManager projectManager,
        ILoggerService loggerService,
        IOptions<Globals> globals,
        Red4ParserService parserService,
        IWatcherService watcherService,
        IArchiveManager archiveManager,
        ExtendedScriptService scriptService,
        ITabViewmodelFactory tabViewmodelFactory,
        IPaneViewModelFactory paneViewModelFactory)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _globals = globals;
        _parserService = parserService;
        _watcherService = watcherService;
        _archiveManager = archiveManager;
        _scriptService = scriptService;
        _tabViewmodelFactory = tabViewmodelFactory;
        _paneViewModelFactory = paneViewModelFactory;
    }
    public RedDocumentViewModel RedDocumentViewModel(CR2WFile file, string path, AppViewModel appViewModel) 
        => new(file, path, appViewModel, _tabViewmodelFactory, _projectManager, _loggerService, _globals, _parserService, _watcherService, _archiveManager);

    public WScriptDocumentViewModel WScriptDocumentViewModel(string path) 
        => new(path, _projectManager, _loggerService, _parserService, _watcherService, _archiveManager, _scriptService, _paneViewModelFactory);

    public TweakXLDocumentViewModel TweakXLDocumentViewModel(string path) => new(path);
}
