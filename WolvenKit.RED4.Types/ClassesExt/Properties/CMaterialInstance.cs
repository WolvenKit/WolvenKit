namespace WolvenKit.RED4.Types;

public partial class CMaterialInstance
{
    [OrdinalOverride(After = 0)]
    [RED("metadata")]
    public SerializationDeferredDataBuffer Metadata
    {
        get => GetPropertyValue<SerializationDeferredDataBuffer>();
        set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
    }
}
