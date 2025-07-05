namespace WolvenKit.RED4.Types;

public partial class animAnimNode_ForegroundSegmentBegin
{
    [Ordinal(991)]
    [RED("segmentEndNodeId")]
    public CUInt32 SegmentEndNodeId
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }
}