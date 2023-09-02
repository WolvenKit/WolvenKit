using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItem : IScriptable
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("Hash")] 
		public CUInt64 Hash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		[Ordinal(3)] 
		[RED("manager")] 
		public CWeakHandle<UIInventoryItemsManager> Manager
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItemsManager>>(value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("itemData")] 
		public CWeakHandle<gameItemData> ItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(6)] 
		[RED("itemRecord")] 
		public CWeakHandle<gamedataItem_Record> ItemRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("realItemRecord")] 
		public CWeakHandle<gamedataItem_Record> RealItemRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(8)] 
		[RED("itemTweakID")] 
		public TweakDBID ItemTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("realItemTweakID")] 
		public TweakDBID RealItemTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<UIInventoryItemInternalData> Data
		{
			get => GetPropertyValue<CHandle<UIInventoryItemInternalData>>();
			set => SetPropertyValue<CHandle<UIInventoryItemInternalData>>(value);
		}

		[Ordinal(11)] 
		[RED("weaponData")] 
		public CHandle<UIInventoryWeaponInternalData> WeaponData
		{
			get => GetPropertyValue<CHandle<UIInventoryWeaponInternalData>>();
			set => SetPropertyValue<CHandle<UIInventoryWeaponInternalData>>(value);
		}

		[Ordinal(12)] 
		[RED("programData")] 
		public CHandle<UIInventoryItemProgramData> ProgramData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemProgramData>>();
			set => SetPropertyValue<CHandle<UIInventoryItemProgramData>>(value);
		}

		[Ordinal(13)] 
		[RED("grenadeData")] 
		public CHandle<UIInventoryItemGrenadeData> GrenadeData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemGrenadeData>>();
			set => SetPropertyValue<CHandle<UIInventoryItemGrenadeData>>(value);
		}

		[Ordinal(14)] 
		[RED("parentItem")] 
		public CWeakHandle<gameItemData> ParentItem
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(15)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("fetchedFlags")] 
		public CInt32 FetchedFlags
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("isQuantityDirty")] 
		public CBool IsQuantityDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("craftingResult")] 
		public CWeakHandle<gamedataCraftingResult_Record> CraftingResult
		{
			get => GetPropertyValue<CWeakHandle<gamedataCraftingResult_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataCraftingResult_Record>>(value);
		}

		[Ordinal(19)] 
		[RED("TEMP_isEquippedPrefetched")] 
		public CBool TEMP_isEquippedPrefetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("TEMP_isEquipped")] 
		public CBool TEMP_isEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInventoryItem()
		{
			ID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
