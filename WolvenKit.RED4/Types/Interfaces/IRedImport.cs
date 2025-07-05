namespace WolvenKit.RED4.Types;

public interface IRedImport
{
    public ResourcePath DepotPath { get; }
    public InternalEnums.EImportFlags Flags { get; }
}