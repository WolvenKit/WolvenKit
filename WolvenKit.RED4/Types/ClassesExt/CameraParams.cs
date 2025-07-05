namespace WolvenKit.RED4.Types;

public partial class CameraParams : RedBaseClass
{
    [RED("contentScale")]
    public TweakDBID ContentScale
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }

    [RED("cameraSkillChecks")]
    public CHandle<EngDemoContainer> CameraSkillChecks
    {
        get => GetPropertyValue<CHandle<EngDemoContainer>>();
        set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
    }

    [RED("maxRotationAngle")]
    public CFloat MaxRotationAngle
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}