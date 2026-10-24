using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class WorldTransformsBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<RenderProxyTransform> Transforms { get; set; } = new();
}
