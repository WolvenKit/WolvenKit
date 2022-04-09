using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_LayerTemplateOverridesNormalStrength : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("n")] 
		public CName N
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("v")] 
		public CFloat V
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Multilayer_LayerTemplateOverridesNormalStrength()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
