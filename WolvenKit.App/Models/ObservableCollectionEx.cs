using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace WolvenKit.App.Models;

public class ObservableCollectionEx<T> : ObservableCollection<T>
{
    private bool _notificationSuppressed;
    private bool _suppressNotification;

    public bool SuppressNotification
    {
        get => _suppressNotification;
        set
        {
            _suppressNotification = value;
            if (_suppressNotification == false && _notificationSuppressed)
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                _notificationSuppressed = false;
            }
        }
    }

    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    {
        if (SuppressNotification)
        {
            _notificationSuppressed = true;
            return;
        }
        base.OnCollectionChanged(e);
    }
}
