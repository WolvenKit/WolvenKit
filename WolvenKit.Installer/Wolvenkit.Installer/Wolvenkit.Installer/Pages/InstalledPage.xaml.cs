// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
using Wolvenkit.Installer.ViewModel;
using static Wolvenkit.Installer.MainWindow;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Wolvenkit.Installer.Pages;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class InstalledPage : Page
{
    public InstalledPage()
    {
        InitializeComponent();

        ViewModel = App.Current.Services.GetService<InstalledViewModel>();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {

    }

    internal InstalledViewModel ViewModel { get; set; }

    private void OnItemGridViewContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
    {

    }

    private void OnItemGridViewItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void OnItemGridViewKeyDown(object sender, KeyRoutedEventArgs e)
    {

    }

    private void OnItemGridViewLoaded(object sender, RoutedEventArgs e)
    {

    }

    private void OnItemGridViewSizeChanged(object sender, SizeChangedEventArgs e)
    {

    }
}
