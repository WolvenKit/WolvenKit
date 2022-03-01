using System.Collections.Generic;
using AlphaChiTech.Virtualization.Pageing;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface ISourcePage<T>
    {
        bool CanReclaimPage { get; }

        int ItemsCount { get; }

        int ItemsPerPage { get; set; }

        object LastTouch { get; set; }
        int Page { get; set; }

        PageFetchStateEnum PageFetchState { get; set; }

        List<SourcePagePendingUpdates> PendingUpdates { get; }

        object WiredDateTime { get; set; }

        int Append(T item, object updatedAt, IPageExpiryComparer comparer);

        T GetAt(int offset);

        int IndexOf(T item);

        void InsertAt(int offset, T item, object updatedAt, IPageExpiryComparer comparer);

        bool RemoveAt(int offset, object updatedAt, IPageExpiryComparer comparer);

        T ReplaceAt(int offset, T newValue, object updatedAt, IPageExpiryComparer comparer);

        T ReplaceAt(T oldValue, T newValue, object updatedAt, IPageExpiryComparer comparer);

        bool ReplaceNeeded(int offset);
    }
}