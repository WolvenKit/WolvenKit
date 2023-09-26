using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryDataManagerV2 : IScriptable
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameuiHUDGameController> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameuiHUDGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHUDGameController>>(value);
		}

		[Ordinal(1)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(2)] 
		[RED("TransactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(3)] 
		[RED("EquipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("StatsSystem")] 
		public CWeakHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CWeakHandle<gameStatsSystem>>();
			set => SetPropertyValue<CWeakHandle<gameStatsSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("ItemModificationSystem")] 
		public CWeakHandle<ItemModificationSystem> ItemModificationSystem
		{
			get => GetPropertyValue<CWeakHandle<ItemModificationSystem>>();
			set => SetPropertyValue<CWeakHandle<ItemModificationSystem>>(value);
		}

		[Ordinal(6)] 
		[RED("LocMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get => GetPropertyValue<CHandle<UILocalizationMap>>();
			set => SetPropertyValue<CHandle<UILocalizationMap>>(value);
		}

		[Ordinal(7)] 
		[RED("InventoryItemsData")] 
		public CArray<gameInventoryItemData> InventoryItemsData
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(8)] 
		[RED("EquipmentAreaInventoryItemsData")] 
		public CArray<CArray<gameInventoryItemData>> EquipmentAreaInventoryItemsData
		{
			get => GetPropertyValue<CArray<CArray<gameInventoryItemData>>>();
			set => SetPropertyValue<CArray<CArray<gameInventoryItemData>>>(value);
		}

		[Ordinal(9)] 
		[RED("InventoryItemsDataWithoutEquipment")] 
		public CArray<gameInventoryItemData> InventoryItemsDataWithoutEquipment
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(10)] 
		[RED("EquipmentItemsData")] 
		public CArray<gameInventoryItemData> EquipmentItemsData
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(11)] 
		[RED("WeaponItemsData")] 
		public CArray<gameInventoryItemData> WeaponItemsData
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(12)] 
		[RED("QuickSlotsData")] 
		public CArray<gameInventoryItemData> QuickSlotsData
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(13)] 
		[RED("ConsumablesSlotsData")] 
		public CArray<gameInventoryItemData> ConsumablesSlotsData
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(14)] 
		[RED("PartsData")] 
		public CArray<InventoryPartsData> PartsData
		{
			get => GetPropertyValue<CArray<InventoryPartsData>>();
			set => SetPropertyValue<CArray<InventoryPartsData>>(value);
		}

		[Ordinal(15)] 
		[RED("ToRebuild")] 
		public CBool ToRebuild
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("ToRebuildEquipmentArea")] 
		public CArray<CBool> ToRebuildEquipmentArea
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(17)] 
		[RED("ToRebuildItemsWithEquipped")] 
		public CBool ToRebuildItemsWithEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("ToRebuildWeapons")] 
		public CBool ToRebuildWeapons
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("ToRebuildEquipment")] 
		public CBool ToRebuildEquipment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("ToRebuildQuickSlots")] 
		public CBool ToRebuildQuickSlots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("ToRebuildConsumables")] 
		public CBool ToRebuildConsumables
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("ActiveWeapon")] 
		public gameItemID ActiveWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(23)] 
		[RED("EquipRecords")] 
		public CArray<CHandle<gamedataEquipmentArea_Record>> EquipRecords
		{
			get => GetPropertyValue<CArray<CHandle<gamedataEquipmentArea_Record>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataEquipmentArea_Record>>>(value);
		}

		[Ordinal(24)] 
		[RED("ItemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get => GetPropertyValue<CEnum<gameItemIconGender>>();
			set => SetPropertyValue<CEnum<gameItemIconGender>>(value);
		}

		[Ordinal(25)] 
		[RED("WeaponUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> WeaponUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("UIBBEquipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("UIBBItemModBlackbord")] 
		public CWeakHandle<gameIBlackboard> UIBBItemModBlackbord
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(28)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(29)] 
		[RED("UIBBItemMod")] 
		public CHandle<UI_ItemModSystemDef> UIBBItemMod
		{
			get => GetPropertyValue<CHandle<UI_ItemModSystemDef>>();
			set => SetPropertyValue<CHandle<UI_ItemModSystemDef>>(value);
		}

		[Ordinal(30)] 
		[RED("InventoryBBID")] 
		public CHandle<redCallbackObject> InventoryBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("EquipmentBBID")] 
		public CHandle<redCallbackObject> EquipmentBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("SubEquipmentBBID")] 
		public CHandle<redCallbackObject> SubEquipmentBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("ItemModBBID")] 
		public CHandle<redCallbackObject> ItemModBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("BBWeaponList")] 
		public CHandle<redCallbackObject> BBWeaponList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("InventoryItemDataWrappers")] 
		public CArray<CHandle<InventoryItemDataWrapper>> InventoryItemDataWrappers
		{
			get => GetPropertyValue<CArray<CHandle<InventoryItemDataWrapper>>>();
			set => SetPropertyValue<CArray<CHandle<InventoryItemDataWrapper>>>(value);
		}

		[Ordinal(36)] 
		[RED("HashMapCache")] 
		public CHandle<inkScriptWeakHashMap> HashMapCache
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(37)] 
		[RED("uiInventorySystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		public InventoryDataManagerV2()
		{
			InventoryItemsData = new();
			EquipmentAreaInventoryItemsData = new();
			InventoryItemsDataWithoutEquipment = new();
			EquipmentItemsData = new();
			WeaponItemsData = new();
			QuickSlotsData = new();
			ConsumablesSlotsData = new();
			PartsData = new();
			ToRebuild = true;
			ToRebuildEquipmentArea = new();
			ToRebuildItemsWithEquipped = true;
			ToRebuildWeapons = true;
			ToRebuildEquipment = true;
			ToRebuildQuickSlots = true;
			ToRebuildConsumables = true;
			ActiveWeapon = new gameItemID();
			EquipRecords = new();
			InventoryItemDataWrappers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
