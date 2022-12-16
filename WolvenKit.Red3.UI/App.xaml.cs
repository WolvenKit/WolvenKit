// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml;
using WolvenKit.Red3.UI.Helpers;
using WolvenKit.Red3.UI.Pages;
using WolvenKit.Red3.UI.Services;
using WolvenKit.Red3.UI.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WolvenKit.Red3.UI;
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
        StartupWindow = WindowHelper.CreateWindow();

        EnsureWindow();
    }

    private void EnsureWindow()
    {
        ThemeHelper.Initialize();

        MainRoot = StartupWindow.Content as FrameworkElement;

        (StartupWindow as MainWindow).Navigate(typeof(ProjectExplorerPage), "");

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

        //services.AddLogging();
        services.AddLogging(builder =>
        {
            builder.ClearProviders();
            builder.AddDebug();
        });


        services.AddSingleton<INotificationService, NotificationService>();
        services.AddTransient<IDialogService, DialogService>();

        services.AddSingleton<IWorkspaceService, WorkspaceService>();


        // Viewmodels
        services.AddSingleton<MainViewModel>();

        services.AddSingleton<ProjectExplorerViewModel>();


        return services.BuildServiceProvider();
    }

    public static TEnum GetEnum<TEnum>(string text) where TEnum : struct
    {
        return !typeof(TEnum).GetTypeInfo().IsEnum
            ? throw new InvalidOperationException("Generic parameter 'TEnum' must be an enum.")
            : (TEnum)Enum.Parse(typeof(TEnum), text);
    }
}
