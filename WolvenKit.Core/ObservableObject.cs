using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WolvenKit.Core;

public class ObservableObject : INotifyPropertyChanging, INotifyPropertyChanged
{
    public event PropertyChangingEventHandler? PropertyChanging;
    public event PropertyChangedEventHandler? PropertyChanged;

    protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, newValue))
        {
            return false;
        }

        PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

        field = newValue;

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        return true;
    }
}