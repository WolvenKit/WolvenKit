using System;
using System.Windows;

namespace WolvenKit.App.ViewModels.Events;

public class ValueChangedEventArgs(RoutedEvent routedEvent, string oldValue, string newValue) : RoutedEventArgs(routedEvent)
{
    public string OldValue { get; } = oldValue;
    public string NewValue { get; } = newValue;
    public Type? RedType { get; set; }
}