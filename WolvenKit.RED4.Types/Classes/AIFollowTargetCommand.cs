using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowTargetCommand : AIMoveCommand
	{
		private CWeakHandle<gameObject> _target;
		private CFloat _desiredDistance;
		private CFloat _tolerance;
		private CBool _stopWhenDestinationReached;
		private CEnum<moveMovementType> _movementType;
		private CWeakHandle<gameObject> _lookAtTarget;
		private CBool _matchSpeed;
		private CBool _teleport;

		[Ordinal(7)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(8)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(9)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get => GetProperty(ref _tolerance);
			set => SetProperty(ref _tolerance, value);
		}

		[Ordinal(10)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get => GetProperty(ref _stopWhenDestinationReached);
			set => SetProperty(ref _stopWhenDestinationReached, value);
		}

		[Ordinal(11)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(12)] 
		[RED("lookAtTarget")] 
		public CWeakHandle<gameObject> LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(13)] 
		[RED("matchSpeed")] 
		public CBool MatchSpeed
		{
			get => GetProperty(ref _matchSpeed);
			set => SetProperty(ref _matchSpeed, value);
		}

		[Ordinal(14)] 
		[RED("teleport")] 
		public CBool Teleport
		{
			get => GetProperty(ref _teleport);
			set => SetProperty(ref _teleport, value);
		}

		public AIFollowTargetCommand()
		{
			_matchSpeed = true;
			_teleport = true;
		}
	}
}
