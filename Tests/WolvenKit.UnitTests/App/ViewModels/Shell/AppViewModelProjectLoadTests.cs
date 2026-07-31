using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
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
/// Covers AppViewModel.LoadProjectFromPathAsync lifecycle (review issues 2 and 4):
/// HandleStartup faults still raise OnInitialProjectLoaded; failed loads cancel PE chrome;
/// location mismatch vs ProjectManager previous project cancels loading.
/// </summary>
[Collection(DispatcherTimerTestCollection.Name)]
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
        try
        {
            _pe.CancelProjectLoad();
            if (Directory.Exists(_tempRoot))
            {
                Directory.Delete(_tempRoot, recursive: true);
            }
        }
        catch
        {
            // best-effort
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

    [Fact]
    public async Task LoadProjectFromPathAsync_HandleStartupFault_StillRaisesOnInitialProjectLoaded()
    {
        var project = CreateProject("ModA");
        _projectManager.Setup(m => m.LoadAsync(project.Location)).ReturnsAsync(project);
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);
        _gameController.Setup(c => c.HandleStartup()).ThrowsAsync(new InvalidOperationException("archive boom"));

        var raised = false;
        _app.OnInitialProjectLoaded += (_, _) => raised = true;

        await _app.LoadProjectFromPathAsync(project.Location);

        Assert.True(raised);
        _logger.Verify(l => l.Error(It.IsAny<Exception>()), Times.AtLeastOnce);
        // TODO: Uncomment when on .NET 10
        //_notifications.Verify(n => n.Success(It.Is<string>(s => s.Contains("loaded", StringComparison.OrdinalIgnoreCase))), Times.Once);
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
        _gameController.Verify(c => c.HandleStartup(), Times.Never);
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
        _gameController.Verify(c => c.HandleStartup(), Times.Never);
    }

    [Fact]
    public async Task LoadProjectFromPathAsync_Success_ArmsProjectWillLoadThenRaisesEvent()
    {
        var project = CreateProject("ModA");
        _projectManager.Setup(m => m.LoadAsync(project.Location)).ReturnsAsync(project);
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);
        _gameController.Setup(c => c.HandleStartup()).Returns(Task.CompletedTask);

        var raised = false;
        _app.OnInitialProjectLoaded += (_, _) =>
        {
            raised = true;
            // After successful load, PE should have been armed (LoadingNewProject) before the event.
            Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);
        };

        await _app.LoadProjectFromPathAsync(project.Location);

        Assert.True(raised);
        Assert.Equal(project, _app.ActiveProject);
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
