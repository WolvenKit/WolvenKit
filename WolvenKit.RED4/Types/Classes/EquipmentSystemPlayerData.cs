using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentSystemPlayerData : IScriptable
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<ScriptedPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("equipment")] 
		public gameSLoadout Equipment
		{
			get => GetPropertyValue<gameSLoadout>();
			set => SetPropertyValue<gameSLoadout>(value);
		}

		[Ordinal(3)] 
		[RED("lastUsedStruct")] 
		public gameSLastUsedWeapon LastUsedStruct
		{
			get => GetPropertyValue<gameSLastUsedWeapon>();
			set => SetPropertyValue<gameSLastUsedWeapon>(value);
		}

		[Ordinal(4)] 
		[RED("slotActiveItemsInHands")] 
		public gameSSlotActiveItems SlotActiveItemsInHands
		{
			get => GetPropertyValue<gameSSlotActiveItems>();
			set => SetPropertyValue<gameSSlotActiveItems>(value);
		}

		[Ordinal(5)] 
		[RED("clothingSlotsInfo")] 
		public CArray<gameSSlotInfo> ClothingSlotsInfo
		{
			get => GetPropertyValue<CArray<gameSSlotInfo>>();
			set => SetPropertyValue<CArray<gameSSlotInfo>>(value);
		}

		[Ordinal(6)] 
		[RED("clothingVisualsInfo")] 
		public CArray<gameSSlotVisualInfo> ClothingVisualsInfo
		{
			get => GetPropertyValue<CArray<gameSSlotVisualInfo>>();
			set => SetPropertyValue<CArray<gameSSlotVisualInfo>>(value);
		}

		[Ordinal(7)] 
		[RED("visualUnequipTransition")] 
		public CBool VisualUnequipTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("wardrobeDisabled")] 
		public CBool WardrobeDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("lastActiveWardrobeSet")] 
		public CEnum<gameWardrobeClothingSetIndex> LastActiveWardrobeSet
		{
			get => GetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>();
			set => SetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>(value);
		}

		[Ordinal(10)] 
		[RED("visualTagProcessingInfo")] 
		public CArray<gameSVisualTagProcessing> VisualTagProcessingInfo
		{
			get => GetPropertyValue<CArray<gameSVisualTagProcessing>>();
			set => SetPropertyValue<CArray<gameSVisualTagProcessing>>(value);
		}

		[Ordinal(11)] 
		[RED("eventsSent")] 
		public CInt32 EventsSent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("hotkeys")] 
		public CArray<CHandle<Hotkey>> Hotkeys
		{
			get => GetPropertyValue<CArray<CHandle<Hotkey>>>();
			set => SetPropertyValue<CArray<CHandle<Hotkey>>>(value);
		}

		[Ordinal(13)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(14)] 
		[RED("wardrobeSystem")] 
		public CHandle<gameWardrobeSystem> WardrobeSystem
		{
			get => GetPropertyValue<CHandle<gameWardrobeSystem>>();
			set => SetPropertyValue<CHandle<gameWardrobeSystem>>(value);
		}

		[Ordinal(15)] 
		[RED("equipPending")] 
		public CBool EquipPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("equipAreaIndexCache")] 
		public CArray<CInt32> EquipAreaIndexCache
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public EquipmentSystemPlayerData()
		{
			OwnerID = new entEntityID();
			Equipment = new gameSLoadout { EquipAreas = new(), EquipmentSets = new() };
			LastUsedStruct = new gameSLastUsedWeapon { LastUsedWeapon = new gameItemID(), LastUsedRanged = new gameItemID(), LastUsedMelee = new gameItemID(), LastUsedHeavy = new gameItemID() };
			SlotActiveItemsInHands = new gameSSlotActiveItems { RightHandItem = new gameItemID(), LeftHandItem = new gameItemID() };
			ClothingSlotsInfo = new();
			ClothingVisualsInfo = new();
			LastActiveWardrobeSet = Enums.gameWardrobeClothingSetIndex.INVALID;
			VisualTagProcessingInfo = new();
			Hotkeys = new();
			EquipAreaIndexCache = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
