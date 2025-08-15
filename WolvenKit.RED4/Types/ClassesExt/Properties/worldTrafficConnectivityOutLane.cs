namespace WolvenKit.RED4.Types;

public partial class worldTrafficConnectivityOutLane
{
    [RED("laneIndex")]
    public CUInt16 LaneIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("exitProbabilityCompressed")]
    public CUInt8 ExitProbabilityCompressed
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("isSharpAngle")]
    public CBool IsSharpAngle
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("thisLaneExitPosition")]
    public CFloat ThisLaneExitPosition
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("nextLaneEntryPosition")]
    public CFloat NextLaneEntryPosition
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}