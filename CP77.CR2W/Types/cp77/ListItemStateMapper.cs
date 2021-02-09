using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ListItemStateMapper : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("toggled")] public CBool Toggled { get; set; }
		[Ordinal(1)]  [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(2)]  [RED("new")] public CBool New { get; set; }
		[Ordinal(3)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public ListItemStateMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
