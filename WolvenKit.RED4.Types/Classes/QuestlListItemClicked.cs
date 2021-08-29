using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestlListItemClicked : redEvent
	{
		private CWeakHandle<gameJournalQuest> _questData;
		private CBool _skipAnimation;

		[Ordinal(0)] 
		[RED("questData")] 
		public CWeakHandle<gameJournalQuest> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		[Ordinal(1)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetProperty(ref _skipAnimation);
			set => SetProperty(ref _skipAnimation, value);
		}
	}
}
