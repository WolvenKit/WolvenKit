using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Modkit.RED4.Project;
using WolvenKit.App.Services;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using Xunit.Sdk;

namespace WolvenKit.IntegrationTests.Helpers;

/// <summary>
/// Boots a real application host and loads the real Cyberpunk 2077 game archives once, then shares
/// them across every test in a class.
///
/// Requires the `CP77_DIR` user environment variable, same as
/// `ProjectExplorerConvertToJsonIntegrationTests`.
/// </summary>
public sealed class ArchiveXlItemTestFixture : IDisposable
{
    public IHost Host { get; }
    public IServiceProvider Services => Host.Services;
    public ArchiveXlItemService ItemService { get; }
    public IProjectManager ProjectManager { get; }
    public IAppArchiveManager ArchiveManager { get; }
    public Cr2WTools Cr2WTools { get; }

    public ArchiveXlItemTestFixture()
    {
        Host = IntegrationTestHost.Create();

        var hashService = Services.GetRequiredService<IHashService>();
        hashService.Load();

        var settingsManager = Services.GetRequiredService<ISettingsManager>();
        var exePath = Path.Combine(ResolveGameDirectory(), "bin", "x64", "Cyberpunk2077.exe");
        if (!File.Exists(exePath))
        {
            throw new XunitException($"Cyberpunk2077.exe not found at '{exePath}'.");
        }

        settingsManager.CP77ExecutablePath = exePath;

        ArchiveManager = Services.GetRequiredService<IAppArchiveManager>();
        ArchiveManager.LoadGameArchives(new FileInfo(exePath));

        ProjectManager = Services.GetRequiredService<IProjectManager>();
        ItemService = Services.GetRequiredService<ArchiveXlItemService>();
        Cr2WTools = Services.GetRequiredService<Cr2WTools>();
    }

    /// <summary>
    /// Creates an empty project in a throwaway directory and makes it the active project.
    /// </summary>
    public Cp77Project CreateTempProject(out string projectRoot)
    {
        projectRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_AxlItemTest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(projectRoot);

        // Location points at the .cdproj file, not the folder - ProjectDirectory is derived from it
        // via GetDirectoryName. Passing a folder silently resolves the project one level too high,
        // which puts every test in a shared %TEMP%\source.
        var location = Path.Combine(projectRoot, "axl_test.cdproj");
        var project = new Cp77Project(location, "axl_test", "axl_test") { Author = "tester" };
        project.CreateDefaultDirectories();

        if (!project.ModDirectory.StartsWith(projectRoot, StringComparison.OrdinalIgnoreCase))
        {
            throw new XunitException(
                $"Test project is not isolated: ModDirectory '{project.ModDirectory}' is outside '{projectRoot}'.");
        }

        ProjectManager.ActiveProject = project;
        return project;
    }

    private static string ResolveGameDirectory()
    {
        var dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
        {
            return dir;
        }

        throw new XunitException(
            "CP77_DIR user environment variable must point to a valid Cyberpunk 2077 installation.");
    }

    public void Dispose() => Host.Dispose();
}
