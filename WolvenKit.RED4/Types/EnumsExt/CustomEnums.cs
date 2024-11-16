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
}