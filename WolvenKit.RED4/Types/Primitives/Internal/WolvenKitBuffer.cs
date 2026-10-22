namespace WolvenKit.RED4.Types;

public class WolvenKitBuffer : IRedBufferWrapper, IRedPrimitive
{
    public RedBuffer Buffer { get; set; }
    public IParseableBuffer? Data { get; set; }
}
