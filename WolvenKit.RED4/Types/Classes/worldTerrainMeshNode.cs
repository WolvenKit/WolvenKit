using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTerrainMeshNode : worldNode
	{
		[Ordinal(2)] 
		[RED("mesh")] 
		public CHandle<CMesh> Mesh
		{
			get => GetPropertyValue<CHandle<CMesh>>();
			set => SetPropertyValue<CHandle<CMesh>>(value);
		}

		[Ordinal(3)] 
		[RED("meshRef")] 
		public CResourceAsyncReference<CMesh> MeshRef
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		public worldTerrainMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
