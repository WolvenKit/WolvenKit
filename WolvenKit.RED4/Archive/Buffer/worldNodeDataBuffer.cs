using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class worldNodeDataBuffer : CArray<worldCompiledNodeInstanceSetupInfo>, IParseableBuffer, IRedType
{
    public IRedType? Data => null;

    public Dictionary<int, List<worldCompiledNodeInstanceSetupInfo>> Lookup = new();

    public worldNodeDataBuffer()
    {

    }
}

public class RedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IRedType where TKey : notnull
{

}