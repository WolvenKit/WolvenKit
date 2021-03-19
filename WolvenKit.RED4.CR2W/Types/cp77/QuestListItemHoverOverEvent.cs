using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListItemHoverOverEvent : redEvent
	{
		private CBool _isQuestResolved;

		[Ordinal(0)] 
		[RED("isQuestResolved")] 
		public CBool IsQuestResolved
		{
			get => GetProperty(ref _isQuestResolved);
			set => SetProperty(ref _isQuestResolved, value);
		}

		public QuestListItemHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
