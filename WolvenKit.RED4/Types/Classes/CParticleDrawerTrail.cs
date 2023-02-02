using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerTrail : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("texturesPerUnit")] 
		public CFloat TexturesPerUnit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("dynamicTexCoords")] 
		public CBool DynamicTexCoords
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("minSegmentsPer360Degrees")] 
		public CInt32 MinSegmentsPer360Degrees
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("ribbonize")] 
		public CBool Ribbonize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ribbonTesselationDelta")] 
		public CFloat RibbonTesselationDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleDrawerTrail()
		{
			TexturesPerUnit = 0.500000F;
			MinSegmentsPer360Degrees = 40;
			RibbonTesselationDelta = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
