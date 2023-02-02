namespace WolvenKit.RED4.Types;

public interface IRedMeshComponent
{
    public CResourceAsyncReference<CMesh> Mesh { get; set; }

    public CName MeshAppearance { get; set; }

    public CName Name { get; set; }

    public CUInt64 ChunkMask { get; set; }

    public WorldTransform LocalTransform { get; set; }

    public CHandle<entITransformBinding> ParentTransform { get; set; }
}

public partial class entSkinnedMeshComponent : IRedMeshComponent
{

}

public partial class entMeshComponent : IRedMeshComponent
{

}