using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLightComponent : entIVisualComponent
	{
		private CEnum<ELightType> _type;
		private CColor _color;
		private CFloat _radius;
		private CEnum<ELightUnit> _unit;
		private CFloat _intensity;
		private CFloat _rayTracingIntensityScale;
		private CFloat _eV;
		private CFloat _temperature;
		private CEnum<rendLightChannel> _lightChannel;
		private CBool _sceneDiffuse;
		private CBool _sceneSpecular;
		private CBool _directional;
		private CInt8 _roughnessBias;
		private CBool _useInGI;
		private CBool _useInEnvProbes;
		private CBool _useInTransparents;
		private CBool _useInFog;
		private CBool _useInParticles;
		private CEnum<rendLightAttenuation> _attenuation;
		private CBool _clampAttenuation;
		private CEnum<rendLightGroup> _group;
		private CEnum<EAreaLightShape> _areaShape;
		private CBool _areaTwoSided;
		private CBool _spotCapsule;
		private CFloat _sourceRadius;
		private CFloat _capsuleLength;
		private CFloat _areaRectSideA;
		private CFloat _areaRectSideB;
		private CFloat _innerAngle;
		private CFloat _outerAngle;
		private CFloat _softness;
		private CBool _enableLocalShadows;
		private CBool _enableLocalShadowsForceStaticsOnly;
		private CEnum<rendContactShadowReciever> _contactShadows;
		private CFloat _shadowAngle;
		private CFloat _shadowRadius;
		private CFloat _shadowFadeDistance;
		private CFloat _shadowFadeRange;
		private CEnum<ELightShadowSoftnessMode> _shadowSoftnessMode;
		private raRef<CIESDataResource> _iesProfile;
		private rendSLightFlickering _flicker;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CUInt8 _colorGroupSaturation;
		private CUInt8 _portalAngleCutoff;
		private CBool _allowDistantLight;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("type")] 
		public CEnum<ELightType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ELightType>) CR2WTypeManager.Create("ELightType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get
			{
				if (_unit == null)
				{
					_unit = (CEnum<ELightUnit>) CR2WTypeManager.Create("ELightUnit", "unit", cr2w, this);
				}
				return _unit;
			}
			set
			{
				if (_unit == value)
				{
					return;
				}
				_unit = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (CFloat) CR2WTypeManager.Create("Float", "intensity", cr2w, this);
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

		[Ordinal(13)] 
		[RED("rayTracingIntensityScale")] 
		public CFloat RayTracingIntensityScale
		{
			get
			{
				if (_rayTracingIntensityScale == null)
				{
					_rayTracingIntensityScale = (CFloat) CR2WTypeManager.Create("Float", "rayTracingIntensityScale", cr2w, this);
				}
				return _rayTracingIntensityScale;
			}
			set
			{
				if (_rayTracingIntensityScale == value)
				{
					return;
				}
				_rayTracingIntensityScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("temperature")] 
		public CFloat Temperature
		{
			get
			{
				if (_temperature == null)
				{
					_temperature = (CFloat) CR2WTypeManager.Create("Float", "temperature", cr2w, this);
				}
				return _temperature;
			}
			set
			{
				if (_temperature == value)
				{
					return;
				}
				_temperature = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lightChannel")] 
		public CEnum<rendLightChannel> LightChannel
		{
			get
			{
				if (_lightChannel == null)
				{
					_lightChannel = (CEnum<rendLightChannel>) CR2WTypeManager.Create("rendLightChannel", "lightChannel", cr2w, this);
				}
				return _lightChannel;
			}
			set
			{
				if (_lightChannel == value)
				{
					return;
				}
				_lightChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("directional")] 
		public CBool Directional
		{
			get
			{
				if (_directional == null)
				{
					_directional = (CBool) CR2WTypeManager.Create("Bool", "directional", cr2w, this);
				}
				return _directional;
			}
			set
			{
				if (_directional == value)
				{
					return;
				}
				_directional = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("useInEnvProbes")] 
		public CBool UseInEnvProbes
		{
			get
			{
				if (_useInEnvProbes == null)
				{
					_useInEnvProbes = (CBool) CR2WTypeManager.Create("Bool", "useInEnvProbes", cr2w, this);
				}
				return _useInEnvProbes;
			}
			set
			{
				if (_useInEnvProbes == value)
				{
					return;
				}
				_useInEnvProbes = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("useInFog")] 
		public CBool UseInFog
		{
			get
			{
				if (_useInFog == null)
				{
					_useInFog = (CBool) CR2WTypeManager.Create("Bool", "useInFog", cr2w, this);
				}
				return _useInFog;
			}
			set
			{
				if (_useInFog == value)
				{
					return;
				}
				_useInFog = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
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

		[Ordinal(26)] 
		[RED("attenuation")] 
		public CEnum<rendLightAttenuation> Attenuation
		{
			get
			{
				if (_attenuation == null)
				{
					_attenuation = (CEnum<rendLightAttenuation>) CR2WTypeManager.Create("rendLightAttenuation", "attenuation", cr2w, this);
				}
				return _attenuation;
			}
			set
			{
				if (_attenuation == value)
				{
					return;
				}
				_attenuation = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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

		[Ordinal(28)] 
		[RED("group")] 
		public CEnum<rendLightGroup> Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CEnum<rendLightGroup>) CR2WTypeManager.Create("rendLightGroup", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("areaShape")] 
		public CEnum<EAreaLightShape> AreaShape
		{
			get
			{
				if (_areaShape == null)
				{
					_areaShape = (CEnum<EAreaLightShape>) CR2WTypeManager.Create("EAreaLightShape", "areaShape", cr2w, this);
				}
				return _areaShape;
			}
			set
			{
				if (_areaShape == value)
				{
					return;
				}
				_areaShape = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("areaTwoSided")] 
		public CBool AreaTwoSided
		{
			get
			{
				if (_areaTwoSided == null)
				{
					_areaTwoSided = (CBool) CR2WTypeManager.Create("Bool", "areaTwoSided", cr2w, this);
				}
				return _areaTwoSided;
			}
			set
			{
				if (_areaTwoSided == value)
				{
					return;
				}
				_areaTwoSided = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("spotCapsule")] 
		public CBool SpotCapsule
		{
			get
			{
				if (_spotCapsule == null)
				{
					_spotCapsule = (CBool) CR2WTypeManager.Create("Bool", "spotCapsule", cr2w, this);
				}
				return _spotCapsule;
			}
			set
			{
				if (_spotCapsule == value)
				{
					return;
				}
				_spotCapsule = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("sourceRadius")] 
		public CFloat SourceRadius
		{
			get
			{
				if (_sourceRadius == null)
				{
					_sourceRadius = (CFloat) CR2WTypeManager.Create("Float", "sourceRadius", cr2w, this);
				}
				return _sourceRadius;
			}
			set
			{
				if (_sourceRadius == value)
				{
					return;
				}
				_sourceRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("capsuleLength")] 
		public CFloat CapsuleLength
		{
			get
			{
				if (_capsuleLength == null)
				{
					_capsuleLength = (CFloat) CR2WTypeManager.Create("Float", "capsuleLength", cr2w, this);
				}
				return _capsuleLength;
			}
			set
			{
				if (_capsuleLength == value)
				{
					return;
				}
				_capsuleLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("areaRectSideA")] 
		public CFloat AreaRectSideA
		{
			get
			{
				if (_areaRectSideA == null)
				{
					_areaRectSideA = (CFloat) CR2WTypeManager.Create("Float", "areaRectSideA", cr2w, this);
				}
				return _areaRectSideA;
			}
			set
			{
				if (_areaRectSideA == value)
				{
					return;
				}
				_areaRectSideA = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("areaRectSideB")] 
		public CFloat AreaRectSideB
		{
			get
			{
				if (_areaRectSideB == null)
				{
					_areaRectSideB = (CFloat) CR2WTypeManager.Create("Float", "areaRectSideB", cr2w, this);
				}
				return _areaRectSideB;
			}
			set
			{
				if (_areaRectSideB == value)
				{
					return;
				}
				_areaRectSideB = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get
			{
				if (_innerAngle == null)
				{
					_innerAngle = (CFloat) CR2WTypeManager.Create("Float", "innerAngle", cr2w, this);
				}
				return _innerAngle;
			}
			set
			{
				if (_innerAngle == value)
				{
					return;
				}
				_innerAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get
			{
				if (_outerAngle == null)
				{
					_outerAngle = (CFloat) CR2WTypeManager.Create("Float", "outerAngle", cr2w, this);
				}
				return _outerAngle;
			}
			set
			{
				if (_outerAngle == value)
				{
					return;
				}
				_outerAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("softness")] 
		public CFloat Softness
		{
			get
			{
				if (_softness == null)
				{
					_softness = (CFloat) CR2WTypeManager.Create("Float", "softness", cr2w, this);
				}
				return _softness;
			}
			set
			{
				if (_softness == value)
				{
					return;
				}
				_softness = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("enableLocalShadows")] 
		public CBool EnableLocalShadows
		{
			get
			{
				if (_enableLocalShadows == null)
				{
					_enableLocalShadows = (CBool) CR2WTypeManager.Create("Bool", "enableLocalShadows", cr2w, this);
				}
				return _enableLocalShadows;
			}
			set
			{
				if (_enableLocalShadows == value)
				{
					return;
				}
				_enableLocalShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("enableLocalShadowsForceStaticsOnly")] 
		public CBool EnableLocalShadowsForceStaticsOnly
		{
			get
			{
				if (_enableLocalShadowsForceStaticsOnly == null)
				{
					_enableLocalShadowsForceStaticsOnly = (CBool) CR2WTypeManager.Create("Bool", "enableLocalShadowsForceStaticsOnly", cr2w, this);
				}
				return _enableLocalShadowsForceStaticsOnly;
			}
			set
			{
				if (_enableLocalShadowsForceStaticsOnly == value)
				{
					return;
				}
				_enableLocalShadowsForceStaticsOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("contactShadows")] 
		public CEnum<rendContactShadowReciever> ContactShadows
		{
			get
			{
				if (_contactShadows == null)
				{
					_contactShadows = (CEnum<rendContactShadowReciever>) CR2WTypeManager.Create("rendContactShadowReciever", "contactShadows", cr2w, this);
				}
				return _contactShadows;
			}
			set
			{
				if (_contactShadows == value)
				{
					return;
				}
				_contactShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("shadowAngle")] 
		public CFloat ShadowAngle
		{
			get
			{
				if (_shadowAngle == null)
				{
					_shadowAngle = (CFloat) CR2WTypeManager.Create("Float", "shadowAngle", cr2w, this);
				}
				return _shadowAngle;
			}
			set
			{
				if (_shadowAngle == value)
				{
					return;
				}
				_shadowAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("shadowRadius")] 
		public CFloat ShadowRadius
		{
			get
			{
				if (_shadowRadius == null)
				{
					_shadowRadius = (CFloat) CR2WTypeManager.Create("Float", "shadowRadius", cr2w, this);
				}
				return _shadowRadius;
			}
			set
			{
				if (_shadowRadius == value)
				{
					return;
				}
				_shadowRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("shadowFadeDistance")] 
		public CFloat ShadowFadeDistance
		{
			get
			{
				if (_shadowFadeDistance == null)
				{
					_shadowFadeDistance = (CFloat) CR2WTypeManager.Create("Float", "shadowFadeDistance", cr2w, this);
				}
				return _shadowFadeDistance;
			}
			set
			{
				if (_shadowFadeDistance == value)
				{
					return;
				}
				_shadowFadeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("shadowFadeRange")] 
		public CFloat ShadowFadeRange
		{
			get
			{
				if (_shadowFadeRange == null)
				{
					_shadowFadeRange = (CFloat) CR2WTypeManager.Create("Float", "shadowFadeRange", cr2w, this);
				}
				return _shadowFadeRange;
			}
			set
			{
				if (_shadowFadeRange == value)
				{
					return;
				}
				_shadowFadeRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("shadowSoftnessMode")] 
		public CEnum<ELightShadowSoftnessMode> ShadowSoftnessMode
		{
			get
			{
				if (_shadowSoftnessMode == null)
				{
					_shadowSoftnessMode = (CEnum<ELightShadowSoftnessMode>) CR2WTypeManager.Create("ELightShadowSoftnessMode", "shadowSoftnessMode", cr2w, this);
				}
				return _shadowSoftnessMode;
			}
			set
			{
				if (_shadowSoftnessMode == value)
				{
					return;
				}
				_shadowSoftnessMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("iesProfile")] 
		public raRef<CIESDataResource> IesProfile
		{
			get
			{
				if (_iesProfile == null)
				{
					_iesProfile = (raRef<CIESDataResource>) CR2WTypeManager.Create("raRef:CIESDataResource", "iesProfile", cr2w, this);
				}
				return _iesProfile;
			}
			set
			{
				if (_iesProfile == value)
				{
					return;
				}
				_iesProfile = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
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

		[Ordinal(49)] 
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

		[Ordinal(50)] 
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

		[Ordinal(51)] 
		[RED("portalAngleCutoff")] 
		public CUInt8 PortalAngleCutoff
		{
			get
			{
				if (_portalAngleCutoff == null)
				{
					_portalAngleCutoff = (CUInt8) CR2WTypeManager.Create("Uint8", "portalAngleCutoff", cr2w, this);
				}
				return _portalAngleCutoff;
			}
			set
			{
				if (_portalAngleCutoff == value)
				{
					return;
				}
				_portalAngleCutoff = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("allowDistantLight")] 
		public CBool AllowDistantLight
		{
			get
			{
				if (_allowDistantLight == null)
				{
					_allowDistantLight = (CBool) CR2WTypeManager.Create("Bool", "allowDistantLight", cr2w, this);
				}
				return _allowDistantLight;
			}
			set
			{
				if (_allowDistantLight == value)
				{
					return;
				}
				_allowDistantLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public entLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
