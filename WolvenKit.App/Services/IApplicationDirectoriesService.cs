namespace WolvenKit.App.Services;

public interface IApplicationDirectoriesService
{
    string AppData { get; }
    string LogsDir { get; }
    string ManagerCacheDir { get; }
    string WorkDir { get; }
    string TempAudioDir { get; }
    string TempObjDir { get; }
    string TempAudioImportDir { get; }
    string TempVideoPreviewPath { get; }
    string WScriptDir { get; }
    string UserTemplateDir { get; }
}
