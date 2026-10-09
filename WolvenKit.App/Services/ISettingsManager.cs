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
