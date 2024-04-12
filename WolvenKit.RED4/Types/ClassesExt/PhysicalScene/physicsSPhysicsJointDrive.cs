namespace WolvenKit.RED4.Types.PhysicalScene;

public class physicsSPhysicsJointDrive : RedBaseClass
{
    [Ordinal(0)]
    [RED("forceLimit")]
    [REDProperty(IsIgnored = true)]
    public CFloat ForceLimit
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(1)]
    [RED("isAcceleration")]
    [REDProperty(IsIgnored = true)]
    public CBool IsAcceleration
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
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
}