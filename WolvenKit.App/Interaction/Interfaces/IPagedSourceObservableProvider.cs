using System.Collections.Specialized;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IPagedSourceObservableProvider<T> : IPagedSourceProvider<T>, INotifyCollectionChanged,
        IEditableProvider<T>
    {
    }
}