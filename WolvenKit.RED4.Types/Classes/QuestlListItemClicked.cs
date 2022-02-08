using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestlListItemClicked : redEvent
	{
		[Ordinal(0)] 
		[RED("questData")] 
		public CWeakHandle<gameJournalQuest> QuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(1)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
