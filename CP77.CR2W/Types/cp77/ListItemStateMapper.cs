using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ListItemStateMapper : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("new")] public CBool New { get; set; }
		[Ordinal(1)]  [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(2)]  [RED("toggled")] public CBool Toggled { get; set; }
		[Ordinal(3)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public ListItemStateMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
