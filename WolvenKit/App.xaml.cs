using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using DynamicData.Binding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReactiveUI;
using Serilog;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.Services.Themes;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Helpers;
using WolvenKit.RED4.CR2W;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit
{
    public partial class AppImpl //: Application
    {
        // Determines if the application is in design mode.
        //public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        private ISettingsManager _settingsManager;
        private ILoggerService _loggerService;
        private IThemeService _themeService;

        // Constructor #1
        static AppImpl()
        {

        }

        // Constructor #2
        public AppImpl()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);

            Init();

            SetupExceptionHandling();

            // load oodle
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            if (_settingsManager?.IsHealthy() == true && !Oodle.Load(_settingsManager.GetRED4OodleDll()))
            {
                throw new FileNotFoundException($"{Core.Constants.Oodle} not found.");
            }
        }

        // Application OnStartup Override.
        protected override void OnStartup(StartupEventArgs e)
        {
            _settingsManager ??= Locator.Current.GetService<ISettingsManager>();

            _loggerService = Locator.Current.GetService<ILoggerService>();
            _loggerService.Info("Starting application");
            _loggerService.Info($"Version: {_settingsManager.GetVersionNumber()}");

            // Apply the WolvenKit color theme before any window is created:
            // views resolve StaticResource colors when they are loaded.
            _themeService = Locator.Current.GetService<IThemeService>();
            try
            {
                _themeService.Initialize();
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Exception while loading color themes: {ex.Message}");
            }

            // Register themes before loading any UI to avoid exceptions.
            try
            {
                _loggerService.Info("Registering themes...");
                var themeSettings = BuildTheme(_settingsManager, _themeService);
                SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
                SfSkinManager.ApplyStylesOnApplication = true;
                _loggerService.Info("Themes registered successfully.");
            }
            catch (WolvenKitException ex)
            {
                _loggerService.Error($"Exception while registering themes: {ex.Message}");
            }

            Interactions.ShowFirstTimeSetup = () =>
            {
                var dialog = new FirstSetupView();

                var result = dialog.ShowDialog() == true;
                return result;
            };


            _loggerService.Debug("Initializing red database");
            Initializations.InitializeThemeHelper();

            Initializations.InitializeSyntaxHighlighting();

            // main app viewmodel
            _loggerService.Debug("Initializing Shell");
            Initializations.InitializeShell(_settingsManager);

            RedImage.LoggerService = _loggerService;
            DiscordHelper.LoggerService = _loggerService;

            _loggerService.Debug("Initializing Discord RPC API");
            DiscordHelper.SetEnabled(_settingsManager.IsDiscordRPCEnabled);
            DiscordHelper.InitializeDiscordRPC();

            _settingsManager
                .WhenPropertyChanged(settings => settings.UiScale)
                .Skip(1)
                .Subscribe(_ => OnUiScaleChanged());

            _themeService.CurrentThemeChanging += (_, _) => OnThemeChanging();
            _themeService.CurrentThemeChanged += (_, _) => OnThemeChanged();

            // SfSkinManager may merge its own brush dictionaries when the main window gets its theme;
            // keep the WolvenKit theme overrides on top of them.
            Activated += OnFirstActivated;

            StartDeferredServiceLoad();

            base.OnStartup(e);
        }

        private static void StartDeferredServiceLoad()
        {
            var thread = new Thread(() =>
            {
                // ~250 ms; cheap, so get it out of the way first
                var cruidService = Locator.Current.GetService<CRUIDService>();
                cruidService?.Load();

                // ~5 000 ms
                var hashService = Locator.Current.GetService<IHashService>();
                hashService?.Load();
            })
            {
                Name = "WolvenKit.DeferredServiceLoad",
                Priority = ThreadPriority.BelowNormal,
                IsBackground = true
            };

            thread.Start();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Log.Information("Exiting application...");
            Log.CloseAndFlush();

            base.OnExit(e);
        }

        private IServiceProvider Container { get; set; }

        private IHost _host;

        private void Init()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            //protobuf
            //RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));

            _host = GenericHost.CreateHostBuilder().Build();

            // Since MS DI container is a different type,
            // we need to re-register the built container with Splat again
            Container = _host.Services;
            Container.UseMicrosoftDependencyResolver();

            MoveOldLogs();

            var path = Path.Combine(ISettingsManager.GetLogsDir(), "applog.txt");
            var outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}";

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
#if DEBUG

                .WriteTo.Async(a => a.Console(), bufferSize: 1000)
