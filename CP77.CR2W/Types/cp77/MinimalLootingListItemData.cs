using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimalLootingListItemData : IScriptable
	{
		[Ordinal(0)]  [RED("dpsDiff")] public CFloat DpsDiff { get; set; }
		[Ordinal(1)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(2)]  [RED("gameItemData")] public wCHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(3)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(4)]  [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(5)]  [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(6)]  [RED("lootItemType")] public CEnum<gameLootItemType> LootItemType { get; set; }
		[Ordinal(7)]  [RED("quality")] public CEnum<gamedataQuality> Quality { get; set; }
		[Ordinal(8)]  [RED("quantity")] public CInt32 Quantity { get; set; }

		public MinimalLootingListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
