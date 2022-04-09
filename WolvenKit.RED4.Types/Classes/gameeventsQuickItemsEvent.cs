using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsQuickItemsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("questName")] 
		public CName QuestName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameeventsQuickItemsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
