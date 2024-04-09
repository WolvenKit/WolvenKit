using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData.Binding;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.Services;

/// <summary>
/// This handles the application settings defined by the user.
/// </summary>
public partial class SettingsManager : ObservableObject, ISettingsManager
{
    private bool _isLoaded;

    private readonly string _assemblyVersion;

    /// <summary>
    /// Default constructor.
    /// </summary>
    public SettingsManager()
    {
        _assemblyVersion = CommonFunctions.GetAssemblyVersion(Constants.AssemblyName).ToString();

        _ = this.WhenAnyPropertyChanged(
            nameof(ShowGuidedTour),
            nameof(MaterialRepositoryPath),
            nameof(ThemeAccentString),
            nameof(SkipUpdateCheck),
            nameof(CP77ExecutablePath),
            nameof(CP77LaunchCommand),
            nameof(CP77LaunchOptions),
            nameof(ShowFilePreview),
            nameof(ReddbHash),
            nameof(InstallerHash),
            nameof(TreeViewGroups),
            nameof(TreeViewGroupSize),
            nameof(TreeViewIgnoredExtensions),
            nameof(ShowAdvancedOptions),
            nameof(ShowCNameAsHex),
            nameof(ShowResourcePathAsHex),
            nameof(ShowNodeRefAsHex),
            nameof(ShowTweakDBIDAsHex),
            nameof(ShowReferenceGraph),
            nameof(EnableNoobFilterByDefault),
            nameof(GameLanguage),
            nameof(AnalyzeModArchives),
            nameof(ExtraModDirPath),
            nameof(LastUsedProjectPath),
            nameof(PinnedOrder),
            nameof(RecentOrder)
            )
          .Subscribe(_ =>
          {
              if (_isLoaded)
              {
                  Save();
              }
          });
    }

    #region lifecycle

    public static SettingsManager Load()
    {
        var dto = LoadFromFile();

        var settings =
            dto != null
            ? dto.ToSettingsManager()
            : new SettingsManager();

        settings._isLoaded = true;
        return settings;
    }

    public void Save()
    {
        if (!_isLoaded)
        {
            return;
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        };
        var json = JsonSerializer.Serialize(new SettingsDto(this), options);
        File.WriteAllText(GetConfigurationPath(), json);
        // _loggerService.Info("Settings saved.");
    }

    public void Bounce()
    {
        Save();
        var bouncedSettings = LoadFromFile();
        bouncedSettings?.ReconfigureSettingsManager(this);
    }

