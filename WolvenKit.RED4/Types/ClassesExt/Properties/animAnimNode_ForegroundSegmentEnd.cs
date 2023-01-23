namespace WolvenKit.RED4.Types;

public partial class animAnimNode_ForegroundSegmentEnd
{
    [Ordinal(991)]
    [RED("segmentBeginNodeId")]
    public CUInt32 SegmentBeginNodeId
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(992)]
    [RED("isPairedWithSelf")]
    public CBool IsPairedWithSelf
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}