namespace AlphaChiTech.VirtualizingCollection.Interfaces
{
    public interface IRepeatingVirtualizationAction
    {
        bool IsDueToRun();
        bool KeepInActionsList();
    }
}