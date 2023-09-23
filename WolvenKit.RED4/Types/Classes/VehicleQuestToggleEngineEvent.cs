using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleQuestToggleEngineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("lockState")] 
		public CEnum<VehicleQuestEngineLockState> LockState
		{
			get => GetPropertyValue<CEnum<VehicleQuestEngineLockState>>();
			set => SetPropertyValue<CEnum<VehicleQuestEngineLockState>>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleOnEngineOff")] 
		public CBool VehicleOnEngineOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleQuestToggleEngineEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
