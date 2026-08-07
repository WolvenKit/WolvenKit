using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WolvenKit.App.Helpers;

//Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
public static class DispatcherHelper
{
    private static readonly Dictionary<string, RepeatingActionState> s_repeatingActions =
        new(StringComparer.Ordinal);

    private static readonly object s_repeatingActionsLock = new();

    public static void RunOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        // If in a unit test there is no current application, so use the current dispatcher.
        if (TestHelper.InActiveTest)
        {
            Task.Run(action);
            return;
        }

        Application.Current.RunOnUIThread(action, priority);
    }

    private static void RunOnUIThread(this DispatcherObject? d, Action action,
        DispatcherPriority priority = DispatcherPriority.Normal)
    {
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
        var dispatcher = Dispatcher.CurrentDispatcher; // or Application.Current.Dispatcher

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

    #region repeating actions

    /// <summary>
    /// Runs <paramref name="action"/> every <paramref name="interval"/> until every handle
    /// returned for this purpose has been disposed.
    ///
    /// Acquisitions are reference counted: starting a purpose that is already running joins the
    /// existing timer instead of throwing, and returns an independent handle. This lets several
    /// owners (for example the transient RED4Controller instances that each drive the archive
    /// loading indicator) share one heartbeat without one of them tearing it down while another
    /// still needs it. <paramref name="action"/>, <paramref name="interval"/> and
    /// <paramref name="onCancelled"/> are therefore only honoured for the FIRST acquirer — use a
    /// purpose that is unique per owner when the work is instance-specific.
    ///
    /// <paramref name="onCancelled"/> runs once, when the last handle is released.
    /// </summary>
    public static RepeatingActionHandle StartRepeatingAction(
        string purpose,
        Action action,
        TimeSpan interval,
        Action? onCancelled = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(purpose);
        ArgumentNullException.ThrowIfNull(action);

        lock (s_repeatingActionsLock)
        {
            if (s_repeatingActions.TryGetValue(purpose, out var existing))
            {
                existing.RefCount++;
                return new RepeatingActionHandle(purpose);
            }

            // Bind to the application dispatcher rather than whatever thread happens to call in.
            // A DispatcherTimer created on a pool thread would attach to a dispatcher that never
            // runs, and would silently never tick.
            var dispatcher = Application.Current?.Dispatcher ?? Dispatcher.CurrentDispatcher;
            var timer = new DispatcherTimer(DispatcherPriority.Normal, dispatcher) { Interval = interval };
            timer.Tick += (_, _) => action();

            s_repeatingActions[purpose] = new RepeatingActionState
            {
                Timer = timer,
                OnCancelled = onCancelled,
                RefCount = 1
            };

            timer.Start();
            return new RepeatingActionHandle(purpose);
        }
    }

    /// <summary>
    /// Releases a handle if it is non-null. Convenience for the common
    /// "stop it if we started it" call site.
    /// </summary>
    public static void StopRepeatingAction(RepeatingActionHandle? handle) => handle?.Dispose();

    /// <summary>
    /// Returns true if a repeating action with the given purpose is currently running.
    /// </summary>
    public static bool IsRepeatingActionRunning(string purpose)
    {
        if (string.IsNullOrEmpty(purpose))
        {
            return false;
        }

        lock (s_repeatingActionsLock)
        {
            return s_repeatingActions.ContainsKey(purpose);
        }
    }

    /// <summary>
    /// Number of live handles currently sharing the given purpose (0 if not running).
    /// Intended for diagnostics and tests.
    /// </summary>
    public static int GetRepeatingActionRefCount(string purpose)
    {
        if (string.IsNullOrEmpty(purpose))
        {
            return 0;
        }

        lock (s_repeatingActionsLock)
        {
            return s_repeatingActions.TryGetValue(purpose, out var state) ? state.RefCount : 0;
        }
    }

    /// <summary>
    /// Releases one claim on a purpose, stopping the timer when the last claim goes away.
    /// </summary>
    private static void ReleaseRepeatingAction(string purpose)
    {
        Action? onCancelled = null;

        lock (s_repeatingActionsLock)
        {
            if (!s_repeatingActions.TryGetValue(purpose, out var state))
            {
                return;
            }

            state.RefCount--;
            if (state.RefCount > 0)
            {
                return;
            }

            s_repeatingActions.Remove(purpose);
            state.Timer.Stop();
            onCancelled = state.OnCancelled;
        }

        // Invoked outside the lock: callbacks touch view models and the progress service, and
        // must not be able to re-enter the registry while it is held.
        onCancelled?.Invoke();
    }

    private sealed class RepeatingActionState
    {
        public required DispatcherTimer Timer { get; init; }
        public required Action? OnCancelled { get; init; }

        /// <summary>Number of live handles sharing this timer.</summary>
        public int RefCount { get; set; }
    }

    /// <summary>
    /// A live registration of a repeating action. Dispose to release this holder's claim;
    /// the underlying timer stops once every holder has released it.
    /// Disposal is idempotent and thread-safe.
    /// </summary>
    public sealed class RepeatingActionHandle : IDisposable
    {
        private int _released;

        internal RepeatingActionHandle(string purpose) => Purpose = purpose;

        public string Purpose { get; }

        /// <summary>True until this handle is disposed. Does not imply the timer is still running.</summary>
        public bool IsActive => Volatile.Read(ref _released) == 0;

        public void Dispose()
        {
            if (Interlocked.Exchange(ref _released, 1) != 0)
            {
                return;
            }

            ReleaseRepeatingAction(Purpose);
        }
    }

    #endregion repeating actions
}
