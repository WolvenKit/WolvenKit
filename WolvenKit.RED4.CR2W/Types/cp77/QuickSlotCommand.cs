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
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(1)] 
		[RED("IsSlotUnlocked")] 
		public CBool IsSlotUnlocked
		{
			get => GetProperty(ref _isSlotUnlocked);
			set => SetProperty(ref _isSlotUnlocked, value);
		}

		[Ordinal(2)] 
		[RED("IsLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(3)] 
		[RED("AtlasPath")] 
		public CName AtlasPath
		{
			get => GetProperty(ref _atlasPath);
			set => SetProperty(ref _atlasPath, value);
		}

		[Ordinal(4)] 
		[RED("IconName")] 
		public CName IconName
		{
			get => GetProperty(ref _iconName);
			set => SetProperty(ref _iconName, value);
		}

		[Ordinal(5)] 
		[RED("MaxTier")] 
		public CInt32 MaxTier
		{
			get => GetProperty(ref _maxTier);
			set => SetProperty(ref _maxTier, value);
		}

		[Ordinal(6)] 
		[RED("VehicleState")] 
		public CInt32 VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}

		[Ordinal(7)] 
		[RED("ItemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(8)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(9)] 
		[RED("Type")] 
		public CString Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(10)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(11)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get => GetProperty(ref _isEquipped);
			set => SetProperty(ref _isEquipped, value);
		}

		[Ordinal(12)] 
		[RED("intData")] 
		public CInt32 IntData
		{
			get => GetProperty(ref _intData);
			set => SetProperty(ref _intData, value);
		}

		[Ordinal(13)] 
		[RED("playerVehicleData")] 
		public vehiclePlayerVehicle PlayerVehicleData
		{
			get => GetProperty(ref _playerVehicleData);
			set => SetProperty(ref _playerVehicleData, value);
		}

		[Ordinal(14)] 
		[RED("itemType")] 
		public CEnum<QuickSlotItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(15)] 
		[RED("equipType")] 
		public CEnum<gamedataEquipmentArea> EquipType
		{
			get => GetProperty(ref _equipType);
			set => SetProperty(ref _equipType, value);
		}

		[Ordinal(16)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(17)] 
		[RED("interactiveAction")] 
		public CHandle<gamedeviceAction> InteractiveAction
		{
			get => GetProperty(ref _interactiveAction);
			set => SetProperty(ref _interactiveAction, value);
		}

		[Ordinal(18)] 
		[RED("interactiveActionOwner")] 
		public entEntityID InteractiveActionOwner
		{
			get => GetProperty(ref _interactiveActionOwner);
			set => SetProperty(ref _interactiveActionOwner, value);
		}

		public QuickSlotCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
