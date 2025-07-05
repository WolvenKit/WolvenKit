using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateOpenedQuestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("openedQuest")] 
		public CWeakHandle<gameJournalQuest> OpenedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		public UpdateOpenedQuestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
