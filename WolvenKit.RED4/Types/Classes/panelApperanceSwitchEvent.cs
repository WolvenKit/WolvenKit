using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class panelApperanceSwitchEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newApperance")] 
		public CName NewApperance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public panelApperanceSwitchEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
