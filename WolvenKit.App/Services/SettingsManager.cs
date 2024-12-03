using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData.Binding;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common;
using WolvenKit.Core;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.Services;

/// <summary>
/// This handles the application settings defined by the user.
/// </summary>
public partial class SettingsManager : ObservableObject, ISettingsManager
{
    private bool _isLoaded;

    private readonly string _assemblyVersion;


    private static readonly JsonSerializerOptions s_options = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// Default constructor.
    /// </summary>
    public SettingsManager()
    {
        _assemblyVersion = CommonFunctions.GetAssemblyVersion(Constants.AssemblyName).ToString();

        _ = this.WhenAnyPropertyChanged(
            nameof(ReddbHash),
            nameof(InstallerHash),

            nameof(LastUsedProjectPath),
            nameof(LastLaunchProfile),

            nameof(PinnedOrder),
            nameof(RecentOrder),

            // Cyberpunk
            nameof(CP77ExecutablePath),
            nameof(CP77LaunchCommand),
            nameof(CP77LaunchOptions),
            nameof(MaterialRepositoryPath),
            nameof(AnalyzeModArchives),
            nameof(ExtraModDirPath),

            // Display
            nameof(ShowCNameAsHex),
            nameof(ShowResourcePathAsHex),
            nameof(ShowNodeRefAsHex),
            nameof(ShowTweakDBIDAsHex),
            nameof(ShowReferenceGraph),
            nameof(GameLanguage),
            nameof(ShowGraphEditorNodeProperties),

            // FileEditor
            nameof(TreeViewGroups),
            nameof(TreeViewGroupSize),
            nameof(DefaultEditorDifficultyLevel),
            nameof(TreeViewIgnoredExtensions),

            // General
            nameof(SkipUpdateCheck),
            nameof(ShowGuidedTour),
            nameof(ThemeAccentString),
            nameof(DefaultProjectPath),
            nameof(ModderName),
            nameof(ModderEmail),

            // Interface
            nameof(UiScale),
            nameof(ShowFilePreview),
            nameof(ShowAdvancedOptions),
            nameof(RefactoringCheckboxDefaultValue),
            nameof(ShowRedmodInRibbon),
            nameof(UseValidatingEditor),
            nameof(ReopenLastProject),
            nameof(ShowVerboseLogOutput)
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

        if (dto?.IsDirty == true)
        {
            settings.Save();
        }
        return settings;
    }

    public void Save()
    {
        if (!_isLoaded)
        {
            return;
        }

        var json = JsonSerializer.Serialize(new SettingsDto(this), s_options);
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
        if (!File.Exists(GetConfigurationPath()))
        {
            return null;
        }
        try
        {
            var jsonString = File.ReadAllText(GetConfigurationPath());
            var dto = JsonSerializer.Deserialize<SettingsDto>(jsonString, s_options);

            return dto;
        }
        catch (Exception)
        {
            return null;
        }

    }

    #endregion lifecycle

    #region properties

    [Display(Name = "Settings Version", GroupName = "General")]
    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private int _settingsVersion;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private string? _reddbHash;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private string? _installerHash;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private Dictionary<string, LaunchProfile> _launchProfiles = [];

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private Dictionary<string, bool>? _scriptStatus;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private string? _lastUsedProjectPath;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private string? _lastLaunchProfile;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private int _pinnedOrder;

    [ObservableProperty]
    [property: System.ComponentModel.Browsable(false)]
    private int _recentOrder;

    #region Cyberpunk

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

    [Display(Name = "Depot Path", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _materialRepositoryPath;

    [Display(Name = "Analyze mods", Description = "Scan installed mods for file paths when opening mod browser", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private bool _analyzeModArchives;

    [Display(Name = "Additional Mod directory", Description = "Path to an optional directory containing mod archives", GroupName = "Cyberpunk")]
    [ObservableProperty]
    private string? _extraModDirPath;

    #endregion

    #region Display

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
    private EGameLanguage _gameLanguage = EGameLanguage.en_us;

    [Display(Name = "Show Graph Editor Node Properties", GroupName = "Display")]
    [ObservableProperty]
    private bool _showGraphEditorNodeProperties = true;

    #endregion

    #region FileEditor

    [Display(Name = "Group Large Collections", GroupName = "File Editor")]
    [ObservableProperty]
    private bool _treeViewGroups;

    [Display(Name = "Group Size", GroupName = "File Editor")]
    [ObservableProperty]
    private uint _treeViewGroupSize = 100;

    [Display(Name = "Editor default mode (recommended: Easy)", GroupName = "File Editor")]
    [ObservableProperty]
    private EditorDifficultyLevel _defaultEditorDifficultyLevel;

    [Display(Name = "Ignored Extensions (Open using System Editor. Syntax: .ext1|.ext2)", GroupName = "File Editor")]
    [ObservableProperty]
    private string? _treeViewIgnoredExtensions = "";

    #endregion

    #region General

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

    [Display(Name = "Default project path", Description = "Path to the directory where you store your mods", GroupName = "General")]
    [ObservableProperty]
    private string? _defaultProjectPath;

    [Display(Name = "Your name", Description = "Will be used for project properties on creation", GroupName = "General")]
    [ObservableProperty]
    private string? _modderName;

    [Display(Name = "Your e-Mail", Description = "Will be used for project properties on creation", GroupName = "General")]
    [ObservableProperty]
    private string? _modderEmail;

    #endregion

    #region Interface

    private int _uiScale;

    [Display(Name = "Scale UI (%)",
        Description = "Resize fonts/icons to improve interface for your screen resolution.",
        GroupName = "Interface")]
    public int UiScale
    {
        get => _uiScale;
        set
        {
            if (value is < 100 or > 900)
            {
                value = 100;
            }
            SetProperty(ref _uiScale, value);
        }
    }

    [Display(Name = "Show File Preview", GroupName = "Interface")]
    [ObservableProperty]
    private bool _showFilePreview = true;

    [Display(Name = "Import/Export: Show advanced Options", GroupName = "Interface")]
    [ObservableProperty]
    private bool _showAdvancedOptions;

    [Display(Name = "Update references on rename",
        Description = "When renaming or moving a file or folder, should Wolvenkit try to update all references to it?",
        GroupName = "Interface")]
    [ObservableProperty]
    private bool _refactoringCheckboxDefaultValue;

    [Display(Name = "Show REDmod in Ribbon",
        Description = "Display 'Pack as REDmod' and 'Install as REDMod' in the ribbon?",
        GroupName = "Interface")]
    [ObservableProperty]
    private bool _showRedmodInRibbon;

    [Display(Name = "Use validating editor?",
        Description = "Editor fields validate themselves (or try to). Disable this if you run into editor performance issues.",
        GroupName = "Interface")]
    [ObservableProperty]
    private bool _useValidatingEditor;

    [Display(Name = "Open last project on launch?",
        Description = "Will re-open the last project",
        GroupName = "Interface")]
    [ObservableProperty]
    private bool _reopenLastProject;

    [Display(Name = "Show verbose log output",
        Description = "Will give you all the information",
        GroupName = "Interface")]
    [ObservableProperty]
    private bool _showVerboseLogOutput;

    [Display(Name = "Exclude archives from scan by name (comma separated)",
        Description = "Exclude archives from scan if you know that they'll lead to exceptions (only the base name)",
        GroupName = "Interface")]
    [ObservableProperty]
    private string _archiveNamesExcludeFromScan = "basegame_AMM_Props";

    #endregion

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
        if (CP77ExecutablePath is null)
        {
            throw new WolvenKitException(0x4002, "Your Cyberpunk game executable isn't set");
        }

        var fi = new FileInfo(CP77ExecutablePath);

        return fi.Directory is { Parent.Parent: { } }
            ? Path.Combine(fi.Directory.Parent.Parent.FullName)
            : throw new DirectoryNotFoundException();
    }

    public string GetRED4GameExecutablePath() => CP77ExecutablePath.NotNull();

    // If no launch command is set, use the executable path
    public string GetRED4GameLaunchCommand() => CP77LaunchCommand ?? CP77ExecutablePath ?? "";

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

    #endregion methods
}
