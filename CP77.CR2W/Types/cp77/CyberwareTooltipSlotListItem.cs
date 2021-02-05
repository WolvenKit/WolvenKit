using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipSlotListItem : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("Root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(1)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(3)]  [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(4)]  [RED("data")] public CHandle<CyberwareSlotTooltipData> Data { get; set; }

		public CyberwareTooltipSlotListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
