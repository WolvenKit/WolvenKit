using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIVehicleDrivePatrolCommand : AIVehicleCommand
	{
		[Ordinal(6)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("clearTrafficOnPath")] 
		public CBool ClearTrafficOnPath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("emergencyPatrol")] 
		public CBool EmergencyPatrol
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("numPatrolLoops")] 
		public CUInt32 NumPatrolLoops
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIVehicleDrivePatrolCommand()
		{
			MaxSpeed = 26.000000F;
			MinSpeed = 12.000000F;
			ClearTrafficOnPath = true;
			EmergencyPatrol = true;
			NumPatrolLoops = 1;
			ForcedStartSpeed = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
