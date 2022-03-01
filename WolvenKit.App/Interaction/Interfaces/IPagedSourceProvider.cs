using AlphaChiTech.Virtualization.Pageing;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IPagedSourceProvider<T> : IBaseSourceProvider<T>
    {
        int Count { get; }
        bool Contains(T item);
        PagedSourceItemsPacket<T> GetItemsAt(int pageoffset, int count, bool usePlaceholder);

        int IndexOf(T item);
    }
}