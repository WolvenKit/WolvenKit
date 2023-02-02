using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendSLightFlickering : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positionOffset")] 
		public CFloat PositionOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("flickerStrength")] 
		public CFloat FlickerStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("flickerPeriod")] 
		public CFloat FlickerPeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public rendSLightFlickering()
		{
			FlickerPeriod = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
