using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace WolvenKit.App.Services.Themes;

/// <summary>
/// Lists, applies and persists WolvenKit themes.
/// <para>
/// Theme colors are written into the resource dictionaries that define them (see ThemeService.LivePatching).
/// WolvenKit's XAML references them with DynamicResource, so it follows a switch immediately; Syncfusion
/// controls are re-styled by re-applying the SfSkinManager theme (App.ApplyThemeLive).
/// </para>
/// </summary>
public interface IThemeService
{
    public const string DefaultThemeName = "WolvenKit Dark";

    public static readonly Color DefaultAccent = Color.FromRgb(0xDF, 0x29, 0x35);

    public static string GetUserThemesDir()
    {
        var dir = Path.Combine(ISettingsManager.GetAppData(), "Themes");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        return dir;
    }

    ThemeSchema Schema { get; }

    /// <summary>The default theme, then the other built-in themes, then user themes, sorted by name.</summary>
    IReadOnlyList<ThemeDefinition> Themes { get; }

    /// <summary>The theme selected in the settings (falls back to the default theme).</summary>
    ThemeDefinition Current { get; }

    /// <summary>Raised when themes are added, saved, renamed or deleted.</summary>
    event EventHandler? ThemesChanged;

    /// <summary>
    /// Raised when <see cref="Current"/> changed, before the (UI-blocking) work of applying it starts.
    /// The work runs at background dispatcher priority, so a notification shown here gets rendered first.
    /// </summary>
    event EventHandler? CurrentThemeChanging;

    /// <summary>Raised after <see cref="Current"/> changed and its resources were applied.</summary>
    event EventHandler? CurrentThemeChanged;

    /// <summary>
    /// Captures the default colors, loads themes, migrates the old accent setting
    /// and applies the active theme. Call on the UI thread before any window is created.
    /// </summary>
    void Initialize();

    ThemeDefinition? Find(string? name);

    /// <summary>Makes <paramref name="name"/> the active theme (persisted in the settings).</summary>
    void SetActive(string name);

    /// <summary>
    /// Puts the palette of <paramref name="theme"/> into the application resources without
    /// changing <see cref="Current"/>. Used for live preview; call with <see cref="Current"/> to revert.
    /// </summary>
    void ApplyResources(ThemeDefinition theme);

    /// <summary>
    /// Scans for resource dictionaries loaded since the last scan (e.g. after Syncfusion re-applied its theme)
    /// and writes the current theme into them. Returns the number of newly found entries.
    /// </summary>
    int Refresh();

    /// <summary>
    /// Temporarily makes the read-only theme dictionaries (Syncfusion's shared Brushes.xaml) writable, so
    /// SfSkinManager can re-register its theme settings. Dispose to seal them again.
    /// </summary>
    IDisposable BeginSkinUpdate();

    /// <summary>Moves the theme dictionary back to the end of the application's merged dictionaries.</summary>
    void EnsureResourcesOnTop();

    /// <summary>
    /// Builds the resource dictionary for a theme. With <paramref name="complete"/> every themeable key is
    /// included (defaults for keys the theme does not override) — used by the editor preview, so that it
    /// does not fall back to the colors of the currently applied theme.
    /// </summary>
    ResourceDictionary CreateResourceDictionary(ThemeDefinition theme, bool complete = false);

    /// <summary>Factory color of a key, before any theme was applied.</summary>
    Color? GetDefaultColor(string key);

    /// <summary>Overrides of the theme merged with all themes it is based on.</summary>
    IReadOnlyDictionary<string, Color> ResolveOverrides(ThemeDefinition theme);

    /// <summary>Effective color of a key: overrides of the theme chain, else the default.</summary>
    Color? ResolveColor(ThemeDefinition theme, string key);

    Color ResolveAccent(ThemeDefinition theme);

    Color? ResolveAccentForeground(ThemeDefinition theme);

    string GetUniqueName(string baseName);

    /// <summary>Creates and saves a user copy of <paramref name="source"/>.</summary>
    ThemeDefinition Duplicate(ThemeDefinition source, string newName);

    /// <summary>
    /// Saves a user theme. <paramref name="previousName"/> is the name it had before editing
    /// (for renames); the active-theme setting follows the rename.
    /// </summary>
    ThemeDefinition Save(ThemeDefinition theme, string? previousName = null);

    void Delete(ThemeDefinition theme);

    /// <summary>Imports a theme JSON file as a user theme (renamed if the name is taken).</summary>
    ThemeDefinition Import(string path);

    /// <summary>
    /// Exports a theme. With <paramref name="flatten"/> the inherited overrides are included
    /// and <see cref="ThemeDefinition.BasedOn"/> is dropped, so the file works on its own.
    /// </summary>
    void Export(ThemeDefinition theme, string path, bool flatten);
}
