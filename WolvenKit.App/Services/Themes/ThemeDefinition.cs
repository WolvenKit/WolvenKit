using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WolvenKit.App.Services.Themes;

/// <summary>
/// A WolvenKit theme: a named set of color overrides, stored as JSON.
/// Only the keys that differ from <see cref="BasedOn"/> (or from the built-in defaults) are stored.
/// </summary>
public sealed class ThemeDefinition
{
    public const int CurrentFormatVersion = 1;

    public int FormatVersion { get; set; } = CurrentFormatVersion;

    public string Name { get; set; } = "";

    public string? Author { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// Name of the theme this one inherits from. <c>null</c> means the WolvenKit defaults.
    /// </summary>
    public string? BasedOn { get; set; }

    /// <summary>
    /// Main accent (Syncfusion primary color, MahApps accent). Hex string, e.g. "#DF2935".
    /// </summary>
    public string? Accent { get; set; }

    /// <summary>
    /// Text color on top of the accent. Hex string.
    /// </summary>
    public string? AccentForeground { get; set; }

    /// <summary>
    /// Recolor neutral (gray) colors the theme does not set, by interpolating between the gray colors it does set.
    /// <c>null</c> means yes. Keeps menus, popups, separators, hover states etc. in the theme's tint.
    /// </summary>
    public bool? DeriveNeutralColors { get; set; }

    /// <summary>
    /// Resource key → hex color. Keys are listed in theme-schema.json.
    /// </summary>
    public Dictionary<string, string> Colors { get; set; } = new(StringComparer.Ordinal);

    [JsonIgnore]
    public bool IsBuiltIn { get; internal set; }

    /// <summary>The stock WolvenKit look (<see cref="IThemeService.DefaultThemeName"/>).</summary>
    [JsonIgnore]
    public bool IsDefault => IsBuiltIn && string.Equals(Name, IThemeService.DefaultThemeName, StringComparison.Ordinal);

    /// <summary>Name for menus and lists, e.g. "WolvenKit Dark (default)".</summary>
    [JsonIgnore]
    public string DisplayName => IsDefault ? $"{Name} (default)" : Name;

    /// <summary>
    /// Full path of the JSON file for user themes, <c>null</c> for built-in themes.
    /// </summary>
    [JsonIgnore]
    public string? FilePath { get; internal set; }

    public ThemeDefinition Clone() => new()
    {
        FormatVersion = FormatVersion,
        Name = Name,
        Author = Author,
        Description = Description,
        BasedOn = BasedOn,
        Accent = Accent,
        AccentForeground = AccentForeground,
        DeriveNeutralColors = DeriveNeutralColors,
        Colors = new Dictionary<string, string>(Colors, StringComparer.Ordinal),
        IsBuiltIn = IsBuiltIn,
        FilePath = FilePath
    };

    public override string ToString() => Name;
}
