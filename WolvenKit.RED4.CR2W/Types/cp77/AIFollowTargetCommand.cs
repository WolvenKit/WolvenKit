using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowTargetCommand : AIMoveCommand
	{
		private wCHandle<gameObject> _target;
		private CFloat _desiredDistance;
		private CFloat _tolerance;
		private CBool _stopWhenDestinationReached;
		private CEnum<moveMovementType> _movementType;
		private wCHandle<gameObject> _lookAtTarget;
		private CBool _matchSpeed;
		private CBool _teleport;

		[Ordinal(7)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
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
		public wCHandle<gameObject> LookAtTarget
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

		public AIFollowTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
