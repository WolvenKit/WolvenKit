using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using Moq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;
using Wolvenkit.Test.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.ViewModels.Shell;

/// <summary>
/// Covers AppViewModel.LoadProjectFromPathAsync lifecycle: failed loads cancel PE chrome;
/// location mismatch vs ProjectManager previous project cancels loading; a successful load
/// eventually raises OnInitialProjectLoaded.
///
/// Note that the success path finishes on a delayed dispatcher callback
/// (DispatcherHelper.DelayOnMainThread), so awaiting LoadProjectFromPathAsync won't
/// work... the tests would have to "pump" (see PumpUntil).
/// </summary>
[Collection(ProjectLoadHeartbeatCollection.Name)]
public class AppViewModelProjectLoadTests : IDisposable
{
    private readonly string _tempRoot;
    private readonly Mock<IProjectManager> _projectManager = new();
    private readonly Mock<ILoggerService> _logger = new();
    private readonly Mock<INotificationService> _notifications = new();
    private readonly Mock<IProgressService<double>> _progress = new();
    private readonly Mock<IModTools> _modTools = new();
    private readonly Mock<IGameControllerFactory> _gameControllerFactory = new();
    private readonly Mock<IGameController> _gameController = new();
    private readonly Mock<IPluginService> _plugins = new();
    private readonly Mock<ISettingsManager> _settings = new();
    private readonly Mock<IModifierViewStateService> _modifiers = new();
    private readonly Mock<IArchiveManager> _archives = new();
    private readonly Mock<IArchiveManagerLoader> _archiveLoader = new();
    private readonly ProjectEvents _projectEvents = new();
    private readonly AppViewModel _app;
    private readonly ProjectExplorerViewModel _pe;
    private readonly string _fakeExePath;

