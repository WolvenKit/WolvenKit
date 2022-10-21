// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Wolvenkit.Installer.Helper;
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
    public MainWindow()
    {
        InitializeComponent();

        Title = "WolvenKit Installer";

        SetTitleBar(AppTitleBar);


    }



    public MainViewModel ViewModel => App.Current.Services.GetService<MainViewModel>();

    public Microsoft.UI.Xaml.Controls.NavigationView NavigationView => NavigationViewControl;

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
