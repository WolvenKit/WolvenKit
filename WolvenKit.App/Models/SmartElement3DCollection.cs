using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using HelixToolkit.Wpf.SharpDX;

namespace WolvenKit.App.Models;

public class SmartElement3DCollection : ObservableElement3DCollection
{
    public SmartElement3DCollection() : base()
    {
    }

    public void AddRange(IEnumerable<Element3D> range)
    {
        foreach (var item in range)
        {
            Items.Add(item);
        }

        OnPropertyChanged(new PropertyChangedEventArgs("Count"));
        OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
        OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
    }

    public void Reset(IEnumerable<Element3D> range)
    {
        Items.Clear();

        AddRange(range);
    }
}
