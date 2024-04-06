using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Media;

namespace WolvenKit.App.Services;


public interface ISettingsManager : ISettingsDto, INotifyPropertyChanged
{
    #region lifecyclestuff

    void Save();
    void Bounce();

    bool IsHealthy();


    #endregion lifecyclestuff

    string? GetRED4OodleDll();

    string GetRED4GameRootDir();

    string GetRED4GameExecutablePath();

    string? GetRED4GameLaunchCommand();

    string GetRED4GameLaunchOptions();

    public string GetRED4GameLegacyModDir();
    public string GetRED4GameModDir();


    public static string GetAppData()
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetManagerCacheDir()
    {
        var dir = Path.Combine(GetAppData(), "Config");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetWorkDir()
    {
        var dir = Path.Combine(GetAppData(), "tmp_workdir");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetTemp_AudioPath()
    {
        var dir = Path.Combine(GetAppData(), "Temp_Audio");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetTemp_OBJPath()
    {
        var dir = Path.Combine(GetAppData(), "Temp_OBJ");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetTemp_Audio_importPath()
    {
        var dir = Path.Combine(GetAppData(), "Temp_Audio_import");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetTemp_Video_PreviewPath()
    {
        var dir = Path.Combine(GetAppData(), "Temp_Video_Preview");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public static string GetWScriptDir()
    {
        var dir = Path.Combine(GetAppData(), "WScript");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }


    Color GetThemeAccent();

    void SetThemeAccent(Color color);

    string GetVersionNumber();

    /// <summary>
    /// For "simple" editor view: hides fields that the user shouldn't edit 
    /// </summary>
    bool IsNoobFilterEnabled();
}
