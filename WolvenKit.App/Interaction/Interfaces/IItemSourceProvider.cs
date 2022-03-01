namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IItemSourceProvider<T> : IBaseSourceProvider<T>
    {
        bool Contains(T item);
        T GetAt(int index, object voc, bool usePlaceholder);
        int GetCount(bool asyncOk);

        int IndexOf(T item);
    }
}