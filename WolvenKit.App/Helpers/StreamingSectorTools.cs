using WolvenKit.App.Services;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

public class StreamingSectorTools
{
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IModTools _modTools;
    private readonly Cr2WTools _cr2WTools;
    private readonly DocumentTools _documentTools;
    private readonly ProjectResourceTools _projectResourceTools;
    private readonly ISettingsManager _settingsManager;
    private readonly IAppArchiveManager _archiveManager;

    public StreamingSectorTools(ILoggerService loggerService, IProjectManager projectManager, IModTools modTools,
        Cr2WTools cr2WTools, DocumentTools documentTools, ProjectResourceTools projectResourceTools,
        ISettingsManager settingsManager, IAppArchiveManager archiveManager)
    {
        _loggerService = loggerService;
        _projectManager = projectManager;
        _modTools = modTools;
        _cr2WTools = cr2WTools;
        _documentTools = documentTools;
        _projectResourceTools = projectResourceTools;
        _settingsManager = settingsManager;
        _settingsManager = settingsManager;
        _archiveManager = archiveManager;
    }
}
