using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleDoor_ConditionType : questIVehicleConditionType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorState> _state;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<vehicleVehicleDoorState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public questVehicleDoor_ConditionType()
		{
			_state = new() { Value = Enums.vehicleVehicleDoorState.Open };
		}
	}
}
