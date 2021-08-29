namespace WolvenKit.RED4.Types
{
    [RED("serializationDeferredDataBuffer")]
    public class SerializationDeferredDataBuffer : IRedPrimitive
    {
        public CUInt16 Buffer { get; set; }
    }
}
