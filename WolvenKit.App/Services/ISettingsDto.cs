using System.Collections.Generic;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common;

namespace WolvenKit.App.Services;

public interface ISettingsDto
{
    // I wish there was a better way to inject deps
    // than creating unnecessary interfaces.
    public int SettingsVersion { get; }

    public string? ReddbHash { get; set; }
    public string? InstallerHash { get; set; }

    public Dictionary<string, LaunchProfile> LaunchProfiles { get; set; }
    public Dictionary<string, bool>? ScriptStatus { get; set; }
    public string? LastUsedProjectPath { get; set; }
    // public string? LastLaunchProfile { get; set; }

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
    public EGameLanguage GameLanguage { get; set; }
    public bool ShowGraphEditorNodeProperties { get; set; }

    #endregion

    #region FileEditor

    public bool TreeViewGroups { get; set; }
    public uint TreeViewGroupSize { get; set; }
    public EditorDifficultyLevel DefaultEditorDifficultyLevel { get; set; }
    public string? TreeViewIgnoredExtensions { get; set; }

    #endregion

    #region General

    public bool SkipUpdateCheck { get; set; }
    public EUpdateChannel UpdateChannel { get; set; }
    public bool ShowGuidedTour { get; set; }
    public string? ThemeAccentString { get; set; }
    public string? DefaultProjectPath { get; set; }
    public string? ModderName { get; set; }
    public string? ModderEmail { get; set; }

    #endregion

    #region Interface

    public bool ShowFilePreview { get; set; }
    public bool ShowAdvancedOptions { get; set; }
    public bool RefactoringCheckboxDefaultValue { get; set; }
    // public bool ShowRedmodInRibbon { get; set; }
    // public bool UseValidatingEditor { get; set; }
    // public bool ReopenLastProject { get; set; }
    // public bool ShowVerboseLogOutput { get; set; }
    public string ArchiveNamesExcludeFromScan { get; set; }
    public int UiScale { get; set; }
    public double UiScalePercentage => (double)UiScale / 100.0;

    #endregion

}
