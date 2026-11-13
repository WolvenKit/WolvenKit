using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WolvenKit.App.Services.Themes;

/// <summary>
/// Dialog windows (Add Prop files, Add ArchiveXL files and the like) get their background from Syncfusion's window
/// style, which takes the color with StaticResource: after a theme change while WolvenKit runs, the frame around
/// their content kept an old color. The same color as DynamicResource follows the theme.
/// </summary>
public sealed partial class ThemeService
{
    private const string WindowBackgroundKey = "ContentBackground";

    private static void ApplyWindowBackground(Window window)
    {
        if (ReferenceEquals(window, Application.Current?.MainWindow))
        {
            return;
        }

        // only a background that comes from a style: a window that sets its own keeps it
        var source = DependencyPropertyHelper.GetValueSource(window, Control.BackgroundProperty).BaseValueSource;
        if (source is not (BaseValueSource.Style or BaseValueSource.ImplicitStyleReference or BaseValueSource.DefaultStyle))
        {
            return;
        }

        if (window.TryFindResource(WindowBackgroundKey) is Brush)
        {
            window.SetResourceReference(Control.BackgroundProperty, WindowBackgroundKey);
        }
    }
}
