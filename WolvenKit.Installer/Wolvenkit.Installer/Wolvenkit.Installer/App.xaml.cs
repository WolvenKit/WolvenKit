// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel.Activation;
using Wolvenkit.Installer.Helper;
using Wolvenkit.Installer.Pages;
using Wolvenkit.Installer.Services;
using Wolvenkit.Installer.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Wolvenkit.Installer;
/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        InitializeComponent();

        Services = ConfigureServices();
    }

    /// <summary>
    /// Invoked when the application is launched normally by the end user.  Other entry points
    /// will be used such as when the application is launched to open a specific file.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        //m_window = new MainWindow();
        //m_window.Activate();
        StartupWindow = WindowHelper.CreateWindow();

        EnsureWindow();
    }

    private void EnsureWindow(IActivatedEventArgs args = null)
    {
        // No matter what our destination is, we're going to need control data loaded - let's knock that out now.
        // We'll never need to do this again.
        //var library = App.Current.Services.GetService<ILibraryService>();
        //await library.LoadAsync();

        ThemeHelper.Initialize();

        var targetPageType = typeof(InstalledPage);
        var targetPageArguments = string.Empty;

        if (args != null)
        {
            if (args.Kind == ActivationKind.Launch)
            {
                targetPageArguments = ((Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)args).Arguments;
            }
        }

        MainRoot = StartupWindow.Content as FrameworkElement;
        var rootPage = StartupWindow as MainWindow;
        rootPage.Navigate(targetPageType, targetPageArguments);

        if (targetPageType == typeof(InstalledPage))
        {
            ((NavigationViewItem)((MainWindow)App.StartupWindow).NavigationView.MenuItems[0]).IsSelected = true;
        }

        // Ensure the current window is active
        StartupWindow.Activate();
    }

    // Get the initial window created for this app
    // On UWP, this is simply Window.Current
    // On Desktop, multiple Windows may be created, and the StartupWindow may have already
    // been closed.
    public static Window StartupWindow { get; private set; }


    public static FrameworkElement MainRoot { get; private set; }

    public static new App Current => (App)Application.Current;

    /// <summary>
    /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
    /// </summary>
    public IServiceProvider Services { get; }

    /// <summary>
    /// Configures the services for the application.
    /// </summary>
    private static IServiceProvider ConfigureServices()
    {
        ServiceCollection services = new();

        services.AddLogging();

        services.AddSingleton<INotificationService, NotificationService>();
        services.AddTransient<IDialogService, DialogService>();

        services.AddSingleton<ILibraryService, LibraryService>();



        // Viewmodels
        services.AddTransient<MainViewModel>();
        services.AddTransient<InstalledViewModel>();
        services.AddTransient<AvailableViewModel>();


        return services.BuildServiceProvider();
    }

    public static TEnum GetEnum<TEnum>(string text) where TEnum : struct
    {
        return !typeof(TEnum).GetTypeInfo().IsEnum
            ? throw new InvalidOperationException("Generic parameter 'TEnum' must be an enum.")
            : (TEnum)Enum.Parse(typeof(TEnum), text);
    }
}

