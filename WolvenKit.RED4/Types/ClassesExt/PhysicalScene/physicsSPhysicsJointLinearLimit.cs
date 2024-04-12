namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsSPhysicsJointLinearLimit : physicsSPhysicsJointLimitBase
{
    [Ordinal(5)]
    [RED("x")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsJointMotion> X
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsJointMotion>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsJointMotion>>(value);
    }

    [Ordinal(6)]
    [RED("y")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsJointMotion> Y
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsJointMotion>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsJointMotion>>(value);
    }

    [Ordinal(7)]
    [RED("z")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsJointMotion> Z
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsJointMotion>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsJointMotion>>(value);
    }

    [Ordinal(8)]
    [RED("value")]
    [REDProperty(IsIgnored = true)]
    public CFloat Value
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}