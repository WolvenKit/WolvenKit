namespace WolvenKit.RED4.Types;

public interface IRedMeshNode
{
    public CResourceAsyncReference<CMesh> Mesh { get; set; }

    public CName MeshAppearance { get; set; }

}

public partial class worldBendedMeshNode : IRedMeshNode
{

}

public partial class worldStaticMeshNode : IRedMeshNode
{

}

public partial class worldInstancedMeshNode : IRedMeshNode
{

}

public partial class worldPrefabProxyMeshNode : IRedMeshNode
{

}

public partial class worldFoliageNode : IRedMeshNode
{

}

public partial class worldMeshNode : IRedMeshNode
{

}

/*public partial class worldStaticOccluderMeshNode : IRedMeshNode
{

    [REDProperty(IsIgnored = true)]
    [Ordinal(9)]
    [RED("MeshAppearance")]
    public CName MeshAppearance
    {
        get
        {
            return "default";
        }
        set
        {

        }
    }

}*/