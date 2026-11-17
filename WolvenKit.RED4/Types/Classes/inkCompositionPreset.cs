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
			ShaderParams = new fxCompositionShaderParams();
			Transitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
