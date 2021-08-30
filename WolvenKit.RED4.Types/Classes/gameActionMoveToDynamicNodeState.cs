using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionMoveToDynamicNodeState : gameActionMoveToState
	{
		private CWeakHandle<gameObject> _target;
		private CWeakHandle<gameObject> _strafingTarget;
		private CFloat _desiredDistanceFromTarget;
		private CBool _stopWhenDestinationReached;
		private CFloat _pathfindingUpdateInterval;
		private CBool _usePathfinding;
		private CBool _useStart;
		private CBool _useStop;

		[Ordinal(9)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(10)] 
		[RED("strafingTarget")] 
		public CWeakHandle<gameObject> StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}

		[Ordinal(11)] 
		[RED("desiredDistanceFromTarget")] 
		public CFloat DesiredDistanceFromTarget
		{
			get => GetProperty(ref _desiredDistanceFromTarget);
			set => SetProperty(ref _desiredDistanceFromTarget, value);
		}

		[Ordinal(12)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get => GetProperty(ref _stopWhenDestinationReached);
			set => SetProperty(ref _stopWhenDestinationReached, value);
		}

		[Ordinal(13)] 
		[RED("pathfindingUpdateInterval")] 
		public CFloat PathfindingUpdateInterval
		{
			get => GetProperty(ref _pathfindingUpdateInterval);
			set => SetProperty(ref _pathfindingUpdateInterval, value);
		}

		[Ordinal(14)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get => GetProperty(ref _usePathfinding);
			set => SetProperty(ref _usePathfinding, value);
		}

		[Ordinal(15)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(16)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		public gameActionMoveToDynamicNodeState()
		{
			_stopWhenDestinationReached = true;
			_pathfindingUpdateInterval = 0.500000F;
			_usePathfinding = true;
			_useStart = true;
			_useStop = true;
		}
	}
}
