using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICNameArgumentInstancePS : AIArgumentInstancePS
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AICNameArgumentInstancePS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