    public AppViewModelProjectLoadTests()
    {
        _tempRoot = Path.Combine(Path.GetTempPath(), "AppVmProjectLoad_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempRoot);
        _fakeExePath = Path.Combine(_tempRoot, "Cyberpunk2077.exe");
        File.WriteAllText(_fakeExePath, "exe");

        _settings.SetupGet(s => s.CP77ExecutablePath).Returns(_fakeExePath);
        _gameControllerFactory.Setup(f => f.GetController()).Returns(_gameController.Object);

        _app = (AppViewModel)RuntimeHelpers.GetUninitializedObject(typeof(AppViewModel));
        SetField(_app, "_projectManager", _projectManager.Object);
        SetField(_app, "_loggerService", _logger.Object);
        SetField(_app, "_notificationService", _notifications.Object);
        SetField(_app, "_gameControllerFactory", _gameControllerFactory.Object);
        SetField(_app, "_archiveManagerLoader", _archiveLoader.Object);
        SetProperty(_app, nameof(AppViewModel.SettingsManager), _settings.Object);

        // DockedViews is initialized by the field initializer; with GetUninitializedObject it is null.
        SetField(_app, "_dockedViews", new ObservableCollection<IDockElement>());

        var projectResourceTools = (ProjectResourceTools)RuntimeHelpers.GetUninitializedObject(typeof(ProjectResourceTools));
        var importExportHelper = (ImportExportHelper)RuntimeHelpers.GetUninitializedObject(typeof(ImportExportHelper));

        _pe = new ProjectExplorerViewModel(
            _app,
            _projectManager.Object,
            _logger.Object,
            _notifications.Object,
            _progress.Object,
            _modTools.Object,
            _gameControllerFactory.Object,
            _plugins.Object,
            _settings.Object,
            _modifiers.Object,
            _archives.Object,
            projectResourceTools,
            importExportHelper,
            _projectEvents);

        _app.DockedViews.Add(_pe);
    }

    public void Dispose()
    {
        _pe.CancelProjectLoad();

        try
        {
            _pe.UnwatchProject(_pe.ActiveProject);
        }
        catch (Exception)
        {
            // The watcher may never have been started for a given test.
        }

        TempProjectDirectory.Delete(_tempRoot);
    }

    /// <summary>
    /// A failing archive load must not escape startup. ArchiveManagerLoader logs and rethrows, and
    /// HandleActivation is reached from the Status setter, so an unguarded fault would propagate
    /// out of OnStatusChanged and take the launch down. Before archive loading moved to
    /// HandleActivation this was guarded inside LoadProjectFromPathAsync; these two pin the
    /// replacement guard.
    /// </summary>
    [Fact]
    public async Task LoadArchivesSafely_LoaderFaults_IsLoggedAndSwallowed()
    {
        _archiveLoader.Setup(c => c.LoadArchiveManagerAsync())
            .ThrowsAsync(new InvalidOperationException("archive boom"));

        await InvokeLoadArchivesSafely();

        _archiveLoader.Verify(c => c.LoadArchiveManagerAsync(), Times.Once);
        _logger.Verify(l => l.Error(It.IsAny<Exception>()), Times.Once);
    }

    [Fact]
    public async Task LoadArchivesSafely_LoaderSucceeds_LogsNoError()
    {
        _archiveLoader.Setup(c => c.LoadArchiveManagerAsync()).Returns(Task.CompletedTask);

        await InvokeLoadArchivesSafely();

        _archiveLoader.Verify(c => c.LoadArchiveManagerAsync(), Times.Once);
        _logger.Verify(l => l.Error(It.IsAny<Exception>()), Times.Never);
    }

    /// <summary>
    /// HandleActivation itself is not reachable from these tests - it also inits plugins, opens
    /// the home page and fires update commands, none of which exist on a
    /// GetUninitializedObject AppViewModel - so the guard is exercised directly.
    /// </summary>
    private Task InvokeLoadArchivesSafely()
    {
        var method = typeof(AppViewModel).GetMethod(
            "LoadArchivesSafelyAsync",
            BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);

        return (Task)method!.Invoke(_app, null)!;
    }

    /// <summary>
    /// Drains the dispatcher queue until <paramref name="condition"/> holds or we time out.
    /// Nothing runs a dispatcher frame in a unit test, so callbacks posted by
    /// DispatcherHelper.DelayOnMainThread would otherwise never execute.
    /// </summary>
    private static void PumpUntil(Func<bool> condition, TimeSpan timeout)
    {
        var dispatcher = Dispatcher.CurrentDispatcher;
        var stopwatch = Stopwatch.StartNew();

        while (!condition() && stopwatch.Elapsed < timeout)
        {
            dispatcher.Invoke(() => { }, DispatcherPriority.Background);
            Thread.Sleep(1);
        }
    }

    private Cp77Project CreateProject(string name)
    {
        var dir = Path.Combine(_tempRoot, name);
        Directory.CreateDirectory(dir);
        var projectFile = Path.Combine(dir, name + Cp77Project.ProjectFileExtension);
        File.WriteAllText(projectFile, "<!-- test -->");
        var project = new Cp77Project(projectFile, name, name);
        project.CreateDefaultDirectories();
        return project;
    }

    /// <summary>
    /// Archive loading moved out of the project-load path and into AppViewModel.HandleActivation,
    /// so a broken archive load can no longer affect opening a project. This test checks
    /// that these are now decoupled: the archive loader is not consulted here at all,
    /// and the project still loads.
    /// </summary>
    [Fact]
    public async Task LoadProjectFromPathAsync_DoesNotLoadArchives()
    {
        var project = CreateProject("ModA");
        _projectManager.Setup(m => m.LoadAsync(project.Location)).ReturnsAsync(project);
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);
        _archiveLoader.Setup(c => c.LoadArchiveManagerAsync()).ThrowsAsync(new InvalidOperationException("archive boom"));

        var raised = false;
        _app.OnInitialProjectLoaded += (_, _) => raised = true;

        await _app.LoadProjectFromPathAsync(project.Location);

        _archiveLoader.Verify(c => c.LoadArchiveManagerAsync(), Times.Never);

        PumpUntil(() => raised, TimeSpan.FromSeconds(10));
        Assert.True(raised);
        _notifications.Verify(n => n.Success(It.Is<string>(s => s.Contains("loaded", StringComparison.OrdinalIgnoreCase))), Times.Once);
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_MissingExe_RaisesOnInitialProjectLoadedWithoutHandleStartup()
    {
        var project = CreateProject("ModA");
        _projectManager.Setup(m => m.LoadAsync(project.Location)).ReturnsAsync(project);
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);
        _settings.SetupGet(s => s.CP77ExecutablePath).Returns(Path.Combine(_tempRoot, "missing.exe"));

        var raised = false;
        _app.OnInitialProjectLoaded += (_, _) => raised = true;

        await _app.LoadProjectFromPathAsync(project.Location);

        Assert.True(raised);
        _archiveLoader.Verify(c => c.LoadArchiveManagerAsync(), Times.Never);
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_NullProject_CancelsPeLoading()
    {
        var path = Path.Combine(_tempRoot, "ghost", "ghost.cpmodproj");
        _projectManager.Setup(m => m.LoadAsync(path)).ReturnsAsync((Cp77Project?)null);
        _pe.ProjectWillLoad(path);
        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);

        await _app.LoadProjectFromPathAsync(path);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_LocationMismatch_CancelsPeLoading()
    {
        var existing = CreateProject("Existing");
        var requested = Path.Combine(_tempRoot, "Other", "Other.cpmodproj");
        Directory.CreateDirectory(Path.GetDirectoryName(requested)!);

        // Simulates ProjectManager returning previous ActiveProject when new path fails.
        _projectManager.Setup(m => m.LoadAsync(requested)).ReturnsAsync(existing);
        _pe.ProjectWillLoad(requested);
        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);

        await _app.LoadProjectFromPathAsync(requested);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        _archiveLoader.Verify(c => c.LoadArchiveManagerAsync(), Times.Never);
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_Success_ArmsProjectWillLoadThenRaisesEvent()
    {
        var project = CreateProject("ModA");
        _projectManager.Setup(m => m.LoadAsync(project.Location)).ReturnsAsync(project);
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);

        var raised = false;
        _app.OnInitialProjectLoaded += (_, _) => raised = true;

        await _app.LoadProjectFromPathAsync(project.Location);

        // ActiveProject is set synchronously; the event is not. The success lane runs on a
        // DelayOnMainThread callback, so it needs a dispatcher frame and more than that delay.
        Assert.Equal(project, _app.ActiveProject);

        PumpUntil(() => raised, TimeSpan.FromSeconds(10));
        Assert.True(raised);
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_AnnouncesPendingLoadBeforeProjectManagerSwapsActiveProject()
    {
        var project = CreateProject("ModA");
        var modeWhenLoadAsyncRan = ProjectExplorerViewModel.LoadingMode.Ready;

        _projectManager.Setup(m => m.LoadAsync(project.Location))
            .Callback(() => modeWhenLoadAsyncRan = _pe.CurrentLoadingMode)
            .ReturnsAsync(project);
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);
        _archiveLoader.Setup(c => c.LoadArchiveManagerAsync()).Returns(Task.CompletedTask);

        await _app.LoadProjectFromPathAsync(project.Location);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, modeWhenLoadAsyncRan);
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_FailedLoad_DoesNotReportProjectLoaded()
    {
        var path = Path.Combine(_tempRoot, "ghost", "ghost.cpmodproj");
        _projectManager.Setup(m => m.LoadAsync(path)).ReturnsAsync((Cp77Project?)null);

        await _app.LoadProjectFromPathAsync(path);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        _logger.Verify(
            l => l.Success(It.Is<string>(s => s.Contains("Loaded project", StringComparison.Ordinal))),
            Times.Never);
    }

    private static void SetField(object target, string name, object? value)
    {
        var field = target.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        Assert.NotNull(field);
        field!.SetValue(target, value);
    }

    private static void SetProperty(object target, string name, object? value)
    {
        var prop = target.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        Assert.NotNull(prop);
        prop!.SetValue(target, value);
    }
}
