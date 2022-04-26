using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CloudAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("cloudSunShadowFaloff")] 
		public CLegacySingleChannelCurve<CFloat> CloudSunShadowFaloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("cloudSunScattering")] 
		public CLegacySingleChannelCurve<CFloat> CloudSunScattering
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("cloudMoonScattering")] 
		public CLegacySingleChannelCurve<CFloat> CloudMoonScattering
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("cloudLightColor")] 
		public CLegacySingleChannelCurve<HDRColor> CloudLightColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(6)] 
		[RED("cloudAmbientIntensity")] 
		public CLegacySingleChannelCurve<CFloat> CloudAmbientIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("cloudCirrusOpacity")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusOpacity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("cloudCirrusScale")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("cloudCirrusAltitude")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusAltitude
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("cloudCirrusTexture")] 
		public CResourceReference<CBitmapTexture> CloudCirrusTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(11)] 
		[RED("volWeatherTexture")] 
		public CResourceReference<CBitmapTexture> VolWeatherTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(12)] 
		[RED("volNoiseTexture")] 
		public CResourceReference<CBitmapTexture> VolNoiseTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(13)] 
		[RED("volHorizonCoverage")] 
		public CFloat VolHorizonCoverage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("volCoverage")] 
		public CLegacySingleChannelCurve<CFloat> VolCoverage
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("volDensity")] 
		public CLegacySingleChannelCurve<CFloat> VolDensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(16)] 
		[RED("cloudsBottom")] 
		public CFloat CloudsBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("cloudsTop")] 
		public CFloat CloudsTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("rayStartOffset")] 
		public CFloat RayStartOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("rayStartFalloff")] 
		public CFloat RayStartFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("lightIntensity")] 
		public CLegacySingleChannelCurve<CFloat> LightIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(21)] 
		[RED("reflectionProbeLightIntensity")] 
		public CLegacySingleChannelCurve<CFloat> ReflectionProbeLightIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(22)] 
		[RED("shadowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> ShadowIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(23)] 
		[RED("worldShadowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> WorldShadowIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(24)] 
		[RED("ambientIntensity")] 
		public CLegacySingleChannelCurve<CFloat> AmbientIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(25)] 
		[RED("ambientOutscatter")] 
		public CLegacySingleChannelCurve<CFloat> AmbientOutscatter
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(26)] 
		[RED("inScatter")] 
		public CFloat InScatter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("outScatter")] 
		public CFloat OutScatter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("inVsOutScatter")] 
		public CFloat InVsOutScatter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("silverLining")] 
		public CFloat SilverLining
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("volCoverageWindInfluence")] 
		public CFloat VolCoverageWindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("volNoiseWindInfluence")] 
		public CFloat VolNoiseWindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("volDetailWindInfluence")] 
		public CFloat VolDetailWindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("volDistantFogOpacity")] 
		public CFloat VolDistantFogOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CloudAreaSettings()
		{
			Enable = true;
			VolHorizonCoverage = 1.000000F;
			CloudsBottom = 400.000000F;
			CloudsTop = 1000.000000F;
			RayStartOffset = 25.000000F;
			RayStartFalloff = 50.000000F;
			InScatter = 0.200000F;
			OutScatter = 0.100000F;
			InVsOutScatter = 0.500000F;
			SilverLining = 0.800000F;
			VolCoverageWindInfluence = 0.750000F;
			VolNoiseWindInfluence = 1.000000F;
			VolDetailWindInfluence = 1.250000F;
			VolDistantFogOpacity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
