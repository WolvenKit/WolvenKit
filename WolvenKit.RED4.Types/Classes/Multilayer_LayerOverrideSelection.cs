using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_LayerOverrideSelection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("colorScale")] 
		public CName ColorScale
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("normalStrength")] 
		public CName NormalStrength
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("roughLevelsIn")] 
		public CName RoughLevelsIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("roughLevelsOut")] 
		public CName RoughLevelsOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("metalLevelsIn")] 
		public CName MetalLevelsIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("metalLevelsOut")] 
		public CName MetalLevelsOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Multilayer_LayerOverrideSelection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
