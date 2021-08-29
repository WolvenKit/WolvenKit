using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporaryDoorState : RedBaseClass
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorInteractionState> _interactionState;

		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(1)] 
		[RED("interactionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> InteractionState
		{
			get => GetProperty(ref _interactionState);
			set => SetProperty(ref _interactionState, value);
		}
	}
}
