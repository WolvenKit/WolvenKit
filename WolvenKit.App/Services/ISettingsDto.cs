using System.Collections.Generic;
using WolvenKit.App.Models;
using WolvenKit.Common;

namespace WolvenKit.App.Services;

public interface ISettingsDto
{
    // I wish there was a better way to inject deps
    // than creating unnecessary interfaces.
    public int SettingsVersion { get; }

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
    public string? TreeViewIgnoredExtensions { get; set; }
    public bool ShowAdvancedOptions { get; set; }
    public bool ShowCNameAsHex { get; set; }
    public bool ShowResourcePathAsHex { get; set; }
    public bool ShowNodeRefAsHex { get; set; }
    public bool ShowTweakDBIDAsHex { get; set; }
    public bool ShowReferenceGraph { get; set; }
    public EGameLanguage GameLanguage { get; set; }
    public Dictionary<string, LaunchProfile>? LaunchProfiles { get; set; }
    public Dictionary<string, bool>? ScriptStatus { get; set; }
    public bool AnalyzeModArchives { get; set; }
}
