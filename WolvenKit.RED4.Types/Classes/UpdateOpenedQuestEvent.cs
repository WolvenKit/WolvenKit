using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateOpenedQuestEvent : redEvent
	{
		private CWeakHandle<gameJournalQuest> _openedQuest;

		[Ordinal(0)] 
		[RED("openedQuest")] 
		public CWeakHandle<gameJournalQuest> OpenedQuest
		{
			get => GetProperty(ref _openedQuest);
			set => SetProperty(ref _openedQuest, value);
		}
	}
}
