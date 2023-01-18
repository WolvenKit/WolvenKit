using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventBaseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamestateMachineeventBaseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
