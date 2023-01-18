namespace WolvenKit.RED4.Types;

public interface IRedRef : IRedType
{
    public CName DepotPath { get; }
    public InternalEnums.EImportFlags Flags { get; }
    public bool IsSet { get; }
    public uint GetPersistentHash();
}