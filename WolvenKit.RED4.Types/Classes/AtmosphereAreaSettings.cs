using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AtmosphereAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("skydomeColor")] 
		public CLegacySingleChannelCurve<HDRColor> SkydomeColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(3)] 
		[RED("skylightColor")] 
		public CLegacySingleChannelCurve<HDRColor> SkylightColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(4)] 
		[RED("groundReflectance")] 
		public CLegacySingleChannelCurve<HDRColor> GroundReflectance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(5)] 
		[RED("sunMinZ")] 
		public CLegacySingleChannelCurve<CFloat> SunMinZ
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("horizonMinZ")] 
		public CLegacySingleChannelCurve<CFloat> HorizonMinZ
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("horizonFalloff")] 
		public CLegacySingleChannelCurve<CFloat> HorizonFalloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("turbidity")] 
		public CLegacySingleChannelCurve<CFloat> Turbidity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("lutTurbidity")] 
		public CLegacySingleChannelCurve<CFloat> LutTurbidity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("artisticDarkeningColor")] 
		public CLegacySingleChannelCurve<HDRColor> ArtisticDarkeningColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(11)] 
		[RED("artisticDarkeningStartPoint")] 
		public CLegacySingleChannelCurve<CFloat> ArtisticDarkeningStartPoint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("artisticDarkeningEndPoint")] 
		public CLegacySingleChannelCurve<CFloat> ArtisticDarkeningEndPoint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(13)] 
		[RED("artisticDarkeningExponent")] 
		public CLegacySingleChannelCurve<CFloat> ArtisticDarkeningExponent
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(14)] 
		[RED("sunColor")] 
		public CLegacySingleChannelCurve<HDRColor> SunColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(15)] 
		[RED("sunFalloff")] 
		public CLegacySingleChannelCurve<CFloat> SunFalloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(16)] 
		[RED("rayTracedSunShadowRange")] 
		public CLegacySingleChannelCurve<CFloat> RayTracedSunShadowRange
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("moonColor")] 
		public CLegacySingleChannelCurve<HDRColor> MoonColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(18)] 
		[RED("moonFalloff")] 
		public CLegacySingleChannelCurve<CFloat> MoonFalloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("moonGlowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> MoonGlowIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(20)] 
		[RED("moonGlowFalloff")] 
		public CLegacySingleChannelCurve<CFloat> MoonGlowFalloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(21)] 
		[RED("moonTexture")] 
		public CResourceReference<CBitmapTexture> MoonTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(22)] 
		[RED("galaxyIntensity")] 
		public CLegacySingleChannelCurve<CFloat> GalaxyIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(23)] 
		[RED("starMapIntensity")] 
		public CLegacySingleChannelCurve<CFloat> StarMapIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(24)] 
		[RED("starMapBrightScale")] 
		public CLegacySingleChannelCurve<CFloat> StarMapBrightScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(25)] 
		[RED("starMapDimScale")] 
		public CLegacySingleChannelCurve<CFloat> StarMapDimScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(26)] 
		[RED("starMapConstelationsScale")] 
		public CLegacySingleChannelCurve<CFloat> StarMapConstelationsScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(27)] 
		[RED("starCornerLuminanceFix")] 
		public CLegacySingleChannelCurve<CFloat> StarCornerLuminanceFix
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(28)] 
		[RED("starMapTexture")] 
		public CResourceReference<CCubeTexture> StarMapTexture
		{
			get => GetPropertyValue<CResourceReference<CCubeTexture>>();
			set => SetPropertyValue<CResourceReference<CCubeTexture>>(value);
		}

		[Ordinal(29)] 
		[RED("galaxyTexture")] 
		public CResourceReference<CBitmapTexture> GalaxyTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(30)] 
		[RED("probeColorOverrideHorizon")] 
		public CLegacySingleChannelCurve<HDRColor> ProbeColorOverrideHorizon
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(31)] 
		[RED("probeAlphaOverrideHorizon")] 
		public CLegacySingleChannelCurve<CFloat> ProbeAlphaOverrideHorizon
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(32)] 
		[RED("probeColorOverrideZenith")] 
		public CLegacySingleChannelCurve<HDRColor> ProbeColorOverrideZenith
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(33)] 
		[RED("probeAlphaOverrideZenith")] 
		public CLegacySingleChannelCurve<CFloat> ProbeAlphaOverrideZenith
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(34)] 
		[RED("cloudSunShadowFaloff")] 
		public CLegacySingleChannelCurve<CFloat> CloudSunShadowFaloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(35)] 
		[RED("cloudSunScattering")] 
		public CLegacySingleChannelCurve<CFloat> CloudSunScattering
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(36)] 
		[RED("cloudMoonScattering")] 
		public CLegacySingleChannelCurve<CFloat> CloudMoonScattering
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(37)] 
		[RED("cloudAmbientIntensity")] 
		public CLegacySingleChannelCurve<CFloat> CloudAmbientIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(38)] 
		[RED("cloudCirrusOpacity")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusOpacity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(39)] 
		[RED("cloudCirrusScale")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(40)] 
		[RED("cloudCirrusAltitude")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusAltitude
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(41)] 
		[RED("cloudCirrusTexture")] 
		public CResourceReference<CBitmapTexture> CloudCirrusTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(42)] 
		[RED("volWeatherTexture")] 
		public CResourceReference<CBitmapTexture> VolWeatherTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(43)] 
		[RED("volNoiseTexture")] 
		public CResourceReference<CBitmapTexture> VolNoiseTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(44)] 
		[RED("volHorizonCoverage")] 
		public CFloat VolHorizonCoverage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("volCoverage")] 
		public CLegacySingleChannelCurve<CFloat> VolCoverage
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(46)] 
		[RED("volDensity")] 
		public CLegacySingleChannelCurve<CFloat> VolDensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(47)] 
		[RED("cloudsBottom")] 
		public CFloat CloudsBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("cloudsTop")] 
		public CFloat CloudsTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("rayStartOffset")] 
		public CFloat RayStartOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("rayStartFalloff")] 
		public CFloat RayStartFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("lightIntensity")] 
		public CLegacySingleChannelCurve<CFloat> LightIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(52)] 
		[RED("reflectionProbeLightIntensity")] 
		public CLegacySingleChannelCurve<CFloat> ReflectionProbeLightIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(53)] 
		[RED("shadowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> ShadowIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(54)] 
		[RED("worldShadowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> WorldShadowIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(55)] 
		[RED("ambientIntensity")] 
		public CLegacySingleChannelCurve<CFloat> AmbientIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(56)] 
		[RED("ambientOutscatter")] 
		public CLegacySingleChannelCurve<CFloat> AmbientOutscatter
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(57)] 
		[RED("inScatter")] 
		public CFloat InScatter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("outScatter")] 
		public CFloat OutScatter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("inVsOutScatter")] 
		public CFloat InVsOutScatter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("silverLining")] 
		public CFloat SilverLining
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("volCoverageWindInfluence")] 
		public CFloat VolCoverageWindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(62)] 
		[RED("volNoiseWindInfluence")] 
		public CFloat VolNoiseWindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(63)] 
		[RED("volDetailWindInfluence")] 
		public CFloat VolDetailWindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(64)] 
		[RED("volDistantFogOpacity")] 
		public CFloat VolDistantFogOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AtmosphereAreaSettings()
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
		}
	}
}
