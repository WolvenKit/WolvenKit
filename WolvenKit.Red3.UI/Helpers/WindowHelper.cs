using System.Collections.Generic;
using Microsoft.UI.Xaml;

namespace WolvenKit.Red3.UI.Helpers;

// Helper class to allow the app to find the Window that contains an
// arbitrary UIElement (GetWindowForElement).  To do this, we keep track
// of all active Windows.  The app code must call WindowHelper.CreateWindow
// rather than "new Window" so we can keep track of all the relevant
// windows.  In the future, we would like to support this in platform APIs.
// https://github.com/microsoft/WinUI-Gallery/blob/main/WinUIGallery/Helper/WindowHelper.cs
public class WindowHelper
{
    public static Window CreateWindow()
    {
        var newWindow = new MainWindow
        {
            ExtendsContentIntoTitleBar = true,
        };
        TrackWindow(newWindow);
        return newWindow;
    }

    public static void TrackWindow(Window window)
    {
        window.Closed += (sender, args) => ActiveWindows.Remove(window);
        ActiveWindows.Add(window);
    }

    public static Window GetWindowForElement(UIElement element)
    {
        if (element.XamlRoot != null)
        {
            foreach (var window in ActiveWindows)
            {
                if (element.XamlRoot == window.Content.XamlRoot)
                {
                    return window;
                }
            }
        }
        return null;
    }

    public static UIElement FindElementByName(UIElement element, string name)
    {
        if (element.XamlRoot != null && element.XamlRoot.Content != null)
        {
            var ele = (element.XamlRoot.Content as FrameworkElement).FindName(name);
            if (ele != null)
            {
                return ele as UIElement;
            }
        }
        return null;
    }

    public static List<Window> ActiveWindows { get; } = new List<Window>();
}
