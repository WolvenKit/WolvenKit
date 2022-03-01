using System.Collections.Specialized;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public class SourcePagePendingUpdates
    {
        public INotifyCollectionChanged Args { get; set; }
        public object UpdatedAt { get; set; }
    }
}