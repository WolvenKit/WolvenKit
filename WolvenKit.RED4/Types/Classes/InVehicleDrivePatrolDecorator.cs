using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InVehicleDrivePatrolDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("vehCommand")] 
		public CHandle<AIVehicleDrivePatrolCommand> VehCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleDrivePatrolCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleDrivePatrolCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CHandle<AIArgumentMapping> MaxSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("minSpeed")] 
		public CHandle<AIArgumentMapping> MinSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("clearTrafficOnPath")] 
		public CHandle<AIArgumentMapping> ClearTrafficOnPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("emergencyPatrol")] 
		public CHandle<AIArgumentMapping> EmergencyPatrol
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("numPatrolLoops")] 
		public CHandle<AIArgumentMapping> NumPatrolLoops
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public InVehicleDrivePatrolDecorator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
