using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LootingListItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("comparisionArrow")] public inkImageWidgetReference ComparisionArrow { get; set; }
		[Ordinal(1)]  [RED("defaultIcon")] public inkWidgetReference DefaultIcon { get; set; }
		[Ordinal(2)]  [RED("highlightFrames")] public CArray<inkWidgetReference> HighlightFrames { get; set; }
		[Ordinal(3)]  [RED("iconicLines")] public inkWidgetReference IconicLines { get; set; }
		[Ordinal(4)]  [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(5)]  [RED("itemQuantity")] public inkTextWidgetReference ItemQuantity { get; set; }
		[Ordinal(6)]  [RED("itemRarity")] public inkWidgetReference ItemRarity { get; set; }
		[Ordinal(7)]  [RED("itemTypeIcon")] public inkImageWidgetReference ItemTypeIcon { get; set; }
		[Ordinal(8)]  [RED("itemTypeIconWrapper")] public inkWidgetReference ItemTypeIconWrapper { get; set; }
		[Ordinal(9)]  [RED("lootingData")] public CHandle<MinimalLootingListItemData> LootingData { get; set; }
		[Ordinal(10)]  [RED("specialIcon")] public inkImageWidgetReference SpecialIcon { get; set; }
		[Ordinal(11)]  [RED("tooltipData")] public CHandle<InventoryTooltipData> TooltipData { get; set; }
		[Ordinal(12)]  [RED("widgetWrapper")] public inkWidgetReference WidgetWrapper { get; set; }

		public LootingListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
