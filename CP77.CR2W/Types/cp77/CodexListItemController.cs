using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexListItemController : inkListItemController
	{
		[Ordinal(16)] [RED("doMarkNew")] public CBool DoMarkNew { get; set; }
		[Ordinal(17)] [RED("stateMapperRef")] public inkWidgetReference StateMapperRef { get; set; }
		[Ordinal(18)] [RED("stateMapper")] public wCHandle<ListItemStateMapper> StateMapper { get; set; }

		public CodexListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
