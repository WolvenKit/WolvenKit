using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPlayerProximityStopEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("profile")] 
		public CName Profile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldPlayerProximityStopEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
