using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using WolvenKit.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Covers DispatcherHelper repeating actions: that they actually tick, and that the
/// reference-counted purpose registry lets several owners share one timer without any of them
/// tearing it down while another still needs it.
///
/// Every test mints its own purpose, so this class needs no xunit collection and runs fully in
/// parallel with the rest of the assembly.
/// </summary>
public class DispatcherHelperTests
{
    private static string UniquePurpose() => "test-purpose-" + Guid.NewGuid().ToString("N");

    /// <summary>
    /// Drains the dispatcher queue until <paramref name="condition"/> holds or we time out.
    ///
    /// Invoking at a priority below Normal forces the queued DispatcherTimer ticks (Normal) to be
    /// processed first — the standard "DoEvents" pump. Without this no DispatcherTimer would ever
    /// fire in a unit test, because nothing is running a dispatcher frame.
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

    [Fact]
    public void StartRepeatingAction_ActuallyInvokesTheAction()
    {
        var purpose = UniquePurpose();
        var ticks = 0;

        using var handle = DispatcherHelper.StartRepeatingAction(
            purpose,
            () => Interlocked.Increment(ref ticks),
            TimeSpan.FromMilliseconds(5));

        PumpUntil(() => Volatile.Read(ref ticks) >= 2, TimeSpan.FromSeconds(10));

        Assert.True(Volatile.Read(ref ticks) >= 2, $"expected at least 2 ticks, saw {ticks}");
    }

    [Fact]
    public void DisposingLastHandle_StopsTheAction()
    {
        var purpose = UniquePurpose();
        var ticks = 0;

        var handle = DispatcherHelper.StartRepeatingAction(
            purpose,
            () => Interlocked.Increment(ref ticks),
            TimeSpan.FromMilliseconds(5));

        PumpUntil(() => Volatile.Read(ref ticks) >= 1, TimeSpan.FromSeconds(10));
        handle.Dispose();

        var afterDispose = Volatile.Read(ref ticks);
        PumpUntil(() => false, TimeSpan.FromMilliseconds(100));

        Assert.Equal(afterDispose, Volatile.Read(ref ticks));
        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));
    }

    [Fact]
    public void StartRepeatingAction_SamePurpose_SharesOneTimerAndRefCounts()
    {
        var purpose = UniquePurpose();
        var firstActionRuns = 0;
        var secondActionRuns = 0;

        using var first = DispatcherHelper.StartRepeatingAction(
            purpose, () => Interlocked.Increment(ref firstActionRuns), TimeSpan.FromMilliseconds(5));

        using var second = DispatcherHelper.StartRepeatingAction(
            purpose, () => Interlocked.Increment(ref secondActionRuns), TimeSpan.FromMilliseconds(5));

        Assert.Equal(2, DispatcherHelper.GetRepeatingActionRefCount(purpose));

        PumpUntil(() => Volatile.Read(ref firstActionRuns) >= 1, TimeSpan.FromSeconds(10));

        Assert.True(Volatile.Read(ref firstActionRuns) >= 1);
        Assert.Equal(0, Volatile.Read(ref secondActionRuns));
    }

    [Fact]
    public void ReleasingOneOfTwoHandles_KeepsTimerAliveForTheOther()
    {
        var purpose = UniquePurpose();

        var first = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
        var second = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));

        second.Dispose();

        Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));
        Assert.Equal(1, DispatcherHelper.GetRepeatingActionRefCount(purpose));

        first.Dispose();

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));
        Assert.Equal(0, DispatcherHelper.GetRepeatingActionRefCount(purpose));
    }

    [Fact]
    public void OnCancelled_RunsOnceWhenLastHandleIsReleased()
    {
        var purpose = UniquePurpose();
        var cancelledCalls = 0;

        var first = DispatcherHelper.StartRepeatingAction(
            purpose,
            () => { },
            TimeSpan.FromHours(1),
            onCancelled: () => Interlocked.Increment(ref cancelledCalls));

        var second = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));

        second.Dispose();
        Assert.Equal(0, Volatile.Read(ref cancelledCalls));

        first.Dispose();
        Assert.Equal(1, Volatile.Read(ref cancelledCalls));
    }

    [Fact]
    public void Handle_Dispose_IsIdempotent()
    {
        var purpose = UniquePurpose();
        var cancelledCalls = 0;

        var handle = DispatcherHelper.StartRepeatingAction(
            purpose,
            () => { },
            TimeSpan.FromHours(1),
            onCancelled: () => Interlocked.Increment(ref cancelledCalls));

        Assert.True(handle.IsActive);

        handle.Dispose();
        handle.Dispose();
        handle.Dispose();

        Assert.False(handle.IsActive);
        Assert.Equal(1, Volatile.Read(ref cancelledCalls));
        Assert.Equal(0, DispatcherHelper.GetRepeatingActionRefCount(purpose));
    }

    [Fact]
    public void StopRepeatingAction_NullHandle_IsNoOp()
    {
        DispatcherHelper.StopRepeatingAction(null);
    }

    [Fact]
    public void StopRepeatingAction_AllowsRestartWithSamePurpose()
    {
        var purpose = UniquePurpose();

        var first = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
        first.Dispose();
        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));

        using var second = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
        Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));
    }

    [Fact]
    public void StartRepeatingAction_DifferentPurposes_RunIndependently()
    {
        var a = UniquePurpose();
        var b = UniquePurpose();

        var first = DispatcherHelper.StartRepeatingAction(a, () => { }, TimeSpan.FromHours(1));
        using var second = DispatcherHelper.StartRepeatingAction(b, () => { }, TimeSpan.FromHours(1));

        first.Dispose();

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(a));
        Assert.True(DispatcherHelper.IsRepeatingActionRunning(b));
    }

    [Fact]
    public void StartRepeatingAction_RejectsEmptyPurposeAndNullAction()
    {
        Assert.Throws<ArgumentException>(() =>
            DispatcherHelper.StartRepeatingAction("", () => { }, TimeSpan.FromHours(1)));

        Assert.Throws<ArgumentNullException>(() =>
            DispatcherHelper.StartRepeatingAction(UniquePurpose(), null!, TimeSpan.FromHours(1)));
    }

    [Fact]
    public async Task ConcurrentStartsAndStops_LeaveNoDanglingRegistration()
    {
        var purpose = UniquePurpose();
        var handles = new ConcurrentBag<DispatcherHelper.RepeatingActionHandle>();

        var starts = new Task[16];
        for (var i = 0; i < starts.Length; i++)
        {
            starts[i] = Task.Run(() =>
                handles.Add(DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1))));
        }

        await Task.WhenAll(starts);

        Assert.Equal(starts.Length, handles.Count);
        Assert.Equal(starts.Length, DispatcherHelper.GetRepeatingActionRefCount(purpose));
        Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));

        await Task.WhenAll(handles.ToArray().Select(h => Task.Run(h.Dispose)).ToArray());

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));
        Assert.Equal(0, DispatcherHelper.GetRepeatingActionRefCount(purpose));

        using var restarted = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
        Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));
    }
}
