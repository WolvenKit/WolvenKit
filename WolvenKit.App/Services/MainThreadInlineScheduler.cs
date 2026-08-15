using System;
using System.Reactive.Concurrency;
using System.Windows.Threading;

namespace WolvenKit.App.Services;

/// <summary>
/// An <see cref="IScheduler"/> that runs work <b>inline</b> (synchronously) when the caller is already on
/// the WPF UI thread, and otherwise defers to a <paramref name="fallback"/> scheduler (normally
/// <c>RxApp.MainThreadScheduler</c>, which posts onto the dispatcher).
///
/// <para>
/// Why this exists: <c>ObserveOn(RxApp.MainThreadScheduler)</c> ALWAYS re-posts each notification to a
/// later dispatcher turn — even for a publisher that is already on the UI thread. For the project-event
/// pipeline that means a UI-thread flow which publishes and then <i>immediately</i> releases a Syncfusion
/// deferred-refresh (e.g. renaming a file) can redraw the grid from domain models the ProjectExplorerViewModel
/// handler hasn't updated yet — a race. Delivering inline when we're on the UI thread closes it: by the
/// time <c>PublishXxx(...)</c> returns, the handler has already applied the change to FileList/FileTree,
/// so the subsequent refresh reflects reality.
/// </para>
///
/// <para>
/// Off-thread publishers (scripts, background imports/exports) are unaffected: they aren't on the UI
/// thread, so they take the fallback (posting) path exactly as before, and any flow that waits on those
/// still needs its own dispatcher pump.
/// </para>
/// </summary>
public sealed class MainThreadInlineScheduler : IScheduler
{
    private readonly IScheduler _fallback;
    private readonly Dispatcher _uiDispatcher;

    /// <param name="fallback">Scheduler used when the caller is not on the UI thread (e.g. RxApp.MainThreadScheduler).</param>
    /// <param name="uiDispatcher">The UI-thread dispatcher; <see cref="Dispatcher.CheckAccess"/> decides "are we on it?".</param>
    public MainThreadInlineScheduler(IScheduler fallback, Dispatcher uiDispatcher)
    {
        _fallback = fallback ?? throw new ArgumentNullException(nameof(fallback));
        _uiDispatcher = uiDispatcher ?? throw new ArgumentNullException(nameof(uiDispatcher));
    }

    public DateTimeOffset Now => _fallback.Now;

    public IDisposable Schedule<TState>(TState state, Func<IScheduler, TState, IDisposable> action)
        => _uiDispatcher.CheckAccess() ? action(this, state) : _fallback.Schedule(state, action);

    /// <summary>
    /// If the <param name="action"/> is supposed to happen immediately,
    /// AND we're already on the UI thread, execute it directly.
    ///
    /// Otherwise, schedule it through <see cref="_fallback"/> scheduler.
    /// </summary>
    /// <param name="state"></param>
    /// <param name="dueTime"></param>
    /// <param name="action"></param>
    /// <typeparam name="TState"></typeparam>
    /// <returns>an <see cref="IDisposable" />s
    /// </returns>
    public IDisposable Schedule<TState>(TState state, TimeSpan dueTime, Func<IScheduler, TState, IDisposable> action)
        => Scheduler.Normalize(dueTime) == TimeSpan.Zero && _uiDispatcher.CheckAccess()
            ? action(this, state)
            : _fallback.Schedule(state, dueTime, action);

    public IDisposable Schedule<TState>(TState state, DateTimeOffset dueTime, Func<IScheduler, TState, IDisposable> action)
        => _fallback.Schedule(state, dueTime, action);
}
