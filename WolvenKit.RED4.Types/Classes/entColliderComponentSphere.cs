using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponentSphere : entColliderComponentShape
	{
		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entColliderComponentSphere()
		{
			LocalToBody = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			Radius = 1.000000F;
		}
	}
}
