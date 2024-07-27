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
    /// <summary>
    /// Current version of SettingsDTO.
    /// </summary>
    private const int s_currentSettingsVersion = 3;

    // Deserialize
    public SettingsDto()
    {
    }

    public SettingsDto(SettingsManager settings)
    {
        SkipUpdateCheck = settings.SkipUpdateCheck;
        UpdateChannel = settings.UpdateChannel;
        ShowGuidedTour = settings.ShowGuidedTour;
        ThemeAccentString = settings.ThemeAccentString;
        CP77ExecutablePath = settings.CP77ExecutablePath;
        CP77LaunchCommand = settings.CP77LaunchCommand;
        CP77LaunchOptions = settings.CP77LaunchOptions;
        ShowFilePreview = settings.ShowFilePreview;
        ReddbHash = settings.ReddbHash;
        InstallerHash = settings.InstallerHash;
        MaterialRepositoryPath = settings.MaterialRepositoryPath;
        TreeViewGroups = settings.TreeViewGroups;
        TreeViewGroupSize = settings.TreeViewGroupSize;
        TreeViewIgnoredExtensions = settings.TreeViewIgnoredExtensions;
        ShowAdvancedOptions = settings.ShowAdvancedOptions;
        ShowCNameAsHex = settings.ShowCNameAsHex;
        ShowResourcePathAsHex = settings.ShowResourcePathAsHex;
        ShowNodeRefAsHex = settings.ShowNodeRefAsHex;
        ShowTweakDBIDAsHex = settings.ShowTweakDBIDAsHex;
        DefaultEditorDifficultyLevel = settings.DefaultEditorDifficultyLevel;
        ShowReferenceGraph = settings.ShowReferenceGraph;
        GameLanguage = settings.GameLanguage;
        LaunchProfiles = settings.LaunchProfiles;
        ScriptStatus = settings.ScriptStatus;
        AnalyzeModArchives = settings.AnalyzeModArchives;
        ExtraModDirPath = settings.ExtraModDirPath;
        LastUsedProjectPath = settings.LastUsedProjectPath;
        PinnedOrder = settings.PinnedOrder;
        RecentOrder = settings.RecentOrder;
        ShowGraphEditorNodeProperties = settings.ShowGraphEditorNodeProperties;
        ModderName = settings.ModderName;
        ModderEmail = settings.ModderEmail;
        RefactoringCheckboxDefaultValue = settings.RefactoringCheckboxDefaultValue;
        LastLaunchProfile = settings.LastLaunchProfile;
        ShowRedmodInRibbon = settings.ShowRedmodInRibbon;
        UseValidatingEditor = settings.UseValidatingEditor;
        ReopenLastProject = settings.ReopenLastProject;
        ArchiveNamesExcludeFromScan = settings.ArchiveNamesExcludeFromScan;

        MigrateSettings(settings.SettingsVersion);
    }

    public int SettingsVersion { get; set; } = 2;

    public bool SkipUpdateCheck { get; set; }
    public EUpdateChannel UpdateChannel { get; set; }
    public bool ShowGuidedTour { get; set; }
    public string? ThemeAccentString { get; set; }
    public string? CP77ExecutablePath { get; set; }
    public string? CP77LaunchCommand { get; set; }
    public string? CP77LaunchOptions { get; set; }
    public bool ShowFilePreview { get; set; }
    public string? ReddbHash { get; set; }
    public string? InstallerHash { get; set; }
    public string? MaterialRepositoryPath { get; set; }
    public bool TreeViewGroups { get; set; }
    public uint TreeViewGroupSize { get; set; }
    public string? TreeViewIgnoredExtensions { get; set; } = "";
    public bool ShowAdvancedOptions { get; set; }
    public bool ShowCNameAsHex { get; set; }
    public bool ShowResourcePathAsHex { get; set; }
    public bool ShowNodeRefAsHex { get; set; }
    public EditorDifficultyLevel DefaultEditorDifficultyLevel { get; set; } = EditorDifficultyLevel.Easy;
    public bool ShowTweakDBIDAsHex { get; set; }
    public bool ShowReferenceGraph { get; set; }
    public EGameLanguage GameLanguage { get; set; } = EGameLanguage.en_us;
    public Dictionary<string, LaunchProfile> LaunchProfiles { get; set; } = [];
    public bool RefactoringCheckboxDefaultValue { get; set; }
    public Dictionary<string, bool>? ScriptStatus { get; set; }
    public bool AnalyzeModArchives { get; set; } = false;
    public string? ExtraModDirPath { get; set; }
    public string? LastUsedProjectPath { get; set; }
    public string? LastLaunchProfile { get; set; }
    public bool ShowRedmodInRibbon { get; set; }
    public bool UseValidatingEditor { get; set; } = true;
    public bool ReopenLastProject { get; set; }
    public int PinnedOrder { get; set; }
    public int RecentOrder { get; set; }
    public bool ShowGraphEditorNodeProperties { get; set; } = true;
    public string? ModderName { get; set; }
    public string? ModderEmail { get; set; }
    public string ArchiveNamesExcludeFromScan { get; set; } = "basegame_AMM_Props";

    public SettingsManager ReconfigureSettingsManager(SettingsManager settingsManager)
    {
        MigrateSettings(SettingsVersion);

        settingsManager.SettingsVersion = SettingsVersion;

        settingsManager.SkipUpdateCheck = SkipUpdateCheck;
        settingsManager.UpdateChannel = UpdateChannel;
        settingsManager.ShowGuidedTour = ShowGuidedTour;
        settingsManager.ThemeAccentString = ThemeAccentString;
        settingsManager.CP77ExecutablePath = CP77ExecutablePath;
        settingsManager.CP77LaunchCommand = CP77LaunchCommand;
        settingsManager.CP77LaunchOptions = CP77LaunchOptions;
        settingsManager.ShowFilePreview = ShowFilePreview;
        settingsManager.ReddbHash = ReddbHash;
        settingsManager.InstallerHash = InstallerHash;
        settingsManager.MaterialRepositoryPath = MaterialRepositoryPath;
        settingsManager.TreeViewGroups = TreeViewGroups;
        settingsManager.TreeViewGroupSize = TreeViewGroupSize;
        settingsManager.TreeViewIgnoredExtensions = TreeViewIgnoredExtensions;
        settingsManager.ShowAdvancedOptions = ShowAdvancedOptions;
        settingsManager.ShowCNameAsHex = ShowCNameAsHex;
        settingsManager.ShowResourcePathAsHex = ShowResourcePathAsHex;
        settingsManager.ShowNodeRefAsHex = ShowNodeRefAsHex;
        settingsManager.ShowTweakDBIDAsHex = ShowTweakDBIDAsHex;
        settingsManager.DefaultEditorDifficultyLevel = DefaultEditorDifficultyLevel;
        settingsManager.ShowReferenceGraph = ShowReferenceGraph;
        settingsManager.LaunchProfiles = LaunchProfiles;
        settingsManager.ScriptStatus = ScriptStatus;
        settingsManager.GameLanguage = GameLanguage;
        settingsManager.AnalyzeModArchives = AnalyzeModArchives;
        settingsManager.ExtraModDirPath = ExtraModDirPath;
        settingsManager.LastUsedProjectPath = LastUsedProjectPath;
        settingsManager.PinnedOrder = PinnedOrder;
        settingsManager.RecentOrder = RecentOrder;
        settingsManager.ShowGraphEditorNodeProperties = ShowGraphEditorNodeProperties;
        settingsManager.ModderName = ModderName;
        settingsManager.ModderEmail = ModderEmail;
        settingsManager.RefactoringCheckboxDefaultValue = RefactoringCheckboxDefaultValue;
        settingsManager.LastLaunchProfile = LastLaunchProfile;
        settingsManager.UseValidatingEditor = UseValidatingEditor;
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
    private void MigrateSettings(int fromVersion)
    {
        if (fromVersion == s_currentSettingsVersion)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(CP77ExecutablePath))
        {
            CP77LaunchCommand = CP77ExecutablePath;
        }

        if (fromVersion < 3)
        {
            UpdateLaunchProfilesV3();
        }

        SettingsVersion = s_currentSettingsVersion;
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
                    WriteIndented = true, DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
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
