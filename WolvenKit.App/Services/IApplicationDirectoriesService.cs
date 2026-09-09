namespace WolvenKit.App.Services;

public interface IApplicationDirectoriesService
{
    string AppDataDir { get; }
    string LogsDir { get; }
    string ManagerCacheDir { get; }
    string WorkDir { get; }
    string TempAudioDir { get; }
    string TempObjDir { get; }
    string TempAudioImportDir { get; }
    string TempVideoPreviewDir { get; }
    string WScriptDir { get; }
    string UserTemplateDir { get; }
    string MaterialDepotDir { get; }
    string ConfigFile { get; }
    string DockStatesFile { get; }
    string RecentItemsFile { get; }
}
