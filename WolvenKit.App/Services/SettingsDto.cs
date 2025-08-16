using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common;

namespace WolvenKit.App.Services;

public class SettingsDto : ISettingsDto
{
    private readonly ISettingsManager? _settingsManager;

    /// <summary>
    /// Current version of SettingsDTO.
    /// </summary>
    private const int s_currentSettingsVersion = 4;

    public bool IsDirty;

    // Deserialize
    public SettingsDto() => MigrateSettings();

    public SettingsDto(SettingsManager settings)
    {
        _settingsManager = settings;

        SettingsVersion = settings.SettingsVersion;

        ReddbHash = settings.ReddbHash;
        InstallerHash = settings.InstallerHash;

        LaunchProfiles = settings.LaunchProfiles;
        ScriptStatus = settings.ScriptStatus;
        LastUsedProjectPath = settings.LastUsedProjectPath;
        LastLaunchProfile = settings.LastLaunchProfile;

        PinnedOrder = settings.PinnedOrder;
        RecentOrder = settings.RecentOrder;

        // Cyberpunk
        CP77ExecutablePath = settings.CP77ExecutablePath;
        CP77LaunchCommand = settings.CP77LaunchCommand;
        CP77LaunchOptions = settings.CP77LaunchOptions;
        MaterialRepositoryPath = settings.MaterialRepositoryPath;
        AnalyzeModArchives = settings.AnalyzeModArchives;
        ExtraModDirPath = settings.ExtraModDirPath;

        // Display
        ShowCNameAsHex = settings.ShowCNameAsHex;
        ShowResourcePathAsHex = settings.ShowResourcePathAsHex;
        ShowNodeRefAsHex = settings.ShowNodeRefAsHex;
        ShowTweakDBIDAsHex = settings.ShowTweakDBIDAsHex;
        ShowReferenceGraph = settings.ShowReferenceGraph;
        GameLanguage = settings.GameLanguage;
        ShowGraphEditorNodeProperties = settings.ShowGraphEditorNodeProperties;

        // File Editor
        TreeViewGroups = settings.TreeViewGroups;
        TreeViewGroupSize = settings.TreeViewGroupSize;
        DefaultEditorDifficultyLevel = settings.DefaultEditorDifficultyLevel;
        TreeViewIgnoredExtensions = settings.TreeViewIgnoredExtensions;

        // General
        SkipUpdateCheck = settings.SkipUpdateCheck;
        AlwaysAskBeforeUpdating = settings.AlwaysAskBeforeUpdating;       
        UpdateChannel = settings.UpdateChannel;
        ShowGuidedTour = settings.ShowGuidedTour;
        ThemeAccentString = settings.ThemeAccentString;
        DefaultProjectPath = settings.DefaultProjectPath;
        ModderName = settings.ModderName;
        ModderEmail = settings.ModderEmail;

        // Interface
        UiScale = settings.UiScale;
        ShowFilePreview = settings.ShowFilePreview;
        ShowAdvancedOptions = settings.ShowAdvancedOptions;
        RefactoringCheckboxDefaultValue = settings.RefactoringCheckboxDefaultValue;
        ShowRedmodInRibbon = settings.ShowRedmodInRibbon;
        UseValidatingEditor = settings.UseValidatingEditor;
        ReopenLastProject = settings.ReopenLastProject;
        NumFilesToReopen = settings.NumFilesToReopen;
        ReopenFiles = settings.ReopenFiles;
        ShowVerboseLogOutput = settings.ShowVerboseLogOutput;
        ArchiveNamesExcludeFromScan = settings.ArchiveNamesExcludeFromScan;

        MigrateSettings();
    }

    public int SettingsVersion { get; set; } = 2;

    public string? ReddbHash { get; set; }
    public string? InstallerHash { get; set; }

    public Dictionary<string, LaunchProfile> LaunchProfiles { get; set; } = [];
    public Dictionary<string, bool>? ScriptStatus { get; set; }
    public string? LastUsedProjectPath { get; set; }
    public string? LastLaunchProfile { get; set; }

    public int PinnedOrder { get; set; }
    public int RecentOrder { get; set; }

    #region Cyberpunk

