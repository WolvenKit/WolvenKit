using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("hiddenItems")] 
		public CArray<gameItemID> HiddenItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(6)] 
		[RED("clothingSlotsInfo")] 
		public CArray<gameSSlotInfo> ClothingSlotsInfo
		{
			get => GetPropertyValue<CArray<gameSSlotInfo>>();
			set => SetPropertyValue<CArray<gameSSlotInfo>>(value);
		}

		[Ordinal(7)] 
		[RED("isPartialVisualTagActive")] 
		public CBool IsPartialVisualTagActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("visualTagProcessingInfo")] 
		public CArray<gameSVisualTagProcessing> VisualTagProcessingInfo
		{
			get => GetPropertyValue<CArray<gameSVisualTagProcessing>>();
			set => SetPropertyValue<CArray<gameSVisualTagProcessing>>(value);
		}

		[Ordinal(9)] 
		[RED("eventsSent")] 
		public CInt32 EventsSent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("hotkeys")] 
		public CArray<CHandle<Hotkey>> Hotkeys
		{
			get => GetPropertyValue<CArray<CHandle<Hotkey>>>();
			set => SetPropertyValue<CArray<CHandle<Hotkey>>>(value);
		}

		[Ordinal(11)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		public EquipmentSystemPlayerData()
		{
			OwnerID = new();
			Equipment = new() { EquipAreas = new(), EquipmentSets = new() };
			LastUsedStruct = new() { LastUsedWeapon = new(), LastUsedRanged = new(), LastUsedMelee = new(), LastUsedHeavy = new() };
			SlotActiveItemsInHands = new() { RightHandItem = new(), LeftHandItem = new() };
			HiddenItems = new();
			ClothingSlotsInfo = new();
			VisualTagProcessingInfo = new();
			Hotkeys = new();
		}
	}
}
