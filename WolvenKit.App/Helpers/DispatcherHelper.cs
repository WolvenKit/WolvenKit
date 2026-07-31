using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.App.Helpers;

//Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
public static class DispatcherHelper
{
    public static void RunOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal) => Application.Current.RunOnUIThread(action, priority);

    public static async Task RunOnMainThreadAsync(Func<Task> action, DispatcherPriority priority = DispatcherPriority.Normal) => await Application.Current.RunOnUIThreadAsync(action, priority);

    /// <summary>
    /// Queues the action to a fresh dispatcher frame, even when already on the UI thread
    /// (unlike "RunOnMainThread", which runs inline in that case). Use when the
    /// action must not run inside the currently executing event handler's stack.
    /// </summary>
    public static void PostOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        if (Application.Current is not { Dispatcher: { } dispatcher })
        {
            // Headless / unit-test context: run synchronously, matching the other helpers.
            action();
            return;
        }

        dispatcher.BeginInvoke(action, priority);
    }

    private static async Task RunOnUIThreadAsync(this DispatcherObject? d, Func<Task> action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        // In a unit test / headless context there is no WPF Application and no Dispatcher.
        // Run the action synchronously so code paths that rely on DispatcherHelper
        // (DispatchedObservableCollection, etc.) continue to work.
        if (d == null && Application.Current == null)
        {
            await action();
            return;
        }

        if (d is not { Dispatcher: { } dispatcher })
        {
            return;
        }

        if (dispatcher.CheckAccess())
        {
            await action();
        }
        else
        {
            try
            {
                await dispatcher.InvokeAsync(action, priority);
            }
            catch (Exception)
            {
                // TODO: Add logger here?
                throw;
            }
        }
    }

    private static void RunOnUIThread(this DispatcherObject? d, Action action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        // In a unit test / headless context there is no WPF Application and no Dispatcher.
        // Run the action synchronously so code paths that rely on DispatcherHelper
        // (DispatchedObservableCollection, etc.) continue to work.
        if (d == null && Application.Current == null)
        {
            action();
            return;
        }

        if (d is not { Dispatcher: { } dispatcher })
        {
            return;
        }

        if (dispatcher.CheckAccess())
        {
            action();
        }
        else
        {
            try
            {
                dispatcher.InvokeAsync(action, priority);
            }
            catch (Exception)
            {
                // TODO: Add logger here?
                throw;
            }
        }
    }

    /// <summary>
    /// Runs `action` on the main thread after specified delay, without blocking.
    /// </summary>
    /// <param name="action"></param>
    /// <param name="millisecondsDelay"></param>
    public static void DelayOnMainThread(Action action, int millisecondsDelay)
    {
        Task.Delay(millisecondsDelay)
            .ContinueWith(_ => RunOnMainThread(action), TaskScheduler.Default);
    }

    public static void WaitUntilCancelled(CancellationToken token, Action onCancelled)
    {
        if (token.IsCancellationRequested)
        {
            onCancelled?.Invoke();
            return;
        }

        // Use a low-priority dispatcher operation that re-queues itself
        var dispatcher = Dispatcher.CurrentDispatcher;   // or Application.Current.Dispatcher

        void CheckCancellation()
        {
            if (token.IsCancellationRequested)
            {
                onCancelled?.Invoke();
            }
            else
            {
                // Re-queue itself with low priority so other UI work can run
                dispatcher.BeginInvoke(CheckCancellation, DispatcherPriority.Background);
            }
        }

        // Start the polling loop
        dispatcher.BeginInvoke(CheckCancellation, DispatcherPriority.Background);
    }

    private static readonly ConcurrentDictionary<Guid, RepeatingAction> s_dispatcherTimers = new();
    private static readonly ConcurrentDictionary<string, Guid> s_purposeToGuid = new();

    private sealed record RepeatingAction(
        string Purpose,
        DispatcherTimer Timer
    );

    /// <summary>
    /// Returns true if a repeating action with the given purpose is currently registered.
    /// </summary>
    public static bool IsRepeatingActionRunning(string purpose) =>
        !string.IsNullOrEmpty(purpose) && s_purposeToGuid.ContainsKey(purpose);

    /// <summary>
    /// Tries to get the guid of a running repeating action by purpose.
    /// </summary>
    public static bool TryGetRepeatingAction(string purpose, out Guid guid)
    {
        if (string.IsNullOrEmpty(purpose))
        {
            guid = Guid.Empty;
            return false;
        }

        return s_purposeToGuid.TryGetValue(purpose, out guid);
    }

    /// <summary>
    /// Repeats action every interval TimeSpan until the timer is
    /// stopped by passing the returned guid to StopRepeatingAction.
    ///
    /// Purpose names are unique: a second start with the same purpose throws
    /// unless the first was stopped. Registration of purpose is atomic.
    ///
    /// Returns a Guid to call StopRepeatingAction(guid) with, to stop it.
    /// </summary>
    public static Guid StartRepeatingAction(
        string purpose,
        Action action,
        TimeSpan interval,
        Action? onCancelled = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(purpose);
        ArgumentNullException.ThrowIfNull(action);
        var guid = Guid.NewGuid();

        if (!s_purposeToGuid.TryAdd(purpose, guid))
        {
            throw new WolvenKitException(0xBa57a2d, $"{purpose} is already running.");
        }

        DispatcherTimer timer = new()
        {
            Interval = interval,
            Tag = onCancelled
        };

        if (!s_dispatcherTimers.TryAdd(guid, new RepeatingAction(purpose, timer)))
        {
            s_purposeToGuid.TryRemove(purpose, out _);
            throw new WolvenKitException(0xBa57a2d, $"{purpose} is already running.");
        }

        timer.Tick += (_, _) => action();
        timer.Start();

        return guid;
    }

    /// <summary>
    /// Call with a guid to cancel a repeating action timer.
    /// </summary>
    public static void StopRepeatingAction(Guid guid)
    {
        if (guid == Guid.Empty)
        {
            return;
        }

        if (!s_dispatcherTimers.TryRemove(guid, out var record))
        {
            return;
        }

        s_purposeToGuid.TryRemove(record.Purpose, out _);

        var onCancelled = record.Timer.Tag as Action;
        record.Timer.Tag = null;
        record.Timer.Stop();
        onCancelled?.Invoke();
    }
}
