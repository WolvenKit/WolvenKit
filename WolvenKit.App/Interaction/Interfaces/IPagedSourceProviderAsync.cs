using System.Threading.Tasks;
using AlphaChiTech.Virtualization.Pageing;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IPagedSourceProviderAsync<T> : IPagedSourceProvider<T>
    {
        Task<bool> ContainsAsync(T item);

        Task<int> GetCountAsync();
        Task<PagedSourceItemsPacket<T>> GetItemsAtAsync(int pageoffset, int count, bool usePlaceholder);

        T GetPlaceHolder(int index, int page, int offset);

        Task<int> IndexOfAsync(T item);
    }
}