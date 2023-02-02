using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPlayerProximityStartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("profile")] 
		public CName Profile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldPlayerProximityStartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
