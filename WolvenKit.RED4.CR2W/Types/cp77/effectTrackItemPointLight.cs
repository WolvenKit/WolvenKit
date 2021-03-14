using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemPointLight : effectTrackItem
	{
		private effectEffectParameterEvaluatorColor _tint;
		private effectEffectParameterEvaluatorFloat _intensity;
		private CFloat _eV;
		private effectEffectParameterEvaluatorFloat _radius;
		private Vector3 _offset;
		private CColor _color;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CUInt8 _colorGroupSaturation;
		private CInt8 _roughnessBias;
		private CBool _useInGI;
		private CBool _useInVolFog;
		private CBool _useInTransparents;
		private CBool _useInParticles;
		private CBool _sceneDiffuse;
		private CBool _sceneSpecular;
		private CBool _clampAttenuation;
		private rendSLightFlickering _flicker;

		[Ordinal(3)] 
		[RED("tint")] 
		public effectEffectParameterEvaluatorColor Tint
		{
			get
			{
				if (_tint == null)
				{
					_tint = (effectEffectParameterEvaluatorColor) CR2WTypeManager.Create("effectEffectParameterEvaluatorColor", "tint", cr2w, this);
				}
				return _tint;
			}
			set
			{
				if (_tint == value)
				{
					return;
				}
				_tint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("EV")] 
		public CFloat EV
		{
			get
			{
				if (_eV == null)
				{
					_eV = (CFloat) CR2WTypeManager.Create("Float", "EV", cr2w, this);
				}
				return _eV;
			}
			set
			{
				if (_eV == value)
				{
					return;
				}
				_eV = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("radius")] 
		public effectEffectParameterEvaluatorFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "radius", cr2w, this);
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

		[Ordinal(7)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get
			{
				if (_envColorGroup == null)
				{
					_envColorGroup = (CEnum<EEnvColorGroup>) CR2WTypeManager.Create("EEnvColorGroup", "envColorGroup", cr2w, this);
				}
				return _envColorGroup;
			}
			set
			{
				if (_envColorGroup == value)
				{
					return;
				}
				_envColorGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("colorGroupSaturation")] 
		public CUInt8 ColorGroupSaturation
		{
			get
			{
				if (_colorGroupSaturation == null)
				{
					_colorGroupSaturation = (CUInt8) CR2WTypeManager.Create("Uint8", "colorGroupSaturation", cr2w, this);
				}
				return _colorGroupSaturation;
			}
			set
			{
				if (_colorGroupSaturation == value)
				{
					return;
				}
				_colorGroupSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("roughnessBias")] 
		public CInt8 RoughnessBias
		{
			get
			{
				if (_roughnessBias == null)
				{
					_roughnessBias = (CInt8) CR2WTypeManager.Create("Int8", "roughnessBias", cr2w, this);
				}
				return _roughnessBias;
			}
			set
			{
				if (_roughnessBias == value)
				{
					return;
				}
				_roughnessBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useInGI")] 
		public CBool UseInGI
		{
			get
			{
				if (_useInGI == null)
				{
					_useInGI = (CBool) CR2WTypeManager.Create("Bool", "useInGI", cr2w, this);
				}
				return _useInGI;
			}
			set
			{
				if (_useInGI == value)
				{
					return;
				}
				_useInGI = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useInVolFog")] 
		public CBool UseInVolFog
		{
			get
			{
				if (_useInVolFog == null)
				{
					_useInVolFog = (CBool) CR2WTypeManager.Create("Bool", "useInVolFog", cr2w, this);
				}
				return _useInVolFog;
			}
			set
			{
				if (_useInVolFog == value)
				{
					return;
				}
				_useInVolFog = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useInTransparents")] 
		public CBool UseInTransparents
		{
			get
			{
				if (_useInTransparents == null)
				{
					_useInTransparents = (CBool) CR2WTypeManager.Create("Bool", "useInTransparents", cr2w, this);
				}
				return _useInTransparents;
			}
			set
			{
				if (_useInTransparents == value)
				{
					return;
				}
				_useInTransparents = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("useInParticles")] 
		public CBool UseInParticles
		{
			get
			{
				if (_useInParticles == null)
				{
					_useInParticles = (CBool) CR2WTypeManager.Create("Bool", "useInParticles", cr2w, this);
				}
				return _useInParticles;
			}
			set
			{
				if (_useInParticles == value)
				{
					return;
				}
				_useInParticles = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("sceneDiffuse")] 
		public CBool SceneDiffuse
		{
			get
			{
				if (_sceneDiffuse == null)
				{
					_sceneDiffuse = (CBool) CR2WTypeManager.Create("Bool", "sceneDiffuse", cr2w, this);
				}
				return _sceneDiffuse;
			}
			set
			{
				if (_sceneDiffuse == value)
				{
					return;
				}
				_sceneDiffuse = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("sceneSpecular")] 
		public CBool SceneSpecular
		{
			get
			{
				if (_sceneSpecular == null)
				{
					_sceneSpecular = (CBool) CR2WTypeManager.Create("Bool", "sceneSpecular", cr2w, this);
				}
				return _sceneSpecular;
			}
			set
			{
				if (_sceneSpecular == value)
				{
					return;
				}
				_sceneSpecular = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("clampAttenuation")] 
		public CBool ClampAttenuation
		{
			get
			{
				if (_clampAttenuation == null)
				{
					_clampAttenuation = (CBool) CR2WTypeManager.Create("Bool", "clampAttenuation", cr2w, this);
				}
				return _clampAttenuation;
			}
			set
			{
				if (_clampAttenuation == value)
				{
					return;
				}
				_clampAttenuation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("flicker")] 
		public rendSLightFlickering Flicker
		{
			get
			{
				if (_flicker == null)
				{
					_flicker = (rendSLightFlickering) CR2WTypeManager.Create("rendSLightFlickering", "flicker", cr2w, this);
				}
				return _flicker;
			}
			set
			{
				if (_flicker == value)
				{
					return;
				}
				_flicker = value;
				PropertySet(this);
			}
		}

		public effectTrackItemPointLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
