using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace WolvenKit.App.Services.Themes;

/// <summary>
/// The thin border Windows 11 draws around windows with the native frame (dialogs such as Create Photo Mode Files)
/// is gray whatever the theme. With a theme accent it gets the dark accent shade, as the rest of the window; the
/// default theme keeps the system border. Earlier Windows versions ignore it.
/// </summary>
public sealed partial class ThemeService
{
    // DWMWA_BORDER_COLOR (Windows 11 build 22000+); DWMWA_COLOR_DEFAULT puts the system color back
    private const int DwmwaBorderColor = 34;
    private const uint DwmwaColorDefault = 0xFFFFFFFF;

    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref uint value, int size);

    private void ApplyWindowBorder(Window window)
    {
        var hwnd = new WindowInteropHelper(window).Handle;
        if (hwnd == IntPtr.Zero)
        {
            return;
        }

        var value = DwmwaColorDefault;
        if (_patchedTheme is { } theme && ResolveAccent(theme) is var accent && accent != IThemeService.DefaultAccent)
        {
            var border = Darken(accent, 0.67);
            value = border.R | ((uint)border.G << 8) | ((uint)border.B << 16);
        }

        try
        {
            // the result is ignored: not supported before Windows 11
            _ = DwmSetWindowAttribute(hwnd, DwmwaBorderColor, ref value, sizeof(uint));
        }
        catch (DllNotFoundException)
        {
        }
        catch (EntryPointNotFoundException)
        {
        }
    }

    private void ApplyWindowBorders()
    {
        if (Application.Current is not { } app)
        {
            return;
        }

        foreach (Window window in app.Windows)
        {
            ApplyWindowBorder(window);
        }
    }
}
