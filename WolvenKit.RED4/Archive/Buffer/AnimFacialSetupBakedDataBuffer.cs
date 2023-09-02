using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class AnimFacialSetupBakedDataBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<CUInt16> LipsyncOverridesIndexMapping { get; set; } = new();
    public CArray<CUInt8> JointRegions { get; set; } = new();
    public FacialSetup_BakedPartData Face { get; set; }
    public FacialSetup_BakedPartData Tongue { get; set; }
    public FacialSetup_BakedPartData Eyes { get; set; }
}

public class FacialSetup_BakedPartData : IRedClass
{
    public CArray<FacialTrackMapping> EnvelopesPerTrackMapping { get; set; } = new();
    public CArray<FacialPoseLimit> GlobalLimits { get; set; } = new();
    public CArray<FacialInfluencedPose> InfluencedPoses { get; set; } = new();
    public CArray<CUInt16> InfluenceIndices { get; set; } = new();
    public CArray<FacialParts> UpperLowerFace { get; set; } = new();
    public CArray<FacialPoseSides> LipsyncPosesSides { get; set; } = new();
    public CArray<FacialCorrectiveInfo> GlobalCorrectiveEntries { get; set; } = new();
    public CArray<FacialCorrectiveInfo> InbetweenCorrectiveEntries { get; set; } = new();
    public CArray<FacialCorrectiveInfluencedPose> CorrectiveInfluencedPoses { get; set; } = new();
    public CArray<CUInt16> CorrectiveInfluenceIndices { get; set; } = new();
    public CArray<FacialMainPoseInfo> AllMainPoses { get; set; } = new();
    public CArray<CFloat> AllMainPosesInbetweens { get; set; } = new();
    public CArray<CFloat> AllMainPosesInbetweenScopeMultipliers { get; set; } = new();
    public CArray<CUInt16> Wrinkles { get; set; } = new();
}

public class FacialTrackMapping : IRedClass
{
    public CUInt16 Track { get; set; }
    public CUInt8 LevelOfDetail { get; set; }
    public CUInt8 Envelope { get; set; }
}

public class FacialPoseLimit : IRedClass
{
    public CFloat Max { get; set; }
    public CFloat Mid { get; set; }
    public CFloat Min { get; set; }
    public CUInt16 Track { get; set; }
    public CUInt8 Envelope { get; set; }
    public CBool IsCachable { get; set; }
}

public class FacialInfluencedPose : IRedClass
{
    public CUInt16 Track { get; set; }
    public CUInt8 NumInfluences { get; set; }
    public CUInt8 Type { get; set; }
}

public class FacialParts : IRedClass
{
    public CUInt16 Track { get; set; }
    public CUInt8 Part { get; set; }
    public CUInt8 Unknown { get; set; }
}

public class FacialPoseSides : IRedClass
{
    public CUInt16 Track { get; set; }
    public CUInt8 Side { get; set; }
    public CUInt8 Unknown { get; set; }
}

public class FacialCorrectiveInfo : IRedClass
{
    public CUInt16 Index { get; set; }
    public CUInt16 Track { get; set; }
    public CUInt8 Unknown { get; set; }
}

public class FacialCorrectiveInfluencedPose : IRedClass
{
    public CUInt16 Index { get; set; }
    public CUInt8 NumInfluences { get; set; }
    public CUInt8 Type { get; set; }
}

public class FacialMainPoseInfo : IRedClass
{
    public CUInt16 Track { get; set; }
    public CUInt8 NumInbetweens { get; set; }
    public CUInt8 Unknown { get; set; }
}