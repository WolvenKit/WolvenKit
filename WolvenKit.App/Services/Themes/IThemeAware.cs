namespace WolvenKit.App.Services.Themes;

/// <summary>
/// Implemented by objects that have to refresh something themselves when the color theme changes
/// (e.g. values read from theme resources in code). Register with <see cref="IThemeService.Register"/>.
/// </summary>
public interface IThemeAware
{
    /// <summary>Called on the UI thread after the new theme's resources were applied.</summary>
    void OnThemeChanged();
}
