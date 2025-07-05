using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_LayerTemplateOverrides : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("colorScale")] 
		public CArray<Multilayer_LayerTemplateOverridesColor> ColorScale
		{
			get => GetPropertyValue<CArray<Multilayer_LayerTemplateOverridesColor>>();
			set => SetPropertyValue<CArray<Multilayer_LayerTemplateOverridesColor>>(value);
		}

		[Ordinal(1)] 
		[RED("roughLevelsIn")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsIn
		{
			get => GetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>();
			set => SetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>(value);
		}

		[Ordinal(2)] 
		[RED("roughLevelsOut")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsOut
		{
			get => GetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>();
			set => SetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>(value);
		}

		[Ordinal(3)] 
		[RED("metalLevelsIn")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsIn
		{
			get => GetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>();
			set => SetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>(value);
		}

		[Ordinal(4)] 
		[RED("metalLevelsOut")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsOut
		{
			get => GetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>();
			set => SetPropertyValue<CArray<Multilayer_LayerTemplateOverridesLevels>>(value);
		}

		[Ordinal(5)] 
		[RED("normalStrength")] 
		public CArray<Multilayer_LayerTemplateOverridesNormalStrength> NormalStrength
		{
			get => GetPropertyValue<CArray<Multilayer_LayerTemplateOverridesNormalStrength>>();
			set => SetPropertyValue<CArray<Multilayer_LayerTemplateOverridesNormalStrength>>(value);
		}

		public Multilayer_LayerTemplateOverrides()
		{
			ColorScale = new();
			RoughLevelsIn = new();
			RoughLevelsOut = new();
			MetalLevelsIn = new();
			MetalLevelsOut = new();
			NormalStrength = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
