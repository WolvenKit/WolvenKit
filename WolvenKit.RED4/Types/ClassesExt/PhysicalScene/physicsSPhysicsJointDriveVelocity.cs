namespace WolvenKit.RED4.Types.PhysicalScene;

public class physicsSPhysicsJointDriveVelocity : RedBaseClass
{
    [Ordinal(0)]
    [RED("linearVelocity")]
    [REDProperty(IsIgnored = true)]
    public Vector4 LinearVelocity
    {
        get => GetPropertyValue<Vector4>();
        set => SetPropertyValue<Vector4>(value);
    }

    [Ordinal(1)]
    [RED("angularVelocity")]
    [REDProperty(IsIgnored = true)]
    public Vector4 AngularVelocity
    {
        get => GetPropertyValue<Vector4>();
        set => SetPropertyValue<Vector4>(value);
    }
}