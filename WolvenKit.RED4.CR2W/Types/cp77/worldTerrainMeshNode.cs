using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTerrainMeshNode : worldNode
	{
		private CHandle<CMesh> _mesh;
		private raRef<CMesh> _meshRef;

		[Ordinal(4)] 
		[RED("mesh")] 
		public CHandle<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(5)] 
		[RED("meshRef")] 
		public raRef<CMesh> MeshRef
		{
			get => GetProperty(ref _meshRef);
			set => SetProperty(ref _meshRef, value);
		}

		public worldTerrainMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
