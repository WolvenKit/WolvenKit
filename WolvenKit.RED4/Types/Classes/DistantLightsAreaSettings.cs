using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistantLightsAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("distantLightStartDistance")] 
		public CFloat DistantLightStartDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("distantLightFadeDistance")] 
		public CFloat DistantLightFadeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DistantLightsAreaSettings()
		{
			Enable = true;
			DistantLightStartDistance = 50.000000F;
			DistantLightFadeDistance = 15.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