    private static SettingsDto? LoadFromFile()
    {
        try
        {
            if (File.Exists(GetConfigurationPath()))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                };
                var jsonString = File.ReadAllText(GetConfigurationPath());
                var dto = JsonSerializer.Deserialize<SettingsDto>(jsonString, options);

                return dto;
            }
        }
        catch (Exception)
        {
            return null;
        }

        return null;
    }

    #endregion lifecycle

    #region properties

    [Display(Name = "Settings Version", GroupName = "General")]
    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private int _settingsVersion;

    [Display(Name = "Do not check for updates", GroupName = "General")]
    [ObservableProperty]
    private bool _skipUpdateCheck;

    [Display(Name = "Update Channel", GroupName = "General")]
    [ObservableProperty]
    private EUpdateChannel _updateChannel;  // deprecated

    [Display(Name = "Show Guided Tour", GroupName = "General")]
    [ObservableProperty]
    private bool _showGuidedTour = true;

    [Display(Name = "Theme Accent", GroupName = "General")]
    [ObservableProperty]
    private string? _themeAccentString;

    [Display(Name = "Game Executable Path (.exe)", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _cP77ExecutablePath;

    // This should be conditionally updated by CP77ExecutablePath, but not implemented..
    [Display(Name = "Launch Command (executable or other command (e.g. steam:// uri)", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _cP77LaunchCommand;

    [Display(Name = "Launch Options or Command-Line Parameters To Launch Command", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _cP77LaunchOptions;

    [Display(Name = "Show File Preview", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private bool _showFilePreview = true;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private string? _reddbHash;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private string? _installerHash;

    [Display(Name = "Depot Path", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _materialRepositoryPath;

    [Display(Name = "Group Large Collections", GroupName = "File Editor")]
    [ObservableProperty]
    private bool _treeViewGroups;

    [Display(Name = "Group Size", GroupName = "File Editor")]
    [ObservableProperty]
    private uint _treeViewGroupSize = 100;

    [Display(Name = "Default to simple mode", GroupName = "File Editor")] [ObservableProperty]
    private bool _enableNoobFilterByDefault;

    [Display(Name = "Ignored Extensions (Open using System Editor. Syntax: .ext1|.ext2)", GroupName = "File Editor")]
    [ObservableProperty]
    private string? _treeViewIgnoredExtensions = "";

    [Display(Name = "Show advanced Options", GroupName = "Import / Export")]
    [ObservableProperty]
    private bool _showAdvancedOptions;

    [Display(Name = "Show CName hashes as hex", GroupName = "Display")]
    [ObservableProperty]
    private bool _showCNameAsHex;

    [Display(Name = "Show ResourcePath hashes as hex", GroupName = "Display")]
    [ObservableProperty]
    private bool _showResourcePathAsHex;

    [Display(Name = "Show NodeRef hashes as hex", GroupName = "Display")]
    [ObservableProperty]
    private bool _showNodeRefAsHex;

    [Display(Name = "Show TweakDBID hashes as hex", GroupName = "Display")]
    [ObservableProperty]
    private bool _showTweakDBIDAsHex;

    [Display(Name = "Show reference graph", GroupName = "Display")]
    [ObservableProperty]
    private bool _showReferenceGraph;

    [Display(Name = "Game language used for LocKeys", GroupName = "Display")] 
    [ObservableProperty]
    private EGameLanguage _gameLanguage;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private Dictionary<string, LaunchProfile>? _launchProfiles;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private Dictionary<string, bool>? _scriptStatus;

    [Display(Name = "Analyze mods", Description = "Check mod archives for file names and invalid files", GroupName = "Cyberpunk")] 
    [ObservableProperty]
    private bool _analyzeModArchives;

    [Display(Name = "Additional Mod directory", Description = "Path to an optional directory containing mod archives", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _extraModDirPath;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private string? _lastUsedProjectPath;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private int _pinnedOrder;

    [ObservableProperty]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [property: Browsable(false)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    private int _recentOrder;

    #endregion properties

    #region methods

    public string GetVersionNumber() => _assemblyVersion;

    private static string GetConfigurationPath() => Path.Combine(ISettingsManager.GetAppData(), "config.json");

    public Color GetThemeAccent() =>
       !string.IsNullOrEmpty(ThemeAccentString)
           ? (Color)ColorConverter.ConvertFromString(ThemeAccentString)
           : (Color)ColorConverter.ConvertFromString("#DF2935");

    public void SetThemeAccent(Color color) => ThemeAccentString = color.ToString();
    public string GetRED4GameRootDir()
    {
        ArgumentNullException.ThrowIfNull(CP77ExecutablePath);

        var fi = new FileInfo(CP77ExecutablePath);

        return fi.Directory is { Parent.Parent: { } }
            ? Path.Combine(fi.Directory.Parent.Parent.FullName)
            : throw new DirectoryNotFoundException();
    }

    public string GetRED4GameExecutablePath() => CP77ExecutablePath.NotNull();

    public string GetRED4GameLaunchCommand() => CP77LaunchCommand ?? "";

    public string GetRED4GameLaunchOptions() => CP77LaunchOptions ?? "";

    public string GetRED4GameLegacyModDir()
    {
        var dir = Path.Combine(GetRED4GameRootDir(), "archive", "pc", "mod");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public string GetRED4GameModDir()
    {
        //var dir = Path.Combine(GetRED4GameRootDir(), "archive", "pc", "mod");
        var dir = Path.Combine(GetRED4GameRootDir(), "mods");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public string? GetRED4OodleDll() => string.IsNullOrEmpty(GetRED4GameRootDir())
            ? null
            : Path.Combine(GetRED4GameRootDir(), "bin", "x64", Core.Constants.Oodle);

    public bool IsHealthy() => File.Exists(CP77ExecutablePath) && File.Exists(GetRED4OodleDll());

    public bool IsNoobFilterDefaultEnabled() => EnableNoobFilterByDefault;


    #endregion methods
}
