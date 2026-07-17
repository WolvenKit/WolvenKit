namespace WolvenKit.RED4.Types;

public interface IRedMeshNode
{
    public CResourceAsyncReference<CMesh> Mesh { get; set; }

    public CName MeshAppearance { get; set; }



}

public partial class worldMeshNode : IRedMeshNode
{
}
public partial class worldBendedMeshNode : IRedMeshNode
{
}
public partial class worldInstancedMeshNode : IRedMeshNode
{
}
public partial class worldFoliageNode : IRedMeshNode
{
}
