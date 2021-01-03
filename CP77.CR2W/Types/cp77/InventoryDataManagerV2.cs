using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryDataManagerV2 : IScriptable
	{
		[Ordinal(0)]  [RED("ActiveWeapon")] public gameItemID ActiveWeapon { get; set; }
		[Ordinal(1)]  [RED("BBWeaponList")] public CUInt32 BBWeaponList { get; set; }
		[Ordinal(2)]  [RED("ConsumablesSlotsData")] public CArray<InventoryItemData> ConsumablesSlotsData { get; set; }
		[Ordinal(3)]  [RED("EquipRecords")] public CArray<CHandle<gamedataEquipmentArea_Record>> EquipRecords { get; set; }
		[Ordinal(4)]  [RED("EquipmentBBID")] public CUInt32 EquipmentBBID { get; set; }
		[Ordinal(5)]  [RED("EquipmentItemsData")] public CArray<InventoryItemData> EquipmentItemsData { get; set; }
		[Ordinal(6)]  [RED("EquipmentSystem")] public CHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(7)]  [RED("InventoryBBID")] public CUInt32 InventoryBBID { get; set; }
		[Ordinal(8)]  [RED("InventoryItemsData")] public CArray<InventoryItemData> InventoryItemsData { get; set; }
		[Ordinal(9)]  [RED("InventoryItemsDataWithoutEquipment")] public CArray<InventoryItemData> InventoryItemsDataWithoutEquipment { get; set; }
		[Ordinal(10)]  [RED("ItemIconGender")] public CEnum<gameItemIconGender> ItemIconGender { get; set; }
		[Ordinal(11)]  [RED("ItemModBBID")] public CUInt32 ItemModBBID { get; set; }
		[Ordinal(12)]  [RED("ItemModificationSystem")] public CHandle<ItemModificationSystem> ItemModificationSystem { get; set; }
		[Ordinal(13)]  [RED("LocMgr")] public CHandle<UILocalizationMap> LocMgr { get; set; }
		[Ordinal(14)]  [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(15)]  [RED("QuickSlotsData")] public CArray<InventoryItemData> QuickSlotsData { get; set; }
		[Ordinal(16)]  [RED("StatsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(17)]  [RED("SubEquipmentBBID")] public CUInt32 SubEquipmentBBID { get; set; }
		[Ordinal(18)]  [RED("ToRebuild")] public CBool ToRebuild { get; set; }
		[Ordinal(19)]  [RED("ToRebuildConsumables")] public CBool ToRebuildConsumables { get; set; }
		[Ordinal(20)]  [RED("ToRebuildEquipment")] public CBool ToRebuildEquipment { get; set; }
		[Ordinal(21)]  [RED("ToRebuildItemsWithEquipped")] public CBool ToRebuildItemsWithEquipped { get; set; }
		[Ordinal(22)]  [RED("ToRebuildQuickSlots")] public CBool ToRebuildQuickSlots { get; set; }
		[Ordinal(23)]  [RED("ToRebuildWeapons")] public CBool ToRebuildWeapons { get; set; }
		[Ordinal(24)]  [RED("TransactionSystem")] public CHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(25)]  [RED("UIBBEquipment")] public CHandle<UI_EquipmentDef> UIBBEquipment { get; set; }
		[Ordinal(26)]  [RED("UIBBEquipmentBlackboard")] public CHandle<gameIBlackboard> UIBBEquipmentBlackboard { get; set; }
		[Ordinal(27)]  [RED("UIBBItemMod")] public CHandle<UI_ItemModSystemDef> UIBBItemMod { get; set; }
		[Ordinal(28)]  [RED("UIBBItemModBlackbord")] public CHandle<gameIBlackboard> UIBBItemModBlackbord { get; set; }
		[Ordinal(29)]  [RED("WeaponItemsData")] public CArray<InventoryItemData> WeaponItemsData { get; set; }
		[Ordinal(30)]  [RED("WeaponUIBlackboard")] public CHandle<gameIBlackboard> WeaponUIBlackboard { get; set; }
		[Ordinal(31)]  [RED("owner")] public wCHandle<gameuiHUDGameController> Owner { get; set; }

		public InventoryDataManagerV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
