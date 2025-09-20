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

    public enum EChromaSDKDeviceTypeEnum : byte
    {
        DE_1D = 0,
        DE_2D,
    }

    public enum EChromaSDKDevice1DEnum : byte
    {
        DE_ChromaLink = 0,
        DE_Headset,
        DE_Mousepad
    }

    public enum EChromaSDKDevice2DEnum : byte
    {
        DE_Keyboard = 0,
        DE_Keypad,
        DE_Mouse,
        DE_KeyboardExtended
    }

    public enum EChromaSDKDeviceEnum : byte
    {
        DE_ChromaLink = 0,
        DE_Headset,
        DE_Keyboard,
        DE_Keypad,
        DE_Mouse,
        DE_Mousepad,
        DE_KeyboardExtended
    }

    
    // bitmask version of EMaterialModifier
    [Flags]
    public enum EMaterialModifierMask : ulong
    {
        None                    = 0,
        HitProxy                = 1u << 0,
        WindData                = 1u << 1,
        ParticleParams          = 1u << 2,
        RemoteCamera            = 1u << 3,
        Mirror                  = 1u << 4,
        CustomStructBuffer      = 1u << 5,
        EffectParams            = 1u << 6,
        MotionMatrix            = 1u << 7,
        ColorAndTexture         = 1u << 8,
        MaterialParams          = 1u << 9,
        Eye                     = 1u << 10,
        Skin                    = 1u << 11,
        VehicleParams           = 1u << 12,
        Dismemberment           = 1u << 13,
        Garments                = 1u << 14,
        ShadowsDebugParams      = 1u << 15,
        MultilayeredDebug       = 1u << 16,
        ParallaxParams          = 1u << 17,
        HighlightsParams        = 1u << 18,
        DebugColoring           = 1u << 19,
        DrawBufferMask          = 1u << 20,
        AutoSpawnData           = 1u << 21,
        DestructionRegions      = 1u << 22,        
        FloatTracks             = 1u << 23,
        AutoHideDistance        = 1u << 24,
        Rain                    = 1u << 25,
        PlanarReflections       = 1u << 26,
        WaterSim                = 1u << 27,
        TransparencyClipParams  = 1u << 28,
        FlatTireParams          = 1u << 29,
        SecondMultilayerParams  = 1u << 30,
        CrystalCoat             = 1u << 31
        // EMATMOD_MAX = 32
    }

    // bitmask version of EFeatureFlag
    [Flags]
    public enum EFeatureFlagMask : ulong
    {
        None                        = 0,
        Default                     = 1u << 0,
        Shadows                     = 1u << 1,
        HitProxies                  = 1u << 2,
        Selection                   = 1u << 3,
        Wireframe                   = 1u << 4,
        VelocityBuffer              = 1u << 5,
        DebugDraw_BlendOff          = 1u << 6,
        DebugDraw_BlendOn           = 1u << 7,
        DynamicDecals               = 1u << 8,
        Highlights                  = 1u << 9,
        Overdraw                    = 1u << 10,
        IndirectInstancedGrass      = 1u << 11,
        DecalsOnStaticObjects       = 1u << 12,
        DecalsOnDynamicObjects      = 1u << 13,
        MaskParticlesInsideCar      = 1u << 14,
        MaskParticlesInsideInterior = 1u << 15,
        MaskTXAA                    = 1u << 16,
        DistantShadows              = 1u << 17,
        FloatTracks                 = 1u << 18,
        Rain                        = 1u << 19,
        NumLights                   = 1u << 20,
        DepthPrepass                = 1u << 21,
        DecalsOnAllObjects          = 1u << 22
    }

    // Cleaned up version of ERenderMeshStreams
    [Flags]
    public enum ERenderMeshStreamsMask : uint
    {
        None             = 0,
        PositionSkinning = 1,
        TexCoords        = 2,
        TangentFrame     = 4,
        Extended         = 8,
        Custom0          = 16
    }
}
