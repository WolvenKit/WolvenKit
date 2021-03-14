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
			get
			{
				if (_skydomeColor == null)
				{
					_skydomeColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "skydomeColor", cr2w, this);
				}
				return _skydomeColor;
			}
			set
			{
				if (_skydomeColor == value)
				{
					return;
				}
				_skydomeColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skylightColor")] 
		public curveData<HDRColor> SkylightColor
		{
			get
			{
				if (_skylightColor == null)
				{
					_skylightColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "skylightColor", cr2w, this);
				}
				return _skylightColor;
			}
			set
			{
				if (_skylightColor == value)
				{
					return;
				}
				_skylightColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("groundReflectance")] 
		public curveData<HDRColor> GroundReflectance
		{
			get
			{
				if (_groundReflectance == null)
				{
					_groundReflectance = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "groundReflectance", cr2w, this);
				}
				return _groundReflectance;
			}
			set
			{
				if (_groundReflectance == value)
				{
					return;
				}
				_groundReflectance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sunMinZ")] 
		public curveData<CFloat> SunMinZ
		{
			get
			{
				if (_sunMinZ == null)
				{
					_sunMinZ = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "sunMinZ", cr2w, this);
				}
				return _sunMinZ;
			}
			set
			{
				if (_sunMinZ == value)
				{
					return;
				}
				_sunMinZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("horizonMinZ")] 
		public curveData<CFloat> HorizonMinZ
		{
			get
			{
				if (_horizonMinZ == null)
				{
					_horizonMinZ = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "horizonMinZ", cr2w, this);
				}
				return _horizonMinZ;
			}
			set
			{
				if (_horizonMinZ == value)
				{
					return;
				}
				_horizonMinZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("horizonFalloff")] 
		public curveData<CFloat> HorizonFalloff
		{
			get
			{
				if (_horizonFalloff == null)
				{
					_horizonFalloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "horizonFalloff", cr2w, this);
				}
				return _horizonFalloff;
			}
			set
			{
				if (_horizonFalloff == value)
				{
					return;
				}
				_horizonFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("turbidity")] 
		public curveData<CFloat> Turbidity
		{
			get
			{
				if (_turbidity == null)
				{
					_turbidity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "turbidity", cr2w, this);
				}
				return _turbidity;
			}
			set
			{
				if (_turbidity == value)
				{
					return;
				}
				_turbidity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lutTurbidity")] 
		public curveData<CFloat> LutTurbidity
		{
			get
			{
				if (_lutTurbidity == null)
				{
					_lutTurbidity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lutTurbidity", cr2w, this);
				}
				return _lutTurbidity;
			}
			set
			{
				if (_lutTurbidity == value)
				{
					return;
				}
				_lutTurbidity = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("artisticDarkeningColor")] 
		public curveData<HDRColor> ArtisticDarkeningColor
		{
			get
			{
				if (_artisticDarkeningColor == null)
				{
					_artisticDarkeningColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "artisticDarkeningColor", cr2w, this);
				}
				return _artisticDarkeningColor;
			}
			set
			{
				if (_artisticDarkeningColor == value)
				{
					return;
				}
				_artisticDarkeningColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("artisticDarkeningStartPoint")] 
		public curveData<CFloat> ArtisticDarkeningStartPoint
		{
			get
			{
				if (_artisticDarkeningStartPoint == null)
				{
					_artisticDarkeningStartPoint = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "artisticDarkeningStartPoint", cr2w, this);
				}
				return _artisticDarkeningStartPoint;
			}
			set
			{
				if (_artisticDarkeningStartPoint == value)
				{
					return;
				}
				_artisticDarkeningStartPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("artisticDarkeningEndPoint")] 
		public curveData<CFloat> ArtisticDarkeningEndPoint
		{
			get
			{
				if (_artisticDarkeningEndPoint == null)
				{
					_artisticDarkeningEndPoint = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "artisticDarkeningEndPoint", cr2w, this);
				}
				return _artisticDarkeningEndPoint;
			}
			set
			{
				if (_artisticDarkeningEndPoint == value)
				{
					return;
				}
				_artisticDarkeningEndPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("artisticDarkeningExponent")] 
		public curveData<CFloat> ArtisticDarkeningExponent
		{
			get
			{
				if (_artisticDarkeningExponent == null)
				{
					_artisticDarkeningExponent = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "artisticDarkeningExponent", cr2w, this);
				}
				return _artisticDarkeningExponent;
			}
			set
			{
				if (_artisticDarkeningExponent == value)
				{
					return;
				}
				_artisticDarkeningExponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get
			{
				if (_sunColor == null)
				{
					_sunColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "sunColor", cr2w, this);
				}
				return _sunColor;
			}
			set
			{
				if (_sunColor == value)
				{
					return;
				}
				_sunColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("sunFalloff")] 
		public curveData<CFloat> SunFalloff
		{
			get
			{
				if (_sunFalloff == null)
				{
					_sunFalloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "sunFalloff", cr2w, this);
				}
				return _sunFalloff;
			}
			set
			{
				if (_sunFalloff == value)
				{
					return;
				}
				_sunFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("rayTracedSunShadowRange")] 
		public curveData<CFloat> RayTracedSunShadowRange
		{
			get
			{
				if (_rayTracedSunShadowRange == null)
				{
					_rayTracedSunShadowRange = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rayTracedSunShadowRange", cr2w, this);
				}
				return _rayTracedSunShadowRange;
			}
			set
			{
				if (_rayTracedSunShadowRange == value)
				{
					return;
				}
				_rayTracedSunShadowRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get
			{
				if (_moonColor == null)
				{
					_moonColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "moonColor", cr2w, this);
				}
				return _moonColor;
			}
			set
			{
				if (_moonColor == value)
				{
					return;
				}
				_moonColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("moonFalloff")] 
		public curveData<CFloat> MoonFalloff
		{
			get
			{
				if (_moonFalloff == null)
				{
					_moonFalloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "moonFalloff", cr2w, this);
				}
				return _moonFalloff;
			}
			set
			{
				if (_moonFalloff == value)
				{
					return;
				}
				_moonFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("moonGlowIntensity")] 
		public curveData<CFloat> MoonGlowIntensity
		{
			get
			{
				if (_moonGlowIntensity == null)
				{
					_moonGlowIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "moonGlowIntensity", cr2w, this);
				}
				return _moonGlowIntensity;
			}
			set
			{
				if (_moonGlowIntensity == value)
				{
					return;
				}
				_moonGlowIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("moonGlowFalloff")] 
		public curveData<CFloat> MoonGlowFalloff
		{
			get
			{
				if (_moonGlowFalloff == null)
				{
					_moonGlowFalloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "moonGlowFalloff", cr2w, this);
				}
				return _moonGlowFalloff;
			}
			set
			{
				if (_moonGlowFalloff == value)
				{
					return;
				}
				_moonGlowFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("moonTexture")] 
		public rRef<CBitmapTexture> MoonTexture
		{
			get
			{
				if (_moonTexture == null)
				{
					_moonTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "moonTexture", cr2w, this);
				}
				return _moonTexture;
			}
			set
			{
				if (_moonTexture == value)
				{
					return;
				}
				_moonTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("galaxyIntensity")] 
		public curveData<CFloat> GalaxyIntensity
		{
			get
			{
				if (_galaxyIntensity == null)
				{
					_galaxyIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "galaxyIntensity", cr2w, this);
				}
				return _galaxyIntensity;
			}
			set
			{
				if (_galaxyIntensity == value)
				{
					return;
				}
				_galaxyIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("starMapIntensity")] 
		public curveData<CFloat> StarMapIntensity
		{
			get
			{
				if (_starMapIntensity == null)
				{
					_starMapIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "starMapIntensity", cr2w, this);
				}
				return _starMapIntensity;
			}
			set
			{
				if (_starMapIntensity == value)
				{
					return;
				}
				_starMapIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("starMapBrightScale")] 
		public curveData<CFloat> StarMapBrightScale
		{
			get
			{
				if (_starMapBrightScale == null)
				{
					_starMapBrightScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "starMapBrightScale", cr2w, this);
				}
				return _starMapBrightScale;
			}
			set
			{
				if (_starMapBrightScale == value)
				{
					return;
				}
				_starMapBrightScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("starMapDimScale")] 
		public curveData<CFloat> StarMapDimScale
		{
			get
			{
				if (_starMapDimScale == null)
				{
					_starMapDimScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "starMapDimScale", cr2w, this);
				}
				return _starMapDimScale;
			}
			set
			{
				if (_starMapDimScale == value)
				{
					return;
				}
				_starMapDimScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("starMapConstelationsScale")] 
		public curveData<CFloat> StarMapConstelationsScale
		{
			get
			{
				if (_starMapConstelationsScale == null)
				{
					_starMapConstelationsScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "starMapConstelationsScale", cr2w, this);
				}
				return _starMapConstelationsScale;
			}
			set
			{
				if (_starMapConstelationsScale == value)
				{
					return;
				}
				_starMapConstelationsScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("starCornerLuminanceFix")] 
		public curveData<CFloat> StarCornerLuminanceFix
		{
			get
			{
				if (_starCornerLuminanceFix == null)
				{
					_starCornerLuminanceFix = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "starCornerLuminanceFix", cr2w, this);
				}
				return _starCornerLuminanceFix;
			}
			set
			{
				if (_starCornerLuminanceFix == value)
				{
					return;
				}
				_starCornerLuminanceFix = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("starMapTexture")] 
		public rRef<CCubeTexture> StarMapTexture
		{
			get
			{
				if (_starMapTexture == null)
				{
					_starMapTexture = (rRef<CCubeTexture>) CR2WTypeManager.Create("rRef:CCubeTexture", "starMapTexture", cr2w, this);
				}
				return _starMapTexture;
			}
			set
			{
				if (_starMapTexture == value)
				{
					return;
				}
				_starMapTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("galaxyTexture")] 
		public rRef<CBitmapTexture> GalaxyTexture
		{
			get
			{
				if (_galaxyTexture == null)
				{
					_galaxyTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "galaxyTexture", cr2w, this);
				}
				return _galaxyTexture;
			}
			set
			{
				if (_galaxyTexture == value)
				{
					return;
				}
				_galaxyTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("probeColorOverrideHorizon")] 
		public curveData<HDRColor> ProbeColorOverrideHorizon
		{
			get
			{
				if (_probeColorOverrideHorizon == null)
				{
					_probeColorOverrideHorizon = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "probeColorOverrideHorizon", cr2w, this);
				}
				return _probeColorOverrideHorizon;
			}
			set
			{
				if (_probeColorOverrideHorizon == value)
				{
					return;
				}
				_probeColorOverrideHorizon = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("probeAlphaOverrideHorizon")] 
		public curveData<CFloat> ProbeAlphaOverrideHorizon
		{
			get
			{
				if (_probeAlphaOverrideHorizon == null)
				{
					_probeAlphaOverrideHorizon = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "probeAlphaOverrideHorizon", cr2w, this);
				}
				return _probeAlphaOverrideHorizon;
			}
			set
			{
				if (_probeAlphaOverrideHorizon == value)
				{
					return;
				}
				_probeAlphaOverrideHorizon = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("probeColorOverrideZenith")] 
		public curveData<HDRColor> ProbeColorOverrideZenith
		{
			get
			{
				if (_probeColorOverrideZenith == null)
				{
					_probeColorOverrideZenith = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "probeColorOverrideZenith", cr2w, this);
				}
				return _probeColorOverrideZenith;
			}
			set
			{
				if (_probeColorOverrideZenith == value)
				{
					return;
				}
				_probeColorOverrideZenith = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("probeAlphaOverrideZenith")] 
		public curveData<CFloat> ProbeAlphaOverrideZenith
		{
			get
			{
				if (_probeAlphaOverrideZenith == null)
				{
					_probeAlphaOverrideZenith = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "probeAlphaOverrideZenith", cr2w, this);
				}
				return _probeAlphaOverrideZenith;
			}
			set
			{
				if (_probeAlphaOverrideZenith == value)
				{
					return;
				}
				_probeAlphaOverrideZenith = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("cloudSunShadowFaloff")] 
		public curveData<CFloat> CloudSunShadowFaloff
		{
			get
			{
				if (_cloudSunShadowFaloff == null)
				{
					_cloudSunShadowFaloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudSunShadowFaloff", cr2w, this);
				}
				return _cloudSunShadowFaloff;
			}
			set
			{
				if (_cloudSunShadowFaloff == value)
				{
					return;
				}
				_cloudSunShadowFaloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("cloudSunScattering")] 
		public curveData<CFloat> CloudSunScattering
		{
			get
			{
				if (_cloudSunScattering == null)
				{
					_cloudSunScattering = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudSunScattering", cr2w, this);
				}
				return _cloudSunScattering;
			}
			set
			{
				if (_cloudSunScattering == value)
				{
					return;
				}
				_cloudSunScattering = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("cloudMoonScattering")] 
		public curveData<CFloat> CloudMoonScattering
		{
			get
			{
				if (_cloudMoonScattering == null)
				{
					_cloudMoonScattering = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudMoonScattering", cr2w, this);
				}
				return _cloudMoonScattering;
			}
			set
			{
				if (_cloudMoonScattering == value)
				{
					return;
				}
				_cloudMoonScattering = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("cloudAmbientIntensity")] 
		public curveData<CFloat> CloudAmbientIntensity
		{
			get
			{
				if (_cloudAmbientIntensity == null)
				{
					_cloudAmbientIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudAmbientIntensity", cr2w, this);
				}
				return _cloudAmbientIntensity;
			}
			set
			{
				if (_cloudAmbientIntensity == value)
				{
					return;
				}
				_cloudAmbientIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("cloudCirrusOpacity")] 
		public curveData<CFloat> CloudCirrusOpacity
		{
			get
			{
				if (_cloudCirrusOpacity == null)
				{
					_cloudCirrusOpacity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudCirrusOpacity", cr2w, this);
				}
				return _cloudCirrusOpacity;
			}
			set
			{
				if (_cloudCirrusOpacity == value)
				{
					return;
				}
				_cloudCirrusOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("cloudCirrusScale")] 
		public curveData<CFloat> CloudCirrusScale
		{
			get
			{
				if (_cloudCirrusScale == null)
				{
					_cloudCirrusScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudCirrusScale", cr2w, this);
				}
				return _cloudCirrusScale;
			}
			set
			{
				if (_cloudCirrusScale == value)
				{
					return;
				}
				_cloudCirrusScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("cloudCirrusAltitude")] 
		public curveData<CFloat> CloudCirrusAltitude
		{
			get
			{
				if (_cloudCirrusAltitude == null)
				{
					_cloudCirrusAltitude = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "cloudCirrusAltitude", cr2w, this);
				}
				return _cloudCirrusAltitude;
			}
			set
			{
				if (_cloudCirrusAltitude == value)
				{
					return;
				}
				_cloudCirrusAltitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("cloudCirrusTexture")] 
		public rRef<CBitmapTexture> CloudCirrusTexture
		{
			get
			{
				if (_cloudCirrusTexture == null)
				{
					_cloudCirrusTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "cloudCirrusTexture", cr2w, this);
				}
				return _cloudCirrusTexture;
			}
			set
			{
				if (_cloudCirrusTexture == value)
				{
					return;
				}
				_cloudCirrusTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("volWeatherTexture")] 
		public rRef<CBitmapTexture> VolWeatherTexture
		{
			get
			{
				if (_volWeatherTexture == null)
				{
					_volWeatherTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "volWeatherTexture", cr2w, this);
				}
				return _volWeatherTexture;
			}
			set
			{
				if (_volWeatherTexture == value)
				{
					return;
				}
				_volWeatherTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("volNoiseTexture")] 
		public rRef<CBitmapTexture> VolNoiseTexture
		{
			get
			{
				if (_volNoiseTexture == null)
				{
					_volNoiseTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "volNoiseTexture", cr2w, this);
				}
				return _volNoiseTexture;
			}
			set
			{
				if (_volNoiseTexture == value)
				{
					return;
				}
				_volNoiseTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("volHorizonCoverage")] 
		public CFloat VolHorizonCoverage
		{
			get
			{
				if (_volHorizonCoverage == null)
				{
					_volHorizonCoverage = (CFloat) CR2WTypeManager.Create("Float", "volHorizonCoverage", cr2w, this);
				}
				return _volHorizonCoverage;
			}
			set
			{
				if (_volHorizonCoverage == value)
				{
					return;
				}
				_volHorizonCoverage = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("volCoverage")] 
		public curveData<CFloat> VolCoverage
		{
			get
			{
				if (_volCoverage == null)
				{
					_volCoverage = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "volCoverage", cr2w, this);
				}
				return _volCoverage;
			}
			set
			{
				if (_volCoverage == value)
				{
					return;
				}
				_volCoverage = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("volDensity")] 
		public curveData<CFloat> VolDensity
		{
			get
			{
				if (_volDensity == null)
				{
					_volDensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "volDensity", cr2w, this);
				}
				return _volDensity;
			}
			set
			{
				if (_volDensity == value)
				{
					return;
				}
				_volDensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("cloudsBottom")] 
		public CFloat CloudsBottom
		{
			get
			{
				if (_cloudsBottom == null)
				{
					_cloudsBottom = (CFloat) CR2WTypeManager.Create("Float", "cloudsBottom", cr2w, this);
				}
				return _cloudsBottom;
			}
			set
			{
				if (_cloudsBottom == value)
				{
					return;
				}
				_cloudsBottom = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("cloudsTop")] 
		public CFloat CloudsTop
		{
			get
			{
				if (_cloudsTop == null)
				{
					_cloudsTop = (CFloat) CR2WTypeManager.Create("Float", "cloudsTop", cr2w, this);
				}
				return _cloudsTop;
			}
			set
			{
				if (_cloudsTop == value)
				{
					return;
				}
				_cloudsTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("rayStartOffset")] 
		public CFloat RayStartOffset
		{
			get
			{
				if (_rayStartOffset == null)
				{
					_rayStartOffset = (CFloat) CR2WTypeManager.Create("Float", "rayStartOffset", cr2w, this);
				}
				return _rayStartOffset;
			}
			set
			{
				if (_rayStartOffset == value)
				{
					return;
				}
				_rayStartOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("rayStartFalloff")] 
		public CFloat RayStartFalloff
		{
			get
			{
				if (_rayStartFalloff == null)
				{
					_rayStartFalloff = (CFloat) CR2WTypeManager.Create("Float", "rayStartFalloff", cr2w, this);
				}
				return _rayStartFalloff;
			}
			set
			{
				if (_rayStartFalloff == value)
				{
					return;
				}
				_rayStartFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("lightIntensity")] 
		public curveData<CFloat> LightIntensity
		{
			get
			{
				if (_lightIntensity == null)
				{
					_lightIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lightIntensity", cr2w, this);
				}
				return _lightIntensity;
			}
			set
			{
				if (_lightIntensity == value)
				{
					return;
				}
				_lightIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("reflectionProbeLightIntensity")] 
		public curveData<CFloat> ReflectionProbeLightIntensity
		{
			get
			{
				if (_reflectionProbeLightIntensity == null)
				{
					_reflectionProbeLightIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "reflectionProbeLightIntensity", cr2w, this);
				}
				return _reflectionProbeLightIntensity;
			}
			set
			{
				if (_reflectionProbeLightIntensity == value)
				{
					return;
				}
				_reflectionProbeLightIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("shadowIntensity")] 
		public curveData<CFloat> ShadowIntensity
		{
			get
			{
				if (_shadowIntensity == null)
				{
					_shadowIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "shadowIntensity", cr2w, this);
				}
				return _shadowIntensity;
			}
			set
			{
				if (_shadowIntensity == value)
				{
					return;
				}
				_shadowIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("worldShadowIntensity")] 
		public curveData<CFloat> WorldShadowIntensity
		{
			get
			{
				if (_worldShadowIntensity == null)
				{
					_worldShadowIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "worldShadowIntensity", cr2w, this);
				}
				return _worldShadowIntensity;
			}
			set
			{
				if (_worldShadowIntensity == value)
				{
					return;
				}
				_worldShadowIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("ambientIntensity")] 
		public curveData<CFloat> AmbientIntensity
		{
			get
			{
				if (_ambientIntensity == null)
				{
					_ambientIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "ambientIntensity", cr2w, this);
				}
				return _ambientIntensity;
			}
			set
			{
				if (_ambientIntensity == value)
				{
					return;
				}
				_ambientIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("ambientOutscatter")] 
		public curveData<CFloat> AmbientOutscatter
		{
			get
			{
				if (_ambientOutscatter == null)
				{
					_ambientOutscatter = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "ambientOutscatter", cr2w, this);
				}
				return _ambientOutscatter;
			}
			set
			{
				if (_ambientOutscatter == value)
				{
					return;
				}
				_ambientOutscatter = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("inScatter")] 
		public CFloat InScatter
		{
			get
			{
				if (_inScatter == null)
				{
					_inScatter = (CFloat) CR2WTypeManager.Create("Float", "inScatter", cr2w, this);
				}
				return _inScatter;
			}
			set
			{
				if (_inScatter == value)
				{
					return;
				}
				_inScatter = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("outScatter")] 
		public CFloat OutScatter
		{
			get
			{
				if (_outScatter == null)
				{
					_outScatter = (CFloat) CR2WTypeManager.Create("Float", "outScatter", cr2w, this);
				}
				return _outScatter;
			}
			set
			{
				if (_outScatter == value)
				{
					return;
				}
				_outScatter = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("inVsOutScatter")] 
		public CFloat InVsOutScatter
		{
			get
			{
				if (_inVsOutScatter == null)
				{
					_inVsOutScatter = (CFloat) CR2WTypeManager.Create("Float", "inVsOutScatter", cr2w, this);
				}
				return _inVsOutScatter;
			}
			set
			{
				if (_inVsOutScatter == value)
				{
					return;
				}
				_inVsOutScatter = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("silverLining")] 
		public CFloat SilverLining
		{
			get
			{
				if (_silverLining == null)
				{
					_silverLining = (CFloat) CR2WTypeManager.Create("Float", "silverLining", cr2w, this);
				}
				return _silverLining;
			}
			set
			{
				if (_silverLining == value)
				{
					return;
				}
				_silverLining = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("volCoverageWindInfluence")] 
		public CFloat VolCoverageWindInfluence
		{
			get
			{
				if (_volCoverageWindInfluence == null)
				{
					_volCoverageWindInfluence = (CFloat) CR2WTypeManager.Create("Float", "volCoverageWindInfluence", cr2w, this);
				}
				return _volCoverageWindInfluence;
			}
			set
			{
				if (_volCoverageWindInfluence == value)
				{
					return;
				}
				_volCoverageWindInfluence = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("volNoiseWindInfluence")] 
		public CFloat VolNoiseWindInfluence
		{
			get
			{
				if (_volNoiseWindInfluence == null)
				{
					_volNoiseWindInfluence = (CFloat) CR2WTypeManager.Create("Float", "volNoiseWindInfluence", cr2w, this);
				}
				return _volNoiseWindInfluence;
			}
			set
			{
				if (_volNoiseWindInfluence == value)
				{
					return;
				}
				_volNoiseWindInfluence = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("volDetailWindInfluence")] 
		public CFloat VolDetailWindInfluence
		{
			get
			{
				if (_volDetailWindInfluence == null)
				{
					_volDetailWindInfluence = (CFloat) CR2WTypeManager.Create("Float", "volDetailWindInfluence", cr2w, this);
				}
				return _volDetailWindInfluence;
			}
			set
			{
				if (_volDetailWindInfluence == value)
				{
					return;
				}
				_volDetailWindInfluence = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("volDistantFogOpacity")] 
		public CFloat VolDistantFogOpacity
		{
			get
			{
				if (_volDistantFogOpacity == null)
				{
					_volDistantFogOpacity = (CFloat) CR2WTypeManager.Create("Float", "volDistantFogOpacity", cr2w, this);
				}
				return _volDistantFogOpacity;
			}
			set
			{
				if (_volDistantFogOpacity == value)
				{
					return;
				}
				_volDistantFogOpacity = value;
				PropertySet(this);
			}
		}

		public AtmosphereAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
