using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemPointLight : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("tint")] 
		public effectEffectParameterEvaluatorColor Tint
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorColor>();
			set => SetPropertyValue<effectEffectParameterEvaluatorColor>(value);
		}

		[Ordinal(4)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("EV")] 
		public CFloat EV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("radius")] 
		public effectEffectParameterEvaluatorFloat Radius
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(7)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(9)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetPropertyValue<CEnum<EEnvColorGroup>>();
			set => SetPropertyValue<CEnum<EEnvColorGroup>>(value);
		}

		[Ordinal(10)] 
		[RED("colorGroupSaturation")] 
		public CUInt8 ColorGroupSaturation
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(11)] 
		[RED("roughnessBias")] 
		public CInt8 RoughnessBias
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(12)] 
		[RED("useInGI")] 
		public CBool UseInGI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useInVolFog")] 
		public CBool UseInVolFog
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("useInTransparents")] 
		public CBool UseInTransparents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("useInParticles")] 
		public CBool UseInParticles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("sceneDiffuse")] 
		public CBool SceneDiffuse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("sceneSpecular")] 
		public CBool SceneSpecular
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("clampAttenuation")] 
		public CBool ClampAttenuation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("flicker")] 
		public rendSLightFlickering Flicker
		{
			get => GetPropertyValue<rendSLightFlickering>();
			set => SetPropertyValue<rendSLightFlickering>(value);
		}

		public effectTrackItemPointLight()
		{
			TimeDuration = 1.000000F;
			Tint = new();
			Intensity = new();
			Radius = new();
			Offset = new();
			Color = new();
			ColorGroupSaturation = 100;
			UseInGI = true;
			UseInTransparents = true;
			UseInParticles = true;
			SceneDiffuse = true;
			SceneSpecular = true;
			Flicker = new() { FlickerPeriod = 0.200000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
