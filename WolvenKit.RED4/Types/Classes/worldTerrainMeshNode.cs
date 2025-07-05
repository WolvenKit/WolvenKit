using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTerrainMeshNode : worldNode
	{
		[Ordinal(4)] 
		[RED("mesh")] 
		public CHandle<CMesh> Mesh
		{
			get => GetPropertyValue<CHandle<CMesh>>();
			set => SetPropertyValue<CHandle<CMesh>>(value);
		}

		[Ordinal(5)] 
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
