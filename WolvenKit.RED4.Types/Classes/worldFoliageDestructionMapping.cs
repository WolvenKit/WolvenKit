using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageDestructionMapping : ISerializable
	{
		private CResourceAsyncReference<CMesh> _baseMesh;
		private CResourceAsyncReference<CMesh> _destructibleMesh;

		[Ordinal(0)] 
		[RED("baseMesh")] 
		public CResourceAsyncReference<CMesh> BaseMesh
		{
			get => GetProperty(ref _baseMesh);
			set => SetProperty(ref _baseMesh, value);
		}

		[Ordinal(1)] 
		[RED("destructibleMesh")] 
		public CResourceAsyncReference<CMesh> DestructibleMesh
		{
			get => GetProperty(ref _destructibleMesh);
			set => SetProperty(ref _destructibleMesh, value);
		}
	}
}
