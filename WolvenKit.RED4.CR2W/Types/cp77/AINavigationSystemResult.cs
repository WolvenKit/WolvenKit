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
			get
			{
				if (_hasFailed == null)
				{
					_hasFailed = (CBool) CR2WTypeManager.Create("Bool", "hasFailed", cr2w, this);
				}
				return _hasFailed;
			}
			set
			{
				if (_hasFailed == value)
				{
					return;
				}
				_hasFailed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasPath")] 
		public CBool HasPath
		{
			get
			{
				if (_hasPath == null)
				{
					_hasPath = (CBool) CR2WTypeManager.Create("Bool", "hasPath", cr2w, this);
				}
				return _hasPath;
			}
			set
			{
				if (_hasPath == value)
				{
					return;
				}
				_hasPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasClosestPointOnNavmesh")] 
		public CBool HasClosestPointOnNavmesh
		{
			get
			{
				if (_hasClosestPointOnNavmesh == null)
				{
					_hasClosestPointOnNavmesh = (CBool) CR2WTypeManager.Create("Bool", "hasClosestPointOnNavmesh", cr2w, this);
				}
				return _hasClosestPointOnNavmesh;
			}
			set
			{
				if (_hasClosestPointOnNavmesh == value)
				{
					return;
				}
				_hasClosestPointOnNavmesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hasClosestReachablePoint")] 
		public CBool HasClosestReachablePoint
		{
			get
			{
				if (_hasClosestReachablePoint == null)
				{
					_hasClosestReachablePoint = (CBool) CR2WTypeManager.Create("Bool", "hasClosestReachablePoint", cr2w, this);
				}
				return _hasClosestReachablePoint;
			}
			set
			{
				if (_hasClosestReachablePoint == value)
				{
					return;
				}
				_hasClosestReachablePoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lastSourcePosition")] 
		public WorldPosition LastSourcePosition
		{
			get
			{
				if (_lastSourcePosition == null)
				{
					_lastSourcePosition = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "lastSourcePosition", cr2w, this);
				}
				return _lastSourcePosition;
			}
			set
			{
				if (_lastSourcePosition == value)
				{
					return;
				}
				_lastSourcePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lastTargetPosition")] 
		public WorldPosition LastTargetPosition
		{
			get
			{
				if (_lastTargetPosition == null)
				{
					_lastTargetPosition = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "lastTargetPosition", cr2w, this);
				}
				return _lastTargetPosition;
			}
			set
			{
				if (_lastTargetPosition == value)
				{
					return;
				}
				_lastTargetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("adjustedTargetPosition")] 
		public WorldPosition AdjustedTargetPosition
		{
			get
			{
				if (_adjustedTargetPosition == null)
				{
					_adjustedTargetPosition = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "adjustedTargetPosition", cr2w, this);
				}
				return _adjustedTargetPosition;
			}
			set
			{
				if (_adjustedTargetPosition == value)
				{
					return;
				}
				_adjustedTargetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("closestPointOnNavmesh")] 
		public WorldPosition ClosestPointOnNavmesh
		{
			get
			{
				if (_closestPointOnNavmesh == null)
				{
					_closestPointOnNavmesh = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "closestPointOnNavmesh", cr2w, this);
				}
				return _closestPointOnNavmesh;
			}
			set
			{
				if (_closestPointOnNavmesh == value)
				{
					return;
				}
				_closestPointOnNavmesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("closestReachablePoint")] 
		public WorldPosition ClosestReachablePoint
		{
			get
			{
				if (_closestReachablePoint == null)
				{
					_closestReachablePoint = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "closestReachablePoint", cr2w, this);
				}
				return _closestReachablePoint;
			}
			set
			{
				if (_closestReachablePoint == value)
				{
					return;
				}
				_closestReachablePoint = value;
				PropertySet(this);
			}
		}

		public AINavigationSystemResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
