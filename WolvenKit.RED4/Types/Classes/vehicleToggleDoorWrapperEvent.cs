using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleToggleDoorWrapperEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<vehicleEQuestVehicleDoorState> Action
		{
			get => GetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>();
			set => SetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>(value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(2)] 
		[RED("forceScene")] 
		public CBool ForceScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleToggleDoorWrapperEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
