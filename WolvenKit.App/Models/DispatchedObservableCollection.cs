using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Threading;
using WolvenKit.App.Helpers;

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
            foreach (var item in itemsList)
            {
                Items.Add(item);
            }

            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }, DispatcherPriority.Background);
    }

    public void ReplaceAll(IEnumerable<T> items)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            Items.Clear();
            AddRange(items);
        }, DispatcherPriority.Background);
    }
}
