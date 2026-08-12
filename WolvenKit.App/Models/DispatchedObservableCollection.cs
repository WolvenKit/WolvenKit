using System.Collections.ObjectModel;
using WolvenKit.App.Helpers;

namespace WolvenKit.App.Models;

public class DispatchedObservableCollection<T> : ObservableCollection<T>
{
    public new void Add(T item) => DispatcherHelper.RunOnMainThread(() => base.Add(item));
    public new void Remove(T item) => DispatcherHelper.RunOnMainThread(() => base.Remove(item));
    public new void Clear() => DispatcherHelper.RunOnMainThread(() => base.Clear());
}