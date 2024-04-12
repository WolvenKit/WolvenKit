namespace WolvenKit.RED4.Types.PhysicalScene;

public class physicsSPhysicsJointLimitBase : RedBaseClass
{
    [Ordinal(0)]
    [RED("restitution")]
    [REDProperty(IsIgnored = true)]
    public CFloat Restitution
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(1)]
    [RED("bounceThreshold")]
    [REDProperty(IsIgnored = true)]
    public CFloat BounceThreshold
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(2)]
    [RED("stiffness")]
    [REDProperty(IsIgnored = true)]
    public CFloat Stiffness
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(3)]
    [RED("damping")]
    [REDProperty(IsIgnored = true)]
    public CFloat Damping
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(4)]
    [RED("contactDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat ContactDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}