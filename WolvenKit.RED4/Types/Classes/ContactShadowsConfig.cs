using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ContactShadowsConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("rangeLimit")] 
		public CFloat RangeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("screenEdgeFadeRange")] 
		public CFloat ScreenEdgeFadeRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("distanceFadeLimit")] 
		public CFloat DistanceFadeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("distanceFadeRange")] 
		public CFloat DistanceFadeRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ContactShadowsConfig()
		{
			Range = 0.050000F;
			RangeLimit = 0.075000F;
			ScreenEdgeFadeRange = 0.150000F;
			DistanceFadeLimit = 3.000000F;
			DistanceFadeRange = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
