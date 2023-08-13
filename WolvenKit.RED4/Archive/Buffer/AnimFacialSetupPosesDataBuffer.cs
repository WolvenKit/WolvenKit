using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class AnimFacialSetupPosesDataBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public AnimFacialSetupPosesPartData Face { get; set; }
    public AnimFacialSetupPosesPartData Tongue { get; set; }
    public AnimFacialSetupPosesPartData Eyes { get; set; }
}

public class AnimFacialSetupPosesPartData : IRedClass
{
    public CArray<FacialSetup_PoseTrackInfo> Poses { get; set; } = new();
    public CArray<FacialTransform> Transforms { get; set; } = new();
    public CArray<Quaternion> Scales { get; set; } = new();
}

public class FacialSetup_PoseTrackInfo : IRedClass
{
    public CInt32 TransformIdx { get; set; }
    public CInt32 ScaleIdx { get; set; }
    public CInt32 NumTransforms { get; set; }
    public CBool IsScale { get; set; }
    public CUInt16 Flag1 { get; set; }
    public CUInt16 Flag2 { get; set; }
    public CUInt16 Flag3 { get; set; }
}

public class FacialTransform : IRedClass
{
    public Quaternion Rotation { get; set; }
    public Vector3 Translation { get; set; }
    public CUInt16 Bone { get; set; }
    public CUInt8 JointRegion { get; set; }
    public CUInt8 Unknown { get; set; }
}