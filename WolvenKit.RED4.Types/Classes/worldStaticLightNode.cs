using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticLightNode : worldNode
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
		private CUInt8 _sceneSpecularScale;
		private CBool _directional;
		private CInt8 _roughnessBias;
		private CUInt8 _scaleGI;
		private CUInt8 _scaleEnvProbes;
		private CBool _useInTransparents;
		private CUInt8 _scaleVolFog;
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
		private CResourceAsyncReference<CIESDataResource> _iesProfile;
		private rendSLightFlickering _flicker;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CUInt8 _colorGroupSaturation;
		private CUInt8 _portalAngleCutoff;
		private CBool _allowDistantLight;
		private CFloat _autoHideDistance;

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<ELightType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(6)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(7)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(8)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(9)] 
		[RED("rayTracingIntensityScale")] 
		public CFloat RayTracingIntensityScale
		{
			get => GetProperty(ref _rayTracingIntensityScale);
			set => SetProperty(ref _rayTracingIntensityScale, value);
		}

		[Ordinal(10)] 
		[RED("EV")] 
		public CFloat EV
		{
			get => GetProperty(ref _eV);
			set => SetProperty(ref _eV, value);
		}

		[Ordinal(11)] 
		[RED("temperature")] 
		public CFloat Temperature
		{
			get => GetProperty(ref _temperature);
			set => SetProperty(ref _temperature, value);
		}

		[Ordinal(12)] 
		[RED("lightChannel")] 
		public CEnum<rendLightChannel> LightChannel
		{
			get => GetProperty(ref _lightChannel);
			set => SetProperty(ref _lightChannel, value);
		}

		[Ordinal(13)] 
		[RED("sceneDiffuse")] 
		public CBool SceneDiffuse
		{
			get => GetProperty(ref _sceneDiffuse);
			set => SetProperty(ref _sceneDiffuse, value);
		}

		[Ordinal(14)] 
		[RED("sceneSpecularScale")] 
		public CUInt8 SceneSpecularScale
		{
			get => GetProperty(ref _sceneSpecularScale);
			set => SetProperty(ref _sceneSpecularScale, value);
		}

		[Ordinal(15)] 
		[RED("directional")] 
		public CBool Directional
		{
			get => GetProperty(ref _directional);
			set => SetProperty(ref _directional, value);
		}

		[Ordinal(16)] 
		[RED("roughnessBias")] 
		public CInt8 RoughnessBias
		{
			get => GetProperty(ref _roughnessBias);
			set => SetProperty(ref _roughnessBias, value);
		}

		[Ordinal(17)] 
		[RED("scaleGI")] 
		public CUInt8 ScaleGI
		{
			get => GetProperty(ref _scaleGI);
			set => SetProperty(ref _scaleGI, value);
		}

		[Ordinal(18)] 
		[RED("scaleEnvProbes")] 
		public CUInt8 ScaleEnvProbes
		{
			get => GetProperty(ref _scaleEnvProbes);
			set => SetProperty(ref _scaleEnvProbes, value);
		}

		[Ordinal(19)] 
		[RED("useInTransparents")] 
		public CBool UseInTransparents
		{
			get => GetProperty(ref _useInTransparents);
			set => SetProperty(ref _useInTransparents, value);
		}

		[Ordinal(20)] 
		[RED("scaleVolFog")] 
		public CUInt8 ScaleVolFog
		{
			get => GetProperty(ref _scaleVolFog);
			set => SetProperty(ref _scaleVolFog, value);
		}

		[Ordinal(21)] 
		[RED("useInParticles")] 
		public CBool UseInParticles
		{
			get => GetProperty(ref _useInParticles);
			set => SetProperty(ref _useInParticles, value);
		}

		[Ordinal(22)] 
		[RED("attenuation")] 
		public CEnum<rendLightAttenuation> Attenuation
		{
			get => GetProperty(ref _attenuation);
			set => SetProperty(ref _attenuation, value);
		}

		[Ordinal(23)] 
		[RED("clampAttenuation")] 
		public CBool ClampAttenuation
		{
			get => GetProperty(ref _clampAttenuation);
			set => SetProperty(ref _clampAttenuation, value);
		}

		[Ordinal(24)] 
		[RED("group")] 
		public CEnum<rendLightGroup> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(25)] 
		[RED("areaShape")] 
		public CEnum<EAreaLightShape> AreaShape
		{
			get => GetProperty(ref _areaShape);
			set => SetProperty(ref _areaShape, value);
		}

		[Ordinal(26)] 
		[RED("areaTwoSided")] 
		public CBool AreaTwoSided
		{
			get => GetProperty(ref _areaTwoSided);
			set => SetProperty(ref _areaTwoSided, value);
		}

		[Ordinal(27)] 
		[RED("spotCapsule")] 
		public CBool SpotCapsule
		{
			get => GetProperty(ref _spotCapsule);
			set => SetProperty(ref _spotCapsule, value);
		}

		[Ordinal(28)] 
		[RED("sourceRadius")] 
		public CFloat SourceRadius
		{
			get => GetProperty(ref _sourceRadius);
			set => SetProperty(ref _sourceRadius, value);
		}

		[Ordinal(29)] 
		[RED("capsuleLength")] 
		public CFloat CapsuleLength
		{
			get => GetProperty(ref _capsuleLength);
			set => SetProperty(ref _capsuleLength, value);
		}

		[Ordinal(30)] 
		[RED("areaRectSideA")] 
		public CFloat AreaRectSideA
		{
			get => GetProperty(ref _areaRectSideA);
			set => SetProperty(ref _areaRectSideA, value);
		}

		[Ordinal(31)] 
		[RED("areaRectSideB")] 
		public CFloat AreaRectSideB
		{
			get => GetProperty(ref _areaRectSideB);
			set => SetProperty(ref _areaRectSideB, value);
		}

		[Ordinal(32)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get => GetProperty(ref _innerAngle);
			set => SetProperty(ref _innerAngle, value);
		}

		[Ordinal(33)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get => GetProperty(ref _outerAngle);
			set => SetProperty(ref _outerAngle, value);
		}

		[Ordinal(34)] 
		[RED("softness")] 
		public CFloat Softness
		{
			get => GetProperty(ref _softness);
			set => SetProperty(ref _softness, value);
		}

		[Ordinal(35)] 
		[RED("enableLocalShadows")] 
		public CBool EnableLocalShadows
		{
			get => GetProperty(ref _enableLocalShadows);
			set => SetProperty(ref _enableLocalShadows, value);
		}

		[Ordinal(36)] 
		[RED("enableLocalShadowsForceStaticsOnly")] 
		public CBool EnableLocalShadowsForceStaticsOnly
		{
			get => GetProperty(ref _enableLocalShadowsForceStaticsOnly);
			set => SetProperty(ref _enableLocalShadowsForceStaticsOnly, value);
		}

		[Ordinal(37)] 
		[RED("contactShadows")] 
		public CEnum<rendContactShadowReciever> ContactShadows
		{
			get => GetProperty(ref _contactShadows);
			set => SetProperty(ref _contactShadows, value);
		}

		[Ordinal(38)] 
		[RED("shadowAngle")] 
		public CFloat ShadowAngle
		{
			get => GetProperty(ref _shadowAngle);
			set => SetProperty(ref _shadowAngle, value);
		}

		[Ordinal(39)] 
		[RED("shadowRadius")] 
		public CFloat ShadowRadius
		{
			get => GetProperty(ref _shadowRadius);
			set => SetProperty(ref _shadowRadius, value);
		}

		[Ordinal(40)] 
		[RED("shadowFadeDistance")] 
		public CFloat ShadowFadeDistance
		{
			get => GetProperty(ref _shadowFadeDistance);
			set => SetProperty(ref _shadowFadeDistance, value);
		}

		[Ordinal(41)] 
		[RED("shadowFadeRange")] 
		public CFloat ShadowFadeRange
		{
			get => GetProperty(ref _shadowFadeRange);
			set => SetProperty(ref _shadowFadeRange, value);
		}

		[Ordinal(42)] 
		[RED("shadowSoftnessMode")] 
		public CEnum<ELightShadowSoftnessMode> ShadowSoftnessMode
		{
			get => GetProperty(ref _shadowSoftnessMode);
			set => SetProperty(ref _shadowSoftnessMode, value);
		}

		[Ordinal(43)] 
		[RED("iesProfile")] 
		public CResourceAsyncReference<CIESDataResource> IesProfile
		{
			get => GetProperty(ref _iesProfile);
			set => SetProperty(ref _iesProfile, value);
		}

		[Ordinal(44)] 
		[RED("flicker")] 
		public rendSLightFlickering Flicker
		{
			get => GetProperty(ref _flicker);
			set => SetProperty(ref _flicker, value);
		}

		[Ordinal(45)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetProperty(ref _envColorGroup);
			set => SetProperty(ref _envColorGroup, value);
		}

		[Ordinal(46)] 
		[RED("colorGroupSaturation")] 
		public CUInt8 ColorGroupSaturation
		{
			get => GetProperty(ref _colorGroupSaturation);
			set => SetProperty(ref _colorGroupSaturation, value);
		}

		[Ordinal(47)] 
		[RED("portalAngleCutoff")] 
		public CUInt8 PortalAngleCutoff
		{
			get => GetProperty(ref _portalAngleCutoff);
			set => SetProperty(ref _portalAngleCutoff, value);
		}

		[Ordinal(48)] 
		[RED("allowDistantLight")] 
		public CBool AllowDistantLight
		{
			get => GetProperty(ref _allowDistantLight);
			set => SetProperty(ref _allowDistantLight, value);
		}

		[Ordinal(49)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetProperty(ref _autoHideDistance);
			set => SetProperty(ref _autoHideDistance, value);
		}
	}
}
