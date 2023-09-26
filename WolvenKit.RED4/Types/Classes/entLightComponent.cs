using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLightComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("type")] 
		public CEnum<ELightType> Type
		{
			get => GetPropertyValue<CEnum<ELightType>>();
			set => SetPropertyValue<CEnum<ELightType>>(value);
		}

		[Ordinal(9)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(10)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get => GetPropertyValue<CEnum<ELightUnit>>();
			set => SetPropertyValue<CEnum<ELightUnit>>(value);
		}

		[Ordinal(12)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("EV")] 
		public CFloat EV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("temperature")] 
		public CFloat Temperature
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("lightChannel")] 
		public CBitField<rendLightChannel> LightChannel
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(16)] 
		[RED("sceneDiffuse")] 
		public CBool SceneDiffuse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("sceneSpecularScale")] 
		public CUInt8 SceneSpecularScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(18)] 
		[RED("directional")] 
		public CBool Directional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("roughnessBias")] 
		public CInt8 RoughnessBias
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(20)] 
		[RED("scaleGI")] 
		public CUInt8 ScaleGI
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(21)] 
		[RED("scaleEnvProbes")] 
		public CUInt8 ScaleEnvProbes
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(22)] 
		[RED("useInTransparents")] 
		public CBool UseInTransparents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("scaleVolFog")] 
		public CUInt8 ScaleVolFog
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(24)] 
		[RED("useInParticles")] 
		public CBool UseInParticles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("attenuation")] 
		public CEnum<rendLightAttenuation> Attenuation
		{
			get => GetPropertyValue<CEnum<rendLightAttenuation>>();
			set => SetPropertyValue<CEnum<rendLightAttenuation>>(value);
		}

		[Ordinal(26)] 
		[RED("clampAttenuation")] 
		public CBool ClampAttenuation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("group")] 
		public CEnum<rendLightGroup> Group
		{
			get => GetPropertyValue<CEnum<rendLightGroup>>();
			set => SetPropertyValue<CEnum<rendLightGroup>>(value);
		}

		[Ordinal(28)] 
		[RED("areaShape")] 
		public CEnum<EAreaLightShape> AreaShape
		{
			get => GetPropertyValue<CEnum<EAreaLightShape>>();
			set => SetPropertyValue<CEnum<EAreaLightShape>>(value);
		}

		[Ordinal(29)] 
		[RED("areaTwoSided")] 
		public CBool AreaTwoSided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("spotCapsule")] 
		public CBool SpotCapsule
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("sourceRadius")] 
		public CFloat SourceRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("capsuleLength")] 
		public CFloat CapsuleLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("areaRectSideA")] 
		public CFloat AreaRectSideA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("areaRectSideB")] 
		public CFloat AreaRectSideB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("softness")] 
		public CFloat Softness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("enableLocalShadows")] 
		public CBool EnableLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("enableLocalShadowsForceStaticsOnly")] 
		public CBool EnableLocalShadowsForceStaticsOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("contactShadows")] 
		public CEnum<rendContactShadowReciever> ContactShadows
		{
			get => GetPropertyValue<CEnum<rendContactShadowReciever>>();
			set => SetPropertyValue<CEnum<rendContactShadowReciever>>(value);
		}

		[Ordinal(41)] 
		[RED("shadowAngle")] 
		public CFloat ShadowAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("shadowRadius")] 
		public CFloat ShadowRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("shadowFadeDistance")] 
		public CFloat ShadowFadeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("shadowFadeRange")] 
		public CFloat ShadowFadeRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("shadowSoftnessMode")] 
		public CEnum<ELightShadowSoftnessMode> ShadowSoftnessMode
		{
			get => GetPropertyValue<CEnum<ELightShadowSoftnessMode>>();
			set => SetPropertyValue<CEnum<ELightShadowSoftnessMode>>(value);
		}

		[Ordinal(46)] 
		[RED("rayTracedShadowsPlatform")] 
		public CEnum<rendRayTracedShadowsPlatform> RayTracedShadowsPlatform
		{
			get => GetPropertyValue<CEnum<rendRayTracedShadowsPlatform>>();
			set => SetPropertyValue<CEnum<rendRayTracedShadowsPlatform>>(value);
		}

		[Ordinal(47)] 
		[RED("rayTracingLightSourceRadius")] 
		public CFloat RayTracingLightSourceRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("rayTracingContactShadowRange")] 
		public CFloat RayTracingContactShadowRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("iesProfile")] 
		public CResourceAsyncReference<CIESDataResource> IesProfile
		{
			get => GetPropertyValue<CResourceAsyncReference<CIESDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CIESDataResource>>(value);
		}

		[Ordinal(50)] 
		[RED("flicker")] 
		public rendSLightFlickering Flicker
		{
			get => GetPropertyValue<rendSLightFlickering>();
			set => SetPropertyValue<rendSLightFlickering>(value);
		}

		[Ordinal(51)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetPropertyValue<CEnum<EEnvColorGroup>>();
			set => SetPropertyValue<CEnum<EEnvColorGroup>>(value);
		}

		[Ordinal(52)] 
		[RED("colorGroupSaturation")] 
		public CUInt8 ColorGroupSaturation
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(53)] 
		[RED("portalAngleCutoff")] 
		public CUInt8 PortalAngleCutoff
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(54)] 
		[RED("allowDistantLight")] 
		public CBool AllowDistantLight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("rayTracingIntensityScale")] 
		public CFloat RayTracingIntensityScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("pathTracingLightUsage")] 
		public CEnum<rendEPathTracingLightUsage> PathTracingLightUsage
		{
			get => GetPropertyValue<CEnum<rendEPathTracingLightUsage>>();
			set => SetPropertyValue<CEnum<rendEPathTracingLightUsage>>(value);
		}

		[Ordinal(57)] 
		[RED("pathTracingOverrideScaleGI")] 
		public CBool PathTracingOverrideScaleGI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("rtxdiShadowStartingDistance")] 
		public CFloat RtxdiShadowStartingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entLightComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			AutoHideDistance = 15.000000F;
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			Color = new CColor();
			Radius = 5.000000F;
			Intensity = 100.000000F;
			Temperature = -1.000000F;
			LightChannel = Enums.rendLightChannel.LC_Channel1 | Enums.rendLightChannel.LC_Channel2 | Enums.rendLightChannel.LC_Channel3 | Enums.rendLightChannel.LC_Channel4 | Enums.rendLightChannel.LC_Channel5 | Enums.rendLightChannel.LC_Channel6 | Enums.rendLightChannel.LC_Channel7 | Enums.rendLightChannel.LC_Channel8 | Enums.rendLightChannel.LC_ChannelWorld;
			SceneDiffuse = true;
			SceneSpecularScale = 100;
			ScaleGI = 100;
			ScaleEnvProbes = 100;
			UseInTransparents = true;
			UseInParticles = true;
			AreaShape = Enums.EAreaLightShape.ALS_Capsule;
			AreaTwoSided = true;
			SourceRadius = 0.050000F;
			CapsuleLength = 1.000000F;
			AreaRectSideA = 1.000000F;
			AreaRectSideB = 1.000000F;
			InnerAngle = 30.000000F;
			OuterAngle = 45.000000F;
			Softness = 2.000000F;
			ShadowAngle = -1.000000F;
			ShadowRadius = -1.000000F;
			ShadowFadeDistance = 10.000000F;
			ShadowFadeRange = 5.000000F;
			ShadowSoftnessMode = Enums.ELightShadowSoftnessMode.LSSM_Default;
			RayTracingLightSourceRadius = -1.000000F;
			RayTracingContactShadowRange = -1.000000F;
			Flicker = new rendSLightFlickering { FlickerPeriod = 0.200000F };
			ColorGroupSaturation = 100;
			AllowDistantLight = true;
			RayTracingIntensityScale = 1.000000F;
			PathTracingOverrideScaleGI = true;
			RtxdiShadowStartingDistance = -1.000000F;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
