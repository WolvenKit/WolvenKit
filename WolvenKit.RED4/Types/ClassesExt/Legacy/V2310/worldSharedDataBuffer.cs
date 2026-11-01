namespace WolvenKit.RED4.Types.Legacy.V2310;

public class worldSharedDataBuffer : ISerializable
{
    [Ordinal(0)]
    [RED("buffer")]
    public DataBuffer Buffer
    {
        get => GetPropertyValue<DataBuffer>();
        set => SetPropertyValue<DataBuffer>(value);
    }
}
