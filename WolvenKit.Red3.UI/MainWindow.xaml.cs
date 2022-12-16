// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WolvenKit.Red3.UI.Pages;
using WolvenKit.Red3.UI.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WolvenKit.Red3.UI;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    private const int s_width = 1400;
    private const int s_height = 900;

    public MainWindow()
    {
        InitializeComponent();

        Title = "WolvenKit: Next Gen";

        SetTitleBar(AppTitleBar);

        // set window size lmao
        var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
        var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
        appWindow.MoveAndResize(new Windows.Graphics.RectInt32((1920 / 2) - (s_width / 2), (1080 / 2) - (s_height / 2), s_width, s_height));
    }

    public MainViewModel ViewModel => App.Current.Services.GetService<MainViewModel>();

    public NavigationView NavigationView => NavigationViewControl;

    private void NavigationViewControl_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.IsSettingsSelected)
        {
            if (rootFrame.CurrentSourcePageType != typeof(SettingsPage))
            {
                Navigate(typeof(SettingsPage));
            }
        }
        else
        {
            var selectedItem = args.SelectedItemContainer;
            var selectedTagStr = selectedItem.Tag as string;
            if (Enum.TryParse<EPages>(selectedTagStr, out var selectedPage))
            {
                var resultType = selectedPage switch
                {
                    EPages.AssetBrowser => typeof(AssetBrowserPage),
                    EPages.Import => typeof(ImportPage),
                    EPages.Export => typeof(ExportPage),
                    EPages.ProjectExplorer => typeof(ProjectExplorerPage),
                    _ => throw new NotImplementedException(),
                };
                if (rootFrame.CurrentSourcePageType != resultType)
                {
                    Navigate(resultType);
                }
            }
        }
    }

    // Wraps a call to rootFrame.Navigate to give the Page a way to know which NavigationRootPage is navigating.
    // Please call this function rather than rootFrame.Navigate to navigate the rootFrame.
    public void Navigate(
        Type pageType,
        object targetPageArguments = null,
        Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo navigationTransitionInfo = null)
    {
        var args = new NavigationRootPageArgs
        {
            Parameter = targetPageArguments
        };
        rootFrame.Navigate(pageType, args, navigationTransitionInfo);
    }

    public class NavigationRootPageArgs
    {
        public object Parameter;
    }

    private void NavigationViewControl_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
    {

    }
}