    public string? CP77ExecutablePath { get; set; }
    public string? CP77LaunchCommand { get; set; }
    public string? CP77LaunchOptions { get; set; }
    public string? MaterialRepositoryPath { get; set; }
    public bool AnalyzeModArchives { get; set; }
    public string? ExtraModDirPath { get; set; }

    #endregion

    #region Display

    public bool ShowCNameAsHex { get; set; }
    public bool ShowResourcePathAsHex { get; set; }
    public bool ShowNodeRefAsHex { get; set; }
    public bool ShowTweakDBIDAsHex { get; set; }
    public bool ShowReferenceGraph { get; set; }
    public EGameLanguage GameLanguage { get; set; } = EGameLanguage.en_us;
    public bool ShowGraphEditorNodeProperties { get; set; } = true;

    #endregion

    #region FileEditor

    public bool TreeViewGroups { get; set; }
    public uint TreeViewGroupSize { get; set; }
    public EditorDifficultyLevel DefaultEditorDifficultyLevel { get; set; } = EditorDifficultyLevel.Easy;
    public string? TreeViewIgnoredExtensions { get; set; } = "";

    #endregion

    #region General

    public bool SkipUpdateCheck { get; set; }
    public bool AlwaysAskBeforeUpdating { get; set; }
    public EUpdateChannel UpdateChannel { get; set; }
    public bool ShowGuidedTour { get; set; }
    public string? ThemeAccentString { get; set; }
    public string? DefaultProjectPath { get; set; }
    public string? ModderName { get; set; }
    public string? ModderEmail { get; set; }

    #endregion

    #region Interface

    // Default to 0 to automatically scale on first launch
    public int UiScale { get; set; }
    public bool ShowFilePreview { get; set; }
    public bool ShowAdvancedOptions { get; set; }
    public bool RefactoringCheckboxDefaultValue { get; set; }
    public bool ShowRedmodInRibbon { get; set; }
    public bool UseValidatingEditor { get; set; } = true;
    public bool ReopenLastProject { get; set; }

    public int NumFilesToReopen { get; set; } = 3;
    public bool ReopenFiles { get; set; } = true;
    public bool ShowVerboseLogOutput { get; set; }
    public bool IsDiscordRPCEnabled { get; set; } = true;
    public string ArchiveNamesExcludeFromScan { get; set; } = "basegame_AMM_Props";

    #endregion

    public SettingsManager ReconfigureSettingsManager(SettingsManager settingsManager)
    {
        MigrateSettings();

        settingsManager.SettingsVersion = SettingsVersion;

        settingsManager.ReddbHash = ReddbHash;
        settingsManager.InstallerHash = InstallerHash;

        settingsManager.LaunchProfiles = LaunchProfiles;
        settingsManager.ScriptStatus = ScriptStatus;
        settingsManager.LastUsedProjectPath = LastUsedProjectPath;
        settingsManager.LastLaunchProfile = LastLaunchProfile;

        settingsManager.PinnedOrder = PinnedOrder;
        settingsManager.RecentOrder = RecentOrder;

        // Cyberpunk
        settingsManager.CP77ExecutablePath = CP77ExecutablePath;
        settingsManager.CP77LaunchCommand = CP77LaunchCommand;
        settingsManager.CP77LaunchOptions = CP77LaunchOptions;
        settingsManager.MaterialRepositoryPath = MaterialRepositoryPath;
        settingsManager.AnalyzeModArchives = AnalyzeModArchives;
        settingsManager.ExtraModDirPath = ExtraModDirPath;

        // Display
        settingsManager.ShowCNameAsHex = ShowCNameAsHex;
        settingsManager.ShowResourcePathAsHex = ShowResourcePathAsHex;
        settingsManager.ShowNodeRefAsHex = ShowNodeRefAsHex;
        settingsManager.ShowTweakDBIDAsHex = ShowTweakDBIDAsHex;
        settingsManager.ShowReferenceGraph = ShowReferenceGraph;
        settingsManager.GameLanguage = GameLanguage;
        settingsManager.ShowGraphEditorNodeProperties = ShowGraphEditorNodeProperties;

        // File Editor
        settingsManager.TreeViewGroups = TreeViewGroups;
        settingsManager.TreeViewGroupSize = TreeViewGroupSize;
        settingsManager.DefaultEditorDifficultyLevel = DefaultEditorDifficultyLevel;
        settingsManager.TreeViewIgnoredExtensions = TreeViewIgnoredExtensions;

        // General
        settingsManager.SkipUpdateCheck = SkipUpdateCheck;
        settingsManager.AlwaysAskBeforeUpdating = AlwaysAskBeforeUpdating;      
        settingsManager.UpdateChannel = UpdateChannel;
        settingsManager.ShowGuidedTour = ShowGuidedTour;
        settingsManager.ThemeAccentString = ThemeAccentString;
        settingsManager.DefaultProjectPath = DefaultProjectPath;
        settingsManager.ModderName = ModderName;
        settingsManager.ModderEmail = ModderEmail;

        // Interface
        settingsManager.UiScale = UiScale;
        settingsManager.ShowFilePreview = ShowFilePreview;
        settingsManager.ShowAdvancedOptions = ShowAdvancedOptions;
        settingsManager.RefactoringCheckboxDefaultValue = RefactoringCheckboxDefaultValue;
        settingsManager.ShowRedmodInRibbon = ShowRedmodInRibbon;
        settingsManager.UseValidatingEditor = UseValidatingEditor;
        settingsManager.ReopenLastProject = ReopenLastProject;
        settingsManager.ReopenFiles = ReopenFiles;
        settingsManager.NumFilesToReopen = NumFilesToReopen;
        settingsManager.ShowVerboseLogOutput = ShowVerboseLogOutput;
        settingsManager.IsDiscordRPCEnabled = IsDiscordRPCEnabled;
        settingsManager.ArchiveNamesExcludeFromScan = ArchiveNamesExcludeFromScan;

        return settingsManager;
    }

