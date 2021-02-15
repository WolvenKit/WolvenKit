using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListItemHoverOverEvent : redEvent
	{
		[Ordinal(0)] [RED("isQuestResolved")] public CBool IsQuestResolved { get; set; }

		public QuestListItemHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
