using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystemPlayerData : IScriptable
	{
		private wCHandle<ScriptedPuppet> _owner;
		private entEntityID _ownerID;
		private gameSLoadout _equipment;
		private gameSLastUsedWeapon _lastUsedStruct;
		private gameSSlotActiveItems _slotActiveItemsInHands;
		private CArray<gameItemID> _hiddenItems;
		private CArray<gameSSlotInfo> _clothingSlotsInfo;
		private CBool _isPartialVisualTagActive;
		private CArray<gameSVisualTagProcessing> _visualTagProcessingInfo;
		private CInt32 _eventsSent;
		private CArray<CHandle<Hotkey>> _hotkeys;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<ScriptedPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(2)] 
		[RED("equipment")] 
		public gameSLoadout Equipment
		{
			get => GetProperty(ref _equipment);
			set => SetProperty(ref _equipment, value);
		}

		[Ordinal(3)] 
		[RED("lastUsedStruct")] 
		public gameSLastUsedWeapon LastUsedStruct
		{
			get => GetProperty(ref _lastUsedStruct);
			set => SetProperty(ref _lastUsedStruct, value);
		}

		[Ordinal(4)] 
		[RED("slotActiveItemsInHands")] 
		public gameSSlotActiveItems SlotActiveItemsInHands
		{
			get => GetProperty(ref _slotActiveItemsInHands);
			set => SetProperty(ref _slotActiveItemsInHands, value);
		}

		[Ordinal(5)] 
		[RED("hiddenItems")] 
		public CArray<gameItemID> HiddenItems
		{
			get => GetProperty(ref _hiddenItems);
			set => SetProperty(ref _hiddenItems, value);
		}

		[Ordinal(6)] 
		[RED("clothingSlotsInfo")] 
		public CArray<gameSSlotInfo> ClothingSlotsInfo
		{
			get => GetProperty(ref _clothingSlotsInfo);
			set => SetProperty(ref _clothingSlotsInfo, value);
		}

		[Ordinal(7)] 
		[RED("isPartialVisualTagActive")] 
		public CBool IsPartialVisualTagActive
		{
			get => GetProperty(ref _isPartialVisualTagActive);
			set => SetProperty(ref _isPartialVisualTagActive, value);
		}

		[Ordinal(8)] 
		[RED("visualTagProcessingInfo")] 
		public CArray<gameSVisualTagProcessing> VisualTagProcessingInfo
		{
			get => GetProperty(ref _visualTagProcessingInfo);
			set => SetProperty(ref _visualTagProcessingInfo, value);
		}

		[Ordinal(9)] 
		[RED("eventsSent")] 
		public CInt32 EventsSent
		{
			get => GetProperty(ref _eventsSent);
			set => SetProperty(ref _eventsSent, value);
		}

		[Ordinal(10)] 
		[RED("hotkeys")] 
		public CArray<CHandle<Hotkey>> Hotkeys
		{
			get => GetProperty(ref _hotkeys);
			set => SetProperty(ref _hotkeys, value);
		}

		[Ordinal(11)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		public EquipmentSystemPlayerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
