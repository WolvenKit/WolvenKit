using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveOnSplineNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _strafingTarget;
		private CHandle<AIArgumentMapping> _movementType;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _snapToTerrain;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _useStop;
		private CHandle<AIArgumentMapping> _reverse;
		private CHandle<AIArgumentMapping> _isBackAndForth;
		private CHandle<AIArgumentMapping> _isInfinite;
		private CHandle<AIArgumentMapping> _numberOfLoops;
		private CHandle<AIArgumentMapping> _useOffMeshLinkReservation;

		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(2)] 
		[RED("strafingTarget")] 
		public CHandle<AIArgumentMapping> StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}

		[Ordinal(3)] 
		[RED("movementType")] 
		public CHandle<AIArgumentMapping> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(4)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(5)] 
		[RED("snapToTerrain")] 
		public CHandle<AIArgumentMapping> SnapToTerrain
		{
			get => GetProperty(ref _snapToTerrain);
			set => SetProperty(ref _snapToTerrain, value);
		}

		[Ordinal(6)] 
		[RED("rotateEntity")] 
		public CHandle<AIArgumentMapping> RotateEntity
		{
			get => GetProperty(ref _rotateEntity);
			set => SetProperty(ref _rotateEntity, value);
		}

		[Ordinal(7)] 
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		[Ordinal(8)] 
		[RED("useStart")] 
		public CHandle<AIArgumentMapping> UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(9)] 
		[RED("useStop")] 
		public CHandle<AIArgumentMapping> UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(10)] 
		[RED("reverse")] 
		public CHandle<AIArgumentMapping> Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(11)] 
		[RED("isBackAndForth")] 
		public CHandle<AIArgumentMapping> IsBackAndForth
		{
			get => GetProperty(ref _isBackAndForth);
			set => SetProperty(ref _isBackAndForth, value);
		}

		[Ordinal(12)] 
		[RED("isInfinite")] 
		public CHandle<AIArgumentMapping> IsInfinite
		{
			get => GetProperty(ref _isInfinite);
			set => SetProperty(ref _isInfinite, value);
		}

		[Ordinal(13)] 
		[RED("numberOfLoops")] 
		public CHandle<AIArgumentMapping> NumberOfLoops
		{
			get => GetProperty(ref _numberOfLoops);
			set => SetProperty(ref _numberOfLoops, value);
		}

		[Ordinal(14)] 
		[RED("useOffMeshLinkReservation")] 
		public CHandle<AIArgumentMapping> UseOffMeshLinkReservation
		{
			get => GetProperty(ref _useOffMeshLinkReservation);
			set => SetProperty(ref _useOffMeshLinkReservation, value);
		}

		public AIbehaviorActionMoveOnSplineNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
