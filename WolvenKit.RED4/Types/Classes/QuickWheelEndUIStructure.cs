using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickWheelEndUIStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ChosenItem")] 
		public QuickSlotCommand ChosenItem
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(1)] 
		[RED("WasUsed")] 
		public CBool WasUsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("WasAssignedToSlot")] 
		public CBool WasAssignedToSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("WheelDirection")] 
		public CEnum<EDPadSlot> WheelDirection
		{
			get => GetPropertyValue<CEnum<EDPadSlot>>();
			set => SetPropertyValue<CEnum<EDPadSlot>>(value);
		}

		public QuickWheelEndUIStructure()
		{
			ChosenItem = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid }, InteractiveActionOwner = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
