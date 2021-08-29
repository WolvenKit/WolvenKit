using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTerrainMeshNode : worldNode
	{
		private CHandle<CMesh> _mesh;
		private CResourceAsyncReference<CMesh> _meshRef;

		[Ordinal(4)] 
		[RED("mesh")] 
		public CHandle<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(5)] 
		[RED("meshRef")] 
		public CResourceAsyncReference<CMesh> MeshRef
		{
			get => GetProperty(ref _meshRef);
			set => SetProperty(ref _meshRef, value);
		}
	}
}
