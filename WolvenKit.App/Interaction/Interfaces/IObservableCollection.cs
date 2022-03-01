using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IObservableCollection<T> : INotifyCollectionChanged, ICollection<T>, IObservableCollection
    {
        new int Count { get; }
        new bool Remove(object item);
    }

    public interface IObservableCollection : ICollection, INotifyCollectionChanged
    {
        void Add(object item);
        void Clear();
        bool Remove(object item);
    }
}