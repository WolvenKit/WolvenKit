using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleQuestChangeDoorStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<vehicleEQuestVehicleDoorState> NewState
		{
			get => GetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>();
			set => SetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>(value);
		}

		[Ordinal(2)] 
		[RED("forceScene")] 
		public CBool ForceScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleQuestChangeDoorStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
