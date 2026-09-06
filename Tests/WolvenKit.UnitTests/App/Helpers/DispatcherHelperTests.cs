using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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

    #region DrainTheQueue

    // The drain semantics are covered by passing a dispatcher the test owns.

    [Fact]
    public void DrainTheQueue_WithoutAnApplication_DoesNotThrow()
    {
        Assert.Null(Record.Exception(() =>
        {
            DispatcherHelper.DrainTheQueue();
            DispatcherHelper.DrainTheQueue();
        }));
    }

    [Fact]
    public void DrainTheQueue_WithoutAnApplication_DrainsNothing()
    {
        var dispatcher = Dispatcher.CurrentDispatcher;
        var ran = false;

        dispatcher.BeginInvoke(() => ran = true, DispatcherPriority.Normal);

        DispatcherHelper.DrainTheQueue();

        // no Application.Current means no dispatcher to invoke on, so the queue is untouched
        Assert.False(ran);

        // ...and the operation really was pending - it runs the moment anything does pump
        PumpUntil(() => ran, TimeSpan.FromSeconds(10));
        Assert.True(ran);
    }

    [Fact]
    public void DrainTheQueue_OnAThreadWithNoDispatcher_ReturnsWithoutCreatingOne()
    {
        Exception? thrown = null;
        var createdADispatcher = true;

        // a fresh thread, so this cannot see a dispatcher some earlier test left on a pool thread
        var thread = new Thread(() =>
        {
            try
            {
                DispatcherHelper.DrainTheQueue();
                createdADispatcher = Dispatcher.FromThread(Thread.CurrentThread) is not null;
            }
            catch (Exception exception)
            {
                thrown = exception;
            }
        });

        thread.Start();

        // the Join bound is the real assertion: reaching for Dispatcher.CurrentDispatcher here
        // instead of Application.Current would spin up a dispatcher nobody pumps and block forever
        Assert.True(thread.Join(TimeSpan.FromSeconds(10)), "DrainTheQueue did not return");
        Assert.Null(thrown);
        Assert.False(createdADispatcher);
    }

    [Fact]
    public void DrainTheQueue_RunsEverythingQueuedAboveContextIdle_HighestPriorityFirst()
    {
        var dispatcher = Dispatcher.CurrentDispatcher;
        var order = new List<string>();

        // queued lowest-first, so an implementation that merely drained in insertion order would
        // still pass the ordering assertion by accident
        var background = dispatcher.BeginInvoke(() => order.Add("background"), DispatcherPriority.Background);
        var input = dispatcher.BeginInvoke(() => order.Add("input"), DispatcherPriority.Input);
        var normal = dispatcher.BeginInvoke(() => order.Add("normal"), DispatcherPriority.Normal);

        DispatcherHelper.DrainTheQueue(dispatcher);

        Assert.Equal(new[] { "normal", "input", "background" }, order);
        Assert.Equal(DispatcherOperationStatus.Completed, normal.Status);
        Assert.Equal(DispatcherOperationStatus.Completed, input.Status);
        Assert.Equal(DispatcherOperationStatus.Completed, background.Status);
    }

    [Fact]
    public void DrainTheQueue_LeavesWorkQueuedBelowContextIdle()
    {
        var dispatcher = Dispatcher.CurrentDispatcher;
        var ran = false;

        var operation = dispatcher.BeginInvoke(() => ran = true, DispatcherPriority.ApplicationIdle);

        DispatcherHelper.DrainTheQueue(dispatcher);

        // ContextIdle is the floor: idle-priority work is deliberately left for a real idle moment
        Assert.False(ran);
        Assert.Equal(DispatcherOperationStatus.Pending, operation.Status);

        // this dispatcher outlives the test - don't leave the operation to fire during another one
        operation.Abort();
    }

    [Fact]
    public void DrainTheQueue_OnAShutDownDispatcher_DoesNotThrow()
    {
        var dispatcher = DispatcherOnItsOwnShutDownThread();

        // the only path that reaches the catch: Invoke on a dead dispatcher. "Best effort" in the
        // doc comment means the caller never sees this.
        Assert.Null(Record.Exception(() => DispatcherHelper.DrainTheQueue(dispatcher)));
    }

    /// <summary>Spins up a dispatcher on its own thread, shuts it down, and hands back the corpse.</summary>
    private static Dispatcher DispatcherOnItsOwnShutDownThread()
    {
        Dispatcher? dispatcher = null;
        using var ready = new ManualResetEventSlim();

        var thread = new Thread(() =>
        {
            dispatcher = Dispatcher.CurrentDispatcher;
            ready.Set();
            Dispatcher.Run();
        })
        {
            IsBackground = true
        };

        thread.Start();
        Assert.True(ready.Wait(TimeSpan.FromSeconds(10)), "the dispatcher thread never started");

        dispatcher!.InvokeShutdown();
        Assert.True(thread.Join(TimeSpan.FromSeconds(10)), "the dispatcher thread never stopped");

        return dispatcher;
    }

    #endregion DrainTheQueue
}
