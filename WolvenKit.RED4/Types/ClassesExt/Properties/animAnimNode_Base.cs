namespace WolvenKit.RED4.Types;

public partial class animAnimNode_Base
{
    [Ordinal(1)]
    [RED("debugName")]
    public CName DebugName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(2)]
    [RED("visPrePose")]
    public CBool VisPrePose
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(3)]
    [RED("visPrePoseColor")]
    public CColor VisPrePoseColor
    {
        get => GetPropertyValue<CColor>();
        set => SetPropertyValue<CColor>(value);
    }

    [Ordinal(4)]
    [RED("visPostPose")]
    public CBool VisPostPose
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(5)]
    [RED("visPostPoseColor")]
    public CColor VisPostPoseColor
    {
        get => GetPropertyValue<CColor>();
        set => SetPropertyValue<CColor>(value);
    }

    [Ordinal(6)]
    [RED("visRigPartMask")]
    public CName VisRigPartMask
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(7)]
    [RED("visAxes")]
    public CBool VisAxes
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(8)]
    [RED("visNames")]
    public CBool VisNames
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(9)]
    [RED("visMask")]
    public CArray<animTransformIndex> VisMask
    {
        get => GetPropertyValue<CArray<animTransformIndex>>();
        set => SetPropertyValue<CArray<animTransformIndex>>(value);
    }

    [Ordinal(10)]
    [RED("poseInfoLogger")]
    public animPoseInfoLogger PoseInfoLogger
    {
        get => GetPropertyValue<animPoseInfoLogger>();
        set => SetPropertyValue<animPoseInfoLogger>(value);
    }

    [Ordinal(1000)]
    [RED("visWhenActive")]
    public CBool VisWhenActive
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    partial void PostConstruct()
    {
        VisPrePoseColor = new();
        VisPostPoseColor = new();
    }
}