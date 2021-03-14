using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipSlotListItem : AGenericTooltipController
	{
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(4)] [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(5)] [RED("data")] public CHandle<CyberwareSlotTooltipData> Data { get; set; }

		public CyberwareTooltipSlotListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
