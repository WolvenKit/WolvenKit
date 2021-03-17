using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AINavigationSystemResult : CVariable
	{
		private CBool _hasFailed;
		private CBool _hasPath;
		private CBool _hasClosestPointOnNavmesh;
		private CBool _hasClosestReachablePoint;
		private WorldPosition _lastSourcePosition;
		private WorldPosition _lastTargetPosition;
		private WorldPosition _adjustedTargetPosition;
		private WorldPosition _closestPointOnNavmesh;
		private WorldPosition _closestReachablePoint;

		[Ordinal(0)] 
		[RED("hasFailed")] 
		public CBool HasFailed
		{
			get => GetProperty(ref _hasFailed);
			set => SetProperty(ref _hasFailed, value);
		}

		[Ordinal(1)] 
		[RED("hasPath")] 
		public CBool HasPath
		{
			get => GetProperty(ref _hasPath);
			set => SetProperty(ref _hasPath, value);
		}

		[Ordinal(2)] 
		[RED("hasClosestPointOnNavmesh")] 
		public CBool HasClosestPointOnNavmesh
		{
			get => GetProperty(ref _hasClosestPointOnNavmesh);
			set => SetProperty(ref _hasClosestPointOnNavmesh, value);
		}

		[Ordinal(3)] 
		[RED("hasClosestReachablePoint")] 
		public CBool HasClosestReachablePoint
		{
			get => GetProperty(ref _hasClosestReachablePoint);
			set => SetProperty(ref _hasClosestReachablePoint, value);
		}

		[Ordinal(4)] 
		[RED("lastSourcePosition")] 
		public WorldPosition LastSourcePosition
		{
			get => GetProperty(ref _lastSourcePosition);
			set => SetProperty(ref _lastSourcePosition, value);
		}

		[Ordinal(5)] 
		[RED("lastTargetPosition")] 
		public WorldPosition LastTargetPosition
		{
			get => GetProperty(ref _lastTargetPosition);
			set => SetProperty(ref _lastTargetPosition, value);
		}

		[Ordinal(6)] 
		[RED("adjustedTargetPosition")] 
		public WorldPosition AdjustedTargetPosition
		{
			get => GetProperty(ref _adjustedTargetPosition);
			set => SetProperty(ref _adjustedTargetPosition, value);
		}

		[Ordinal(7)] 
		[RED("closestPointOnNavmesh")] 
		public WorldPosition ClosestPointOnNavmesh
		{
			get => GetProperty(ref _closestPointOnNavmesh);
			set => SetProperty(ref _closestPointOnNavmesh, value);
		}

		[Ordinal(8)] 
		[RED("closestReachablePoint")] 
		public WorldPosition ClosestReachablePoint
		{
			get => GetProperty(ref _closestReachablePoint);
			set => SetProperty(ref _closestReachablePoint, value);
		}

		public AINavigationSystemResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
