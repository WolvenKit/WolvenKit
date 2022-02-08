using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporaryDoorState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(1)] 
		[RED("interactionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> InteractionState
		{
			get => GetPropertyValue<CEnum<vehicleVehicleDoorInteractionState>>();
			set => SetPropertyValue<CEnum<vehicleVehicleDoorInteractionState>>(value);
		}
	}
}
