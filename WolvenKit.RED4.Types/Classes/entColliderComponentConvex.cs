using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponentConvex : entColliderComponentShape
	{
		private CResourceReference<CMesh> _mesh;

		[Ordinal(1)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}
	}
}
