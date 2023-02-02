using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCompositionPreset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stateName")] 
		public CName StateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("useBackgroundTexture")] 
		public CBool UseBackgroundTexture
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("shaderParams")] 
		public fxCompositionShaderParams ShaderParams
		{
			get => GetPropertyValue<fxCompositionShaderParams>();
			set => SetPropertyValue<fxCompositionShaderParams>(value);
		}

		[Ordinal(3)] 
		[RED("transitions")] 
		public CArray<inkCompositionTransition> Transitions
		{
			get => GetPropertyValue<CArray<inkCompositionTransition>>();
			set => SetPropertyValue<CArray<inkCompositionTransition>>(value);
		}

		public inkCompositionPreset()
		{
			ShaderParams = new() { SphericalDistPower = new(), ShadowDistance = new(), ShadowRadius = 1.000000F, GlowIntensity = 0.500000F, GlowTresholdStart = 0.750000F, GlowTresholdEnd = 1.000000F, BlurredRenderSaturation = 0.730000F, UiSaturation = 1.000000F, ChromaticAberrationStrength = 0.000750F, UiLayer2Scale = new() { X = -0.005000F, Y = -0.002500F }, UiLayer3Scale = new() { X = -0.010800F, Y = -0.006800F }, UiLayer4Scale = new() { X = -0.012600F, Y = -0.007300F }, UiLayer2Weight = 0.080000F, UiLayer3Weight = 0.070000F, UiLayer4Weight = 0.060000F };
			Transitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
