using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("arrow")] public inkWidgetReference Arrow { get; set; }
		[Ordinal(1)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(2)]  [RED("questType")] public CInt32 QuestType { get; set; }
		[Ordinal(3)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(4)]  [RED("title")] public inkTextWidgetReference Title { get; set; }

		public QuestListHeaderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
