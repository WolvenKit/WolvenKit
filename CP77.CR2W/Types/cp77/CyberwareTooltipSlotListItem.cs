using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipSlotListItem : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<CyberwareSlotTooltipData> Data { get; set; }
		[Ordinal(1)]  [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("label")] public inkTextWidgetReference Label { get; set; }

		public CyberwareTooltipSlotListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
