using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class fxCompositionShaderParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("glitchParam")] 
		public CFloat GlitchParam
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("glitchParam1")] 
		public CFloat GlitchParam1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("visionActiveTime")] 
		public CFloat VisionActiveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("uiFactor")] 
		public CFloat UiFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("uiPassthroughFactor")] 
		public CFloat UiPassthroughFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("mainRenderFactor")] 
		public CFloat MainRenderFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("blurredRenderFactor")] 
		public CFloat BlurredRenderFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("backgroundTextureFactor")] 
		public CFloat BackgroundTextureFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("backgroundBlurRadius")] 
		public CFloat BackgroundBlurRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("sphericalDistPower")] 
		public Vector2 SphericalDistPower
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(11)] 
		[RED("shadowDistance")] 
		public Vector2 ShadowDistance
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(12)] 
		[RED("shadowIntensity")] 
		public CFloat ShadowIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("shadowRadius")] 
		public CFloat ShadowRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("glowIntensity")] 
		public CFloat GlowIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("glowTresholdStart")] 
		public CFloat GlowTresholdStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("glowTresholdEnd")] 
		public CFloat GlowTresholdEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("glowBlurRadius")] 
		public CFloat GlowBlurRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("vignetteStart")] 
		public CFloat VignetteStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("vignetteEnd")] 
		public CFloat VignetteEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("vignetteIntensity")] 
		public CFloat VignetteIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("blurredRenderSaturation")] 
		public CFloat BlurredRenderSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("uiSaturation")] 
		public CFloat UiSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("chromaticAberrationStrength")] 
		public CFloat ChromaticAberrationStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("uiLayer2Scale")] 
		public Vector2 UiLayer2Scale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(25)] 
		[RED("uiLayer3Scale")] 
		public Vector2 UiLayer3Scale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(26)] 
		[RED("uiLayer4Scale")] 
		public Vector2 UiLayer4Scale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(27)] 
		[RED("uiLayer2Weight")] 
		public CFloat UiLayer2Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("uiLayer3Weight")] 
		public CFloat UiLayer3Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("uiLayer4Weight")] 
		public CFloat UiLayer4Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public fxCompositionShaderParams()
		{
			SphericalDistPower = new();
			ShadowDistance = new();
			ShadowRadius = 1.000000F;
			GlowIntensity = 0.500000F;
			GlowTresholdStart = 0.750000F;
			GlowTresholdEnd = 1.000000F;
			BlurredRenderSaturation = 0.730000F;
			UiSaturation = 1.000000F;
			ChromaticAberrationStrength = 0.000750F;
			UiLayer2Scale = new() { X = -0.005000F, Y = -0.002500F };
			UiLayer3Scale = new() { X = -0.010800F, Y = -0.006800F };
			UiLayer4Scale = new() { X = -0.012600F, Y = -0.007300F };
			UiLayer2Weight = 0.080000F;
			UiLayer3Weight = 0.070000F;
			UiLayer4Weight = 0.060000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
