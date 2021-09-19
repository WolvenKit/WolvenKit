namespace WolvenKit.RED4.Types
{
    public interface IRedImport
    {
        public string DepotPath { get; }
        public InternalEnums.EImportFlags Flags { get; }
    }
}
