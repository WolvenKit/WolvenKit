using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIDriveToPointAutonomousUpdate : AIDriveCommandUpdate
	{
		[Ordinal(3)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("minimumDistanceToTarget")] 
		public CFloat MinimumDistanceToTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CBool DriveDownTheRoadIndefinitely
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIDriveToPointAutonomousUpdate()
		{
			TargetPosition = new Vector4();
			MinimumDistanceToTarget = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
