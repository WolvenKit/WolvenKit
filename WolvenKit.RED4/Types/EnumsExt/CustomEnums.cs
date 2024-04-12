// ReSharper disable InconsistentNaming

namespace WolvenKit.RED4.Types;

public static partial class Enums
{
    // flags

    public enum EInterpolationType
    {
        Constant,
        Linear,
        BezierQuadratic,
        BezierCubic,
        Hermite
    }

    public enum ESegmentsLinkType
    {
        ESLT_Normal,
        ESLT_Smooth,
        ESLT_SmoothSymmetric
    };

    public enum EChannelLinkType
    {
        Normal,
        Smooth,
        SmoothSymmertric
    }

    public enum toolsSocketDirection
    {
        Invalid,
        Output,
    }

    public enum toolsSocketPlacement
    {
        Invalid,
        Bottom,
        Right,
    }

    public enum toolsAudioPlaybackDirectionSupport
    {
        Forward,
        Backward
    }

    public enum toolsAudioFastForwardSupport
    {
        MuteDuringFastForward,
        DontMuteDuringFastForward
    }

    public enum scnbPerformerAcquisitionPlanType
    {
        Invalid,
        Community,
        SpawnSet
    }

    public enum scnbExternalLayerVersion
    {
        VER_unset,
        VER_saving_substance
    }
    
    // physicalscene buffer
    
    public enum physicsEPhysicsSimulation : byte
    {
        Static = 0,
        Dynamic = 1,
        Kinematic = 2,
        Undefined = 3
    }
    
    public enum physicsEPhysicsBaseType : byte
    {
        Base = 4,
        Actor = 0,
        Shape = 1,
        Joint = 2,
        Mesh = 3,
        Max = 6
    }
    
    public enum physicsEPhysicsShapeGeometryType : byte
    {
        Box = 0,
        Sphere = 1,
        Capsule = 2,
        Convex = 3,
        TriMesh = 4,
        Invalid = 8,
        Max = 9,
    }
    
    public enum physicsEPhysicsJointMotion : byte
    {
        Locked = 0,
        Limited = 1,
        Free = 2
    }
}