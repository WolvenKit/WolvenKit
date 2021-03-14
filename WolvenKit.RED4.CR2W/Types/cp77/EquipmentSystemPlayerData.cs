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
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "owner", cr2w, this);
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
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipment")] 
		public gameSLoadout Equipment
		{
			get
			{
				if (_equipment == null)
				{
					_equipment = (gameSLoadout) CR2WTypeManager.Create("gameSLoadout", "equipment", cr2w, this);
				}
				return _equipment;
			}
			set
			{
				if (_equipment == value)
				{
					return;
				}
				_equipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastUsedStruct")] 
		public gameSLastUsedWeapon LastUsedStruct
		{
			get
			{
				if (_lastUsedStruct == null)
				{
					_lastUsedStruct = (gameSLastUsedWeapon) CR2WTypeManager.Create("gameSLastUsedWeapon", "lastUsedStruct", cr2w, this);
				}
				return _lastUsedStruct;
			}
			set
			{
				if (_lastUsedStruct == value)
				{
					return;
				}
				_lastUsedStruct = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slotActiveItemsInHands")] 
		public gameSSlotActiveItems SlotActiveItemsInHands
		{
			get
			{
				if (_slotActiveItemsInHands == null)
				{
					_slotActiveItemsInHands = (gameSSlotActiveItems) CR2WTypeManager.Create("gameSSlotActiveItems", "slotActiveItemsInHands", cr2w, this);
				}
				return _slotActiveItemsInHands;
			}
			set
			{
				if (_slotActiveItemsInHands == value)
				{
					return;
				}
				_slotActiveItemsInHands = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hiddenItems")] 
		public CArray<gameItemID> HiddenItems
		{
			get
			{
				if (_hiddenItems == null)
				{
					_hiddenItems = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "hiddenItems", cr2w, this);
				}
				return _hiddenItems;
			}
			set
			{
				if (_hiddenItems == value)
				{
					return;
				}
				_hiddenItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("clothingSlotsInfo")] 
		public CArray<gameSSlotInfo> ClothingSlotsInfo
		{
			get
			{
				if (_clothingSlotsInfo == null)
				{
					_clothingSlotsInfo = (CArray<gameSSlotInfo>) CR2WTypeManager.Create("array:gameSSlotInfo", "clothingSlotsInfo", cr2w, this);
				}
				return _clothingSlotsInfo;
			}
			set
			{
				if (_clothingSlotsInfo == value)
				{
					return;
				}
				_clothingSlotsInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isPartialVisualTagActive")] 
		public CBool IsPartialVisualTagActive
		{
			get
			{
				if (_isPartialVisualTagActive == null)
				{
					_isPartialVisualTagActive = (CBool) CR2WTypeManager.Create("Bool", "isPartialVisualTagActive", cr2w, this);
				}
				return _isPartialVisualTagActive;
			}
			set
			{
				if (_isPartialVisualTagActive == value)
				{
					return;
				}
				_isPartialVisualTagActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("visualTagProcessingInfo")] 
		public CArray<gameSVisualTagProcessing> VisualTagProcessingInfo
		{
			get
			{
				if (_visualTagProcessingInfo == null)
				{
					_visualTagProcessingInfo = (CArray<gameSVisualTagProcessing>) CR2WTypeManager.Create("array:gameSVisualTagProcessing", "visualTagProcessingInfo", cr2w, this);
				}
				return _visualTagProcessingInfo;
			}
			set
			{
				if (_visualTagProcessingInfo == value)
				{
					return;
				}
				_visualTagProcessingInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("eventsSent")] 
		public CInt32 EventsSent
		{
			get
			{
				if (_eventsSent == null)
				{
					_eventsSent = (CInt32) CR2WTypeManager.Create("Int32", "eventsSent", cr2w, this);
				}
				return _eventsSent;
			}
			set
			{
				if (_eventsSent == value)
				{
					return;
				}
				_eventsSent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hotkeys")] 
		public CArray<CHandle<Hotkey>> Hotkeys
		{
			get
			{
				if (_hotkeys == null)
				{
					_hotkeys = (CArray<CHandle<Hotkey>>) CR2WTypeManager.Create("array:handle:Hotkey", "hotkeys", cr2w, this);
				}
				return _hotkeys;
			}
			set
			{
				if (_hotkeys == value)
				{
					return;
				}
				_hotkeys = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "inventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		public EquipmentSystemPlayerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
