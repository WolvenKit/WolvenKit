using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(2)] [RED("arrow")] public inkWidgetReference Arrow { get; set; }
		[Ordinal(3)] [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(4)] [RED("questType")] public CInt32 QuestType { get; set; }
		[Ordinal(5)] [RED("hovered")] public CBool Hovered { get; set; }

		public QuestListHeaderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
