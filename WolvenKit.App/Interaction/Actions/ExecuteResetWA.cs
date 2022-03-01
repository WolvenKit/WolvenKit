using System;
using System.Collections.Specialized;

namespace AlphaChiTech.Virtualization.Actions
{
    public class ExecuteResetWA<T> : BaseActionVirtualization where T : class
    {
        readonly WeakReference _voc;

        public ExecuteResetWA(VirtualizingObservableCollection<T> voc)
            : base(VirtualActionThreadModelEnum.UseUIThread)
        {
            this._voc = new WeakReference(voc);
        }

        public override void DoAction()
        {
            var voc = (VirtualizingObservableCollection<T>) this._voc.Target;

            if (voc != null && this._voc.IsAlive)
            {
                voc.RaiseCollectionChangedEvent(
                    new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }
    }
}