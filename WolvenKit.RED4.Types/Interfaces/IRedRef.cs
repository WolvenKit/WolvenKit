namespace WolvenKit.RED4.Types
{
    public interface IRedRef : IRedType
    {
        public CName DepotPath { get; set; }

        public InternalEnums.EImportFlags Flags { get; set; }

        public uint GetPersistentHash();
    }
}
