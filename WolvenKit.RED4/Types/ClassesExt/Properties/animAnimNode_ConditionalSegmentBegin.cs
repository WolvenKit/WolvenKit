namespace WolvenKit.RED4.Types;

public partial class animAnimNode_ConditionalSegmentBegin
{
    [Ordinal(12)]
    [RED("segmentEndNodeId")]
    public CUInt32 SegmentEndNodeId
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }
}