namespace WolvenKit.RED4.Types
{
    public interface IRedImport
    {
        public CName DepotPath { get; }
        public InternalEnums.EImportFlags Flags { get; }
    }
}
