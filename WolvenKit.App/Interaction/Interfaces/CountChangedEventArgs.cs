using System;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public class CountChangedEventArgs : EventArgs
    {
        public int Count { get; set; }
        public bool NeedsReset { get; set; }
    }
}