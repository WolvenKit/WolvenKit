using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsPerfectChargeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CName Type
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameweaponeventsPerfectChargeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
