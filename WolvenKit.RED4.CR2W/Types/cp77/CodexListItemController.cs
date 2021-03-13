using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
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
