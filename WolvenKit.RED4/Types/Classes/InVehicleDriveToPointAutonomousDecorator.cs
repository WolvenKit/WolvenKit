using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InVehicleDriveToPointAutonomousDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("vehCommand")] 
		public CHandle<AIVehicleDriveToPointAutonomousCommand> VehCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleDriveToPointAutonomousCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleDriveToPointAutonomousCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("minimumDistanceToTarget")] 
		public CHandle<AIArgumentMapping> MinimumDistanceToTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("maxSpeed")] 
		public CHandle<AIArgumentMapping> MaxSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("minSpeed")] 
		public CHandle<AIArgumentMapping> MinSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("clearTrafficOnPath")] 
		public CHandle<AIArgumentMapping> ClearTrafficOnPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CHandle<AIArgumentMapping> DriveDownTheRoadIndefinitely
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public InVehicleDriveToPointAutonomousDecorator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
