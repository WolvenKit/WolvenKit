using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VolumetricFogAreaSettings : IAreaSettings
	{
		private curveData<HDRColor> _albedo;
		private curveData<CFloat> _range;
		private curveData<CFloat> _fogHeight;
		private curveData<CFloat> _fogHeightFalloff;
		private curveData<CFloat> _fogHeightMaxCut;
		private curveData<CFloat> _density;
		private curveData<CFloat> _absorption;
		private curveData<CFloat> _ambientScale;
		private curveData<CFloat> _localAmbientScale;
		private curveData<CFloat> _globalLightScale;
		private curveData<CFloat> _globalLightAnisotropy;
		private curveData<CFloat> _globalLightAnisotropyBase;
		private curveData<CFloat> _globalLightAnisotropyScale;
		private curveData<CFloat> _localLightRange;
		private curveData<CFloat> _localLightScale;
		private curveData<HDRColor> _distantAlbedo;
		private curveData<CFloat> _distantGlobalLightScale;
		private curveData<CFloat> _distantGroundIrradiance;
		private curveData<CFloat> _distantGroundSaturation;
		private curveData<CFloat> _distantSkyIrradiance;
		private curveData<CFloat> _distantShadowAmbientDarkening;

		[Ordinal(2)] 
		[RED("albedo")] 
		public curveData<HDRColor> Albedo
		{
			get
			{
				if (_albedo == null)
				{
					_albedo = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "albedo", cr2w, this);
				}
				return _albedo;
			}
			set
			{
				if (_albedo == value)
				{
					return;
				}
				_albedo = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("range")] 
		public curveData<CFloat> Range
		{
			get
			{
				if (_range == null)
				{
					_range = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fogHeight")] 
		public curveData<CFloat> FogHeight
		{
			get
			{
				if (_fogHeight == null)
				{
					_fogHeight = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "fogHeight", cr2w, this);
				}
				return _fogHeight;
			}
			set
			{
				if (_fogHeight == value)
				{
					return;
				}
				_fogHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fogHeightFalloff")] 
		public curveData<CFloat> FogHeightFalloff
		{
			get
			{
				if (_fogHeightFalloff == null)
				{
					_fogHeightFalloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "fogHeightFalloff", cr2w, this);
				}
				return _fogHeightFalloff;
			}
			set
			{
				if (_fogHeightFalloff == value)
				{
					return;
				}
				_fogHeightFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fogHeightMaxCut")] 
		public curveData<CFloat> FogHeightMaxCut
		{
			get
			{
				if (_fogHeightMaxCut == null)
				{
					_fogHeightMaxCut = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "fogHeightMaxCut", cr2w, this);
				}
				return _fogHeightMaxCut;
			}
			set
			{
				if (_fogHeightMaxCut == value)
				{
					return;
				}
				_fogHeightMaxCut = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("density")] 
		public curveData<CFloat> Density
		{
			get
			{
				if (_density == null)
				{
					_density = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "density", cr2w, this);
				}
				return _density;
			}
			set
			{
				if (_density == value)
				{
					return;
				}
				_density = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("absorption")] 
		public curveData<CFloat> Absorption
		{
			get
			{
				if (_absorption == null)
				{
					_absorption = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "absorption", cr2w, this);
				}
				return _absorption;
			}
			set
			{
				if (_absorption == value)
				{
					return;
				}
				_absorption = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ambientScale")] 
		public curveData<CFloat> AmbientScale
		{
			get
			{
				if (_ambientScale == null)
				{
					_ambientScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "ambientScale", cr2w, this);
				}
				return _ambientScale;
			}
			set
			{
				if (_ambientScale == value)
				{
					return;
				}
				_ambientScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("localAmbientScale")] 
		public curveData<CFloat> LocalAmbientScale
		{
			get
			{
				if (_localAmbientScale == null)
				{
					_localAmbientScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "localAmbientScale", cr2w, this);
				}
				return _localAmbientScale;
			}
			set
			{
				if (_localAmbientScale == value)
				{
					return;
				}
				_localAmbientScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("globalLightScale")] 
		public curveData<CFloat> GlobalLightScale
		{
			get
			{
				if (_globalLightScale == null)
				{
					_globalLightScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "globalLightScale", cr2w, this);
				}
				return _globalLightScale;
			}
			set
			{
				if (_globalLightScale == value)
				{
					return;
				}
				_globalLightScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("globalLightAnisotropy")] 
		public curveData<CFloat> GlobalLightAnisotropy
		{
			get
			{
				if (_globalLightAnisotropy == null)
				{
					_globalLightAnisotropy = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "globalLightAnisotropy", cr2w, this);
				}
				return _globalLightAnisotropy;
			}
			set
			{
				if (_globalLightAnisotropy == value)
				{
					return;
				}
				_globalLightAnisotropy = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("globalLightAnisotropyBase")] 
		public curveData<CFloat> GlobalLightAnisotropyBase
		{
			get
			{
				if (_globalLightAnisotropyBase == null)
				{
					_globalLightAnisotropyBase = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "globalLightAnisotropyBase", cr2w, this);
				}
				return _globalLightAnisotropyBase;
			}
			set
			{
				if (_globalLightAnisotropyBase == value)
				{
					return;
				}
				_globalLightAnisotropyBase = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("globalLightAnisotropyScale")] 
		public curveData<CFloat> GlobalLightAnisotropyScale
		{
			get
			{
				if (_globalLightAnisotropyScale == null)
				{
					_globalLightAnisotropyScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "globalLightAnisotropyScale", cr2w, this);
				}
				return _globalLightAnisotropyScale;
			}
			set
			{
				if (_globalLightAnisotropyScale == value)
				{
					return;
				}
				_globalLightAnisotropyScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("localLightRange")] 
		public curveData<CFloat> LocalLightRange
		{
			get
			{
				if (_localLightRange == null)
				{
					_localLightRange = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "localLightRange", cr2w, this);
				}
				return _localLightRange;
			}
			set
			{
				if (_localLightRange == value)
				{
					return;
				}
				_localLightRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("localLightScale")] 
		public curveData<CFloat> LocalLightScale
		{
			get
			{
				if (_localLightScale == null)
				{
					_localLightScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "localLightScale", cr2w, this);
				}
				return _localLightScale;
			}
			set
			{
				if (_localLightScale == value)
				{
					return;
				}
				_localLightScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("distantAlbedo")] 
		public curveData<HDRColor> DistantAlbedo
		{
			get
			{
				if (_distantAlbedo == null)
				{
					_distantAlbedo = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "distantAlbedo", cr2w, this);
				}
				return _distantAlbedo;
			}
			set
			{
				if (_distantAlbedo == value)
				{
					return;
				}
				_distantAlbedo = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("distantGlobalLightScale")] 
		public curveData<CFloat> DistantGlobalLightScale
		{
			get
			{
				if (_distantGlobalLightScale == null)
				{
					_distantGlobalLightScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "distantGlobalLightScale", cr2w, this);
				}
				return _distantGlobalLightScale;
			}
			set
			{
				if (_distantGlobalLightScale == value)
				{
					return;
				}
				_distantGlobalLightScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("distantGroundIrradiance")] 
		public curveData<CFloat> DistantGroundIrradiance
		{
			get
			{
				if (_distantGroundIrradiance == null)
				{
					_distantGroundIrradiance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "distantGroundIrradiance", cr2w, this);
				}
				return _distantGroundIrradiance;
			}
			set
			{
				if (_distantGroundIrradiance == value)
				{
					return;
				}
				_distantGroundIrradiance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("distantGroundSaturation")] 
		public curveData<CFloat> DistantGroundSaturation
		{
			get
			{
				if (_distantGroundSaturation == null)
				{
					_distantGroundSaturation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "distantGroundSaturation", cr2w, this);
				}
				return _distantGroundSaturation;
			}
			set
			{
				if (_distantGroundSaturation == value)
				{
					return;
				}
				_distantGroundSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("distantSkyIrradiance")] 
		public curveData<CFloat> DistantSkyIrradiance
		{
			get
			{
				if (_distantSkyIrradiance == null)
				{
					_distantSkyIrradiance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "distantSkyIrradiance", cr2w, this);
				}
				return _distantSkyIrradiance;
			}
			set
			{
				if (_distantSkyIrradiance == value)
				{
					return;
				}
				_distantSkyIrradiance = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("distantShadowAmbientDarkening")] 
		public curveData<CFloat> DistantShadowAmbientDarkening
		{
			get
			{
				if (_distantShadowAmbientDarkening == null)
				{
					_distantShadowAmbientDarkening = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "distantShadowAmbientDarkening", cr2w, this);
				}
				return _distantShadowAmbientDarkening;
			}
			set
			{
				if (_distantShadowAmbientDarkening == value)
				{
					return;
				}
				_distantShadowAmbientDarkening = value;
				PropertySet(this);
			}
		}

		public VolumetricFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
