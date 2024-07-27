using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ClearScript.V8;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.Services;

public partial class AppScriptService : ScriptService
{
    private readonly AppScriptFunctions _wkit;
    
    private readonly ISettingsManager _settingsManager;
    private readonly IHookService _hookService;

    public Dictionary<string, object> DefaultHostObject { get; }

    public AppScriptService(
        ISettingsManager settingsManager,
        ILoggerService loggerService, 
        IProjectManager projectManager, 
        IArchiveManager archiveManager,
        Red4ParserService red4ParserService,
        IModTools modTools,
        ImportExportHelper importExportHelper,
        IHookService hookService,
        IGameControllerFactory gameController,
        GeometryCacheService geometryCacheService) : base(loggerService)
    {
        _settingsManager = settingsManager;
        _hookService = hookService;

        _wkit = new AppScriptFunctions(_loggerService, projectManager, archiveManager, red4ParserService, modTools, importExportHelper, gameController, geometryCacheService);
        _ui = new UiScriptFunctions(this);
        
        DefaultHostObject = new() { { "wkit", _wkit } };

        RegisterHooks();
        RefreshUIScripts();
    }


    private ProjectExplorerViewModel? _projectExplorerViewModel = null;

    private ProjectExplorerViewModel? GetProjectExplorerViewModel()
    {
        _projectExplorerViewModel ??= Locator.Current.GetService<ProjectExplorerViewModel>();
        return _projectExplorerViewModel;
    }

    public async Task ExecuteAsync(string code)
    {
        GetProjectExplorerViewModel()?.SuspendFileWatcher();
        await ExecuteAsync(code, DefaultHostObject);
        GetProjectExplorerViewModel()?.ResumeFileWatcher();
    }

    public void SetAppViewModel(AppViewModel appViewModel) => _wkit.AppViewModel = appViewModel;

    public IList<ScriptFile> GetScripts()
    {
        var result = GetScripts(ISettingsManager.GetWScriptDir());

        foreach (var scriptFile in GetScripts(@"Resources\Scripts"))
        {
            if (result.All(x => x.Name != scriptFile.Name))
            {
                result.Add(scriptFile);
            }
        }

        return result;
    }

    protected override V8ScriptEngine GetScriptEngine(Dictionary<string, object>? hostObjects = null, List<string>? searchPaths = null)
    {
        searchPaths ??= new List<string> { ISettingsManager.GetWScriptDir(), Path.GetFullPath(@"Resources\Scripts") };

        var engine = base.GetScriptEngine(hostObjects, searchPaths);

        engine.AddHostType(typeof(EUncookExtension));
        engine.AddHostType(typeof(MeshExporterType));
        engine.AddHostType(typeof(MeshExportType));
        engine.AddHostType(typeof(WemExportTypes));

        engine.AddHostType(typeof(WMessageBoxImage));
        engine.AddHostType(typeof(WMessageBoxButtons));
        engine.AddHostType(typeof(WMessageBoxResult));

        return engine;
    }
}