using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotCommand : CVariable
	{
		private CEnum<QuickSlotActionType> _actionType;
		private CBool _isSlotUnlocked;
		private CBool _isLocked;
		private CName _atlasPath;
		private CName _iconName;
		private CInt32 _maxTier;
		private CInt32 _vehicleState;
		private gameItemID _itemId;
		private CString _title;
		private CString _type;
		private CString _description;
		private CBool _isEquipped;
		private CInt32 _intData;
		private vehiclePlayerVehicle _playerVehicleData;
		private CEnum<QuickSlotItemType> _itemType;
		private CEnum<gamedataEquipmentArea> _equipType;
		private CInt32 _slotIndex;
		private CHandle<gamedeviceAction> _interactiveAction;
		private entEntityID _interactiveActionOwner;

		[Ordinal(0)] 
		[RED("ActionType")] 
		public CEnum<QuickSlotActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<QuickSlotActionType>) CR2WTypeManager.Create("QuickSlotActionType", "ActionType", cr2w, this);
				}
				return _actionType;
			}
			set
			{
				if (_actionType == value)
				{
					return;
				}
				_actionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsSlotUnlocked")] 
		public CBool IsSlotUnlocked
		{
			get
			{
				if (_isSlotUnlocked == null)
				{
					_isSlotUnlocked = (CBool) CR2WTypeManager.Create("Bool", "IsSlotUnlocked", cr2w, this);
				}
				return _isSlotUnlocked;
			}
			set
			{
				if (_isSlotUnlocked == value)
				{
					return;
				}
				_isSlotUnlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("IsLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "IsLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("AtlasPath")] 
		public CName AtlasPath
		{
			get
			{
				if (_atlasPath == null)
				{
					_atlasPath = (CName) CR2WTypeManager.Create("CName", "AtlasPath", cr2w, this);
				}
				return _atlasPath;
			}
			set
			{
				if (_atlasPath == value)
				{
					return;
				}
				_atlasPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("IconName")] 
		public CName IconName
		{
			get
			{
				if (_iconName == null)
				{
					_iconName = (CName) CR2WTypeManager.Create("CName", "IconName", cr2w, this);
				}
				return _iconName;
			}
			set
			{
				if (_iconName == value)
				{
					return;
				}
				_iconName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("MaxTier")] 
		public CInt32 MaxTier
		{
			get
			{
				if (_maxTier == null)
				{
					_maxTier = (CInt32) CR2WTypeManager.Create("Int32", "MaxTier", cr2w, this);
				}
				return _maxTier;
			}
			set
			{
				if (_maxTier == value)
				{
					return;
				}
				_maxTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("VehicleState")] 
		public CInt32 VehicleState
		{
			get
			{
				if (_vehicleState == null)
				{
					_vehicleState = (CInt32) CR2WTypeManager.Create("Int32", "VehicleState", cr2w, this);
				}
				return _vehicleState;
			}
			set
			{
				if (_vehicleState == value)
				{
					return;
				}
				_vehicleState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ItemId")] 
		public gameItemID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "ItemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "Title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Type")] 
		public CString Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CString) CR2WTypeManager.Create("String", "Type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "Description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get
			{
				if (_isEquipped == null)
				{
					_isEquipped = (CBool) CR2WTypeManager.Create("Bool", "IsEquipped", cr2w, this);
				}
				return _isEquipped;
			}
			set
			{
				if (_isEquipped == value)
				{
					return;
				}
				_isEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("intData")] 
		public CInt32 IntData
		{
			get
			{
				if (_intData == null)
				{
					_intData = (CInt32) CR2WTypeManager.Create("Int32", "intData", cr2w, this);
				}
				return _intData;
			}
			set
			{
				if (_intData == value)
				{
					return;
				}
				_intData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("playerVehicleData")] 
		public vehiclePlayerVehicle PlayerVehicleData
		{
			get
			{
				if (_playerVehicleData == null)
				{
					_playerVehicleData = (vehiclePlayerVehicle) CR2WTypeManager.Create("vehiclePlayerVehicle", "playerVehicleData", cr2w, this);
				}
				return _playerVehicleData;
			}
			set
			{
				if (_playerVehicleData == value)
				{
					return;
				}
				_playerVehicleData = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("itemType")] 
		public CEnum<QuickSlotItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<QuickSlotItemType>) CR2WTypeManager.Create("QuickSlotItemType", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("equipType")] 
		public CEnum<gamedataEquipmentArea> EquipType
		{
			get
			{
				if (_equipType == null)
				{
					_equipType = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipType", cr2w, this);
				}
				return _equipType;
			}
			set
			{
				if (_equipType == value)
				{
					return;
				}
				_equipType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("interactiveAction")] 
		public CHandle<gamedeviceAction> InteractiveAction
		{
			get
			{
				if (_interactiveAction == null)
				{
					_interactiveAction = (CHandle<gamedeviceAction>) CR2WTypeManager.Create("handle:gamedeviceAction", "interactiveAction", cr2w, this);
				}
				return _interactiveAction;
			}
			set
			{
				if (_interactiveAction == value)
				{
					return;
				}
				_interactiveAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("interactiveActionOwner")] 
		public entEntityID InteractiveActionOwner
		{
			get
			{
				if (_interactiveActionOwner == null)
				{
					_interactiveActionOwner = (entEntityID) CR2WTypeManager.Create("entEntityID", "interactiveActionOwner", cr2w, this);
				}
				return _interactiveActionOwner;
			}
			set
			{
				if (_interactiveActionOwner == value)
				{
					return;
				}
				_interactiveActionOwner = value;
				PropertySet(this);
			}
		}

		public QuickSlotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
