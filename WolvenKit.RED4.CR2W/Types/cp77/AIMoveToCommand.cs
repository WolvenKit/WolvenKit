using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCommand : AIMoveCommand
	{
		private AIPositionSpec _movementTarget;
		private CBool _rotateEntityTowardsFacingTarget;
		private AIPositionSpec _facingTarget;
		private CEnum<moveMovementType> _movementType;
		private CBool _ignoreNavigation;
		private CBool _useStart;
		private CBool _useStop;
		private CFloat _desiredDistanceFromTarget;
		private CBool _finishWhenDestinationReached;

		[Ordinal(7)] 
		[RED("movementTarget")] 
		public AIPositionSpec MovementTarget
		{
			get => GetProperty(ref _movementTarget);
			set => SetProperty(ref _movementTarget, value);
		}

		[Ordinal(8)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetProperty(ref _rotateEntityTowardsFacingTarget);
			set => SetProperty(ref _rotateEntityTowardsFacingTarget, value);
		}

		[Ordinal(9)] 
		[RED("facingTarget")] 
		public AIPositionSpec FacingTarget
		{
			get => GetProperty(ref _facingTarget);
			set => SetProperty(ref _facingTarget, value);
		}

		[Ordinal(10)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(11)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(12)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(13)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(14)] 
		[RED("desiredDistanceFromTarget")] 
		public CFloat DesiredDistanceFromTarget
		{
			get => GetProperty(ref _desiredDistanceFromTarget);
			set => SetProperty(ref _desiredDistanceFromTarget, value);
		}

		[Ordinal(15)] 
		[RED("finishWhenDestinationReached")] 
		public CBool FinishWhenDestinationReached
		{
			get => GetProperty(ref _finishWhenDestinationReached);
			set => SetProperty(ref _finishWhenDestinationReached, value);
		}

		public AIMoveToCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
