using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class worldNodeDataBuffer : CArray<ICompiledNodeInstanceSetupInfo>, IParseableBuffer, IRedType
{
    public IRedType? Data => null;

    public Dictionary<ulong, List<ICompiledNodeInstanceSetupInfo>> Lookup = new();

    public worldNodeDataBuffer()
    {

    }
}

public class RedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IRedType where TKey : notnull
{

}
