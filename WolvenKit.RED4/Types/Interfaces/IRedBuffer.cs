namespace WolvenKit.RED4.Types;

public interface IRedBuffer
{
    public uint Flags { get; }
    public uint MemSize { get; }

    public IParseableBuffer Data { get; set; }
}

public interface IRedBufferWrapper
{
    public RedBuffer Buffer { get; }
}