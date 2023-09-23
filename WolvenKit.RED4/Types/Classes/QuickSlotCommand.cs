using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotCommand : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ActionType")] 
		public CEnum<QuickSlotActionType> ActionType
		{
			get => GetPropertyValue<CEnum<QuickSlotActionType>>();
			set => SetPropertyValue<CEnum<QuickSlotActionType>>(value);
		}

		[Ordinal(1)] 
		[RED("IsSlotUnlocked")] 
		public CBool IsSlotUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("IsLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("AtlasPath")] 
		public CName AtlasPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("IconName")] 
		public CName IconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("MaxTier")] 
		public CInt32 MaxTier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("VehicleState")] 
		public CInt32 VehicleState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("ItemId")] 
		public gameItemID ItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("Type")] 
		public CString Type
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("intData")] 
		public CInt32 IntData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("playerVehicleData")] 
		public vehiclePlayerVehicle PlayerVehicleData
		{
			get => GetPropertyValue<vehiclePlayerVehicle>();
			set => SetPropertyValue<vehiclePlayerVehicle>(value);
		}

		[Ordinal(14)] 
		[RED("itemType")] 
		public CEnum<QuickSlotItemType> ItemType
		{
			get => GetPropertyValue<CEnum<QuickSlotItemType>>();
			set => SetPropertyValue<CEnum<QuickSlotItemType>>(value);
		}

		[Ordinal(15)] 
		[RED("equipType")] 
		public CEnum<gamedataEquipmentArea> EquipType
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(16)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("interactiveAction")] 
		public CHandle<gamedeviceAction> InteractiveAction
		{
			get => GetPropertyValue<CHandle<gamedeviceAction>>();
			set => SetPropertyValue<CHandle<gamedeviceAction>>(value);
		}

		[Ordinal(18)] 
		[RED("interactiveActionOwner")] 
		public entEntityID InteractiveActionOwner
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuickSlotCommand()
		{
			IsSlotUnlocked = true;
			ItemId = new gameItemID();
			PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, DestructionTimeStamp = new EngineTime() };
			InteractiveActionOwner = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
