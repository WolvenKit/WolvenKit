using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

		public AtmosphereAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
