namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IEditableProvider<in T>
    {
        int OnAppend(T item, object timestamp);
        void OnInsert(int index, T item, object timestamp);
        void OnReplace(int index, T oldItem, T newItem, object timestamp);
    }
}