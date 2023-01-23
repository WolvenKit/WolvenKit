using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questToggleDoor_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("doorAction")] 
		public CEnum<vehicleEQuestVehicleDoorState> DoorAction
		{
			get => GetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>();
			set => SetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>(value);
		}

		[Ordinal(2)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(3)] 
		[RED("forceScene")] 
		public CBool ForceScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("toOpen")] 
		public CBool ToOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("doorID")] 
		public CName DoorID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questToggleDoor_NodeType()
		{
			VehicleRef = new() { Names = new() };
			DoorAction = Enums.vehicleEQuestVehicleDoorState.Invalid;
			Door = Enums.vehicleEVehicleDoor.invalid;
			ToOpen = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
