namespace WolvenKit.RED4.Types.PhysicalScene;

public class physicsPhysicsMeshBoneMapping : RedBaseClass
{
    [Ordinal(0)]
    [RED("boneName")]
    [REDProperty(IsIgnored = true)]
    public CName BoneName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(1)]
    [RED("meshId")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 MeshId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(2)]
    [RED("boneIndex")]
    [REDProperty(IsIgnored = true)]
    public CInt32 BoneIndex
    {
        get => GetPropertyValue<CInt32>();
        set => SetPropertyValue<CInt32>(value);
    }
}