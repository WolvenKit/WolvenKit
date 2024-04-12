namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsPhysicsBase : ISerializable
{
    [Ordinal(0)]
    [RED("baseType")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsBaseType> BaseType
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsBaseType>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsBaseType>>(value);
    }

    [Ordinal(1)]
    [RED("localToWorld")]
    [REDProperty(IsIgnored = true)]
    public CMatrix LocalToWorld
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }

    [Ordinal(2)]
    [RED("physicsBaseId")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 PhysicsBaseId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(3)]
    [RED("flags")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Flags
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    public physicsPhysicsBase()
    {
        BaseType = physicsEPhysicsBaseType.Base;
    }
}