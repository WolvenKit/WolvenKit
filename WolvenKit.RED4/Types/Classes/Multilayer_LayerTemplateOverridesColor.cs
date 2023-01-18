using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_LayerTemplateOverridesColor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("n")] 
		public CName N
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("v", 3)] 
		public CArrayFixedSize<CFloat> V
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		public Multilayer_LayerTemplateOverridesColor()
		{
			V = new(3);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
