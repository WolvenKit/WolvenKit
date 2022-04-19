using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleChangeWindowStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleEQuestVehicleWindowState> State
		{
			get => GetPropertyValue<CEnum<vehicleEQuestVehicleWindowState>>();
			set => SetPropertyValue<CEnum<vehicleEQuestVehicleWindowState>>(value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		public vehicleChangeWindowStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
