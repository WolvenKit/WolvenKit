using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RainAreaSettings : IAreaSettings
	{
		private CUInt32 _numParticles;
		private CFloat _radius;
		private CFloat _heightRange;
		private CFloat _globalLightResponse;
		private curveData<CFloat> _tiling;
		private curveData<CFloat> _speed;
		private CFloat _roughnessShift;
		private CFloat _roughnessClip;
		private CFloat _roughnessExponent;
		private CFloat _baseColorShift;
		private CFloat _baseColorClip;
		private CFloat _baseColorExponent;
		private CFloat _porosityThreshold;
		private CFloat _moistureAccumulationSpeed;
		private CFloat _puddlesAccumulationSpeed;
		private CFloat _moistureEvaporationSpeed;
		private CFloat _puddlesEvaporationSpeed;
		private curveData<CFloat> _rainIntensity;
		private curveData<CFloat> _rainOverride;
		private curveData<CFloat> _rainMoistureOverride;
		private curveData<CFloat> _rainPuddlesOverride;
		private rRef<CBitmapTexture> _rainleaksMask;
		private rRef<CBitmapTexture> _raindropsMask;
		private rRef<CBitmapTexture> _rainRipplesMask;

		[Ordinal(2)] 
		[RED("numParticles")] 
		public CUInt32 NumParticles
		{
			get
			{
				if (_numParticles == null)
				{
					_numParticles = (CUInt32) CR2WTypeManager.Create("Uint32", "numParticles", cr2w, this);
				}
				return _numParticles;
			}
			set
			{
				if (_numParticles == value)
				{
					return;
				}
				_numParticles = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("heightRange")] 
		public CFloat HeightRange
		{
			get
			{
				if (_heightRange == null)
				{
					_heightRange = (CFloat) CR2WTypeManager.Create("Float", "heightRange", cr2w, this);
				}
				return _heightRange;
			}
			set
			{
				if (_heightRange == value)
				{
					return;
				}
				_heightRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("globalLightResponse")] 
		public CFloat GlobalLightResponse
		{
			get
			{
				if (_globalLightResponse == null)
				{
					_globalLightResponse = (CFloat) CR2WTypeManager.Create("Float", "globalLightResponse", cr2w, this);
				}
				return _globalLightResponse;
			}
			set
			{
				if (_globalLightResponse == value)
				{
					return;
				}
				_globalLightResponse = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tiling")] 
		public curveData<CFloat> Tiling
		{
			get
			{
				if (_tiling == null)
				{
					_tiling = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "tiling", cr2w, this);
				}
				return _tiling;
			}
			set
			{
				if (_tiling == value)
				{
					return;
				}
				_tiling = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("speed")] 
		public curveData<CFloat> Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("roughnessShift")] 
		public CFloat RoughnessShift
		{
			get
			{
				if (_roughnessShift == null)
				{
					_roughnessShift = (CFloat) CR2WTypeManager.Create("Float", "roughnessShift", cr2w, this);
				}
				return _roughnessShift;
			}
			set
			{
				if (_roughnessShift == value)
				{
					return;
				}
				_roughnessShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("roughnessClip")] 
		public CFloat RoughnessClip
		{
			get
			{
				if (_roughnessClip == null)
				{
					_roughnessClip = (CFloat) CR2WTypeManager.Create("Float", "roughnessClip", cr2w, this);
				}
				return _roughnessClip;
			}
			set
			{
				if (_roughnessClip == value)
				{
					return;
				}
				_roughnessClip = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("roughnessExponent")] 
		public CFloat RoughnessExponent
		{
			get
			{
				if (_roughnessExponent == null)
				{
					_roughnessExponent = (CFloat) CR2WTypeManager.Create("Float", "roughnessExponent", cr2w, this);
				}
				return _roughnessExponent;
			}
			set
			{
				if (_roughnessExponent == value)
				{
					return;
				}
				_roughnessExponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("baseColorShift")] 
		public CFloat BaseColorShift
		{
			get
			{
				if (_baseColorShift == null)
				{
					_baseColorShift = (CFloat) CR2WTypeManager.Create("Float", "baseColorShift", cr2w, this);
				}
				return _baseColorShift;
			}
			set
			{
				if (_baseColorShift == value)
				{
					return;
				}
				_baseColorShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("baseColorClip")] 
		public CFloat BaseColorClip
		{
			get
			{
				if (_baseColorClip == null)
				{
					_baseColorClip = (CFloat) CR2WTypeManager.Create("Float", "baseColorClip", cr2w, this);
				}
				return _baseColorClip;
			}
			set
			{
				if (_baseColorClip == value)
				{
					return;
				}
				_baseColorClip = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("baseColorExponent")] 
		public CFloat BaseColorExponent
		{
			get
			{
				if (_baseColorExponent == null)
				{
					_baseColorExponent = (CFloat) CR2WTypeManager.Create("Float", "baseColorExponent", cr2w, this);
				}
				return _baseColorExponent;
			}
			set
			{
				if (_baseColorExponent == value)
				{
					return;
				}
				_baseColorExponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("porosityThreshold")] 
		public CFloat PorosityThreshold
		{
			get
			{
				if (_porosityThreshold == null)
				{
					_porosityThreshold = (CFloat) CR2WTypeManager.Create("Float", "porosityThreshold", cr2w, this);
				}
				return _porosityThreshold;
			}
			set
			{
				if (_porosityThreshold == value)
				{
					return;
				}
				_porosityThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("moistureAccumulationSpeed")] 
		public CFloat MoistureAccumulationSpeed
		{
			get
			{
				if (_moistureAccumulationSpeed == null)
				{
					_moistureAccumulationSpeed = (CFloat) CR2WTypeManager.Create("Float", "moistureAccumulationSpeed", cr2w, this);
				}
				return _moistureAccumulationSpeed;
			}
			set
			{
				if (_moistureAccumulationSpeed == value)
				{
					return;
				}
				_moistureAccumulationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("puddlesAccumulationSpeed")] 
		public CFloat PuddlesAccumulationSpeed
		{
			get
			{
				if (_puddlesAccumulationSpeed == null)
				{
					_puddlesAccumulationSpeed = (CFloat) CR2WTypeManager.Create("Float", "puddlesAccumulationSpeed", cr2w, this);
				}
				return _puddlesAccumulationSpeed;
			}
			set
			{
				if (_puddlesAccumulationSpeed == value)
				{
					return;
				}
				_puddlesAccumulationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("moistureEvaporationSpeed")] 
		public CFloat MoistureEvaporationSpeed
		{
			get
			{
				if (_moistureEvaporationSpeed == null)
				{
					_moistureEvaporationSpeed = (CFloat) CR2WTypeManager.Create("Float", "moistureEvaporationSpeed", cr2w, this);
				}
				return _moistureEvaporationSpeed;
			}
			set
			{
				if (_moistureEvaporationSpeed == value)
				{
					return;
				}
				_moistureEvaporationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("puddlesEvaporationSpeed")] 
		public CFloat PuddlesEvaporationSpeed
		{
			get
			{
				if (_puddlesEvaporationSpeed == null)
				{
					_puddlesEvaporationSpeed = (CFloat) CR2WTypeManager.Create("Float", "puddlesEvaporationSpeed", cr2w, this);
				}
				return _puddlesEvaporationSpeed;
			}
			set
			{
				if (_puddlesEvaporationSpeed == value)
				{
					return;
				}
				_puddlesEvaporationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rainIntensity")] 
		public curveData<CFloat> RainIntensity
		{
			get
			{
				if (_rainIntensity == null)
				{
					_rainIntensity = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rainIntensity", cr2w, this);
				}
				return _rainIntensity;
			}
			set
			{
				if (_rainIntensity == value)
				{
					return;
				}
				_rainIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("rainOverride")] 
		public curveData<CFloat> RainOverride
		{
			get
			{
				if (_rainOverride == null)
				{
					_rainOverride = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rainOverride", cr2w, this);
				}
				return _rainOverride;
			}
			set
			{
				if (_rainOverride == value)
				{
					return;
				}
				_rainOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rainMoistureOverride")] 
		public curveData<CFloat> RainMoistureOverride
		{
			get
			{
				if (_rainMoistureOverride == null)
				{
					_rainMoistureOverride = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rainMoistureOverride", cr2w, this);
				}
				return _rainMoistureOverride;
			}
			set
			{
				if (_rainMoistureOverride == value)
				{
					return;
				}
				_rainMoistureOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rainPuddlesOverride")] 
		public curveData<CFloat> RainPuddlesOverride
		{
			get
			{
				if (_rainPuddlesOverride == null)
				{
					_rainPuddlesOverride = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rainPuddlesOverride", cr2w, this);
				}
				return _rainPuddlesOverride;
			}
			set
			{
				if (_rainPuddlesOverride == value)
				{
					return;
				}
				_rainPuddlesOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("rainleaksMask")] 
		public rRef<CBitmapTexture> RainleaksMask
		{
			get
			{
				if (_rainleaksMask == null)
				{
					_rainleaksMask = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "rainleaksMask", cr2w, this);
				}
				return _rainleaksMask;
			}
			set
			{
				if (_rainleaksMask == value)
				{
					return;
				}
				_rainleaksMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("raindropsMask")] 
		public rRef<CBitmapTexture> RaindropsMask
		{
			get
			{
				if (_raindropsMask == null)
				{
					_raindropsMask = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "raindropsMask", cr2w, this);
				}
				return _raindropsMask;
			}
			set
			{
				if (_raindropsMask == value)
				{
					return;
				}
				_raindropsMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("rainRipplesMask")] 
		public rRef<CBitmapTexture> RainRipplesMask
		{
			get
			{
				if (_rainRipplesMask == null)
				{
					_rainRipplesMask = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "rainRipplesMask", cr2w, this);
				}
				return _rainRipplesMask;
			}
			set
			{
				if (_rainRipplesMask == value)
				{
					return;
				}
				_rainRipplesMask = value;
				PropertySet(this);
			}
		}

		public RainAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
