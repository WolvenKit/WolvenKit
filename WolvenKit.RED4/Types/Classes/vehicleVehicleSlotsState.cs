using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleSlotsState : ISerializable
	{
		[Ordinal(0)] 
		[RED("vehicleDoorState")] 
		public CEnum<vehicleVehicleDoorState> VehicleDoorState
		{
			get => GetPropertyValue<CEnum<vehicleVehicleDoorState>>();
			set => SetPropertyValue<CEnum<vehicleVehicleDoorState>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleWindowState")] 
		public CEnum<vehicleEVehicleWindowState> VehicleWindowState
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleWindowState>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleWindowState>>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleInteractionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> VehicleInteractionState
		{
			get => GetPropertyValue<CEnum<vehicleVehicleDoorInteractionState>>();
			set => SetPropertyValue<CEnum<vehicleVehicleDoorInteractionState>>(value);
		}

		public vehicleVehicleSlotsState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
