using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMixParamDescription : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioMixParamDescription()
		{
			DefaultValue = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
