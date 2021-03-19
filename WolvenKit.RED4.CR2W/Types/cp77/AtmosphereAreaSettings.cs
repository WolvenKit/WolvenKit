using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AtmosphereAreaSettings : IAreaSettings
	{
		private curveData<HDRColor> _skydomeColor;
		private curveData<HDRColor> _skylightColor;
		private curveData<HDRColor> _groundReflectance;
		private curveData<CFloat> _sunMinZ;
		private curveData<CFloat> _horizonMinZ;
		private curveData<CFloat> _horizonFalloff;
		private curveData<CFloat> _turbidity;
		private curveData<CFloat> _lutTurbidity;
		private curveData<HDRColor> _artisticDarkeningColor;
		private curveData<CFloat> _artisticDarkeningStartPoint;
		private curveData<CFloat> _artisticDarkeningEndPoint;
		private curveData<CFloat> _artisticDarkeningExponent;
		private curveData<HDRColor> _sunColor;
		private curveData<CFloat> _sunFalloff;
		private curveData<CFloat> _rayTracedSunShadowRange;
		private curveData<HDRColor> _moonColor;
		private curveData<CFloat> _moonFalloff;
		private curveData<CFloat> _moonGlowIntensity;
		private curveData<CFloat> _moonGlowFalloff;
		private rRef<CBitmapTexture> _moonTexture;
		private curveData<CFloat> _galaxyIntensity;
		private curveData<CFloat> _starMapIntensity;
		private curveData<CFloat> _starMapBrightScale;
		private curveData<CFloat> _starMapDimScale;
		private curveData<CFloat> _starMapConstelationsScale;
		private curveData<CFloat> _starCornerLuminanceFix;
		private rRef<CCubeTexture> _starMapTexture;
		private rRef<CBitmapTexture> _galaxyTexture;
		private curveData<HDRColor> _probeColorOverrideHorizon;
		private curveData<CFloat> _probeAlphaOverrideHorizon;
		private curveData<HDRColor> _probeColorOverrideZenith;
		private curveData<CFloat> _probeAlphaOverrideZenith;
		private curveData<CFloat> _cloudSunShadowFaloff;
		private curveData<CFloat> _cloudSunScattering;
		private curveData<CFloat> _cloudMoonScattering;
		private curveData<CFloat> _cloudAmbientIntensity;
		private curveData<CFloat> _cloudCirrusOpacity;
		private curveData<CFloat> _cloudCirrusScale;
		private curveData<CFloat> _cloudCirrusAltitude;
		private rRef<CBitmapTexture> _cloudCirrusTexture;
		private rRef<CBitmapTexture> _volWeatherTexture;
		private rRef<CBitmapTexture> _volNoiseTexture;
		private CFloat _volHorizonCoverage;
		private curveData<CFloat> _volCoverage;
		private curveData<CFloat> _volDensity;
		private CFloat _cloudsBottom;
		private CFloat _cloudsTop;
		private CFloat _rayStartOffset;
		private CFloat _rayStartFalloff;
		private curveData<CFloat> _lightIntensity;
		private curveData<CFloat> _reflectionProbeLightIntensity;
		private curveData<CFloat> _shadowIntensity;
		private curveData<CFloat> _worldShadowIntensity;
		private curveData<CFloat> _ambientIntensity;
		private curveData<CFloat> _ambientOutscatter;
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
		public curveData<HDRColor> SkydomeColor
		{
			get => GetProperty(ref _skydomeColor);
			set => SetProperty(ref _skydomeColor, value);
		}

		[Ordinal(3)] 
		[RED("skylightColor")] 
		public curveData<HDRColor> SkylightColor
		{
			get => GetProperty(ref _skylightColor);
			set => SetProperty(ref _skylightColor, value);
		}

		[Ordinal(4)] 
		[RED("groundReflectance")] 
		public curveData<HDRColor> GroundReflectance
		{
			get => GetProperty(ref _groundReflectance);
			set => SetProperty(ref _groundReflectance, value);
		}

		[Ordinal(5)] 
		[RED("sunMinZ")] 
		public curveData<CFloat> SunMinZ
		{
			get => GetProperty(ref _sunMinZ);
			set => SetProperty(ref _sunMinZ, value);
		}

		[Ordinal(6)] 
		[RED("horizonMinZ")] 
		public curveData<CFloat> HorizonMinZ
		{
			get => GetProperty(ref _horizonMinZ);
			set => SetProperty(ref _horizonMinZ, value);
		}

		[Ordinal(7)] 
		[RED("horizonFalloff")] 
		public curveData<CFloat> HorizonFalloff
		{
			get => GetProperty(ref _horizonFalloff);
			set => SetProperty(ref _horizonFalloff, value);
		}

		[Ordinal(8)] 
		[RED("turbidity")] 
		public curveData<CFloat> Turbidity
		{
			get => GetProperty(ref _turbidity);
			set => SetProperty(ref _turbidity, value);
		}

		[Ordinal(9)] 
		[RED("lutTurbidity")] 
		public curveData<CFloat> LutTurbidity
		{
			get => GetProperty(ref _lutTurbidity);
			set => SetProperty(ref _lutTurbidity, value);
		}

		[Ordinal(10)] 
		[RED("artisticDarkeningColor")] 
		public curveData<HDRColor> ArtisticDarkeningColor
		{
			get => GetProperty(ref _artisticDarkeningColor);
			set => SetProperty(ref _artisticDarkeningColor, value);
		}

		[Ordinal(11)] 
		[RED("artisticDarkeningStartPoint")] 
		public curveData<CFloat> ArtisticDarkeningStartPoint
		{
			get => GetProperty(ref _artisticDarkeningStartPoint);
			set => SetProperty(ref _artisticDarkeningStartPoint, value);
		}

		[Ordinal(12)] 
		[RED("artisticDarkeningEndPoint")] 
		public curveData<CFloat> ArtisticDarkeningEndPoint
		{
			get => GetProperty(ref _artisticDarkeningEndPoint);
			set => SetProperty(ref _artisticDarkeningEndPoint, value);
		}

		[Ordinal(13)] 
		[RED("artisticDarkeningExponent")] 
		public curveData<CFloat> ArtisticDarkeningExponent
		{
			get => GetProperty(ref _artisticDarkeningExponent);
			set => SetProperty(ref _artisticDarkeningExponent, value);
		}

		[Ordinal(14)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(15)] 
		[RED("sunFalloff")] 
		public curveData<CFloat> SunFalloff
		{
			get => GetProperty(ref _sunFalloff);
			set => SetProperty(ref _sunFalloff, value);
		}

		[Ordinal(16)] 
		[RED("rayTracedSunShadowRange")] 
		public curveData<CFloat> RayTracedSunShadowRange
		{
			get => GetProperty(ref _rayTracedSunShadowRange);
			set => SetProperty(ref _rayTracedSunShadowRange, value);
		}

		[Ordinal(17)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(18)] 
		[RED("moonFalloff")] 
		public curveData<CFloat> MoonFalloff
		{
			get => GetProperty(ref _moonFalloff);
			set => SetProperty(ref _moonFalloff, value);
		}

		[Ordinal(19)] 
		[RED("moonGlowIntensity")] 
		public curveData<CFloat> MoonGlowIntensity
		{
			get => GetProperty(ref _moonGlowIntensity);
			set => SetProperty(ref _moonGlowIntensity, value);
		}

		[Ordinal(20)] 
		[RED("moonGlowFalloff")] 
		public curveData<CFloat> MoonGlowFalloff
		{
			get => GetProperty(ref _moonGlowFalloff);
			set => SetProperty(ref _moonGlowFalloff, value);
		}

		[Ordinal(21)] 
		[RED("moonTexture")] 
		public rRef<CBitmapTexture> MoonTexture
		{
			get => GetProperty(ref _moonTexture);
			set => SetProperty(ref _moonTexture, value);
		}

		[Ordinal(22)] 
		[RED("galaxyIntensity")] 
		public curveData<CFloat> GalaxyIntensity
		{
			get => GetProperty(ref _galaxyIntensity);
			set => SetProperty(ref _galaxyIntensity, value);
		}

		[Ordinal(23)] 
		[RED("starMapIntensity")] 
		public curveData<CFloat> StarMapIntensity
		{
			get => GetProperty(ref _starMapIntensity);
			set => SetProperty(ref _starMapIntensity, value);
		}

		[Ordinal(24)] 
		[RED("starMapBrightScale")] 
		public curveData<CFloat> StarMapBrightScale
		{
			get => GetProperty(ref _starMapBrightScale);
			set => SetProperty(ref _starMapBrightScale, value);
		}

		[Ordinal(25)] 
		[RED("starMapDimScale")] 
		public curveData<CFloat> StarMapDimScale
		{
			get => GetProperty(ref _starMapDimScale);
			set => SetProperty(ref _starMapDimScale, value);
		}

		[Ordinal(26)] 
		[RED("starMapConstelationsScale")] 
		public curveData<CFloat> StarMapConstelationsScale
		{
			get => GetProperty(ref _starMapConstelationsScale);
			set => SetProperty(ref _starMapConstelationsScale, value);
		}

		[Ordinal(27)] 
		[RED("starCornerLuminanceFix")] 
		public curveData<CFloat> StarCornerLuminanceFix
		{
			get => GetProperty(ref _starCornerLuminanceFix);
			set => SetProperty(ref _starCornerLuminanceFix, value);
		}

		[Ordinal(28)] 
		[RED("starMapTexture")] 
		public rRef<CCubeTexture> StarMapTexture
		{
			get => GetProperty(ref _starMapTexture);
			set => SetProperty(ref _starMapTexture, value);
		}

		[Ordinal(29)] 
		[RED("galaxyTexture")] 
		public rRef<CBitmapTexture> GalaxyTexture
		{
			get => GetProperty(ref _galaxyTexture);
			set => SetProperty(ref _galaxyTexture, value);
		}

		[Ordinal(30)] 
		[RED("probeColorOverrideHorizon")] 
		public curveData<HDRColor> ProbeColorOverrideHorizon
		{
			get => GetProperty(ref _probeColorOverrideHorizon);
			set => SetProperty(ref _probeColorOverrideHorizon, value);
		}

		[Ordinal(31)] 
		[RED("probeAlphaOverrideHorizon")] 
		public curveData<CFloat> ProbeAlphaOverrideHorizon
		{
			get => GetProperty(ref _probeAlphaOverrideHorizon);
			set => SetProperty(ref _probeAlphaOverrideHorizon, value);
		}

		[Ordinal(32)] 
		[RED("probeColorOverrideZenith")] 
		public curveData<HDRColor> ProbeColorOverrideZenith
		{
			get => GetProperty(ref _probeColorOverrideZenith);
			set => SetProperty(ref _probeColorOverrideZenith, value);
		}

		[Ordinal(33)] 
		[RED("probeAlphaOverrideZenith")] 
		public curveData<CFloat> ProbeAlphaOverrideZenith
		{
			get => GetProperty(ref _probeAlphaOverrideZenith);
			set => SetProperty(ref _probeAlphaOverrideZenith, value);
		}

		[Ordinal(34)] 
		[RED("cloudSunShadowFaloff")] 
		public curveData<CFloat> CloudSunShadowFaloff
		{
			get => GetProperty(ref _cloudSunShadowFaloff);
			set => SetProperty(ref _cloudSunShadowFaloff, value);
		}

		[Ordinal(35)] 
		[RED("cloudSunScattering")] 
		public curveData<CFloat> CloudSunScattering
		{
			get => GetProperty(ref _cloudSunScattering);
			set => SetProperty(ref _cloudSunScattering, value);
		}

		[Ordinal(36)] 
		[RED("cloudMoonScattering")] 
		public curveData<CFloat> CloudMoonScattering
		{
			get => GetProperty(ref _cloudMoonScattering);
			set => SetProperty(ref _cloudMoonScattering, value);
		}

		[Ordinal(37)] 
		[RED("cloudAmbientIntensity")] 
		public curveData<CFloat> CloudAmbientIntensity
		{
			get => GetProperty(ref _cloudAmbientIntensity);
			set => SetProperty(ref _cloudAmbientIntensity, value);
		}

		[Ordinal(38)] 
		[RED("cloudCirrusOpacity")] 
		public curveData<CFloat> CloudCirrusOpacity
		{
			get => GetProperty(ref _cloudCirrusOpacity);
			set => SetProperty(ref _cloudCirrusOpacity, value);
		}

		[Ordinal(39)] 
		[RED("cloudCirrusScale")] 
		public curveData<CFloat> CloudCirrusScale
		{
			get => GetProperty(ref _cloudCirrusScale);
			set => SetProperty(ref _cloudCirrusScale, value);
		}

		[Ordinal(40)] 
		[RED("cloudCirrusAltitude")] 
		public curveData<CFloat> CloudCirrusAltitude
		{
			get => GetProperty(ref _cloudCirrusAltitude);
			set => SetProperty(ref _cloudCirrusAltitude, value);
		}

		[Ordinal(41)] 
		[RED("cloudCirrusTexture")] 
		public rRef<CBitmapTexture> CloudCirrusTexture
		{
			get => GetProperty(ref _cloudCirrusTexture);
			set => SetProperty(ref _cloudCirrusTexture, value);
		}

		[Ordinal(42)] 
		[RED("volWeatherTexture")] 
		public rRef<CBitmapTexture> VolWeatherTexture
		{
			get => GetProperty(ref _volWeatherTexture);
			set => SetProperty(ref _volWeatherTexture, value);
		}

		[Ordinal(43)] 
		[RED("volNoiseTexture")] 
		public rRef<CBitmapTexture> VolNoiseTexture
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
		public curveData<CFloat> VolCoverage
		{
			get => GetProperty(ref _volCoverage);
			set => SetProperty(ref _volCoverage, value);
		}

		[Ordinal(46)] 
		[RED("volDensity")] 
		public curveData<CFloat> VolDensity
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
		public curveData<CFloat> LightIntensity
		{
			get => GetProperty(ref _lightIntensity);
			set => SetProperty(ref _lightIntensity, value);
		}

		[Ordinal(52)] 
		[RED("reflectionProbeLightIntensity")] 
		public curveData<CFloat> ReflectionProbeLightIntensity
		{
			get => GetProperty(ref _reflectionProbeLightIntensity);
			set => SetProperty(ref _reflectionProbeLightIntensity, value);
		}

		[Ordinal(53)] 
		[RED("shadowIntensity")] 
		public curveData<CFloat> ShadowIntensity
		{
			get => GetProperty(ref _shadowIntensity);
			set => SetProperty(ref _shadowIntensity, value);
		}

		[Ordinal(54)] 
		[RED("worldShadowIntensity")] 
		public curveData<CFloat> WorldShadowIntensity
		{
			get => GetProperty(ref _worldShadowIntensity);
			set => SetProperty(ref _worldShadowIntensity, value);
		}

		[Ordinal(55)] 
		[RED("ambientIntensity")] 
		public curveData<CFloat> AmbientIntensity
		{
			get => GetProperty(ref _ambientIntensity);
			set => SetProperty(ref _ambientIntensity, value);
		}

		[Ordinal(56)] 
		[RED("ambientOutscatter")] 
		public curveData<CFloat> AmbientOutscatter
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

		public AtmosphereAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
