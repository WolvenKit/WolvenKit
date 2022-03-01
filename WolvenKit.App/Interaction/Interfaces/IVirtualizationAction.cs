using AlphaChiTech.Virtualization.Actions;

namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IVirtualizationAction
    {
        VirtualActionThreadModelEnum ThreadModel { get; }

        void DoAction();
    }
}