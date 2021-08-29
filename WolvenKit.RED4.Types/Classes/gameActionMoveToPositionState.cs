using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionMoveToPositionState : gameActionReplicatedState
	{
		private Vector3 _target;
		private CBool _useSpotReservation;
		private CBool _usePathfinding;
		private CBool _useStart;
		private CBool _useStop;
		private CEnum<moveMovementType> _movementType;
		private CWeakHandle<gameObject> _strafingTarget;

		[Ordinal(5)] 
		[RED("target")] 
		public Vector3 Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(6)] 
		[RED("useSpotReservation")] 
		public CBool UseSpotReservation
		{
			get => GetProperty(ref _useSpotReservation);
			set => SetProperty(ref _useSpotReservation, value);
		}

		[Ordinal(7)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get => GetProperty(ref _usePathfinding);
			set => SetProperty(ref _usePathfinding, value);
		}

		[Ordinal(8)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(9)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(10)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(11)] 
		[RED("strafingTarget")] 
		public CWeakHandle<gameObject> StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}
	}
}
