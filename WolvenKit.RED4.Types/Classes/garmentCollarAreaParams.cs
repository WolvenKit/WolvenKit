using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class garmentCollarAreaParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("radiusInCM")] 
		public CFloat RadiusInCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("radiusForTriangleRemovalInCM")] 
		public CFloat RadiusForTriangleRemovalInCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("offsetFromSkinInCM")] 
		public CFloat OffsetFromSkinInCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public garmentCollarAreaParams()
		{
			RadiusInCM = 32.000000F;
			RadiusForTriangleRemovalInCM = 16.000000F;
			Offset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
