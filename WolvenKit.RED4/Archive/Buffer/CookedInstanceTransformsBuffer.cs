using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class CookedInstanceTransformsBuffer : IParseableBuffer
{
    public IRedType Data => Transforms;

    public CArray<Transform> Transforms { get; set; } = new();

    public CookedInstanceTransformsBuffer()
    {

    }
}