using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipHeaderController : ItemTooltipModuleController
	{
		[Ordinal(2)] [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(3)] [RED("itemRarityText")] public inkTextWidgetReference ItemRarityText { get; set; }
		[Ordinal(4)] [RED("itemTypeText")] public inkTextWidgetReference ItemTypeText { get; set; }

		public ItemTooltipHeaderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
