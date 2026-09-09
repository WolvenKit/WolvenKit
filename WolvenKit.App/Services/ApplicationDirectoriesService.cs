using System.IO;
using WolvenKit.App.Models;

namespace WolvenKit.App.Services;

public class ApplicationDirectoriesService : IApplicationDirectoriesService
{
    private string appDataRoot;

    public ApplicationDirectoriesService(IInstanceSettings instanceSettings)
    {
        appDataRoot = instanceSettings.AppDataPath;
    }

    public string AppDataDir
    {
        get
        {
            Directory.CreateDirectory(appDataRoot);
            return appDataRoot;
        }
    }

    public string LogsDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Logs");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string ManagerCacheDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Config");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string WorkDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "tmp_workdir");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempAudioDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Temp_Audio");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempObjDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Temp_OBJ");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempAudioImportDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Temp_Audio_Import");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempVideoPreviewDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Temp_Video_Preview");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string WScriptDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "WScript");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string UserTemplateDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Templates");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string MaterialDepotDir
    {
        get
        {
            var dir = Path.Combine(appDataRoot, "Depot");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string ConfigFile => Path.Combine(appDataRoot, "config.json");
    public string DockStatesFile => Path.Combine(appDataRoot, "DockStates.xml");
    public string RecentItemsFile => Path.Combine(appDataRoot, "recentItems.json");
}
