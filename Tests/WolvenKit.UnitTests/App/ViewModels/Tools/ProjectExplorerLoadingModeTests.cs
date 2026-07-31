using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
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

namespace Wolvenkit.Test.App.ViewModels.Tools;

/// <summary>
/// Covers PE loading chrome lifecycle (review issues 3, 4-related CancelProjectLoad, DisableLoadingMode).
/// Uses an uninitialized AppViewModel so we avoid the heavy DI graph while still exercising PEVM.
/// </summary>
[Collection(DispatcherTimerTestCollection.Name)]
public class ProjectExplorerLoadingModeTests : IDisposable
{
    private readonly string _tempRoot;
    private readonly Mock<IProjectManager> _projectManager = new();
    private readonly Mock<ILoggerService> _logger = new();
    private readonly Mock<INotificationService> _notifications = new();
    private readonly Mock<IProgressService<double>> _progress = new();
    private readonly Mock<IModTools> _modTools = new();
    private readonly Mock<IGameControllerFactory> _gameController = new();
    private readonly Mock<IPluginService> _plugins = new();
    private readonly Mock<ISettingsManager> _settings = new();
    private readonly Mock<IModifierViewStateService> _modifiers = new();
    private readonly Mock<IArchiveManager> _archives = new();
    private readonly ProjectEvents _projectEvents = new();
    private readonly ProjectExplorerViewModel _pe;
    private readonly AppViewModel _appViewModel;

    public ProjectExplorerLoadingModeTests()
    {
        _tempRoot = Path.Combine(Path.GetTempPath(), "PELoadingModeTests_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempRoot);

        _appViewModel = (AppViewModel)RuntimeHelpers.GetUninitializedObject(typeof(AppViewModel));
        var projectResourceTools = (ProjectResourceTools)RuntimeHelpers.GetUninitializedObject(typeof(ProjectResourceTools));
        var importExportHelper = (ImportExportHelper)RuntimeHelpers.GetUninitializedObject(typeof(ImportExportHelper));

        _pe = new ProjectExplorerViewModel(
            _appViewModel,
            _projectManager.Object,
            _logger.Object,
            _notifications.Object,
            _progress.Object,
            _modTools.Object,
            _gameController.Object,
            _plugins.Object,
            _settings.Object,
            _modifiers.Object,
            _archives.Object,
            projectResourceTools,
            importExportHelper,
            _projectEvents);
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
    public void ProjectWillLoad_ArmsLoadingNewProject()
    {
        var project = CreateProject("ModA");

        _pe.ProjectWillLoad(project.Location);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);
        Assert.True(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
    }

    [Fact]
    public void ProjectWillLoad_SameProjectPath_DoesNotRearm()
    {
        var project = CreateProject("ModA");
        _pe.ActiveProject = project;

        _pe.ProjectWillLoad(project.Location);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
    }

    [Fact]
    public void CancelProjectLoad_ClearsLoadingModeWithoutSuccessLog()
    {
        var project = CreateProject("ModA");
        _pe.ProjectWillLoad(project.Location);
        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);

        _pe.CancelProjectLoad();

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
        _logger.Verify(l => l.Success(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void DisableLoadingMode_StopsHeartbeatAndReportsSuccessWhenProjectActive()
    {
        var project = CreateProject("ModA");
        _pe.ActiveProject = project;
        _pe.ProjectWillLoad(CreateProject("ModB").Location);

        _pe.DisableLoadingMode();

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
        _logger.Verify(l => l.Success(It.Is<string>(s => s.Contains("Loaded project", StringComparison.Ordinal))), Times.Once);
    }

    [Fact]
    public void OnInitialProjectLoaded_EqualsBail_DisarmsLoadingChrome()
    {
        var project = CreateProject("ModA");
        _pe.ActiveProject = project;
        _projectManager.SetupGet(m => m.ActiveProject).Returns(project);

        // Arm for a different path so chrome is loading, then simulate event for same project.
        _pe.ProjectWillLoad(CreateProject("ModB").Location);
        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);

        InvokeOnInitialProjectLoaded();

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
    }

    [Fact]
    public void OnInitialProjectLoaded_NullProjectManager_DisarmsLoadingChrome()
    {
        _projectManager.SetupGet(m => m.ActiveProject).Returns((Cp77Project?)null);
        _pe.ProjectWillLoad(CreateProject("ModA").Location);

        InvokeOnInitialProjectLoaded();

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.Ready, _pe.CurrentLoadingMode);
    }

    [Fact]
    public void EnableLoadingMode_SecondCall_DoesNotThrow()
    {
        var a = CreateProject("ModA");
        var b = CreateProject("ModB");

        _pe.ProjectWillLoad(a.Location);
        // Second arm for another project while first heartbeat still running (token non-empty).
        _pe.ProjectWillLoad(b.Location);

        Assert.Equal(ProjectExplorerViewModel.LoadingMode.LoadingNewProject, _pe.CurrentLoadingMode);
        Assert.True(DispatcherHelper.IsRepeatingActionRunning("ProjectExplorer load project"));
    }

    private void InvokeOnInitialProjectLoaded()
    {
        var method = typeof(ProjectExplorerViewModel).GetMethod(
            "AppViewModel_OnInitialProjectLoaded",
            BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);
        method!.Invoke(_pe, new object?[] { _appViewModel, EventArgs.Empty });
    }
}