#endif
                .WriteTo.MySink(_host.Services.GetService<MySink>())
                .WriteTo.Async(
                    a => a.File(
                        path,
                        outputTemplate: outputTemplate,
                        rollingInterval: RollingInterval.Day,
                        fileSizeLimitBytes: 100 * 1000 * 1024, // MaxFileSize: 100 MB
                        retainedFileCountLimit: 10,
                        buffered: true, // Allow internal buffering.
                        flushToDiskInterval: TimeSpan.FromMinutes(1)), // Write once per minute.
                    bufferSize: 1000)
                .CreateLogger();
        }

        private void MoveOldLogs()
        {
            var logFolder = ISettingsManager.GetLogsDir();

            var existingLogs = Directory.GetFiles(logFolder, "*.txt");

            foreach (var file in Directory.GetFiles(ISettingsManager.GetAppData(), "applog*.txt", SearchOption.TopDirectoryOnly))
            {
                var fileName = Path.GetFileName(file);
                var destFileName = Path.Combine(logFolder, fileName);

                var rotatingIndex = 1;

                while (existingLogs.Contains(destFileName))
                {
                    destFileName = Path.Combine(logFolder, $"{fileName.Replace(".txt", "")}_{rotatingIndex:D3}.txt");
                    rotatingIndex++;
                }

                FileHelper.SafeMove(file, destFileName);
            }
        }

        private void OnFirstActivated(object sender, EventArgs e)
        {
            Activated -= OnFirstActivated;
            _themeService.EnsureResourcesOnTop();
            WolvenKit.Helpers.AdonisThemeBridge.Apply();
        }

        private static IThemeSetting BuildTheme(ISettingsManager settingsManager, IThemeService themeService)
        {
            var theme = themeService.Current;
            var accentForeground = themeService.ResolveAccentForeground(theme);

            var settings = new MaterialDarkThemeSettings
            {
                PrimaryBackground = new SolidColorBrush(themeService.ResolveAccent(theme)),
                BodyFontSize = 11 * settingsManager.UiScalePercentage,
                HeaderFontSize = 14 * settingsManager.UiScalePercentage,
                SubHeaderFontSize = 13 * settingsManager.UiScalePercentage,
                TitleFontSize = 13 * settingsManager.UiScalePercentage,
                SubTitleFontSize = 12 * settingsManager.UiScalePercentage,
                BodyAltFontSize = 11 * settingsManager.UiScalePercentage,
                FontFamily = new FontFamily("Segoe UI")
            };

            if (accentForeground is { } foreground)
            {
                settings.PrimaryForeground = new SolidColorBrush(foreground);
            }

            return settings;
        }

        // NOTE: used for debug environment
        public static void UpdateTheme(ISettingsManager settingsManager, IThemeService themeService)
        {
            var window = Application.Current.MainWindow;
            // NOTE: trick SfSkinManager to unregister current ThemeSettings.
            var theme = SfSkinManager.GetTheme(window);

            theme.ThemeName = "";
            var themeSettings = BuildTheme(settingsManager, themeService);

            SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
            SfSkinManager.ApplyStylesOnApplication = true;
            SfSkinManager.SetTheme(window, new Theme("MaterialDark"));
            themeService.EnsureResourcesOnTop();
            window.InvalidateVisual();
            window.UpdateLayout();
            window.Visibility = Visibility.Collapsed;

            Task.Delay(1000).ContinueWith(_ =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    window.InvalidateVisual();
                    window.UpdateLayout();
                    window.Visibility = Visibility.Visible;
                });
            });
        }

        private void OnUiScaleChanged()
        {
            DispatcherHelper.RunOnMainThread(async () =>
            {
#if DEBUG
                // NOTE: Allow dynamic scaling to speed-up workflow when working on UI.
                //       You might need to restart manually in some cases.
                UpdateTheme(_settingsManager, _themeService);
                await Task.CompletedTask;
#else
                await Interactions.ShowMessageBoxAsync("WolvenKit will restart to apply UI changes.", "Restart to scale UI", WMessageBoxButtons.Ok);
                ProcessHelper.Restart(Current);
#endif
            });
        }

        /// <summary>Switching takes a few seconds (Syncfusion rebuilds its styles): tell the user before the UI freezes.</summary>
        /// <summary>From the theme change request until the UI is idle again with the new theme.</summary>
        private static readonly System.Diagnostics.Stopwatch s_themeSwitchWatch = new();

        /// <summary>How long the main window stays hidden while it rebuilds its visuals.</summary>
        private static readonly TimeSpan s_showAfterHideDelay = TimeSpan.FromMilliseconds(200);

        private void OnThemeChanging()
        {
            s_themeSwitchWatch.Restart();
            Locator.Current.GetService<INotificationService>()?.Info($"Applying theme \"{_themeService.Current.Name}\"… WolvenKit may freeze for a few seconds.");
            if (Locator.Current.GetService<IProgressService<double>>() is { } progress)
            {
                progress.IsIndeterminate = true;
                progress.Status = EStatus.Running;
            }
        }

        private void OnThemeChanged()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                // node brushes are cached per resource key
                WolvenKit.App.ViewModels.GraphEditor.Nodes.GraphNodeStyling.ClearBrushCache();
                ApplyThemeLive(_settingsManager, _themeService, _loggerService);
                WolvenKit.Helpers.AdonisThemeBridge.Apply();
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Could not apply the theme without restart: {ex.Message}");
                _loggerService.Debug(ex.ToString());
                _ = Interactions.ShowMessageBoxAsync(
                    "The theme could not be applied completely. Restart WolvenKit to see it everywhere.",
                    "Theme",
                    WMessageBoxButtons.Ok);
            }
            finally
            {
                if (Locator.Current.GetService<IProgressService<double>>() is { } progress)
                {
                    progress.IsIndeterminate = false;
                    progress.Status = EStatus.Ready;
                }
                _loggerService.Info($"Theme \"{_themeService.Current.Name}\" applied in {watch.ElapsedMilliseconds} ms.");
            }
        }

        /// <summary>
        /// Applies the current theme without restart. The theme service has already written the colors into the
        /// resource dictionaries (WolvenKit's XAML follows via DynamicResource). Syncfusion control styles resolve
        /// their brushes with StaticResource, so the SfSkinManager theme is re-applied to rebuild them; this also
        /// registers the new accent. Same sequence as <see cref="UpdateTheme"/>, which is known to work.
        /// </summary>
        public static void ApplyThemeLive(ISettingsManager settingsManager, IThemeService themeService, ILoggerService logger = null)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var window = Current.MainWindow;
            if (window is null)
            {
                return;
            }

            // Re-skinning the DockingManager puts the panels back where the XAML defines them; keep the user's layout.
            string dockState = null;
            try
            {
                dockState = Views.Shell.DockingAdapter.G_Dock?.CaptureDockState();
            }
            catch (Exception ex)
            {
                logger?.Warning($"Themes: could not save the layout before re-applying the skin: {ex.Message}");
            }

            // RegisterThemeSettings writes into Syncfusion dictionaries it sealed earlier (Common.xaml, Brushes.xaml)
            using (themeService.BeginSkinUpdate())
            {
                Reapply();
            }
            var skinMs = watch.ElapsedMilliseconds;

            themeService.Refresh();
            logger?.Debug($"Themes: Syncfusion skin re-applied in {skinMs} ms, new dictionaries patched in {watch.ElapsedMilliseconds - skinMs} ms.");

            // Hiding and showing the window makes it rebuild its visuals with the new styles (as in UpdateTheme).
            // Both the layout pass before hiding and a short delay are needed: without them the window shows a
            // solid color instead of its content.
            window.InvalidateVisual();
            window.UpdateLayout();
            window.Visibility = Visibility.Collapsed;

            var showTimer = new System.Windows.Threading.DispatcherTimer { Interval = s_showAfterHideDelay };
            showTimer.Tick += (_, _) =>
            {
                showTimer.Stop();

                // Syncfusion may have merged new dictionaries while re-applying; patch them before showing
                themeService.Refresh();
                window.InvalidateVisual();
                window.UpdateLayout();
                window.Visibility = Visibility.Visible;

                if (dockState is not null)
                {
                    window.Dispatcher.BeginInvoke(
                        () => Views.Shell.DockingAdapter.G_Dock?.RestoreDockState(dockState),
                        System.Windows.Threading.DispatcherPriority.ApplicationIdle);
                }

                window.Dispatcher.BeginInvoke(
                    () => logger?.Debug($"Themes: switch done in {s_themeSwitchWatch.ElapsedMilliseconds} ms (until the UI is idle)."),
                    System.Windows.Threading.DispatcherPriority.ContextIdle);
            };
            showTimer.Start();

            void Reapply()
            {
                // other windows themed by SfSkinManager (floating panels, open tool windows, dialogs)
                var others = Current.Windows.OfType<Window>()
                    .Where(w => !ReferenceEquals(w, window) && SfSkinManager.GetTheme(w) is not null)
                    .ToList();

                // NOTE: trick SfSkinManager to unregister current ThemeSettings (must happen before registering).
                foreach (var w in others.Prepend(window))
                {
                    if (SfSkinManager.GetTheme(w) is { } theme)
                    {
                        theme.ThemeName = "";
                    }
                }
                SfSkinManager.RegisterThemeSettings("MaterialDark", BuildTheme(settingsManager, themeService));
                SfSkinManager.ApplyStylesOnApplication = true;
                SfSkinManager.SetTheme(window, new Theme("MaterialDark"));
                foreach (var other in others)
                {
                    SfSkinManager.SetTheme(other, new Theme("MaterialDark"));
                    other.InvalidateVisual();
                }

                // Popups have their own visual tree outside of any Window (auto-hidden docking panels sliding in,
                // context menus, dropdowns). Re-skin the ones that contain Syncfusion controls.
                foreach (var source in PresentationSource.CurrentSources.OfType<PresentationSource>().ToList())
                {
                    if (source.RootVisual is FrameworkElement root and not Window && ContainsSyncfusion(root, 6))
                    {
                        if (SfSkinManager.GetTheme(root) is { } popupTheme)
                        {
                            popupTheme.ThemeName = "";
                        }
                        SfSkinManager.SetTheme(root, new Theme("MaterialDark"));
                        root.InvalidateVisual();
                    }
                }
            }

            static bool ContainsSyncfusion(DependencyObject element, int depth)
            {
                if (element.GetType().Namespace?.StartsWith("Syncfusion", StringComparison.Ordinal) == true)
                {
                    return true;
                }
                if (depth == 0)
                {
                    return false;
                }
                var count = VisualTreeHelper.GetChildrenCount(element);
                for (var i = 0; i < count; i++)
                {
                    if (ContainsSyncfusion(VisualTreeHelper.GetChild(element, i), depth - 1))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //https://stackoverflow.com/a/46804709/16407587
        private void SetupExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
                if (e.IsTerminating) // And we have no choice but to exit, flush/write any pending logs.
                {
                    Log.CloseAndFlush();
                }
            };

            DispatcherUnhandledException += (s, e) =>
            {
                LogUnhandledException(e.Exception, "Application.Current.DispatcherUnhandledException");
                e.Handled = true;
            };

            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
                e.SetObserved();
            };

            RxApp.DefaultExceptionHandler = new DefaultObserverExceptionHandler();
        }

        /// <summary>
        /// This isn't great but can used until each TaskCommand ThrownExceptions can be properly subscribed to.
        /// </summary>
        // https://www.reactiveui.net/docs/handbook/default-exception-handler/
        public class DefaultObserverExceptionHandler : IObserver<Exception>
        {
            public void OnNext(Exception ex)
            {
                if (Debugger.IsAttached) // If we're debugging, break.
                {
                    Debugger.Break();
                }

                LogUnhandledException(ex, "RxApp.DefaultExceptionHandler");
            }

            public void OnError(Exception ex)
            {
                if (Debugger.IsAttached) // If we're debugging, break.
                {
                    Debugger.Break();
                }

                LogUnhandledException(ex, "RxApp.DefaultExceptionHandler");
            }

            public void OnCompleted()
            {
                if (Debugger.IsAttached) // If we're debugging, break.
                {
                    Debugger.Break();
                }
            }
        }

        private static void LogUnhandledException(Exception exception, string source)
        {
            var _logger = Splat.Locator.Current.GetService<ILoggerService>();
            if (_logger == null)
            {
                return;
            }

            var message = $"Unhandled exception ({source})";
            try
            {
                var assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName();
                message = string.Format("Unhandled exception in {0} v{1}", assemblyName.Name, assemblyName.Version);
                _logger.Error(message);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            finally
            {
                var isInner = false;
                while (exception != null)
                {
                    if (isInner)
                    {
                        _logger.Error("--------- InnerException ---------");
                    }
                    _logger.Error(exception);

                    exception = exception.InnerException;
                    isInner = true;
                }
                //Application.Current.Shutdown();
            }
        }
    }
}
