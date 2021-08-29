using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestChangeDoorStateEvent : redEvent
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleEQuestVehicleDoorState> _newState;

		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<vehicleEQuestVehicleDoorState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
