using System;

namespace AlphaChiTech.Virtualization.Actions
{
    public class PlaceholderReplaceWA<T> : BaseActionVirtualization where T : class
    {
        private readonly int _index;
        private readonly T _newValue;
        private readonly T _oldValue;

        readonly WeakReference _voc;

        public PlaceholderReplaceWA(VirtualizingObservableCollection<T> voc, T oldValue, T newValue, int index)
            : base(VirtualActionThreadModelEnum.UseUIThread)
        {
            this._voc = new WeakReference(voc);
            this._oldValue = oldValue;
            this._newValue = newValue;
            this._index = index;
        }

        public override void DoAction()
        {
            var voc = (VirtualizingObservableCollection<T>) this._voc.Target;

            if (voc != null && this._voc.IsAlive)
            {
                voc.ReplaceAt(this._index, this._oldValue, this._newValue, null);
            }
        }
    }
}