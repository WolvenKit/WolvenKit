using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIVehicleDriveToPointAutonomousCommand : AIVehicleCommand
	{
		[Ordinal(6)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("clearTrafficOnPath")] 
		public CBool ClearTrafficOnPath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("minimumDistanceToTarget")] 
		public CFloat MinimumDistanceToTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CBool DriveDownTheRoadIndefinitely
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIVehicleDriveToPointAutonomousCommand()
		{
			TargetPosition = new Vector3 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			MaxSpeed = 26.000000F;
			MinSpeed = 12.000000F;
			ClearTrafficOnPath = true;
			MinimumDistanceToTarget = 5.000000F;
			ForcedStartSpeed = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
