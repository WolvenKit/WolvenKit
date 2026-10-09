using System.IO;
using WolvenKit.App.Models;

namespace WolvenKit.App.Services;

public class ApplicationDirectoriesService : IApplicationDirectoriesService
{
    private IInstanceSettings _instanceSettings;

    public ApplicationDirectoriesService(IInstanceSettings instanceSettings)
    {
        _instanceSettings = instanceSettings;
    }

    public string AppDataDir
    {
        get
        {
            Directory.CreateDirectory(_instanceSettings.AppDataPath);
            return _instanceSettings.AppDataPath;
        }
    }

    public string LogsDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Logs");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string ManagerCacheDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Config");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string WorkDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "tmp_workdir");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempAudioDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Temp_Audio");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempObjDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Temp_OBJ");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempAudioImportDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Temp_Audio_Import");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string TempVideoPreviewDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Temp_Video_Preview");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string WScriptDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "WScript");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string UserTemplateDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Templates");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string MaterialDepotDir
    {
        get
        {
            var dir = Path.Combine(_instanceSettings.AppDataPath, "Depot");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }

    public string ConfigFile => Path.Combine(_instanceSettings.AppDataPath, "config.json");
    public string DockStatesFile => Path.Combine(_instanceSettings.AppDataPath, "DockStates.xml");
    public string RecentItemsFile => Path.Combine(_instanceSettings.AppDataPath, "recentItems.json");
}
