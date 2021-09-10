using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateOpenedQuestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("openedQuest")] 
		public CWeakHandle<gameJournalQuest> OpenedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}
	}
}
