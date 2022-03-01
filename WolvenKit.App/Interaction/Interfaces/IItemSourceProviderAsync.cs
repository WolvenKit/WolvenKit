using System.Threading.Tasks;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IItemSourceProviderAsync<T> : IBaseSourceProvider<T>
    {
        Task<int> Count { get; }
        Task<T> GetAt(int index, object voc, bool usePlaceholder);

        T GetPlaceHolder(int index);

        Task<int> IndexOf(T item);
    }
}