namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsPhysicsJoint : physicsPhysicsBase
{
    [Ordinal(4)]
    [RED("projectionEnabled")]
    [REDProperty(IsIgnored = true)]
    public CBool ProjectionEnabled
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(5)]
    [RED("linearTolerance")]
    [REDProperty(IsIgnored = true)]
    public CFloat LinearTolerance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(6)]
    [RED("angularTolerance")]
    [REDProperty(IsIgnored = true)]
    public CFloat AngularTolerance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(7)]
    [RED("isBreakable")]
    [REDProperty(IsIgnored = true)]
    public CBool IsBreakable
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(8)]
    [RED("breakingForce")]
    [REDProperty(IsIgnored = true)]
    public CFloat BreakingForce
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(9)]
    [RED("breakingTorque")]
    [REDProperty(IsIgnored = true)]
    public CFloat BreakingTorque
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(10)]
    [RED("actors", 2)]
    [REDProperty(IsIgnored = true)]
    public CArrayFixedSize<CUInt64> Actors
    {
        get => GetPropertyValue<CArrayFixedSize<CUInt64>>();
        set => SetPropertyValue<CArrayFixedSize<CUInt64>>(value);
    }

    [Ordinal(11)]
    [RED("localFrames", 2)]
    [REDProperty(IsIgnored = true)]
    public CArrayFixedSize<CMatrix> LocalFrames
    {
        get => GetPropertyValue<CArrayFixedSize<CMatrix>>();
        set => SetPropertyValue<CArrayFixedSize<CMatrix>>(value);
    }

    [Ordinal(12)]
    [RED("linearLimit")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointLinearLimit LinearLimit
    {
        get => GetPropertyValue<physicsSPhysicsJointLinearLimit>();
        set => SetPropertyValue<physicsSPhysicsJointLinearLimit>(value);
    }

    [Ordinal(13)]
    [RED("twistLimit")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointAngularLimitPair TwistLimit
    {
        get => GetPropertyValue<physicsSPhysicsJointAngularLimitPair>();
        set => SetPropertyValue<physicsSPhysicsJointAngularLimitPair>(value);
    }

    [Ordinal(14)]
    [RED("swingLimit")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointLimitConePair SwingLimit
    {
        get => GetPropertyValue<physicsSPhysicsJointLimitConePair>();
        set => SetPropertyValue<physicsSPhysicsJointLimitConePair>(value);
    }

    [Ordinal(15)]
    [RED("driveY")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDrive DriveY
    {
        get => GetPropertyValue<physicsSPhysicsJointDrive>();
        set => SetPropertyValue<physicsSPhysicsJointDrive>(value);
    }

    [Ordinal(16)]
    [RED("driveX")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDrive DriveX
    {
        get => GetPropertyValue<physicsSPhysicsJointDrive>();
        set => SetPropertyValue<physicsSPhysicsJointDrive>(value);
    }

    [Ordinal(17)]
    [RED("driveZ")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDrive DriveZ
    {
        get => GetPropertyValue<physicsSPhysicsJointDrive>();
        set => SetPropertyValue<physicsSPhysicsJointDrive>(value);
    }

    [Ordinal(18)]
    [RED("driveTwist")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDrive DriveTwist
    {
        get => GetPropertyValue<physicsSPhysicsJointDrive>();
        set => SetPropertyValue<physicsSPhysicsJointDrive>(value);
    }

    [Ordinal(19)]
    [RED("driveSwing")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDrive DriveSwing
    {
        get => GetPropertyValue<physicsSPhysicsJointDrive>();
        set => SetPropertyValue<physicsSPhysicsJointDrive>(value);
    }

    [Ordinal(20)]
    [RED("driveSLERP")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDrive DriveSLERP
    {
        get => GetPropertyValue<physicsSPhysicsJointDrive>();
        set => SetPropertyValue<physicsSPhysicsJointDrive>(value);
    }

    [Ordinal(21)]
    [RED("driveVelocity")]
    [REDProperty(IsIgnored = true)]
    public physicsSPhysicsJointDriveVelocity DriveVelocity
    {
        get => GetPropertyValue<physicsSPhysicsJointDriveVelocity>();
        set => SetPropertyValue<physicsSPhysicsJointDriveVelocity>(value);
    }

    [Ordinal(22)]
    [RED("drivePosition")]
    [REDProperty(IsIgnored = true)]
    public CMatrix DrivePosition
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }

    public physicsPhysicsJoint()
    {
        BaseType = physicsEPhysicsBaseType.Joint;
    }
}