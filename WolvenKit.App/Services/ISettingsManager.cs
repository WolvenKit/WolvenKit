using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.App.Models;
using System.Windows.Media.Imaging;
using DynamicData.Kernel;

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

    public static string GetSaveDirectory() =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "Saved Games", "CD Projekt Red", "Cyberpunk 2077");

    public static List<SaveGame> GetSaveGames()
    {
        var saveDir = ISettingsManager.GetSaveDirectory();
        if (!Directory.Exists(saveDir))
        {
            return [];
        }

        return Directory.GetDirectories(saveDir)
            .Select(folder => new { Folder = folder, Save = Path.Combine(folder, "sav.dat") })
            .Where(x => File.Exists(x.Save))
            .Select(x => new SaveGame(
                new DirectoryInfo(x.Folder).Name,
                Path.Combine(x.Folder, "screenshot.png"),
                x.Save,
                new DirectoryInfo(x.Folder).LastWriteTime))
            .OrderByDescending(x => x.LastModified)
            .AsList();
    }

    public static string? GetLastSaveName()
    {
        var saveDir = ISettingsManager.GetSaveDirectory();
        if (!Directory.Exists(saveDir))
        {
            return null;
        }

        var saveDirectoryNames = Directory.GetDirectories(saveDir)
            .Select(folder => new { Folder = folder, Save = Path.Combine(folder, "sav.dat") })
            .Where(x => File.Exists(x.Save))
            .Select(x => new { DirName = new DirectoryInfo(x.Folder).Name, LastModified = new DirectoryInfo(x.Folder).LastWriteTime })
            .OrderByDescending(x => x.LastModified)
            .Select(x => x.DirName);

        return saveDirectoryNames.FirstOrDefault();
    }
    Color GetThemeAccent();

    void SetThemeAccent(Color color);

    string GetVersionNumber();

    string LastLaunchProfile { get; set; }

    bool ShowRedmodInRibbon { get; set; }

    bool UseValidatingEditor { get; set; }

    bool ReopenLastProject { get; set; }

    bool ReopenFiles { get; set; }
    int NumFilesToReopen { get; set; }

    bool ShowVerboseLogOutput { get; set; }

    bool IsDiscordRPCEnabled { get; set; }

    bool UseAuthorNameAsSubfolder { get; set; }
}
