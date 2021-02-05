using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipHeaderController : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("lineWidget")] public inkWidgetReference LineWidget { get; set; }
		[Ordinal(1)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(2)]  [RED("itemRarityText")] public inkTextWidgetReference ItemRarityText { get; set; }
		[Ordinal(3)]  [RED("itemTypeText")] public inkTextWidgetReference ItemTypeText { get; set; }

		public ItemTooltipHeaderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
