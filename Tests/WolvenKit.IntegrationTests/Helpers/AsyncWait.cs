using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WolvenKit.IntegrationTests.Helpers;

/// <summary>
/// Polling helpers for state that settles on deferred callbacks rather than on the awaited call.
/// </summary>
internal static class AsyncWait
{
    /// <summary>
    /// Polls <paramref name="condition"/> until it holds, or gives up after <paramref name="timeout"/>.
    /// </summary>
    /// <remarks>
    /// Project loading does not finish when the call that started it returns. LoadProjectFromPathAsync
    /// hands its tail to DispatcherHelper.DelayOnMainThread, which later raises OnInitialProjectLoaded,
    /// which in turn posts StartWatcher_AndLoadProject onto the dispatcher - only then does the project
    /// explorer have an ActiveProject. Awaiting NewProjectTask therefore proves nothing; the awaits in
    /// here are what let those queued callbacks run.
    /// </remarks>
    /// <returns>True if the condition held before the timeout.</returns>
    public static async Task<bool> UntilAsync(Func<bool> condition, TimeSpan timeout)
    {
        var stopwatch = Stopwatch.StartNew();

        while (!condition())
        {
            if (stopwatch.Elapsed > timeout)
            {
                return false;
            }

            await Task.Delay(25);
        }

        return true;
    }

    /// <summary>
    /// Waits until <paramref name="count"/> reaches <paramref name="minimum"/> and has stopped changing.
    /// </summary>
    /// <remarks>
    /// The project explorer's file list is filled by WatcherService, which drains its own queue on a
    /// background thread and marshals every add back onto the dispatcher. An awaited extract/convert
    /// call returning therefore says nothing about what the list holds, and a single dispatcher pump
    /// only drains whatever happens to be queued at that instant. Settling is what "the operation is
    /// fully visible in the tree" actually means here.
    /// </remarks>
    /// <returns>True if the count settled at or above the minimum before the timeout.</returns>
    public static Task<bool> UntilCountSettlesAsync(Func<int> count, int minimum, TimeSpan timeout)
    {
        // 8 polls * 25ms = 200ms of quiet, twice the watcher's 100ms drain interval.
        const int requiredStableReads = 8;

        var stableReads = 0;
        var previous = -1;

        return UntilAsync(
            () =>
            {
                var current = count();
                stableReads = current == previous ? stableReads + 1 : 0;
                previous = current;

                return current >= minimum && stableReads >= requiredStableReads;
            },
            timeout);
    }
}
