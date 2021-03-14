using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantFogAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _range;
		private curveData<HDRColor> _albedoNear;
		private curveData<HDRColor> _albedoFar;
		private curveData<CFloat> _nearDistance;
		private curveData<CFloat> _farDistance;
		private curveData<CFloat> _density;
		private curveData<CFloat> _height;
		private curveData<CFloat> _heightFallof;
		private curveData<CFloat> _densitySecond;
		private curveData<CFloat> _heightSecond;
		private curveData<CFloat> _heightFallofSecond;
		private curveData<HDRColor> _simpleColor;
		private curveData<CFloat> _simpleDensity;
		private curveData<HDRColor> _envProbeColor;
		private curveData<CFloat> _envProbeDensity;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("albedoNear")] 
		public curveData<HDRColor> AlbedoNear
		{
			get
			{
				if (_albedoNear == null)
				{
					_albedoNear = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "albedoNear", cr2w, this);
				}
				return _albedoNear;
			}
			set
			{
				if (_albedoNear == value)
				{
					return;
				}
				_albedoNear = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("albedoFar")] 
		public curveData<HDRColor> AlbedoFar
		{
			get
			{
				if (_albedoFar == null)
				{
					_albedoFar = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "albedoFar", cr2w, this);
				}
				return _albedoFar;
			}
			set
			{
				if (_albedoFar == value)
				{
					return;
				}
				_albedoFar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("nearDistance")] 
		public curveData<CFloat> NearDistance
		{
			get
			{
				if (_nearDistance == null)
				{
					_nearDistance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "nearDistance", cr2w, this);
				}
				return _nearDistance;
			}
			set
			{
				if (_nearDistance == value)
				{
					return;
				}
				_nearDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("farDistance")] 
		public curveData<CFloat> FarDistance
		{
			get
			{
				if (_farDistance == null)
				{
					_farDistance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "farDistance", cr2w, this);
				}
				return _farDistance;
			}
			set
			{
				if (_farDistance == value)
				{
					return;
				}
				_farDistance = value;
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
		[RED("height")] 
		public curveData<CFloat> Height
		{
			get
			{
				if (_height == null)
				{
					_height = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("heightFallof")] 
		public curveData<CFloat> HeightFallof
		{
			get
			{
				if (_heightFallof == null)
				{
					_heightFallof = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "heightFallof", cr2w, this);
				}
				return _heightFallof;
			}
			set
			{
				if (_heightFallof == value)
				{
					return;
				}
				_heightFallof = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("densitySecond")] 
		public curveData<CFloat> DensitySecond
		{
			get
			{
				if (_densitySecond == null)
				{
					_densitySecond = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "densitySecond", cr2w, this);
				}
				return _densitySecond;
			}
			set
			{
				if (_densitySecond == value)
				{
					return;
				}
				_densitySecond = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("heightSecond")] 
		public curveData<CFloat> HeightSecond
		{
			get
			{
				if (_heightSecond == null)
				{
					_heightSecond = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "heightSecond", cr2w, this);
				}
				return _heightSecond;
			}
			set
			{
				if (_heightSecond == value)
				{
					return;
				}
				_heightSecond = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("heightFallofSecond")] 
		public curveData<CFloat> HeightFallofSecond
		{
			get
			{
				if (_heightFallofSecond == null)
				{
					_heightFallofSecond = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "heightFallofSecond", cr2w, this);
				}
				return _heightFallofSecond;
			}
			set
			{
				if (_heightFallofSecond == value)
				{
					return;
				}
				_heightFallofSecond = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("simpleColor")] 
		public curveData<HDRColor> SimpleColor
		{
			get
			{
				if (_simpleColor == null)
				{
					_simpleColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "simpleColor", cr2w, this);
				}
				return _simpleColor;
			}
			set
			{
				if (_simpleColor == value)
				{
					return;
				}
				_simpleColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("simpleDensity")] 
		public curveData<CFloat> SimpleDensity
		{
			get
			{
				if (_simpleDensity == null)
				{
					_simpleDensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "simpleDensity", cr2w, this);
				}
				return _simpleDensity;
			}
			set
			{
				if (_simpleDensity == value)
				{
					return;
				}
				_simpleDensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("envProbeColor")] 
		public curveData<HDRColor> EnvProbeColor
		{
			get
			{
				if (_envProbeColor == null)
				{
					_envProbeColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "envProbeColor", cr2w, this);
				}
				return _envProbeColor;
			}
			set
			{
				if (_envProbeColor == value)
				{
					return;
				}
				_envProbeColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("envProbeDensity")] 
		public curveData<CFloat> EnvProbeDensity
		{
			get
			{
				if (_envProbeDensity == null)
				{
					_envProbeDensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "envProbeDensity", cr2w, this);
				}
				return _envProbeDensity;
			}
			set
			{
				if (_envProbeDensity == value)
				{
					return;
				}
				_envProbeDensity = value;
				PropertySet(this);
			}
		}

		public DistantFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
