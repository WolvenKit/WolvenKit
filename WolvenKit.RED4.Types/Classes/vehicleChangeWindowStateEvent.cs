using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChangeWindowStateEvent : redEvent
	{
		private CEnum<vehicleEQuestVehicleWindowState> _state;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleEQuestVehicleWindowState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}
	}
}
