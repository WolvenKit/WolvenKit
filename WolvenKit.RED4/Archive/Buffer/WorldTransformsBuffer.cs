using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class WorldTransformsBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldNodeTransform> Transforms { get; set; } = new();
}