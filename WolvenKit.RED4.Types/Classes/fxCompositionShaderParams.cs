using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class fxCompositionShaderParams : RedBaseClass
	{
		private CFloat _glitchParam;
		private CFloat _glitchParam1;
		private CFloat _health;
		private CFloat _visionActiveTime;
		private CFloat _uiFactor;
		private CFloat _uiPassthroughFactor;
		private CFloat _mainRenderFactor;
		private CFloat _blurredRenderFactor;
		private CFloat _backgroundTextureFactor;
		private CFloat _backgroundBlurRadius;
		private Vector2 _sphericalDistPower;
		private Vector2 _shadowDistance;
		private CFloat _shadowIntensity;
		private CFloat _shadowRadius;
		private CFloat _glowIntensity;
		private CFloat _glowTresholdStart;
		private CFloat _glowTresholdEnd;
		private CFloat _glowBlurRadius;
		private CFloat _vignetteStart;
		private CFloat _vignetteEnd;
		private CFloat _vignetteIntensity;
		private CFloat _blurredRenderSaturation;
		private CFloat _uiSaturation;
		private CFloat _chromaticAberrationStrength;
		private Vector2 _uiLayer2Scale;
		private Vector2 _uiLayer3Scale;
		private Vector2 _uiLayer4Scale;
		private CFloat _uiLayer2Weight;
		private CFloat _uiLayer3Weight;
		private CFloat _uiLayer4Weight;

		[Ordinal(0)] 
		[RED("glitchParam")] 
		public CFloat GlitchParam
		{
			get => GetProperty(ref _glitchParam);
			set => SetProperty(ref _glitchParam, value);
		}

		[Ordinal(1)] 
		[RED("glitchParam1")] 
		public CFloat GlitchParam1
		{
			get => GetProperty(ref _glitchParam1);
			set => SetProperty(ref _glitchParam1, value);
		}

		[Ordinal(2)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		[Ordinal(3)] 
		[RED("visionActiveTime")] 
		public CFloat VisionActiveTime
		{
			get => GetProperty(ref _visionActiveTime);
			set => SetProperty(ref _visionActiveTime, value);
		}

		[Ordinal(4)] 
		[RED("uiFactor")] 
		public CFloat UiFactor
		{
			get => GetProperty(ref _uiFactor);
			set => SetProperty(ref _uiFactor, value);
		}

		[Ordinal(5)] 
		[RED("uiPassthroughFactor")] 
		public CFloat UiPassthroughFactor
		{
			get => GetProperty(ref _uiPassthroughFactor);
			set => SetProperty(ref _uiPassthroughFactor, value);
		}

		[Ordinal(6)] 
		[RED("mainRenderFactor")] 
		public CFloat MainRenderFactor
		{
			get => GetProperty(ref _mainRenderFactor);
			set => SetProperty(ref _mainRenderFactor, value);
		}

		[Ordinal(7)] 
		[RED("blurredRenderFactor")] 
		public CFloat BlurredRenderFactor
		{
			get => GetProperty(ref _blurredRenderFactor);
			set => SetProperty(ref _blurredRenderFactor, value);
		}

		[Ordinal(8)] 
		[RED("backgroundTextureFactor")] 
		public CFloat BackgroundTextureFactor
		{
			get => GetProperty(ref _backgroundTextureFactor);
			set => SetProperty(ref _backgroundTextureFactor, value);
		}

		[Ordinal(9)] 
		[RED("backgroundBlurRadius")] 
		public CFloat BackgroundBlurRadius
		{
			get => GetProperty(ref _backgroundBlurRadius);
			set => SetProperty(ref _backgroundBlurRadius, value);
		}

		[Ordinal(10)] 
		[RED("sphericalDistPower")] 
		public Vector2 SphericalDistPower
		{
			get => GetProperty(ref _sphericalDistPower);
			set => SetProperty(ref _sphericalDistPower, value);
		}

		[Ordinal(11)] 
		[RED("shadowDistance")] 
		public Vector2 ShadowDistance
		{
			get => GetProperty(ref _shadowDistance);
			set => SetProperty(ref _shadowDistance, value);
		}

		[Ordinal(12)] 
		[RED("shadowIntensity")] 
		public CFloat ShadowIntensity
		{
			get => GetProperty(ref _shadowIntensity);
			set => SetProperty(ref _shadowIntensity, value);
		}

		[Ordinal(13)] 
		[RED("shadowRadius")] 
		public CFloat ShadowRadius
		{
			get => GetProperty(ref _shadowRadius);
			set => SetProperty(ref _shadowRadius, value);
		}

		[Ordinal(14)] 
		[RED("glowIntensity")] 
		public CFloat GlowIntensity
		{
			get => GetProperty(ref _glowIntensity);
			set => SetProperty(ref _glowIntensity, value);
		}

		[Ordinal(15)] 
		[RED("glowTresholdStart")] 
		public CFloat GlowTresholdStart
		{
			get => GetProperty(ref _glowTresholdStart);
			set => SetProperty(ref _glowTresholdStart, value);
		}

		[Ordinal(16)] 
		[RED("glowTresholdEnd")] 
		public CFloat GlowTresholdEnd
		{
			get => GetProperty(ref _glowTresholdEnd);
			set => SetProperty(ref _glowTresholdEnd, value);
		}

		[Ordinal(17)] 
		[RED("glowBlurRadius")] 
		public CFloat GlowBlurRadius
		{
			get => GetProperty(ref _glowBlurRadius);
			set => SetProperty(ref _glowBlurRadius, value);
		}

		[Ordinal(18)] 
		[RED("vignetteStart")] 
		public CFloat VignetteStart
		{
			get => GetProperty(ref _vignetteStart);
			set => SetProperty(ref _vignetteStart, value);
		}

		[Ordinal(19)] 
		[RED("vignetteEnd")] 
		public CFloat VignetteEnd
		{
			get => GetProperty(ref _vignetteEnd);
			set => SetProperty(ref _vignetteEnd, value);
		}

		[Ordinal(20)] 
		[RED("vignetteIntensity")] 
		public CFloat VignetteIntensity
		{
			get => GetProperty(ref _vignetteIntensity);
			set => SetProperty(ref _vignetteIntensity, value);
		}

		[Ordinal(21)] 
		[RED("blurredRenderSaturation")] 
		public CFloat BlurredRenderSaturation
		{
			get => GetProperty(ref _blurredRenderSaturation);
			set => SetProperty(ref _blurredRenderSaturation, value);
		}

		[Ordinal(22)] 
		[RED("uiSaturation")] 
		public CFloat UiSaturation
		{
			get => GetProperty(ref _uiSaturation);
			set => SetProperty(ref _uiSaturation, value);
		}

		[Ordinal(23)] 
		[RED("chromaticAberrationStrength")] 
		public CFloat ChromaticAberrationStrength
		{
			get => GetProperty(ref _chromaticAberrationStrength);
			set => SetProperty(ref _chromaticAberrationStrength, value);
		}

		[Ordinal(24)] 
		[RED("uiLayer2Scale")] 
		public Vector2 UiLayer2Scale
		{
			get => GetProperty(ref _uiLayer2Scale);
			set => SetProperty(ref _uiLayer2Scale, value);
		}

		[Ordinal(25)] 
		[RED("uiLayer3Scale")] 
		public Vector2 UiLayer3Scale
		{
			get => GetProperty(ref _uiLayer3Scale);
			set => SetProperty(ref _uiLayer3Scale, value);
		}

		[Ordinal(26)] 
		[RED("uiLayer4Scale")] 
		public Vector2 UiLayer4Scale
		{
			get => GetProperty(ref _uiLayer4Scale);
			set => SetProperty(ref _uiLayer4Scale, value);
		}

		[Ordinal(27)] 
		[RED("uiLayer2Weight")] 
		public CFloat UiLayer2Weight
		{
			get => GetProperty(ref _uiLayer2Weight);
			set => SetProperty(ref _uiLayer2Weight, value);
		}

		[Ordinal(28)] 
		[RED("uiLayer3Weight")] 
		public CFloat UiLayer3Weight
		{
			get => GetProperty(ref _uiLayer3Weight);
			set => SetProperty(ref _uiLayer3Weight, value);
		}

		[Ordinal(29)] 
		[RED("uiLayer4Weight")] 
		public CFloat UiLayer4Weight
		{
			get => GetProperty(ref _uiLayer4Weight);
			set => SetProperty(ref _uiLayer4Weight, value);
		}
	}
}
