using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace WolvenKit.UITests.Helpers;

/// <summary>
/// Manages launching and disposing WolvenKit.exe for UI tests.
///
/// The app is located via the WOLVENKIT_EXE environment variable. If that is
/// not set, the helper tries the default build output path relative to this
/// test assembly so that running from Visual Studio works out of the box:
///   {repo}/WolvenKit/bin/{config}/net8.0-windows10.0.17763/win-x64/WolvenKit.exe
///
/// The game archives must already be configured inside WolvenKit's settings
/// (CP77_DIR user environment variable or prior manual setup) — the UI tests
/// interact with the live application, not a mock.
/// </summary>
public sealed class WolvenKitTestFixture : IDisposable
{
    private const string ExeEnvVar = "WOLVENKIT_EXE";
    private const string AppProcessName = "WolvenKit";

    private Application? _application;
    private UIA3Automation? _automation;

    public Application Application => _application ?? throw new InvalidOperationException("Fixture not started.");
    public UIA3Automation Automation => _automation ?? throw new InvalidOperationException("Fixture not started.");

    /// <summary>The project temp root that this test run will use. Lives under obj/ so gitignore picks it up.</summary>
    public string TempRoot { get; }

    public WolvenKitTestFixture()
    {
        // Place temp projects under the test project's obj/ directory.
        var assemblyDir = AppContext.BaseDirectory;
        var testProjectRoot = Path.GetFullPath(Path.Combine(assemblyDir, "..", ".."));
        TempRoot = Path.Combine(testProjectRoot, "obj", "UITestTemp", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(TempRoot);
    }

    /// <summary>
    /// Launches the application and waits for its main window to appear.
    /// Call once per test class from [TestInitialize] or class fixture init.
    /// </summary>
    /// <param name="startupTimeoutSeconds">
    /// How long to wait for the main window.
    /// </param>
    public Window Start(int startupTimeoutSeconds = 400)
    {
        var exePath = ResolveExePath();
        _automation = new UIA3Automation();
        _application = Application.Launch(exePath);

        var automation = _automation;
        Window? found = null;

        bool ready = WaitUntil(
            () =>
            {
                var windows = _application.GetAllTopLevelWindows(automation);
                found = windows.FirstOrDefault(IsMainShellWindow);
                return found != null;
            },
            timeoutMs: startupTimeoutSeconds * 1000,
            pollIntervalMs: 500);

        if (!ready || found == null)
        {
            var titles = string.Join(", ",
                _application.GetAllTopLevelWindows(automation).Select(w => $"'{w.Title}'"));
            throw new TimeoutException(
                $"WolvenKit main shell window did not appear within {startupTimeoutSeconds} s. " +
                $"Open windows: [{titles}]. Executable: {exePath}");
        }

        return found;
    }

    /// <summary>
    /// Returns true when <paramref name="window"/> looks like the WolvenKit main docking shell
    /// rather than a transient dialog or splash screen.
    /// We use size as the heuristic: the shell is always large; dialogs are small.
    /// </summary>
    private static bool IsMainShellWindow(Window window)
    {
        try
        {
            if (!window.IsAvailable || window.IsOffscreen)
            {
                return false;
            }

            var bounds = window.BoundingRectangle;

            // Any real application shell will be at least 600×400.
            // Splash screens and dialogs are smaller or zero-sized while loading.
            return bounds.Width >= 600 && bounds.Height >= 400;
        }
        catch
        {
            return false;
        }
    }

    private static string ResolveExePath()
    {
        var fromEnv = Environment.GetEnvironmentVariable(ExeEnvVar);
        if (!string.IsNullOrEmpty(fromEnv) && File.Exists(fromEnv))
        {
            return fromEnv;
        }

        // Walk up from the test output directory to find the repo root, then
        // resolve the default build output location.
        var assemblyDir = AppContext.BaseDirectory;
        foreach (var config in new[] { "Debug", "Release" })
        {
            var candidate = Path.GetFullPath(
                Path.Combine(assemblyDir,
                    "..", "..", "..", "..", "..", "..",    // Tests/WolvenKit.UITests/bin/<config>/net…  →  repo root
                    "WolvenKit", "bin", "x64", config,
                    "net8.0-windows10.0.17763", "win-x64",
                    "WolvenKit.exe"));

            if (File.Exists(candidate))
            {
                return candidate;
            }
            else
            {
                Console.WriteLine($"Failed to find WolvenKit.exe in dir: {candidate}.");
            }
        }

        throw new FileNotFoundException(
            $"Cannot find WolvenKit.exe. Set the {ExeEnvVar} environment variable to its full path, " +
            $"or build the WolvenKit project first.");
    }

    /// <summary>Waits up to <paramref name="timeoutMs"/> ms, polling every 200 ms, until <paramref name="condition"/> returns true.</summary>
    public static bool WaitUntil(Func<bool> condition, int timeoutMs = 15_000, int pollIntervalMs = 50)
    {
        var deadline = Stopwatch.StartNew();
        while (deadline.ElapsedMilliseconds < timeoutMs)
        {
            try
            {
                if (condition())
                {
                    return true;
                }
            }
            catch
            {
                // Element not yet available — keep polling.
            }

            Thread.Sleep(pollIntervalMs);
        }

        return false;
    }

    public void Dispose()
    {
        try { _application?.Close(); } catch { /* best effort */ }
        try { _application?.Dispose(); } catch { /* best effort */ }
        try { _automation?.Dispose(); } catch { /* best effort */ }

        // Clean up temp projects created by this run.
        try
        {
            if (Directory.Exists(TempRoot))
            {
                Directory.Delete(TempRoot, recursive: true);
            }
        }
        catch { /* best effort */ }
    }
}
