using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponentConvex : entColliderComponentShape
	{
		[Ordinal(1)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		public entColliderComponentConvex()
		{
			LocalToBody = new() { Position = new(), Orientation = new() { R = 1.000000F } };
		}
	}
}
