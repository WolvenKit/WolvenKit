using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleDoor_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<vehicleVehicleDoorState> State
		{
			get => GetPropertyValue<CEnum<vehicleVehicleDoorState>>();
			set => SetPropertyValue<CEnum<vehicleVehicleDoorState>>(value);
		}

		public questVehicleDoor_ConditionType()
		{
			VehicleRef = new() { Names = new() };
			State = Enums.vehicleVehicleDoorState.Open;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