    public SettingsManager ToSettingsManager()
    {
        var config = new SettingsManager();

        return ReconfigureSettingsManager(config);
    }

    // Rather than create all kinds of new interfaces etc.,
    // always maintain the DTO as the current, and apply
    // all migrations in order for a controlled upgrade.
    private void MigrateSettings()
    {
        if (SettingsVersion == s_currentSettingsVersion)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(CP77ExecutablePath))
        {
            CP77LaunchCommand = CP77ExecutablePath;
        }

        if (SettingsVersion < 3)
        {
            UpdateLaunchProfilesV3();
            SettingsVersion = 3;
        }

        if (SettingsVersion < 4)
        {
            ScriptStatus ??= [];
            var scriptKeys = ScriptStatus.Keys.Where((key) => key.Contains("hook_global.wscript")).ToList();
            foreach (var scriptKey in scriptKeys)
            {
                ScriptStatus[scriptKey] = false;
            }

            SettingsVersion = 4;
        }

        SettingsVersion = s_currentSettingsVersion;

        IsDirty = true;
    }

    /// <summary>
    /// Version 3: Launch profile changes
    /// Profiles have an `order` field now, and new ones were added
    /// </summary>
    private void UpdateLaunchProfilesV3()
    {
        var idx = 0;
        foreach (var kvp in LaunchProfiles.Where(kvp => kvp.Value.Order is null))
        {
            kvp.Value.Order = idx;
            idx += 1;
        }

        var newLaunchProfiles = new Dictionary<string, LaunchProfile>();
        newLaunchProfiles.AddRange(LaunchProfiles);

        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"WolvenKit.App.Resources.launchprofiles.json");
        if (stream != null)
        {
            var defaultProfiles = JsonSerializer.Deserialize<Dictionary<string, LaunchProfile>>(stream,
                options: new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                }) ?? [];


            // Don't overwrite existing profiles
            foreach (var kvp in defaultProfiles.Where(kvp => !newLaunchProfiles.ContainsKey(kvp.Key)))
            {
                if (kvp.Value.Order is null)
                {
                    kvp.Value.Order = idx;
                    idx += 1;
                }

                newLaunchProfiles.Add(kvp.Key, kvp.Value);
            }
        }

        LaunchProfiles = newLaunchProfiles
            .OrderBy(x => x.Value.Order)
            .ToDictionary(x => x.Key, x => x.Value);
    }
}
