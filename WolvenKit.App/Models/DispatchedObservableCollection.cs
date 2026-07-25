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

    public new void Remove(T item) => DispatcherHelper.RunOnMainThread(() =>
    {
        try
        {
            base.Remove(item);
        }
        catch (Exception e)
        {
            try
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
            catch
            {
                if (item is FileSystemModel model)
                {
                    Locator.Current.GetService<ILoggerService>()
                        ?.Error($"Error when removing model for file: {model.FullName}: \n {e.Message}");
                    return;
                }
            }

            if (item is FileSystemModel fileModel)
            {
                Locator.Current.GetService<ILoggerService>()
                    ?.Error($"Error when removing model for file: {fileModel.FullName}: \n {e.Message}");
                return;
            }

            Locator.Current.GetService<ILoggerService>()?.Error($"Error when removing model: \n {e.Message}");
        }
    });

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
