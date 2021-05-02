using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveToWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _workspotSetup;
		private CHandle<AIArgumentMapping> _lookAtTarget;
		private CHandle<AIArgumentMapping> _movementType;
		private CHandle<AIArgumentMapping> _tolerance;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _spotReservation;
		private CHandle<AIArgumentMapping> _startTangent;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;
		private CHandle<AIArgumentMapping> _ignoreExploration;

		[Ordinal(1)] 
		[RED("workspotSetup")] 
		public CHandle<AIArgumentMapping> WorkspotSetup
		{
			get => GetProperty(ref _workspotSetup);
			set => SetProperty(ref _workspotSetup, value);
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
		[RED("spotReservation")] 
		public CHandle<AIArgumentMapping> SpotReservation
		{
			get => GetProperty(ref _spotReservation);
			set => SetProperty(ref _spotReservation, value);
		}

		[Ordinal(9)] 
		[RED("startTangent")] 
		public CHandle<AIArgumentMapping> StartTangent
		{
			get => GetProperty(ref _startTangent);
			set => SetProperty(ref _startTangent, value);
		}

		[Ordinal(10)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetProperty(ref _fastForwardAfterTeleport);
			set => SetProperty(ref _fastForwardAfterTeleport, value);
		}

		[Ordinal(11)] 
		[RED("ignoreExploration")] 
		public CHandle<AIArgumentMapping> IgnoreExploration
		{
			get => GetProperty(ref _ignoreExploration);
			set => SetProperty(ref _ignoreExploration, value);
		}

		public AIbehaviorActionMoveToWorkspotNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
