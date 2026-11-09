namespace WolvenKit.RED4.Types.Legacy.V2310;

public class WorldTransformsBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldNodeTransform> Transforms { get; set; } = new();
}
