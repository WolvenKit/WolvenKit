using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlobalLightOverrideAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("color")] 
		public CLegacySingleChannelCurve<HDRColor> Color
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(3)] 
		[RED("lightAzimuth")] 
		public CFloat LightAzimuth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lightElevation")] 
		public CFloat LightElevation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GlobalLightOverrideAreaSettings()
		{
			LightAzimuth = 45.000000F;
			LightElevation = 45.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
