using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DpadWheelItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("InventoryDataManager")] public CHandle<InventoryDataManagerV2> InventoryDataManager { get; set; }
		[Ordinal(1)]  [RED("abilityData")] public AbilityData AbilityData { get; set; }
		[Ordinal(2)]  [RED("abilityIcon")] public inkImageWidgetReference AbilityIcon { get; set; }
		[Ordinal(3)]  [RED("arrows")] public inkWidgetReference Arrows { get; set; }
		[Ordinal(4)]  [RED("data")] public QuickSlotCommand Data { get; set; }
		[Ordinal(5)]  [RED("displayWrapper")] public inkWidgetReference DisplayWrapper { get; set; }
		[Ordinal(6)]  [RED("highlight")] public inkImageWidgetReference Highlight { get; set; }
		[Ordinal(7)]  [RED("highlight02")] public inkImageWidgetReference Highlight02 { get; set; }
		[Ordinal(8)]  [RED("highlight03")] public inkImageWidgetReference Highlight03 { get; set; }
		[Ordinal(9)]  [RED("highlight04")] public inkImageWidgetReference Highlight04 { get; set; }
		[Ordinal(10)]  [RED("highlight05")] public inkImageWidgetReference Highlight05 { get; set; }
		[Ordinal(11)]  [RED("highlight06")] public inkImageWidgetReference Highlight06 { get; set; }
		[Ordinal(12)]  [RED("highlight07")] public inkImageWidgetReference Highlight07 { get; set; }
		[Ordinal(13)]  [RED("highlight08")] public inkImageWidgetReference Highlight08 { get; set; }
		[Ordinal(14)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(15)]  [RED("item")] public CHandle<InventoryItemDisplay> Item { get; set; }
		[Ordinal(16)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(17)]  [RED("itemWidget")] public CHandle<inkWidget> ItemWidget { get; set; }
		[Ordinal(18)]  [RED("itemWrapper")] public inkWidgetReference ItemWrapper { get; set; }
		[Ordinal(19)]  [RED("quickHackIcon")] public inkImageWidgetReference QuickHackIcon { get; set; }
		[Ordinal(20)]  [RED("quickHackWheelDefIcon")] public CName QuickHackWheelDefIcon { get; set; }
		[Ordinal(21)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(22)]  [RED("selectorWrapper")] public inkWidgetReference SelectorWrapper { get; set; }
		[Ordinal(23)]  [RED("textDist")] public CFloat TextDist { get; set; }
		[Ordinal(24)]  [RED("weaponTextDist")] public CFloat WeaponTextDist { get; set; }

		public DpadWheelItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
