namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsSPhysicsJointAngularLimitPair : physicsSPhysicsJointLimitBase
{
    [Ordinal(5)]
    [RED("twist")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsJointMotion> Twist
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsJointMotion>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsJointMotion>>(value);
    }

    [Ordinal(6)]
    [RED("upper")]
    [REDProperty(IsIgnored = true)]
    public CFloat Upper
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(7)]
    [RED("lower")]
    [REDProperty(IsIgnored = true)]
    public CFloat Lower
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}