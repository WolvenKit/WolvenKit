using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleVehicleSlotsState : ISerializable
	{
		private CEnum<vehicleVehicleDoorState> _vehicleDoorState;
		private CEnum<vehicleEVehicleWindowState> _vehicleWindowState;
		private CEnum<vehicleVehicleDoorInteractionState> _vehicleInteractionState;

		[Ordinal(0)] 
		[RED("vehicleDoorState")] 
		public CEnum<vehicleVehicleDoorState> VehicleDoorState
		{
			get => GetProperty(ref _vehicleDoorState);
			set => SetProperty(ref _vehicleDoorState, value);
		}

		[Ordinal(1)] 
		[RED("vehicleWindowState")] 
		public CEnum<vehicleEVehicleWindowState> VehicleWindowState
		{
			get => GetProperty(ref _vehicleWindowState);
			set => SetProperty(ref _vehicleWindowState, value);
		}

		[Ordinal(2)] 
		[RED("vehicleInteractionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> VehicleInteractionState
		{
			get => GetProperty(ref _vehicleInteractionState);
			set => SetProperty(ref _vehicleInteractionState, value);
		}
	}
}
