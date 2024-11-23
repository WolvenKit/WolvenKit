using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.Buffer;

public class RazerChromaAnimationBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CUInt32 Version { get; set; }

    public CEnum<EChromaSDKDeviceEnum> Device { get; set; }

    public CArray<FChromaSDKColorFrame> Frames { get; set; }

    public RazerChromaAnimationBuffer()
    {
        Frames = new CArray<FChromaSDKColorFrame>();
    }
}

public abstract class FChromaSDKColorFrame : IRedClass
{

}

public class FChromaSDKColorFrame1D : FChromaSDKColorFrame
{
    public CFloat Duration { get; set; }

    public CArray<CColor> Colors { get; set; }

    public FChromaSDKColorFrame1D()
    {
        Colors = new CArray<CColor>();
    }
}

public class FChromaSDKColorFrame2D : FChromaSDKColorFrame
{
    public CFloat Duration { get; set; }

    public CArray<FChromaSDKColors> Colors { get; set; }

    public FChromaSDKColorFrame2D()
    {
        Colors = new CArray<FChromaSDKColors>();
    }
}

public class FChromaSDKColors : IRedClass
{
    public CArray<CColor> Colors { get; set; }

    public FChromaSDKColors()
    {
        Colors = new CArray<CColor>();
    }
}