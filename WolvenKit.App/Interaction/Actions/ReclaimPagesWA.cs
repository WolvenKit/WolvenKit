using System;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Actions
{
    public class ReclaimPagesWA : BaseRepeatableActionVirtualization
    {
        readonly string _sectionContext = "";

        readonly WeakReference _wrProvider;

        public ReclaimPagesWA(IReclaimableService provider, string sectionContext)
            : base(VirtualActionThreadModelEnum.Background, true, TimeSpan.FromMinutes(1))
        {
            this._wrProvider = new WeakReference(provider);
        }

        public override void DoAction()
        {
            this.LastRun = DateTime.Now;

            var reclaimer = this._wrProvider.Target as IReclaimableService;

            if (reclaimer != null)
            {
                reclaimer.RunClaim(this._sectionContext);
            }
        }

        public override bool KeepInActionsList()
        {
            var ret = base.KeepInActionsList();

            if (!this._wrProvider.IsAlive) ret = false;

            return ret;
        }
    }
}