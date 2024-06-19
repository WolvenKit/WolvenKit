using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Interop;

namespace WolvenKit.App.Services;

public class AppIdleStateService
{
    private readonly Subject<EventArgs> _eventSubject5Seconds = new();
    private readonly Subject<EventArgs> _eventSubject30Seconds = new();
    private readonly Subject<EventArgs> _eventSubjectFiveMinutes = new();

    public AppIdleStateService()
    {
        _eventSubject30Seconds.Throttle(TimeSpan.FromSeconds(30)).Subscribe(e => ThreadIdleThirtySeconds?.Invoke(this, e));
        _eventSubject5Seconds.Throttle(TimeSpan.FromMinutes(1)).Subscribe(e => ThreadIdleOneMinute?.Invoke(this, e));
        _eventSubjectFiveMinutes.Throttle(TimeSpan.FromMinutes(5)).Subscribe(e => ThreadIdleFiveMinutes?.Invoke(this, e));

        ComponentDispatcher.ThreadIdle += ComponentDispatcher_ThreadIdle_5Seconds;
    }

    /// <summary>
    /// Debounced to fire only every five seconds
    /// </summary>
    public event EventHandler? ThreadIdleOneMinute;

    /// <summary>
    /// Debounced to fire only every five seconds
    /// </summary>
    public event EventHandler? ThreadIdleThirtySeconds;

    /// <summary>
    /// Debounced to fire only every five minutes
    /// </summary>
    public event EventHandler? ThreadIdleFiveMinutes;


    private void ComponentDispatcher_ThreadIdle_5Seconds(object? sender, EventArgs e) => _eventSubject5Seconds.OnNext(e);
}