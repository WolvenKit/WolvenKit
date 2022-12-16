using Microsoft.UI.Xaml;
using Windows.Storage;

namespace WolvenKit.Red3.UI.Helpers;

/// <summary>
/// Class providing functionality around switching and restoring theme settings
/// https://github.com/microsoft/WinUI-Gallery/blob/main/WinUIGallery/Helper/ThemeHelper.cs
/// </summary>
public static class ThemeHelper
{
    private const string SelectedAppThemeKey = "SelectedAppTheme";

#if !UNPACKAGED
    private static Window CurrentApplicationWindow;
#endif
    // Keep reference so it does not get optimized/garbage collected
#if UNIVERSAL
        private static UISettings uiSettings;
#endif
    /// <summary>
    /// Gets the current actual theme of the app based on the requested theme of the
    /// root element, or if that value is Default, the requested theme of the Application.
    /// </summary>
    public static ElementTheme ActualTheme
    {
        get
        {
            foreach (var window in WindowHelper.ActiveWindows)
            {
                if (window.Content is FrameworkElement rootElement)
                {
                    if (rootElement.RequestedTheme != ElementTheme.Default)
                    {
                        return rootElement.RequestedTheme;
                    }
                }
            }

            return App.GetEnum<ElementTheme>(App.Current.RequestedTheme.ToString());
        }
    }

    /// <summary>
    /// Gets or sets (with LocalSettings persistence) the RequestedTheme of the root element.
    /// </summary>
    public static ElementTheme RootTheme
    {
        get
        {
            foreach (var window in WindowHelper.ActiveWindows)
            {
                if (window.Content is FrameworkElement rootElement)
                {
                    return rootElement.RequestedTheme;
                }
            }

            return ElementTheme.Default;
        }
        set
        {
            foreach (var window in WindowHelper.ActiveWindows)
            {
                if (window.Content is FrameworkElement rootElement)
                {
                    rootElement.RequestedTheme = value;
                }
            }

#if !UNPACKAGED
            ApplicationData.Current.LocalSettings.Values[SelectedAppThemeKey] = value.ToString();
#endif
            UpdateSystemCaptionButtonColors();
        }
    }

    public static void Initialize()
    {
#if !UNPACKAGED
        // Save reference as this might be null when the user is in another app
        CurrentApplicationWindow = App.StartupWindow;
        var savedTheme = ApplicationData.Current.LocalSettings.Values[SelectedAppThemeKey]?.ToString();

        if (savedTheme != null)
        {
            RootTheme = App.GetEnum<ElementTheme>(savedTheme);
        }
#endif
    }

    public static bool IsDarkTheme()
    {
        return RootTheme == ElementTheme.Default
            ? Application.Current.RequestedTheme == ApplicationTheme.Dark
            : RootTheme == ElementTheme.Dark;
    }

    public static void UpdateSystemCaptionButtonColors()
    {
    }
}