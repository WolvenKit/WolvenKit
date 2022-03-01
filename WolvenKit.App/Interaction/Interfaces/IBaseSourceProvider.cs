namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IBaseSourceProvider<T> : ISynchronized
    {
        void OnReset(int count);
    }
}