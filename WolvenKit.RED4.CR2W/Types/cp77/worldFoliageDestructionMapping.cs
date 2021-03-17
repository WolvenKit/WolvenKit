using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionMapping : ISerializable
	{
		private raRef<CMesh> _baseMesh;
		private raRef<CMesh> _destructibleMesh;
		private CName _meshAppearance;

		[Ordinal(0)] 
		[RED("baseMesh")] 
		public raRef<CMesh> BaseMesh
		{
			get => GetProperty(ref _baseMesh);
			set => SetProperty(ref _baseMesh, value);
		}

		[Ordinal(1)] 
		[RED("destructibleMesh")] 
		public raRef<CMesh> DestructibleMesh
		{
			get => GetProperty(ref _destructibleMesh);
			set => SetProperty(ref _destructibleMesh, value);
		}

		[Ordinal(2)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		public worldFoliageDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
