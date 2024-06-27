using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace WolvenKit.App.Services;

public class AppIdleStateService
{
    private readonly DispatcherTimer _timerTenSeconds;
    private readonly DispatcherTimer _timerThirtySeconds;
    private readonly DispatcherTimer _timerOneMinute;
    private readonly DispatcherTimer _timerFiveMinutes;


    public AppIdleStateService()
    {
        InputManager.Current.PreProcessInput += OnActivity;

        _timerTenSeconds = new DispatcherTimer(
            TimeSpan.FromSeconds(10),
            DispatcherPriority.ApplicationIdle,
            (s, e) => ThreadIdleTenSeconds?.Invoke(this, e),
            Application.Current.Dispatcher
        );

        _timerThirtySeconds = new DispatcherTimer(
            TimeSpan.FromSeconds(30),
            DispatcherPriority.ApplicationIdle,
            (s, e) => ThreadIdleThirtySeconds?.Invoke(this, e),
            Application.Current.Dispatcher
        );

        _timerOneMinute = new DispatcherTimer(
            TimeSpan.FromMinutes(1),
            DispatcherPriority.ApplicationIdle,
            (s, e) => ThreadIdleOneMinute?.Invoke(this, e),
            Application.Current.Dispatcher
        );

        _timerFiveMinutes = new DispatcherTimer(
            TimeSpan.FromMinutes(5),
            DispatcherPriority.ApplicationIdle,
            (s, e) => ThreadIdleFiveMinutes?.Invoke(this, e),
            Application.Current.Dispatcher
        );

        StartTimers();
    }

    private void StartTimers()
    {
        _timerTenSeconds.Start();
        _timerThirtySeconds.Start();
        _timerOneMinute.Start();
        _timerFiveMinutes.Start();
    }

    private void StopTimers()
    {
        _timerTenSeconds.Stop();
        _timerThirtySeconds.Stop();
        _timerOneMinute.Stop();
        _timerFiveMinutes.Stop();
    }

    private void OnActivity(object sender, PreProcessInputEventArgs e)
    {
        if (e.StagingItem?.Input is not MouseEventArgs or KeyboardEventArgs)
        {
            return;
        }

        StopTimers();
        StartTimers();
    }

    /// <summary>
    /// Will fire if the application is idle for ten consecutive seconds
    /// </summary>
    public event EventHandler? ThreadIdleTenSeconds;

    /// <summary>
    /// Will fire if the application is idle for thirty consecutive seconds
    /// </summary>
    public event EventHandler? ThreadIdleThirtySeconds;

    /// <summary>
    /// Will fire if the application is idle for one consecutive minute
    /// </summary>
    public event EventHandler? ThreadIdleOneMinute;
    
    /// <summary>
    /// Will fire if the application is idle for five consecutive minutes
    /// </summary>
    public event EventHandler? ThreadIdleFiveMinutes;

}