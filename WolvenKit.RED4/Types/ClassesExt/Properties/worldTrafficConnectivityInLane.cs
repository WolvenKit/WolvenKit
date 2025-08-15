namespace WolvenKit.RED4.Types;

public partial class worldTrafficConnectivityInLane
{
    [RED("laneIndex")]
    public CUInt16 LaneIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }
}