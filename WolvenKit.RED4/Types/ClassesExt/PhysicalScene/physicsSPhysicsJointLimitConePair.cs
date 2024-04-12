namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsSPhysicsJointLimitConePair : physicsSPhysicsJointLimitBase
{
    [Ordinal(5)]
    [RED("swingY")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsJointMotion> SwingY
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsJointMotion>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsJointMotion>>(value);
    }

    [Ordinal(6)]
    [RED("swingZ")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsJointMotion> SwingZ
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsJointMotion>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsJointMotion>>(value);
    }

    [Ordinal(7)]
    [RED("yAngle")]
    [REDProperty(IsIgnored = true)]
    public CFloat YAngle
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(8)]
    [RED("zAngle")]
    [REDProperty(IsIgnored = true)]
    public CFloat ZAngle
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}