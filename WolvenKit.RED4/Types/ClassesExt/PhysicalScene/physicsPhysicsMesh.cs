namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsPhysicsMesh : physicsPhysicsBase
{
    [Ordinal(4)]
    [RED("mesh")]
    [REDProperty(IsIgnored = true)]
    public CResourceReference<CMesh> mesh
    {
        get => GetPropertyValue<CResourceReference<CMesh>>();
        set => SetPropertyValue<CResourceReference<CMesh>>(value);
    }

    [Ordinal(5)]
    [RED("meshAppearance")]
    [REDProperty(IsIgnored = true)]
    public CName MeshAppearance
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(6)]
    [RED("actorMappings")]
    [REDProperty(IsIgnored = true)]
    public CArray<physicsSPhysicsActorBoneMapping> ActorMappings
    {
        get => GetPropertyValue<CArray<physicsSPhysicsActorBoneMapping>>();
        set => SetPropertyValue<CArray<physicsSPhysicsActorBoneMapping>>(value);
    }

    public physicsPhysicsMesh()
    {
        BaseType = physicsEPhysicsBaseType.Mesh;
    }
}