using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Services;
using Wolvenkit.Test.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.Controllers;

/// <summary>
/// Covers RED4Controller archive-loading heartbeat idempotency (review issue 5)
/// via reflection on private Enable/DisableLoadingMode, without loading real game archives.
/// </summary>
[Collection(DispatcherTimerTestCollection.Name)]
public class Red4ControllerLoadingModeTests : IDisposable
{
    private const string Purpose = "RED4Controller archive loading";

    public void Dispose()
    {
        if (DispatcherHelper.TryGetRepeatingAction(Purpose, out var guid))
        {
            DispatcherHelper.StopRepeatingAction(guid);
        }
    }

    [Fact]
    public void EnableLoadingMode_Twice_DoesNotThrow_AndSharesHeartbeat()
    {
        var controller = CreateUninitializedController(out var progress);

        InvokePrivate(controller, "EnableLoadingMode");
        InvokePrivate(controller, "EnableLoadingMode");

        Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.True(DispatcherHelper.TryGetRepeatingAction(Purpose, out _));

        InvokePrivate(controller, "DisableLoadingMode");
        // depth 2 -> 1, still running
        Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));

        InvokePrivate(controller, "DisableLoadingMode");
        // depth 1 -> 0, stopped
        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(EStatus.Ready, progress.Object.Status);
    }

    [Fact]
    public void DisableLoadingMode_WithoutEnable_DoesNotThrow()
    {
        var controller = CreateUninitializedController(out _);
        InvokePrivate(controller, "DisableLoadingMode");
        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
    }

    private static RED4Controller CreateUninitializedController(out Mock<IProgressService<double>> progress)
    {
        progress = new Mock<IProgressService<double>>();
        progress.SetupAllProperties();

        var controller = (RED4Controller)RuntimeHelpers.GetUninitializedObject(typeof(RED4Controller));
        SetField(controller, "_progressService", progress.Object);
        SetField(controller, "_loadingCompletion", Guid.Empty);
        SetField(controller, "_loadingModeDepth", 0);
        return controller;
    }

    private static void InvokePrivate(object target, string methodName)
    {
        var method = target.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);
        method!.Invoke(target, null);
    }

    private static void SetField(object target, string name, object? value)
    {
        var field = target.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(field);
        field!.SetValue(target, value);
    }
}
