using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderClicked : redEvent
	{
		[Ordinal(0)] [RED("questType")] public CInt32 QuestType { get; set; }

		public QuestListHeaderClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
