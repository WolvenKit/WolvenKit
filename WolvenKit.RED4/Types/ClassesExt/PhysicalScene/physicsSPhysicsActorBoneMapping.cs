namespace WolvenKit.RED4.Types.PhysicalScene;

public partial class physicsSPhysicsActorBoneMapping : RedBaseClass
{
    [Ordinal(0)]
    [RED("bone")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Bone
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(1)]
    [RED("boneName")]
    [REDProperty(IsIgnored = true)]
    public CName BoneName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(2)]
    [RED("actorId")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 ActorId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(3)]
    [RED("boneToBody")]
    [REDProperty(IsIgnored = true)]
    public CMatrix BoneToBody
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }

    [Ordinal(4)]
    [RED("originalL2MInverted")]
    [REDProperty(IsIgnored = true)]
    public CMatrix OriginalL2MInverted
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }
}