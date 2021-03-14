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
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameuiHUDGameController>) CR2WTypeManager.Create("whandle:gameuiHUDGameController", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "Player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("TransactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "TransactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("EquipmentSystem")] 
		public CHandle<EquipmentSystem> EquipmentSystem
		{
			get
			{
				if (_equipmentSystem == null)
				{
					_equipmentSystem = (CHandle<EquipmentSystem>) CR2WTypeManager.Create("handle:EquipmentSystem", "EquipmentSystem", cr2w, this);
				}
				return _equipmentSystem;
			}
			set
			{
				if (_equipmentSystem == value)
				{
					return;
				}
				_equipmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("StatsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get
			{
				if (_statsSystem == null)
				{
					_statsSystem = (CHandle<gameStatsSystem>) CR2WTypeManager.Create("handle:gameStatsSystem", "StatsSystem", cr2w, this);
				}
				return _statsSystem;
			}
			set
			{
				if (_statsSystem == value)
				{
					return;
				}
				_statsSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ItemModificationSystem")] 
		public CHandle<ItemModificationSystem> ItemModificationSystem
		{
			get
			{
				if (_itemModificationSystem == null)
				{
					_itemModificationSystem = (CHandle<ItemModificationSystem>) CR2WTypeManager.Create("handle:ItemModificationSystem", "ItemModificationSystem", cr2w, this);
				}
				return _itemModificationSystem;
			}
			set
			{
				if (_itemModificationSystem == value)
				{
					return;
				}
				_itemModificationSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("LocMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get
			{
				if (_locMgr == null)
				{
					_locMgr = (CHandle<UILocalizationMap>) CR2WTypeManager.Create("handle:UILocalizationMap", "LocMgr", cr2w, this);
				}
				return _locMgr;
			}
			set
			{
				if (_locMgr == value)
				{
					return;
				}
				_locMgr = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("InventoryItemsData")] 
		public CArray<InventoryItemData> InventoryItemsData
		{
			get
			{
				if (_inventoryItemsData == null)
				{
					_inventoryItemsData = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "InventoryItemsData", cr2w, this);
				}
				return _inventoryItemsData;
			}
			set
			{
				if (_inventoryItemsData == value)
				{
					return;
				}
				_inventoryItemsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("InventoryItemsDataWithoutEquipment")] 
		public CArray<InventoryItemData> InventoryItemsDataWithoutEquipment
		{
			get
			{
				if (_inventoryItemsDataWithoutEquipment == null)
				{
					_inventoryItemsDataWithoutEquipment = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "InventoryItemsDataWithoutEquipment", cr2w, this);
				}
				return _inventoryItemsDataWithoutEquipment;
			}
			set
			{
				if (_inventoryItemsDataWithoutEquipment == value)
				{
					return;
				}
				_inventoryItemsDataWithoutEquipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("EquipmentItemsData")] 
		public CArray<InventoryItemData> EquipmentItemsData
		{
			get
			{
				if (_equipmentItemsData == null)
				{
					_equipmentItemsData = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "EquipmentItemsData", cr2w, this);
				}
				return _equipmentItemsData;
			}
			set
			{
				if (_equipmentItemsData == value)
				{
					return;
				}
				_equipmentItemsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("WeaponItemsData")] 
		public CArray<InventoryItemData> WeaponItemsData
		{
			get
			{
				if (_weaponItemsData == null)
				{
					_weaponItemsData = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "WeaponItemsData", cr2w, this);
				}
				return _weaponItemsData;
			}
			set
			{
				if (_weaponItemsData == value)
				{
					return;
				}
				_weaponItemsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("QuickSlotsData")] 
		public CArray<InventoryItemData> QuickSlotsData
		{
			get
			{
				if (_quickSlotsData == null)
				{
					_quickSlotsData = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "QuickSlotsData", cr2w, this);
				}
				return _quickSlotsData;
			}
			set
			{
				if (_quickSlotsData == value)
				{
					return;
				}
				_quickSlotsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ConsumablesSlotsData")] 
		public CArray<InventoryItemData> ConsumablesSlotsData
		{
			get
			{
				if (_consumablesSlotsData == null)
				{
					_consumablesSlotsData = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "ConsumablesSlotsData", cr2w, this);
				}
				return _consumablesSlotsData;
			}
			set
			{
				if (_consumablesSlotsData == value)
				{
					return;
				}
				_consumablesSlotsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ToRebuild")] 
		public CBool ToRebuild
		{
			get
			{
				if (_toRebuild == null)
				{
					_toRebuild = (CBool) CR2WTypeManager.Create("Bool", "ToRebuild", cr2w, this);
				}
				return _toRebuild;
			}
			set
			{
				if (_toRebuild == value)
				{
					return;
				}
				_toRebuild = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ToRebuildItemsWithEquipped")] 
		public CBool ToRebuildItemsWithEquipped
		{
			get
			{
				if (_toRebuildItemsWithEquipped == null)
				{
					_toRebuildItemsWithEquipped = (CBool) CR2WTypeManager.Create("Bool", "ToRebuildItemsWithEquipped", cr2w, this);
				}
				return _toRebuildItemsWithEquipped;
			}
			set
			{
				if (_toRebuildItemsWithEquipped == value)
				{
					return;
				}
				_toRebuildItemsWithEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("ToRebuildWeapons")] 
		public CBool ToRebuildWeapons
		{
			get
			{
				if (_toRebuildWeapons == null)
				{
					_toRebuildWeapons = (CBool) CR2WTypeManager.Create("Bool", "ToRebuildWeapons", cr2w, this);
				}
				return _toRebuildWeapons;
			}
			set
			{
				if (_toRebuildWeapons == value)
				{
					return;
				}
				_toRebuildWeapons = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ToRebuildEquipment")] 
		public CBool ToRebuildEquipment
		{
			get
			{
				if (_toRebuildEquipment == null)
				{
					_toRebuildEquipment = (CBool) CR2WTypeManager.Create("Bool", "ToRebuildEquipment", cr2w, this);
				}
				return _toRebuildEquipment;
			}
			set
			{
				if (_toRebuildEquipment == value)
				{
					return;
				}
				_toRebuildEquipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ToRebuildQuickSlots")] 
		public CBool ToRebuildQuickSlots
		{
			get
			{
				if (_toRebuildQuickSlots == null)
				{
					_toRebuildQuickSlots = (CBool) CR2WTypeManager.Create("Bool", "ToRebuildQuickSlots", cr2w, this);
				}
				return _toRebuildQuickSlots;
			}
			set
			{
				if (_toRebuildQuickSlots == value)
				{
					return;
				}
				_toRebuildQuickSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ToRebuildConsumables")] 
		public CBool ToRebuildConsumables
		{
			get
			{
				if (_toRebuildConsumables == null)
				{
					_toRebuildConsumables = (CBool) CR2WTypeManager.Create("Bool", "ToRebuildConsumables", cr2w, this);
				}
				return _toRebuildConsumables;
			}
			set
			{
				if (_toRebuildConsumables == value)
				{
					return;
				}
				_toRebuildConsumables = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ActiveWeapon")] 
		public gameItemID ActiveWeapon
		{
			get
			{
				if (_activeWeapon == null)
				{
					_activeWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "ActiveWeapon", cr2w, this);
				}
				return _activeWeapon;
			}
			set
			{
				if (_activeWeapon == value)
				{
					return;
				}
				_activeWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("EquipRecords")] 
		public CArray<CHandle<gamedataEquipmentArea_Record>> EquipRecords
		{
			get
			{
				if (_equipRecords == null)
				{
					_equipRecords = (CArray<CHandle<gamedataEquipmentArea_Record>>) CR2WTypeManager.Create("array:handle:gamedataEquipmentArea_Record", "EquipRecords", cr2w, this);
				}
				return _equipRecords;
			}
			set
			{
				if (_equipRecords == value)
				{
					return;
				}
				_equipRecords = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ItemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get
			{
				if (_itemIconGender == null)
				{
					_itemIconGender = (CEnum<gameItemIconGender>) CR2WTypeManager.Create("gameItemIconGender", "ItemIconGender", cr2w, this);
				}
				return _itemIconGender;
			}
			set
			{
				if (_itemIconGender == value)
				{
					return;
				}
				_itemIconGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("WeaponUIBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponUIBlackboard
		{
			get
			{
				if (_weaponUIBlackboard == null)
				{
					_weaponUIBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "WeaponUIBlackboard", cr2w, this);
				}
				return _weaponUIBlackboard;
			}
			set
			{
				if (_weaponUIBlackboard == value)
				{
					return;
				}
				_weaponUIBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("UIBBEquipmentBlackboard")] 
		public wCHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get
			{
				if (_uIBBEquipmentBlackboard == null)
				{
					_uIBBEquipmentBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "UIBBEquipmentBlackboard", cr2w, this);
				}
				return _uIBBEquipmentBlackboard;
			}
			set
			{
				if (_uIBBEquipmentBlackboard == value)
				{
					return;
				}
				_uIBBEquipmentBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("UIBBItemModBlackbord")] 
		public wCHandle<gameIBlackboard> UIBBItemModBlackbord
		{
			get
			{
				if (_uIBBItemModBlackbord == null)
				{
					_uIBBItemModBlackbord = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "UIBBItemModBlackbord", cr2w, this);
				}
				return _uIBBItemModBlackbord;
			}
			set
			{
				if (_uIBBItemModBlackbord == value)
				{
					return;
				}
				_uIBBItemModBlackbord = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get
			{
				if (_uIBBEquipment == null)
				{
					_uIBBEquipment = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "UIBBEquipment", cr2w, this);
				}
				return _uIBBEquipment;
			}
			set
			{
				if (_uIBBEquipment == value)
				{
					return;
				}
				_uIBBEquipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("UIBBItemMod")] 
		public CHandle<UI_ItemModSystemDef> UIBBItemMod
		{
			get
			{
				if (_uIBBItemMod == null)
				{
					_uIBBItemMod = (CHandle<UI_ItemModSystemDef>) CR2WTypeManager.Create("handle:UI_ItemModSystemDef", "UIBBItemMod", cr2w, this);
				}
				return _uIBBItemMod;
			}
			set
			{
				if (_uIBBItemMod == value)
				{
					return;
				}
				_uIBBItemMod = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("InventoryBBID")] 
		public CUInt32 InventoryBBID
		{
			get
			{
				if (_inventoryBBID == null)
				{
					_inventoryBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "InventoryBBID", cr2w, this);
				}
				return _inventoryBBID;
			}
			set
			{
				if (_inventoryBBID == value)
				{
					return;
				}
				_inventoryBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("EquipmentBBID")] 
		public CUInt32 EquipmentBBID
		{
			get
			{
				if (_equipmentBBID == null)
				{
					_equipmentBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "EquipmentBBID", cr2w, this);
				}
				return _equipmentBBID;
			}
			set
			{
				if (_equipmentBBID == value)
				{
					return;
				}
				_equipmentBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("SubEquipmentBBID")] 
		public CUInt32 SubEquipmentBBID
		{
			get
			{
				if (_subEquipmentBBID == null)
				{
					_subEquipmentBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "SubEquipmentBBID", cr2w, this);
				}
				return _subEquipmentBBID;
			}
			set
			{
				if (_subEquipmentBBID == value)
				{
					return;
				}
				_subEquipmentBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ItemModBBID")] 
		public CUInt32 ItemModBBID
		{
			get
			{
				if (_itemModBBID == null)
				{
					_itemModBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "ItemModBBID", cr2w, this);
				}
				return _itemModBBID;
			}
			set
			{
				if (_itemModBBID == value)
				{
					return;
				}
				_itemModBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("BBWeaponList")] 
		public CUInt32 BBWeaponList
		{
			get
			{
				if (_bBWeaponList == null)
				{
					_bBWeaponList = (CUInt32) CR2WTypeManager.Create("Uint32", "BBWeaponList", cr2w, this);
				}
				return _bBWeaponList;
			}
			set
			{
				if (_bBWeaponList == value)
				{
					return;
				}
				_bBWeaponList = value;
				PropertySet(this);
			}
		}

		public InventoryDataManagerV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
