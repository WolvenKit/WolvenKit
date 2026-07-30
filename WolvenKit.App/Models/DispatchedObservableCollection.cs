using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using DynamicData;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Models;

public class DispatchedObservableCollection<T> : ObservableCollection<T>
{
    public new void Add(T item) => DispatcherHelper.RunOnMainThread(() => base.Add(item));

    public new void Remove(T item) => DispatcherHelper.RunOnMainThread(() => base.Remove(item));

    public new void Clear() => DispatcherHelper.RunOnMainThread(() => base.Clear());

    public void AddRange(IEnumerable<T> items)
    {
        var itemsList = items as IList<T> ?? items.ToList();

        if (itemsList.Count == 0)
        {
            return;
        }

        DispatcherHelper.RunOnMainThread(() =>
        {
            Items.AddRange(itemsList);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        });
    }
}
