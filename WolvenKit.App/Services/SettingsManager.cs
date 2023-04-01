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
            nameof(GameLanguage)
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

    [Category("General")]
    [Display(Name = "Settings Version")]
    [ObservableProperty]
    [Browsable(false)]
    private int _settingsVersion;

    [Category("General")]
    [Display(Name = "Do not check for updates")]
    [ObservableProperty]
    private bool _skipUpdateCheck;

    [Category("General")]
    [Display(Name = "Update Channel")]
    [ObservableProperty]
    private EUpdateChannel _updateChannel;  // deprecated

    [Category("General")]
    [Display(Name = "Show Guided Tour")]
    [ObservableProperty]
    private bool _showGuidedTour = true;

    [Category("General")]
    [Display(Name = "Theme Accent")]
    [ObservableProperty]
    private string? _themeAccentString;

    [Category("Cyberpunk")]
    [Display(Name = "Game Executable Path (.exe)")]
    [ObservableProperty]
    private string? _cP77ExecutablePath;

    // This should be conditionally updated by CP77ExecutablePath, but not implemented..
    [Category("Cyberpunk")]
    [Display(Name = "Launch Command (executable or other command (e.g. steam:// uri)")]
    [ObservableProperty]
    private string? _cP77LaunchCommand;

    [Category("Cyberpunk")]
    [Display(Name = "Launch Options or Command-Line Parameters To Launch Command")]
    [ObservableProperty]
    private string? _cP77LaunchOptions;

    [Category("Cyberpunk")]
    [Display(Name = "Show File Preview")]
    [ObservableProperty]
    private bool _showFilePreview = true;

    [Browsable(false)]
    [ObservableProperty]
    private string? _reddbHash;

    [Browsable(false)]
    [ObservableProperty]
    private string? _installerHash;

    [Category("Cyberpunk")]
    [Display(Name = "Depot Path")]
    [ObservableProperty]
    private string? _materialRepositoryPath;

    [Category("File Editor")]
    [Display(Name = "Group Large Collections")]
    [ObservableProperty]
    private bool _treeViewGroups;

    [Category("File Editor")]
    [Display(Name = "Group Size")]
    [ObservableProperty]
    private uint _treeViewGroupSize = 100;

    [Category("File Editor")]
    [Display(Name = "Ignored Extensions (Open using System Editor. Syntax: .ext1|.ext2)")]
    [ObservableProperty]
    private string? _treeViewIgnoredExtensions = "";

    [Category("Import / Export")]
    [Display(Name = "Show advanced Options")]
    [ObservableProperty]
    private bool _showAdvancedOptions;

    [Category("Display")]
    [Display(Name = "Show CName hashes as hex")]
    [ObservableProperty]
    private bool _showCNameAsHex;

    [Category("Display")]
    [Display(Name = "Show ResourcePath hashes as hex")]
    [ObservableProperty]
    private bool _showResourcePathAsHex;

    [Category("Display")]
    [Display(Name = "Show NodeRef hashes as hex")]
    [ObservableProperty]
    private bool _showNodeRefAsHex;

    [Category("Display")]
    [Display(Name = "Show TweakDBID hashes as hex")]
    [ObservableProperty]
    private bool _showTweakDBIDAsHex;

    [Category("Display")]
    [Display(Name = "Show reference graph")]
    [ObservableProperty]
    private bool _showReferenceGraph;

    [Category("Display")] 
    [Display(Name = "Game language used for LocKeys")] 
    [ObservableProperty]
    private EGameLanguage _gameLanguage;

    [ObservableProperty]
    [Browsable(false)]
    private Dictionary<string, LaunchProfile>? _launchProfiles;

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

    public string GetRED4GameLaunchCommand()
    {
        return string.IsNullOrEmpty(CP77LaunchCommand) ? "" : CP77LaunchCommand.NotNull();
    }

    public string GetRED4GameLaunchOptions()
    {
        return string.IsNullOrEmpty(CP77LaunchOptions) ? "" : CP77LaunchOptions.NotNull();
    }

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

    #endregion methods
}
