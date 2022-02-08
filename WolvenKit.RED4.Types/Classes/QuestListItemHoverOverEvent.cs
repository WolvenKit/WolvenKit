using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListItemHoverOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isQuestResolved")] 
		public CBool IsQuestResolved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
