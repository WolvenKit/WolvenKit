using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAppearanceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entAppearanceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
