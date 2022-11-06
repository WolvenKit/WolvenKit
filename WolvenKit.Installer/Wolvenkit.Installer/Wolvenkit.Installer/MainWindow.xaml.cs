// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Wolvenkit.Installer.Pages;
using Wolvenkit.Installer.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Wolvenkit.Installer;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    private const int width = 1400;
    private const int height = 900;

    public MainWindow()
    {
        InitializeComponent();

        Title = "WolvenKit Installer";

        SetTitleBar(AppTitleBar);

        // set app dimensions
        var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
        var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
        appWindow.MoveAndResize(new Windows.Graphics.RectInt32((1920 / 2) - (width / 2), (1080 / 2) - (height / 2), width, height));
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

            if (selectedTagStr == "InstalledPage")
            {
                if (rootFrame.CurrentSourcePageType != typeof(InstalledPage))
                {
                    Navigate(typeof(InstalledPage));
                }
            }
            else if (selectedTagStr == "AvailablePage")
            {
                if (rootFrame.CurrentSourcePageType != typeof(AvailablePage))
                {
                    Navigate(typeof(AvailablePage));
                }
            }
            else
            {
                throw new NotImplementedException();
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
            //NavigationRootPage = this,
            Parameter = targetPageArguments
        };
        rootFrame.Navigate(pageType, args, navigationTransitionInfo);
    }

    public class NavigationRootPageArgs
    {
        //public NavigationRootPage NavigationRootPage;
        public object Parameter;
    }
}
