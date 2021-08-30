using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AtmosphereAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<HDRColor> _skydomeColor;
		private CLegacySingleChannelCurve<HDRColor> _skylightColor;
		private CLegacySingleChannelCurve<HDRColor> _groundReflectance;
		private CLegacySingleChannelCurve<CFloat> _sunMinZ;
		private CLegacySingleChannelCurve<CFloat> _horizonMinZ;
		private CLegacySingleChannelCurve<CFloat> _horizonFalloff;
		private CLegacySingleChannelCurve<CFloat> _turbidity;
		private CLegacySingleChannelCurve<CFloat> _lutTurbidity;
		private CLegacySingleChannelCurve<HDRColor> _artisticDarkeningColor;
		private CLegacySingleChannelCurve<CFloat> _artisticDarkeningStartPoint;
		private CLegacySingleChannelCurve<CFloat> _artisticDarkeningEndPoint;
		private CLegacySingleChannelCurve<CFloat> _artisticDarkeningExponent;
		private CLegacySingleChannelCurve<HDRColor> _sunColor;
		private CLegacySingleChannelCurve<CFloat> _sunFalloff;
		private CLegacySingleChannelCurve<CFloat> _rayTracedSunShadowRange;
		private CLegacySingleChannelCurve<HDRColor> _moonColor;
		private CLegacySingleChannelCurve<CFloat> _moonFalloff;
		private CLegacySingleChannelCurve<CFloat> _moonGlowIntensity;
		private CLegacySingleChannelCurve<CFloat> _moonGlowFalloff;
		private CResourceReference<CBitmapTexture> _moonTexture;
		private CLegacySingleChannelCurve<CFloat> _galaxyIntensity;
		private CLegacySingleChannelCurve<CFloat> _starMapIntensity;
		private CLegacySingleChannelCurve<CFloat> _starMapBrightScale;
		private CLegacySingleChannelCurve<CFloat> _starMapDimScale;
		private CLegacySingleChannelCurve<CFloat> _starMapConstelationsScale;
		private CLegacySingleChannelCurve<CFloat> _starCornerLuminanceFix;
		private CResourceReference<CCubeTexture> _starMapTexture;
		private CResourceReference<CBitmapTexture> _galaxyTexture;
		private CLegacySingleChannelCurve<HDRColor> _probeColorOverrideHorizon;
		private CLegacySingleChannelCurve<CFloat> _probeAlphaOverrideHorizon;
		private CLegacySingleChannelCurve<HDRColor> _probeColorOverrideZenith;
		private CLegacySingleChannelCurve<CFloat> _probeAlphaOverrideZenith;
		private CLegacySingleChannelCurve<CFloat> _cloudSunShadowFaloff;
		private CLegacySingleChannelCurve<CFloat> _cloudSunScattering;
		private CLegacySingleChannelCurve<CFloat> _cloudMoonScattering;
		private CLegacySingleChannelCurve<CFloat> _cloudAmbientIntensity;
		private CLegacySingleChannelCurve<CFloat> _cloudCirrusOpacity;
		private CLegacySingleChannelCurve<CFloat> _cloudCirrusScale;
		private CLegacySingleChannelCurve<CFloat> _cloudCirrusAltitude;
		private CResourceReference<CBitmapTexture> _cloudCirrusTexture;
		private CResourceReference<CBitmapTexture> _volWeatherTexture;
		private CResourceReference<CBitmapTexture> _volNoiseTexture;
		private CFloat _volHorizonCoverage;
		private CLegacySingleChannelCurve<CFloat> _volCoverage;
		private CLegacySingleChannelCurve<CFloat> _volDensity;
		private CFloat _cloudsBottom;
		private CFloat _cloudsTop;
		private CFloat _rayStartOffset;
		private CFloat _rayStartFalloff;
		private CLegacySingleChannelCurve<CFloat> _lightIntensity;
		private CLegacySingleChannelCurve<CFloat> _reflectionProbeLightIntensity;
		private CLegacySingleChannelCurve<CFloat> _shadowIntensity;
		private CLegacySingleChannelCurve<CFloat> _worldShadowIntensity;
		private CLegacySingleChannelCurve<CFloat> _ambientIntensity;
		private CLegacySingleChannelCurve<CFloat> _ambientOutscatter;
		private CFloat _inScatter;
		private CFloat _outScatter;
		private CFloat _inVsOutScatter;
		private CFloat _silverLining;
		private CFloat _volCoverageWindInfluence;
		private CFloat _volNoiseWindInfluence;
		private CFloat _volDetailWindInfluence;
		private CFloat _volDistantFogOpacity;

		[Ordinal(2)] 
		[RED("skydomeColor")] 
		public CLegacySingleChannelCurve<HDRColor> SkydomeColor
		{
			get => GetProperty(ref _skydomeColor);
			set => SetProperty(ref _skydomeColor, value);
		}

		[Ordinal(3)] 
		[RED("skylightColor")] 
		public CLegacySingleChannelCurve<HDRColor> SkylightColor
		{
			get => GetProperty(ref _skylightColor);
			set => SetProperty(ref _skylightColor, value);
		}

		[Ordinal(4)] 
		[RED("groundReflectance")] 
		public CLegacySingleChannelCurve<HDRColor> GroundReflectance
		{
			get => GetProperty(ref _groundReflectance);
			set => SetProperty(ref _groundReflectance, value);
		}

		[Ordinal(5)] 
		[RED("sunMinZ")] 
		public CLegacySingleChannelCurve<CFloat> SunMinZ
		{
			get => GetProperty(ref _sunMinZ);
			set => SetProperty(ref _sunMinZ, value);
		}

		[Ordinal(6)] 
		[RED("horizonMinZ")] 
		public CLegacySingleChannelCurve<CFloat> HorizonMinZ
		{
			get => GetProperty(ref _horizonMinZ);
			set => SetProperty(ref _horizonMinZ, value);
		}

		[Ordinal(7)] 
		[RED("horizonFalloff")] 
		public CLegacySingleChannelCurve<CFloat> HorizonFalloff
		{
			get => GetProperty(ref _horizonFalloff);
			set => SetProperty(ref _horizonFalloff, value);
		}

		[Ordinal(8)] 
		[RED("turbidity")] 
		public CLegacySingleChannelCurve<CFloat> Turbidity
		{
			get => GetProperty(ref _turbidity);
			set => SetProperty(ref _turbidity, value);
		}

		[Ordinal(9)] 
		[RED("lutTurbidity")] 
		public CLegacySingleChannelCurve<CFloat> LutTurbidity
		{
			get => GetProperty(ref _lutTurbidity);
			set => SetProperty(ref _lutTurbidity, value);
		}

		[Ordinal(10)] 
		[RED("artisticDarkeningColor")] 
		public CLegacySingleChannelCurve<HDRColor> ArtisticDarkeningColor
		{
			get => GetProperty(ref _artisticDarkeningColor);
			set => SetProperty(ref _artisticDarkeningColor, value);
		}

		[Ordinal(11)] 
		[RED("artisticDarkeningStartPoint")] 
		public CLegacySingleChannelCurve<CFloat> ArtisticDarkeningStartPoint
		{
			get => GetProperty(ref _artisticDarkeningStartPoint);
			set => SetProperty(ref _artisticDarkeningStartPoint, value);
		}

		[Ordinal(12)] 
		[RED("artisticDarkeningEndPoint")] 
		public CLegacySingleChannelCurve<CFloat> ArtisticDarkeningEndPoint
		{
			get => GetProperty(ref _artisticDarkeningEndPoint);
			set => SetProperty(ref _artisticDarkeningEndPoint, value);
		}

		[Ordinal(13)] 
		[RED("artisticDarkeningExponent")] 
		public CLegacySingleChannelCurve<CFloat> ArtisticDarkeningExponent
		{
			get => GetProperty(ref _artisticDarkeningExponent);
			set => SetProperty(ref _artisticDarkeningExponent, value);
		}

		[Ordinal(14)] 
		[RED("sunColor")] 
		public CLegacySingleChannelCurve<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(15)] 
		[RED("sunFalloff")] 
		public CLegacySingleChannelCurve<CFloat> SunFalloff
		{
			get => GetProperty(ref _sunFalloff);
			set => SetProperty(ref _sunFalloff, value);
		}

		[Ordinal(16)] 
		[RED("rayTracedSunShadowRange")] 
		public CLegacySingleChannelCurve<CFloat> RayTracedSunShadowRange
		{
			get => GetProperty(ref _rayTracedSunShadowRange);
			set => SetProperty(ref _rayTracedSunShadowRange, value);
		}

		[Ordinal(17)] 
		[RED("moonColor")] 
		public CLegacySingleChannelCurve<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(18)] 
		[RED("moonFalloff")] 
		public CLegacySingleChannelCurve<CFloat> MoonFalloff
		{
			get => GetProperty(ref _moonFalloff);
			set => SetProperty(ref _moonFalloff, value);
		}

		[Ordinal(19)] 
		[RED("moonGlowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> MoonGlowIntensity
		{
			get => GetProperty(ref _moonGlowIntensity);
			set => SetProperty(ref _moonGlowIntensity, value);
		}

		[Ordinal(20)] 
		[RED("moonGlowFalloff")] 
		public CLegacySingleChannelCurve<CFloat> MoonGlowFalloff
		{
			get => GetProperty(ref _moonGlowFalloff);
			set => SetProperty(ref _moonGlowFalloff, value);
		}

		[Ordinal(21)] 
		[RED("moonTexture")] 
		public CResourceReference<CBitmapTexture> MoonTexture
		{
			get => GetProperty(ref _moonTexture);
			set => SetProperty(ref _moonTexture, value);
		}

		[Ordinal(22)] 
		[RED("galaxyIntensity")] 
		public CLegacySingleChannelCurve<CFloat> GalaxyIntensity
		{
			get => GetProperty(ref _galaxyIntensity);
			set => SetProperty(ref _galaxyIntensity, value);
		}

		[Ordinal(23)] 
		[RED("starMapIntensity")] 
		public CLegacySingleChannelCurve<CFloat> StarMapIntensity
		{
			get => GetProperty(ref _starMapIntensity);
			set => SetProperty(ref _starMapIntensity, value);
		}

		[Ordinal(24)] 
		[RED("starMapBrightScale")] 
		public CLegacySingleChannelCurve<CFloat> StarMapBrightScale
		{
			get => GetProperty(ref _starMapBrightScale);
			set => SetProperty(ref _starMapBrightScale, value);
		}

		[Ordinal(25)] 
		[RED("starMapDimScale")] 
		public CLegacySingleChannelCurve<CFloat> StarMapDimScale
		{
			get => GetProperty(ref _starMapDimScale);
			set => SetProperty(ref _starMapDimScale, value);
		}

		[Ordinal(26)] 
		[RED("starMapConstelationsScale")] 
		public CLegacySingleChannelCurve<CFloat> StarMapConstelationsScale
		{
			get => GetProperty(ref _starMapConstelationsScale);
			set => SetProperty(ref _starMapConstelationsScale, value);
		}

		[Ordinal(27)] 
		[RED("starCornerLuminanceFix")] 
		public CLegacySingleChannelCurve<CFloat> StarCornerLuminanceFix
		{
			get => GetProperty(ref _starCornerLuminanceFix);
			set => SetProperty(ref _starCornerLuminanceFix, value);
		}

		[Ordinal(28)] 
		[RED("starMapTexture")] 
		public CResourceReference<CCubeTexture> StarMapTexture
		{
			get => GetProperty(ref _starMapTexture);
			set => SetProperty(ref _starMapTexture, value);
		}

		[Ordinal(29)] 
		[RED("galaxyTexture")] 
		public CResourceReference<CBitmapTexture> GalaxyTexture
		{
			get => GetProperty(ref _galaxyTexture);
			set => SetProperty(ref _galaxyTexture, value);
		}

		[Ordinal(30)] 
		[RED("probeColorOverrideHorizon")] 
		public CLegacySingleChannelCurve<HDRColor> ProbeColorOverrideHorizon
		{
			get => GetProperty(ref _probeColorOverrideHorizon);
			set => SetProperty(ref _probeColorOverrideHorizon, value);
		}

		[Ordinal(31)] 
		[RED("probeAlphaOverrideHorizon")] 
		public CLegacySingleChannelCurve<CFloat> ProbeAlphaOverrideHorizon
		{
			get => GetProperty(ref _probeAlphaOverrideHorizon);
			set => SetProperty(ref _probeAlphaOverrideHorizon, value);
		}

		[Ordinal(32)] 
		[RED("probeColorOverrideZenith")] 
		public CLegacySingleChannelCurve<HDRColor> ProbeColorOverrideZenith
		{
			get => GetProperty(ref _probeColorOverrideZenith);
			set => SetProperty(ref _probeColorOverrideZenith, value);
		}

		[Ordinal(33)] 
		[RED("probeAlphaOverrideZenith")] 
		public CLegacySingleChannelCurve<CFloat> ProbeAlphaOverrideZenith
		{
			get => GetProperty(ref _probeAlphaOverrideZenith);
			set => SetProperty(ref _probeAlphaOverrideZenith, value);
		}

		[Ordinal(34)] 
		[RED("cloudSunShadowFaloff")] 
		public CLegacySingleChannelCurve<CFloat> CloudSunShadowFaloff
		{
			get => GetProperty(ref _cloudSunShadowFaloff);
			set => SetProperty(ref _cloudSunShadowFaloff, value);
		}

		[Ordinal(35)] 
		[RED("cloudSunScattering")] 
		public CLegacySingleChannelCurve<CFloat> CloudSunScattering
		{
			get => GetProperty(ref _cloudSunScattering);
			set => SetProperty(ref _cloudSunScattering, value);
		}

		[Ordinal(36)] 
		[RED("cloudMoonScattering")] 
		public CLegacySingleChannelCurve<CFloat> CloudMoonScattering
		{
			get => GetProperty(ref _cloudMoonScattering);
			set => SetProperty(ref _cloudMoonScattering, value);
		}

		[Ordinal(37)] 
		[RED("cloudAmbientIntensity")] 
		public CLegacySingleChannelCurve<CFloat> CloudAmbientIntensity
		{
			get => GetProperty(ref _cloudAmbientIntensity);
			set => SetProperty(ref _cloudAmbientIntensity, value);
		}

		[Ordinal(38)] 
		[RED("cloudCirrusOpacity")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusOpacity
		{
			get => GetProperty(ref _cloudCirrusOpacity);
			set => SetProperty(ref _cloudCirrusOpacity, value);
		}

		[Ordinal(39)] 
		[RED("cloudCirrusScale")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusScale
		{
			get => GetProperty(ref _cloudCirrusScale);
			set => SetProperty(ref _cloudCirrusScale, value);
		}

		[Ordinal(40)] 
		[RED("cloudCirrusAltitude")] 
		public CLegacySingleChannelCurve<CFloat> CloudCirrusAltitude
		{
			get => GetProperty(ref _cloudCirrusAltitude);
			set => SetProperty(ref _cloudCirrusAltitude, value);
		}

		[Ordinal(41)] 
		[RED("cloudCirrusTexture")] 
		public CResourceReference<CBitmapTexture> CloudCirrusTexture
		{
			get => GetProperty(ref _cloudCirrusTexture);
			set => SetProperty(ref _cloudCirrusTexture, value);
		}

		[Ordinal(42)] 
		[RED("volWeatherTexture")] 
		public CResourceReference<CBitmapTexture> VolWeatherTexture
		{
			get => GetProperty(ref _volWeatherTexture);
			set => SetProperty(ref _volWeatherTexture, value);
		}

		[Ordinal(43)] 
		[RED("volNoiseTexture")] 
		public CResourceReference<CBitmapTexture> VolNoiseTexture
		{
			get => GetProperty(ref _volNoiseTexture);
			set => SetProperty(ref _volNoiseTexture, value);
		}

		[Ordinal(44)] 
		[RED("volHorizonCoverage")] 
		public CFloat VolHorizonCoverage
		{
			get => GetProperty(ref _volHorizonCoverage);
			set => SetProperty(ref _volHorizonCoverage, value);
		}

		[Ordinal(45)] 
		[RED("volCoverage")] 
		public CLegacySingleChannelCurve<CFloat> VolCoverage
		{
			get => GetProperty(ref _volCoverage);
			set => SetProperty(ref _volCoverage, value);
		}

		[Ordinal(46)] 
		[RED("volDensity")] 
		public CLegacySingleChannelCurve<CFloat> VolDensity
		{
			get => GetProperty(ref _volDensity);
			set => SetProperty(ref _volDensity, value);
		}

		[Ordinal(47)] 
		[RED("cloudsBottom")] 
		public CFloat CloudsBottom
		{
			get => GetProperty(ref _cloudsBottom);
			set => SetProperty(ref _cloudsBottom, value);
		}

		[Ordinal(48)] 
		[RED("cloudsTop")] 
		public CFloat CloudsTop
		{
			get => GetProperty(ref _cloudsTop);
			set => SetProperty(ref _cloudsTop, value);
		}

		[Ordinal(49)] 
		[RED("rayStartOffset")] 
		public CFloat RayStartOffset
		{
			get => GetProperty(ref _rayStartOffset);
			set => SetProperty(ref _rayStartOffset, value);
		}

		[Ordinal(50)] 
		[RED("rayStartFalloff")] 
		public CFloat RayStartFalloff
		{
			get => GetProperty(ref _rayStartFalloff);
			set => SetProperty(ref _rayStartFalloff, value);
		}

		[Ordinal(51)] 
		[RED("lightIntensity")] 
		public CLegacySingleChannelCurve<CFloat> LightIntensity
		{
			get => GetProperty(ref _lightIntensity);
			set => SetProperty(ref _lightIntensity, value);
		}

		[Ordinal(52)] 
		[RED("reflectionProbeLightIntensity")] 
		public CLegacySingleChannelCurve<CFloat> ReflectionProbeLightIntensity
		{
			get => GetProperty(ref _reflectionProbeLightIntensity);
			set => SetProperty(ref _reflectionProbeLightIntensity, value);
		}

		[Ordinal(53)] 
		[RED("shadowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> ShadowIntensity
		{
			get => GetProperty(ref _shadowIntensity);
			set => SetProperty(ref _shadowIntensity, value);
		}

		[Ordinal(54)] 
		[RED("worldShadowIntensity")] 
		public CLegacySingleChannelCurve<CFloat> WorldShadowIntensity
		{
			get => GetProperty(ref _worldShadowIntensity);
			set => SetProperty(ref _worldShadowIntensity, value);
		}

		[Ordinal(55)] 
		[RED("ambientIntensity")] 
		public CLegacySingleChannelCurve<CFloat> AmbientIntensity
		{
			get => GetProperty(ref _ambientIntensity);
			set => SetProperty(ref _ambientIntensity, value);
		}

		[Ordinal(56)] 
		[RED("ambientOutscatter")] 
		public CLegacySingleChannelCurve<CFloat> AmbientOutscatter
		{
			get => GetProperty(ref _ambientOutscatter);
			set => SetProperty(ref _ambientOutscatter, value);
		}

		[Ordinal(57)] 
		[RED("inScatter")] 
		public CFloat InScatter
		{
			get => GetProperty(ref _inScatter);
			set => SetProperty(ref _inScatter, value);
		}

		[Ordinal(58)] 
		[RED("outScatter")] 
		public CFloat OutScatter
		{
			get => GetProperty(ref _outScatter);
			set => SetProperty(ref _outScatter, value);
		}

		[Ordinal(59)] 
		[RED("inVsOutScatter")] 
		public CFloat InVsOutScatter
		{
			get => GetProperty(ref _inVsOutScatter);
			set => SetProperty(ref _inVsOutScatter, value);
		}

		[Ordinal(60)] 
		[RED("silverLining")] 
		public CFloat SilverLining
		{
			get => GetProperty(ref _silverLining);
			set => SetProperty(ref _silverLining, value);
		}

		[Ordinal(61)] 
		[RED("volCoverageWindInfluence")] 
		public CFloat VolCoverageWindInfluence
		{
			get => GetProperty(ref _volCoverageWindInfluence);
			set => SetProperty(ref _volCoverageWindInfluence, value);
		}

		[Ordinal(62)] 
		[RED("volNoiseWindInfluence")] 
		public CFloat VolNoiseWindInfluence
		{
			get => GetProperty(ref _volNoiseWindInfluence);
			set => SetProperty(ref _volNoiseWindInfluence, value);
		}

		[Ordinal(63)] 
		[RED("volDetailWindInfluence")] 
		public CFloat VolDetailWindInfluence
		{
			get => GetProperty(ref _volDetailWindInfluence);
			set => SetProperty(ref _volDetailWindInfluence, value);
		}

		[Ordinal(64)] 
		[RED("volDistantFogOpacity")] 
		public CFloat VolDistantFogOpacity
		{
			get => GetProperty(ref _volDistantFogOpacity);
			set => SetProperty(ref _volDistantFogOpacity, value);
		}

		public AtmosphereAreaSettings()
		{
			_volHorizonCoverage = 1.000000F;
			_cloudsBottom = 400.000000F;
			_cloudsTop = 1000.000000F;
			_rayStartOffset = 25.000000F;
			_rayStartFalloff = 50.000000F;
			_inScatter = 0.200000F;
			_outScatter = 0.100000F;
			_inVsOutScatter = 0.500000F;
			_silverLining = 0.800000F;
			_volCoverageWindInfluence = 0.750000F;
			_volNoiseWindInfluence = 1.000000F;
			_volDetailWindInfluence = 1.250000F;
			_volDistantFogOpacity = 1.000000F;
		}
	}
}
