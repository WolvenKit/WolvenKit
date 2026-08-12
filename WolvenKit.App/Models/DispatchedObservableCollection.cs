#nullable enable

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers;

namespace WolvenKit.App.Models;

public class DispatchedObservableCollection<T> : ObservableCollectionEx<T> where T : FileSystemModel
{
    private sealed record Batch
    {
        public ConcurrentQueue<T> ToAdd = [];
        public ConcurrentQueue<T> ToRemove = [];

        public void Add(T item) => ToAdd.Enqueue(item);
        public void Remove(T item) => ToRemove.Enqueue(item);

        public void Clear()
        {
            ToAdd = [];
            ToRemove = [];
        }
    }

    private readonly Batch _batch = new();

    public new bool SuppressNotification
    {
        get => base.SuppressNotification;
        set => DispatcherHelper.RunOnMainThread(() =>
        {
            if (base.SuppressNotification && !value)
            {
                while (_batch.ToAdd.TryDequeue(out var item)) { base.Add(item); }
                while (_batch.ToRemove.TryDequeue(out var item)) { base.Remove(item); }
            }
            base.SuppressNotification = value;
        });
    }

    public new void Add(T item)
    {
        switch (this.SuppressNotification)
        {
            case false:
                DispatcherHelper.RunOnMainThread(() => base.Add(item));
                break;

            case true:
                _batch.Add(item);
                break;
        }
    }

    public new void Remove(T item)
    {
        switch (this.SuppressNotification)
        {
            case false:
                DispatcherHelper.RunOnMainThread(() => base.Remove(item));
                break;

            case true:
                _batch.Remove(item);
                break;
        }
    }

    public new void Clear() => DispatcherHelper.RunOnMainThread(() =>
    {
        _batch.Clear();
        base.Clear();
    });

    public void AddRange(IEnumerable<T> items)
    {
        SuppressNotification = true;
        foreach (var item in items)
        {
            Add(item);
        }
        SuppressNotification = false;
    }
}
