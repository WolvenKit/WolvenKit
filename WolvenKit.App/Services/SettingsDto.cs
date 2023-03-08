using System;
using System.Collections.Generic;
using WolvenKit.App.Models;
using WolvenKit.Common;

namespace WolvenKit.App.Services;


public class SettingsDto : ISettingsDto
{
    private const int _CurrentSettingsVersion = 3;

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
        ShowReferenceGraph = settings.ShowReferenceGraph;
        LaunchProfiles = settings.LaunchProfiles;
        // V3
        ExperimentalEnableNewMeshExport = settings.ExperimentalEnableNewMeshExport;

        if (settings.SettingsVersion != _CurrentSettingsVersion)
        {
            MigrateToCurrentVersion();
        }
    }

    public int SettingsVersion { get; set; }

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
    public bool ShowTweakDBIDAsHex { get; set; }
    public bool ShowReferenceGraph { get; set; }
    public Dictionary<string, LaunchProfile>? LaunchProfiles { get; set; }
    // V3
    public bool ExperimentalEnableNewMeshExport { get; set; }


    // Management functions

    public SettingsManager ReconfigureSettingsManager(SettingsManager settingsManager)
    {
        if (SettingsVersion != _CurrentSettingsVersion)
        {
            MigrateToCurrentVersion();
        }

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
        settingsManager.ShowReferenceGraph = ShowReferenceGraph;
        settingsManager.LaunchProfiles = LaunchProfiles;
        // V3
        settingsManager.ExperimentalEnableNewMeshExport = ExperimentalEnableNewMeshExport;

        return settingsManager;
    }

    public SettingsManager ToSettingsManager()
    {
        var config = new SettingsManager()
        {
        };

        return ReconfigureSettingsManager(config);
    }

    //
    // Version migrations
    //

    // Rather than create all kinds of new interfaces etc.,
    // always maintain the DTO as the current, and apply
    // all migrations in order for a controlled upgrade.

    private void MigrateFromV1ToV2()
    {
        if (SettingsVersion < 2) {
            if (!string.IsNullOrWhiteSpace(CP77ExecutablePath))
            {
                CP77LaunchCommand = CP77ExecutablePath;
            }

            SettingsVersion = 2;
        }
    }

    private void MigrateFromV2ToV3()
    {
        if (SettingsVersion < 3) {

            ExperimentalEnableNewMeshExport = true;

            SettingsVersion = 3;
        }
    }

    private void MigrateToCurrentVersion()
    {
        MigrateFromV1ToV2();
        MigrateFromV2ToV3();

        if (SettingsVersion != _CurrentSettingsVersion)
        {
            throw new InvalidOperationException($"Settings: migration problem, current version is {_CurrentSettingsVersion}, but migration ended up at {SettingsVersion}.");
        }
    }

}
