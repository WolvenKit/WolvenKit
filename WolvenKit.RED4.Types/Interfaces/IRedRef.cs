namespace WolvenKit.RED4.Types
{
    public interface IRedRef : IRedType
    {
        public string DepotPath { get; set; }

        public InternalEnums.EImportFlags Flags { get; set; }

        public uint GetPersistentHash();
    }
}
