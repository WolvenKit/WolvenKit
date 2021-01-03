using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CodexListItemController : inkListItemController
	{
		[Ordinal(0)]  [RED("doMarkNew")] public CBool DoMarkNew { get; set; }
		[Ordinal(1)]  [RED("stateMapper")] public wCHandle<ListItemStateMapper> StateMapper { get; set; }
		[Ordinal(2)]  [RED("stateMapperRef")] public inkWidgetReference StateMapperRef { get; set; }

		public CodexListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
