using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListItemHoverOverEvent : redEvent
	{
		private CBool _isQuestResolved;

		[Ordinal(0)] 
		[RED("isQuestResolved")] 
		public CBool IsQuestResolved
		{
			get => GetProperty(ref _isQuestResolved);
			set => SetProperty(ref _isQuestResolved, value);
		}
	}
}
