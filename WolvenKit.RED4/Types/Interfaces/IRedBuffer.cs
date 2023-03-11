namespace WolvenKit.RED4.Types;

public interface IRedBufferWrapper
{
    public RedBuffer Buffer { get; set; }
    public IParseableBuffer? Data { get; set; }
}