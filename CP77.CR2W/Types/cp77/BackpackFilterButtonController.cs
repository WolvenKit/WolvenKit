using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackpackFilterButtonController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(1)]  [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(2)]  [RED("filterType")] public CEnum<ItemFilterCategory> FilterType { get; set; }
		[Ordinal(3)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(4)]  [RED("hovered")] public CBool Hovered { get; set; }

		public BackpackFilterButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
