using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipBottomModule : ItemTooltipModuleController
	{
		[Ordinal(1)]  [RED("weightWrapper")] public inkWidgetReference WeightWrapper { get; set; }
		[Ordinal(2)]  [RED("priceWrapper")] public inkWidgetReference PriceWrapper { get; set; }
		[Ordinal(3)]  [RED("weightText")] public inkTextWidgetReference WeightText { get; set; }
		[Ordinal(4)]  [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }

		public ItemTooltipBottomModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
