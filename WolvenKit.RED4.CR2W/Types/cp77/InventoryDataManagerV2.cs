using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryDataManagerV2 : IScriptable
	{
		private wCHandle<gameuiHUDGameController> _owner;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<EquipmentSystem> _equipmentSystem;
		private CHandle<gameStatsSystem> _statsSystem;
		private CHandle<ItemModificationSystem> _itemModificationSystem;
		private CHandle<UILocalizationMap> _locMgr;
		private CArray<InventoryItemData> _inventoryItemsData;
		private CArray<InventoryItemData> _inventoryItemsDataWithoutEquipment;
		private CArray<InventoryItemData> _equipmentItemsData;
		private CArray<InventoryItemData> _weaponItemsData;
		private CArray<InventoryItemData> _quickSlotsData;
		private CArray<InventoryItemData> _consumablesSlotsData;
		private CBool _toRebuild;
		private CBool _toRebuildItemsWithEquipped;
		private CBool _toRebuildWeapons;
		private CBool _toRebuildEquipment;
		private CBool _toRebuildQuickSlots;
		private CBool _toRebuildConsumables;
		private gameItemID _activeWeapon;
		private CArray<CHandle<gamedataEquipmentArea_Record>> _equipRecords;
		private CEnum<gameItemIconGender> _itemIconGender;
		private wCHandle<gameIBlackboard> _weaponUIBlackboard;
		private wCHandle<gameIBlackboard> _uIBBEquipmentBlackboard;
		private wCHandle<gameIBlackboard> _uIBBItemModBlackbord;
		private CHandle<UI_EquipmentDef> _uIBBEquipment;
		private CHandle<UI_ItemModSystemDef> _uIBBItemMod;
		private CUInt32 _inventoryBBID;
		private CUInt32 _equipmentBBID;
		private CUInt32 _subEquipmentBBID;
		private CUInt32 _itemModBBID;
		private CUInt32 _bBWeaponList;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameuiHUDGameController> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("TransactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("EquipmentSystem")] 
		public CHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(4)] 
		[RED("StatsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(5)] 
		[RED("ItemModificationSystem")] 
		public CHandle<ItemModificationSystem> ItemModificationSystem
		{
			get => GetProperty(ref _itemModificationSystem);
			set => SetProperty(ref _itemModificationSystem, value);
		}

		[Ordinal(6)] 
		[RED("LocMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get => GetProperty(ref _locMgr);
			set => SetProperty(ref _locMgr, value);
		}

		[Ordinal(7)] 
		[RED("InventoryItemsData")] 
		public CArray<InventoryItemData> InventoryItemsData
		{
			get => GetProperty(ref _inventoryItemsData);
			set => SetProperty(ref _inventoryItemsData, value);
		}

		[Ordinal(8)] 
		[RED("InventoryItemsDataWithoutEquipment")] 
		public CArray<InventoryItemData> InventoryItemsDataWithoutEquipment
		{
			get => GetProperty(ref _inventoryItemsDataWithoutEquipment);
			set => SetProperty(ref _inventoryItemsDataWithoutEquipment, value);
		}

		[Ordinal(9)] 
		[RED("EquipmentItemsData")] 
		public CArray<InventoryItemData> EquipmentItemsData
		{
			get => GetProperty(ref _equipmentItemsData);
			set => SetProperty(ref _equipmentItemsData, value);
		}

		[Ordinal(10)] 
		[RED("WeaponItemsData")] 
		public CArray<InventoryItemData> WeaponItemsData
		{
			get => GetProperty(ref _weaponItemsData);
			set => SetProperty(ref _weaponItemsData, value);
		}

		[Ordinal(11)] 
		[RED("QuickSlotsData")] 
		public CArray<InventoryItemData> QuickSlotsData
		{
			get => GetProperty(ref _quickSlotsData);
			set => SetProperty(ref _quickSlotsData, value);
		}

		[Ordinal(12)] 
		[RED("ConsumablesSlotsData")] 
		public CArray<InventoryItemData> ConsumablesSlotsData
		{
			get => GetProperty(ref _consumablesSlotsData);
			set => SetProperty(ref _consumablesSlotsData, value);
		}

		[Ordinal(13)] 
		[RED("ToRebuild")] 
		public CBool ToRebuild
		{
			get => GetProperty(ref _toRebuild);
			set => SetProperty(ref _toRebuild, value);
		}

		[Ordinal(14)] 
		[RED("ToRebuildItemsWithEquipped")] 
		public CBool ToRebuildItemsWithEquipped
		{
			get => GetProperty(ref _toRebuildItemsWithEquipped);
			set => SetProperty(ref _toRebuildItemsWithEquipped, value);
		}

		[Ordinal(15)] 
		[RED("ToRebuildWeapons")] 
		public CBool ToRebuildWeapons
		{
			get => GetProperty(ref _toRebuildWeapons);
			set => SetProperty(ref _toRebuildWeapons, value);
		}

		[Ordinal(16)] 
		[RED("ToRebuildEquipment")] 
		public CBool ToRebuildEquipment
		{
			get => GetProperty(ref _toRebuildEquipment);
			set => SetProperty(ref _toRebuildEquipment, value);
		}

		[Ordinal(17)] 
		[RED("ToRebuildQuickSlots")] 
		public CBool ToRebuildQuickSlots
		{
			get => GetProperty(ref _toRebuildQuickSlots);
			set => SetProperty(ref _toRebuildQuickSlots, value);
		}

		[Ordinal(18)] 
		[RED("ToRebuildConsumables")] 
		public CBool ToRebuildConsumables
		{
			get => GetProperty(ref _toRebuildConsumables);
			set => SetProperty(ref _toRebuildConsumables, value);
		}

		[Ordinal(19)] 
		[RED("ActiveWeapon")] 
		public gameItemID ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(20)] 
		[RED("EquipRecords")] 
		public CArray<CHandle<gamedataEquipmentArea_Record>> EquipRecords
		{
			get => GetProperty(ref _equipRecords);
			set => SetProperty(ref _equipRecords, value);
		}

		[Ordinal(21)] 
		[RED("ItemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get => GetProperty(ref _itemIconGender);
			set => SetProperty(ref _itemIconGender, value);
		}

		[Ordinal(22)] 
		[RED("WeaponUIBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponUIBlackboard
		{
			get => GetProperty(ref _weaponUIBlackboard);
			set => SetProperty(ref _weaponUIBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("UIBBEquipmentBlackboard")] 
		public wCHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get => GetProperty(ref _uIBBEquipmentBlackboard);
			set => SetProperty(ref _uIBBEquipmentBlackboard, value);
		}

		[Ordinal(24)] 
		[RED("UIBBItemModBlackbord")] 
		public wCHandle<gameIBlackboard> UIBBItemModBlackbord
		{
			get => GetProperty(ref _uIBBItemModBlackbord);
			set => SetProperty(ref _uIBBItemModBlackbord, value);
		}

		[Ordinal(25)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetProperty(ref _uIBBEquipment);
			set => SetProperty(ref _uIBBEquipment, value);
		}

		[Ordinal(26)] 
		[RED("UIBBItemMod")] 
		public CHandle<UI_ItemModSystemDef> UIBBItemMod
		{
			get => GetProperty(ref _uIBBItemMod);
			set => SetProperty(ref _uIBBItemMod, value);
		}

		[Ordinal(27)] 
		[RED("InventoryBBID")] 
		public CUInt32 InventoryBBID
		{
			get => GetProperty(ref _inventoryBBID);
			set => SetProperty(ref _inventoryBBID, value);
		}

		[Ordinal(28)] 
		[RED("EquipmentBBID")] 
		public CUInt32 EquipmentBBID
		{
			get => GetProperty(ref _equipmentBBID);
			set => SetProperty(ref _equipmentBBID, value);
		}

		[Ordinal(29)] 
		[RED("SubEquipmentBBID")] 
		public CUInt32 SubEquipmentBBID
		{
			get => GetProperty(ref _subEquipmentBBID);
			set => SetProperty(ref _subEquipmentBBID, value);
		}

		[Ordinal(30)] 
		[RED("ItemModBBID")] 
		public CUInt32 ItemModBBID
		{
			get => GetProperty(ref _itemModBBID);
			set => SetProperty(ref _itemModBBID, value);
		}

		[Ordinal(31)] 
		[RED("BBWeaponList")] 
		public CUInt32 BBWeaponList
		{
			get => GetProperty(ref _bBWeaponList);
			set => SetProperty(ref _bBWeaponList, value);
		}

		public InventoryDataManagerV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
