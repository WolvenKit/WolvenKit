using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionDynamicMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _moveType;
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _targetPosition;
		private CHandle<AIArgumentMapping> _toleranceRadius;
		private CHandle<AIArgumentMapping> _desiredDistanceFromTarget;
		private CHandle<AIArgumentMapping> _strafingTarget;
		private CHandle<AIArgumentMapping> _stopWhenDestinationReached;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _ignoreNavigation;

		[Ordinal(1)] 
		[RED("moveType")] 
		public CHandle<AIArgumentMapping> MoveType
		{
			get => GetProperty(ref _moveType);
			set => SetProperty(ref _moveType, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(4)] 
		[RED("toleranceRadius")] 
		public CHandle<AIArgumentMapping> ToleranceRadius
		{
			get => GetProperty(ref _toleranceRadius);
			set => SetProperty(ref _toleranceRadius, value);
		}

		[Ordinal(5)] 
		[RED("desiredDistanceFromTarget")] 
		public CHandle<AIArgumentMapping> DesiredDistanceFromTarget
		{
			get => GetProperty(ref _desiredDistanceFromTarget);
			set => SetProperty(ref _desiredDistanceFromTarget, value);
		}

		[Ordinal(6)] 
		[RED("strafingTarget")] 
		public CHandle<AIArgumentMapping> StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}

		[Ordinal(7)] 
		[RED("stopWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> StopWhenDestinationReached
		{
			get => GetProperty(ref _stopWhenDestinationReached);
			set => SetProperty(ref _stopWhenDestinationReached, value);
		}

		[Ordinal(8)] 
		[RED("rotateEntity")] 
		public CHandle<AIArgumentMapping> RotateEntity
		{
			get => GetProperty(ref _rotateEntity);
			set => SetProperty(ref _rotateEntity, value);
		}

		[Ordinal(9)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		public AIbehaviorActionDynamicMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
