using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _movementTarget;
		private CHandle<AIArgumentMapping> _lookAtTarget;
		private CHandle<AIArgumentMapping> _movementType;
		private CHandle<AIArgumentMapping> _tolerance;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _useStop;
		private CHandle<AIArgumentMapping> _destinationTangent;
		private CHandle<AIArgumentMapping> _startTangent;
		private CHandle<AIArgumentMapping> _spotReservation;
		private CHandle<AIArgumentMapping> _ignoreRestrictedArea;

		[Ordinal(1)] 
		[RED("movementTarget")] 
		public CHandle<AIArgumentMapping> MovementTarget
		{
			get => GetProperty(ref _movementTarget);
			set => SetProperty(ref _movementTarget, value);
		}

		[Ordinal(2)] 
		[RED("lookAtTarget")] 
		public CHandle<AIArgumentMapping> LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(3)] 
		[RED("movementType")] 
		public CHandle<AIArgumentMapping> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(4)] 
		[RED("tolerance")] 
		public CHandle<AIArgumentMapping> Tolerance
		{
			get => GetProperty(ref _tolerance);
			set => SetProperty(ref _tolerance, value);
		}

		[Ordinal(5)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(6)] 
		[RED("rotateEntity")] 
		public CHandle<AIArgumentMapping> RotateEntity
		{
			get => GetProperty(ref _rotateEntity);
			set => SetProperty(ref _rotateEntity, value);
		}

		[Ordinal(7)] 
		[RED("useStart")] 
		public CHandle<AIArgumentMapping> UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(8)] 
		[RED("useStop")] 
		public CHandle<AIArgumentMapping> UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(9)] 
		[RED("destinationTangent")] 
		public CHandle<AIArgumentMapping> DestinationTangent
		{
			get => GetProperty(ref _destinationTangent);
			set => SetProperty(ref _destinationTangent, value);
		}

		[Ordinal(10)] 
		[RED("startTangent")] 
		public CHandle<AIArgumentMapping> StartTangent
		{
			get => GetProperty(ref _startTangent);
			set => SetProperty(ref _startTangent, value);
		}

		[Ordinal(11)] 
		[RED("spotReservation")] 
		public CHandle<AIArgumentMapping> SpotReservation
		{
			get => GetProperty(ref _spotReservation);
			set => SetProperty(ref _spotReservation, value);
		}

		[Ordinal(12)] 
		[RED("ignoreRestrictedArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictedArea
		{
			get => GetProperty(ref _ignoreRestrictedArea);
			set => SetProperty(ref _ignoreRestrictedArea, value);
		}

		public AIbehaviorActionMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
